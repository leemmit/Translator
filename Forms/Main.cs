using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;

using translate.Forms;
using translate.Classes;

namespace translate
{
    public partial class Mainform : Form
    {
        private static Dictionary<string, Dictionary<string, Dictionary<string, string>>> translations;
        public static Dictionary<string, Dictionary<string, Dictionary<string, string>>> GetTranslations { get => translations; set => translations = value; }
        public string language;

        private static ComboBox _cb_1;
        private static ComboBox _cb_2;
        private static TextBox _tb_output;
        private static TextBox _tb_input;
        public static ComboBox Cb_1 { get => _cb_1; set => _cb_1 = value; }
        public static ComboBox Cb_2 { get => _cb_2; set => _cb_2 = value; }
        public static TextBox Tb_Output { get => _tb_output; set => _tb_output = value; }
        public static TextBox Tb_Input { get => _tb_input; set => _tb_input = value; }
        


        public Mainform()
        {
            InitializeComponent();
            InitVariables();
            Translating.LoadTranslation();
            Init.InitComboboxes(Cb_1, Cb_2);
        }

        private void InitVariables()
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(btn_changeLang, "Сменить языки");
            MaximizeBox = false;
            tb_output.ReadOnly = true;
            _cb_1 = cb_1;
            _cb_2 = cb_2;
            _tb_output = tb_output;
            _tb_input = tb_input;
        }

        public void btn_translate_Click(object sender, EventArgs e)
        {
            Buttons.TranslateClick();
        }

        private void btn_addWord_Click(object sender, EventArgs e) //Добавление слова
        {
            /*string sourceWord = Tb_Input.Text;
            string targetWord = Tb_Output.Text;
            Buttons.AddWordClick(sourceWord, targetWord);*/
            FormAddWord formAddWord = new FormAddWord();
            formAddWord.Show();
        }
        private void btn_addDictionary_Click(object sender, EventArgs e)
        {
            AddDictForm newdict = new AddDictForm();
            newdict.Show();
        }

        private void tb_input_TextChanged(object sender, EventArgs e) //Работа с регистром текста в текстбоксе ввода слова
        {
            if (tb_input.Text == "") tb_output.Text = "";
            if ((sender is TextBox textBox && textBox.Text.Length > 0) && (tb_input.Text.Any(char.IsUpper) != true))
            {
                
                tb_input.Text = char.ToUpper(tb_input.Text[0]) + tb_input.Text.Substring(1);
                textBox.ScrollToCaret();
            }
            tb_input.SelectionStart = tb_input.Text.Length;
            tb_input.ScrollToCaret();
        }

        private void tb_output_TextChanged(object sender, EventArgs e)
        {
            if ((sender is TextBox textBox && textBox.Text.Length > 0) && (tb_output.Text.Any(char.IsUpper) != true))
            {

                tb_output.Text = char.ToUpper(tb_output.Text[0]) + tb_output.Text.Substring(1);
                textBox.ScrollToCaret();
            }
            tb_output.SelectionStart = tb_output.Text.Length;
            tb_output.ScrollToCaret();
        }

        private void cb_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //tb_output.Text = "";
        }

        private void btn_changeLang_Click(object sender, EventArgs e)
        {
            int ind1 = cb_1.SelectedIndex;
            int ind2 = cb_2.SelectedIndex;
            cb_1.SelectedIndex = ind2;
            cb_2.SelectedIndex = ind1;
            if (!string.IsNullOrWhiteSpace(tb_input.Text) && !string.IsNullOrWhiteSpace(tb_output.Text))
            {
                string txt1 = tb_input.Text;
                string txt2 = tb_output.Text;
                tb_input.Text = txt2;
                tb_output.Text = txt1;
            }
        }

        private void tb_input_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Отменяем ввод символа
            }
        }
    }
}
