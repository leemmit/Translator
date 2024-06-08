using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using translate.Classes;

namespace translate.Forms
{
    public partial class EmptyDictForm : Form
    {
        public EmptyDictForm()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void empty_dict_Click(object sender, EventArgs e)
        {
            string lang1 = tb_1.Text;
            string lang2 = tb_2.Text;

            if (lang1 != "" && lang2 != "")
            {
                AddDictionary.AddEmptyDictionary(lang1, lang2);
                Close();
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите необходимые данные в текстовое поле!");
            }

        }
    }
}
