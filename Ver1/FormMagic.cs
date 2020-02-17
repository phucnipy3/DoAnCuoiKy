//Người viết Nguyễn Huỳnh Phúc
//Ngày viết: 29/11/2018
//Chỉnh sửa lần cuối 10:00 PM 22/12/2018

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace Ver1
{
    
    public partial class FormMagic : Form
    {
        private int score;
        private int highScore;
        private List<Block> listPickUp;
        private List<Block> listGame;
        private int[,] matrix;
        private Block blockPicking = null;
        private Point pickLocation;
        private Point originalMouse;
        private Point originalBlock;
        public FormMagic()
        {
            InitializeComponent();
            highScore = 0;
            listPickUp = new List<Block>();
            listGame = new List<Block>();
            GetScore();
        }

        public void GetScore()
        {
            string str = Properties.Settings.Default.highScore;
            highScore = int.Parse(str);
           
        }
        private void FormMagic_Load(object sender, EventArgs e)
        {
            NewGame();
        }
        private void CreateNewBlocks()
        {
            Block block1 = new Block();
            Block block2 = new Block();
            Block block3 = new Block();
            block1.LocationCursor = new Point(block1.LocationCursor.X + 1 * BlockInfo.SmallSize,block1.LocationCursor.Y);
            block2.LocationCursor = new Point(block2.LocationCursor.X + 7 * BlockInfo.SmallSize, block2.LocationCursor.Y);
            block3.LocationCursor = new Point(block3.LocationCursor.X + 13 * BlockInfo.SmallSize, block3.LocationCursor.Y);
            listPickUp.Add(block1);
            listPickUp.Add(block2);
            listPickUp.Add(block3);
        }

        private void timerPickUp_Tick(object sender, EventArgs e)
        {
            if (blockPicking == null && listPickUp.Count == 0)
                CreateNewBlocks();
            Bitmap b = new Bitmap(ptbPickUp.Width, ptbPickUp.Height);
            Graphics g = Graphics.FromImage(b);
            g.DrawImage(Ver1.Properties.Resources.backPickup, 0, 0, ptbPickUp.Width, ptbPickUp.Height);
            for (int j = 0; j < listPickUp.Count; j++)
                listPickUp[j].Show(true, g);
            ptbPickUp.Image = b;

        }
        private void GameLose()
        {
            timerPickUp.Enabled = false;
            timerGame.Enabled = false;
            FormGameOver formOver = new FormGameOver();
            formOver.hiScore = highScore;
            formOver.score = score;
            DialogResult x = formOver.ShowDialog();
            if (x == DialogResult.Retry)
                NewGame();
            else if (x == DialogResult.Cancel)
                this.Close();
        }
        private void ptbPickUp_MouseDown(object sender, MouseEventArgs e)
        {
            Point mouseLocation = e.Location;
            int i;
            for( i = 0;i<listPickUp.Count;i++)
                if (listPickUp[i].Contains(mouseLocation))
                {
                    blockPicking = listPickUp[i];
                    pickLocation = new Point(blockPicking.LocationCursor.X,blockPicking.LocationCursor.Y);
                    blockPicking.LocationCursor = new Point(blockPicking.LocationCursor.X, ptbPlay.Height - blockPicking.Count * BlockInfo.BigSize);
                    break;
                }
            if (i < listPickUp.Count)
            {
                blockPicking.ChangeSize(BlockInfo.BigSize);
                listPickUp.Remove(blockPicking);
                listGame.Add(blockPicking);
                timerGame.Enabled = true;
                blockPicking.CalculateMatrixLocation();
                originalMouse = new Point(Cursor.Position.X, Cursor.Position.Y);
                originalBlock = new Point(blockPicking.LocationCursor.X, blockPicking.LocationCursor.Y);
                timerMoving.Enabled = true;
            }
        }
        private void DrawBackground(Graphics g)
        {
            for (int i = 0; i < BlockInfo.NUMMAX; i++)
                for (int j = 0; j < BlockInfo.NUMMAX; j++)
                    g.DrawImage(Ver1.Properties.Resources.back, i * BlockInfo.BigSize, j * BlockInfo.BigSize, BlockInfo.BigSize, BlockInfo.BigSize);
        }
        private bool isLose()
        {
            if(listPickUp.Count==0)
                return false;
            for (int i= 0; i < listPickUp.Count; i++)
                if (blockPicking !=null || listPickUp[i].isFit(matrix))
                    return false;
            return true;
        }
        private void timerGame_Tick(object sender, EventArgs e)
        {
            
            CheckLine(matrix);
            int i = 0;
            while (i < listGame.Count)
            {
                if (listGame[i] != blockPicking)
                {
                    listGame[i].Update(matrix);
                    if (listGame[i].Count == 0)
                        listGame.Remove(listGame[i]);
                    else
                        i++;
                }
                else
                    i++;
            }
            ShowGame();
            if (isLose())
                GameLose();
        }
        private void ShowGame()
        {
            Bitmap bm = new Bitmap(ptbPlay.Width, ptbPlay.Height);
            Graphics g = Graphics.FromImage(bm);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            DrawBackground(g);
            if (listGame.Count > 0)
            {
                for (int i = 0; i < listGame.Count - 1; i++)
                    listGame[i].Show(true, g);
                if (listGame[listGame.Count - 1].canDrop(matrix))
                    listGame[listGame.Count - 1].Show(false, g);
                else
                    listGame[listGame.Count - 1].Show(true, g);
            }
            ptbPlay.Image = bm;
            btnHi.Text = highScore.ToString();
            btnScore.Text = score.ToString();
        }
        private void CheckLine(int[,] matrix)
        {
            List<int> listRow = new List<int>();
            List<int> listCol = new List<int>();
            for (int i = 0; i < BlockInfo.NUMMAX; i++)
            {
                int sum = 0;
                for (int j = 0; j < BlockInfo.NUMMAX; j++)
                    sum += matrix[i, j];
                if (sum == BlockInfo.NUMMAX)
                    listRow.Add(i);
            }
            for (int i = 0; i < BlockInfo.NUMMAX; i++)
            {
                int sum = 0;
                for (int j = 0; j < BlockInfo.NUMMAX; j++)
                    sum += matrix[j, i];
                if (sum == BlockInfo.NUMMAX)
                    listCol.Add(i);
            }
            int lineNum = listCol.Count + listRow.Count;
            if (lineNum > 0)
            {
                ShowGame();
                ptbPlay.Refresh();
                Thread.Sleep(100);
                for (int i = 0; i < BlockInfo.NUMMAX; i++)
                    for (int j = 0; j < BlockInfo.NUMMAX; j++)
                        if (listRow.Contains(i) || listCol.Contains(j))
                            matrix[i, j] = 0;

                score += 10 * (lineNum);
                if (lineNum >= 2)
                    score += 5 * (lineNum - 1);
                if (score > highScore)
                    highScore = score;
               
            }
            
        }
        private void ptbPickUp_MouseUp(object sender, MouseEventArgs e)
        {
            if (blockPicking == null)
                return;
            blockPicking.CalculateMatrixLocation();
            blockPicking.CalculateCursorLocation();
            if (!blockPicking.canDrop(matrix))
            {
                listGame.Remove(blockPicking);
                listPickUp.Add(blockPicking);
                blockPicking.LocationCursor = new Point(pickLocation.X, pickLocation.Y);
                blockPicking.ChangeSize(BlockInfo.SmallSize);
            }
            else
            {
                blockPicking.Drop(matrix);
            }
            blockPicking = null;
            timerMoving.Enabled = false;
            timerPickUp.Enabled = true;

        }

        private void timerMoving_Tick(object sender, EventArgs e)
        {
            int distanceX = Cursor.Position.X - originalMouse.X;
            int distanceY = Cursor.Position.Y - originalMouse.Y;
            blockPicking.LocationCursor = new Point(originalBlock.X + distanceX, originalBlock.Y + distanceY);
            blockPicking.CalculateMatrixLocation();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            DialogResult x = new FormPause().ShowDialog();
            if (x == DialogResult.OK)
                GameContinue();
            else if (x == DialogResult.Retry)
                NewGame();
            else if (x == DialogResult.Cancel)
                this.Close();
        }
        private void NewGame()
        {
            listGame = new List<Block>();
            listPickUp = new List<Block>();
            CreateNewBlocks();
            timerPickUp.Enabled = true;
            timerGame.Enabled = true;
            score = 0;
            matrix = new int[BlockInfo.NUMMAX, BlockInfo.NUMMAX];
        }
        private void GameContinue()
        {
            timerGame.Enabled = true;
            timerPickUp.Enabled = true;
        }

        private void FormMagic_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.highScore = highScore.ToString();
            Properties.Settings.Default.Save();
        }
    }
    
}
