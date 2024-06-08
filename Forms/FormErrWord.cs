using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace translate.Forms
{
    public partial class FormErrWord : Form
    {
        public FormErrWord()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false;
        }

        private void fe_btn_add_Click(object sender, EventArgs e)
        {
            FormAddWord formAdd = new FormAddWord();
            formAdd.Show();
            Close();
        }

        private void fe_btn_cancel_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
