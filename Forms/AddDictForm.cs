using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using translate.Classes;
using translate.Forms;

namespace translate
{
    public partial class AddDictForm : Form
    {
        public AddDictForm()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            MaximizeBox = false;
        }

        private void JSON_dict_Click(object sender, EventArgs e)
        {
            AddDictionary.AddNewDictionary();
            Init.InitComboboxes(Mainform.Cb_1, Mainform.Cb_2);
            Close();
        }

        private void empty_dict_Click(object sender, EventArgs e)
        {
            EmptyDictForm addEmptyDict = new EmptyDictForm();
            addEmptyDict.Show();
            Close();
        }

    }
}
