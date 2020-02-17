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
    public partial class FormGameOver : Form
    {
        public int hiScore;
        public int score;
        public FormGameOver()
        {
            InitializeComponent();
        }

        private void FormGameOver_Load(object sender, EventArgs e)
        {
            BtnContinue.DialogResult = DialogResult.Retry;
            btnExit.DialogResult = DialogResult.Cancel;
            lblHi.Text = hiScore.ToString();
            lblScore.Text = score.ToString();
            lblTextHi.Location = new Point(lblTextHi.Location.X - (lblHi.Text.Length - 1)*8, lblTextHi.Location.Y);
        }
    }
}
