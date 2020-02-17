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

namespace Ver1
{
    public partial class FormDisappear : Form
    {
        private List<Circle> listCircle;
        public int score;
        private int life;
        public int hiScore = 0;
        private Circle removal;
        public FormDisappear()
        {
            InitializeComponent();
        }

        private void FormDisappear_Load(object sender, EventArgs e)
        {
            newGame();
        }

        private void timerCreate_Tick(object sender, EventArgs e)
        {
            Circle c = new Circle(ptbPlay.Width, ptbPlay.Height);
            listCircle.Add(c);
        }

        private void timerGame_Tick(object sender, EventArgs e)
        {
            // Vẽ lên pictureBox
            Bitmap b = new Bitmap(ptbPlay.Width, ptbPlay.Height);
            Graphics g = Graphics.FromImage(b);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            life = 3;
            foreach (Circle c in listCircle)
            {
                c.Update();
                if (c.hasGone())
                {
                    life--;
                }
                if (life == 0)
                {
                    GameLose();
                    return;
                }
                c.Show(g);
                UpdateScore();
            }
            ptbPlay.Image = b;
            // điều chỉnh life
            if (life >= 1)
                btnLife1.Visible = true;
            else
                btnLife1.Visible = false;
            if (life >= 2)
                btnLife2.Visible = true;
            else
                btnLife2.Visible = false;
            if (life == 3)
                btnLife3.Visible = true;
            else
                btnLife3.Visible = false;
        }
        private void UpdateScore()
        {
            lblScore.Text = score.ToString();
            if (hiScore < score)
                hiScore = score;
            lblHi.Text = hiScore.ToString();
        }
        private void GameLose()
        {
            btnLife1.Visible = false;
            gamePause();
            FormGameOver formOver = new FormGameOver();
            formOver.hiScore = hiScore;
            formOver.score = score;
            DialogResult x = formOver.ShowDialog();
            if (x == DialogResult.Retry)
                newGame();
            else if (x == DialogResult.Cancel)
                this.Close();
        }

        private void timerHarder_Tick(object sender, EventArgs e)
        {
            timerCreate.Interval -= 50;
            if (timerCreate.Interval < 0)
                timerCreate.Interval = 1;
            timerGame.Interval -= 9;
            if (timerGame.Interval < 10)
                timerGame.Interval = 10;
        }

        private void ptbPlay_MouseClick(object sender, MouseEventArgs e)
        {
            Point p = e.Location;

            for (int i = listCircle.Count -1; i >= 0; i--)
            {
                if (listCircle[i].Contains(p))
                { 
                    score++;
                    removal = listCircle[i];
                    break;
                }
            }
            listCircle.Remove(removal);
            UpdateScore();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            gamePause();
            DialogResult rs = new FormPause().ShowDialog();
            if (rs == DialogResult.OK)
                gameContinue();
            else if (rs == DialogResult.Retry)
                newGame();
            else if (rs == DialogResult.Cancel)
                this.Close();
        }
        private void newGame()
        {
            listCircle = new List<Circle>();
            score = 0;
            timerCreate.Interval = 1000;
            timerGame.Interval = 100;
            timerHarder.Interval = 10000;
            UpdateScore();
            gameContinue();
        }
        private void gamePause()
        {
            timerGame.Enabled = false;
            timerCreate.Enabled = false;
            timerHarder.Enabled = false;
        }
        private void gameContinue()
        {
            timerGame.Enabled = true;
            timerCreate.Enabled = true;
            timerHarder.Enabled = true;
        }

    }
}
