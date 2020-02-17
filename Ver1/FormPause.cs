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
    public partial class FormPause : Form
    {
        public FormPause()
        {
            InitializeComponent();
        }

        private void FormPause_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnContinue_Click(object sender, EventArgs e)
        {
            //DialogResult = DialogResult.OK;
        }

        private void btnAgain_Click(object sender, EventArgs e)
        {
            //DialogResult = DialogResult.Retry;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //DialogResult = DialogResult.Cancel;
        }
    }
}
