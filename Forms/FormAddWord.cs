using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using translate.Classes;
using translate;    

namespace translate.Forms
{
    public partial class FormAddWord : Form
    {
        private static ComboBox _fa_cb_from;
        private static ComboBox _fa_cb_to;
        public static ComboBox Fa_Cb_From { get => _fa_cb_from; set => _fa_cb_from = value; }
        public static ComboBox Fa_Cb_To { get => _fa_cb_to; set => _fa_cb_to = value; }

        public FormAddWord()
        {
            InitializeComponent();
            InitVariables();
            Init.InitComboboxes(Fa_Cb_From, Fa_Cb_To);
            SetText();
        }

        private void SetText()
        {
            fa_cb_from.SelectedIndex = Mainform.Cb_1.SelectedIndex; //Math.Abs(Form1.ComboBoxInput.SelectedIndex);
            fa_cb_to.SelectedIndex = Mainform.Cb_2.SelectedIndex; //Form1.ComboBoxOutput.SelectedIndex;
            fa_tb_from.Text = Mainform.Tb_Input.Text; //Form1.TextBoxInput.Text;
        }

        private void InitVariables()
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(fa_btn_changeLang, "Сменить языки");
            _fa_cb_from = fa_cb_from;
            _fa_cb_to = fa_cb_to;
            MaximizeBox = false;
            fa_tb_from.Multiline = false;
            fa_tb_to.Multiline = false;
        }

        private void fa_btn_add_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(fa_tb_from.Text) && !string.IsNullOrWhiteSpace(fa_tb_to.Text))
            {
                if (fa_cb_from.SelectedIndex == fa_cb_to.SelectedIndex) MessageBox.Show("Выбранные языки совпадают. Пожалуйста, выберите разные языки");
                
                string sourceWord = fa_tb_from.Text;
                string targetWord = fa_tb_to.Text;
                try
                {
                    if (Mainform.GetTranslations[fa_cb_from.SelectedItem.ToString()].ContainsKey(fa_cb_to.SelectedItem.ToString()) && Mainform.GetTranslations[fa_cb_from.SelectedItem.ToString()][fa_cb_to.SelectedItem.ToString()].ContainsKey(sourceWord))
                    {
                        MessageBox.Show("Перевод уже существует");
                        return;
                    }
                    else
                    {
                        Buttons.AddWordClick(sourceWord, targetWord);
                        fa_tb_from.Text = "";
                        Mainform.Tb_Input.Text = sourceWord;
                        Mainform.Tb_Output.Text = targetWord;
                        //Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Значения введены некорректно. Пожалуйста, проверьте правильность ввода и попробуйте еще раз");
            }
        }

        private void fa_tb_to_TextChanged(object sender, EventArgs e)
        {
            if ((sender is TextBox textBox && textBox.Text.Length > 0) && (fa_tb_to.Text.Any(char.IsUpper) != true))
            {

                fa_tb_to.Text = char.ToUpper(fa_tb_to.Text[0]) + fa_tb_to.Text.Substring(1);
                textBox.ScrollToCaret();
            }
            fa_tb_to.SelectionStart = fa_tb_to.Text.Length;
            fa_tb_to.ScrollToCaret();
        }

        private void fa_tb_from_TextChanged(object sender, EventArgs e)
        {
            if (fa_tb_from.Text == "") fa_tb_to.Text = "";
            if ((sender is TextBox textBox && textBox.Text.Length > 0) && (fa_tb_from.Text.Any(char.IsUpper) != true))
            {

                fa_tb_from.Text = char.ToUpper(fa_tb_from.Text[0]) + fa_tb_from.Text.Substring(1);
                textBox.ScrollToCaret();
            }
            fa_tb_from.SelectionStart = fa_tb_from.Text.Length;
            fa_tb_from.ScrollToCaret();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fa_btn_changeLang_Click(object sender, EventArgs e)
        {
            int ind1 = fa_cb_from.SelectedIndex;
            int ind2 = fa_cb_to.SelectedIndex;
            fa_cb_from.SelectedIndex = ind2;
            fa_cb_to.SelectedIndex = ind1;
        }

        private void fa_tb_from_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Отменяем ввод символа
                SystemSounds.Beep.Play();
            }
        }

        private void fa_tb_to_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Отменяем ввод символа
                SystemSounds.Beep.Play();
            }
        }
    }
}
