using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using translate.Forms;
using static translate.Mainform;

namespace translate.Classes
{
    class Buttons
    {
        public static void TranslateClick()
        {
            string sourceLang = Cb_1.SelectedItem.ToString();
            string targetLang = Cb_2.SelectedItem.ToString();
            string sourceWord = Tb_Input.Text;

            if (string.IsNullOrWhiteSpace(sourceWord)) MessageBox.Show("Пожалуйста, введите слово для перевода");
            else if (sourceLang == targetLang) MessageBox.Show("Выбранные языки совпадают. Пожалуйста, выберите разные языки");
            else
            {
                if (GetTranslations.ContainsKey(sourceLang) && GetTranslations[sourceLang].ContainsKey(targetLang) && GetTranslations[sourceLang][targetLang].ContainsKey(sourceWord))
                {
                    string translatedWord = GetTranslations[sourceLang][targetLang][sourceWord];
                    Tb_Output.Text = translatedWord;
                }
                else
                {
                    //MessageBox.Show("Перевод не найден. \nВведите перевод вашего слова в поле правее и нажмите кнопку \"Добавить слово\"");
                    FormErrWord formErrWord = new FormErrWord();
                    formErrWord.Show();
                }
            }
        }

        public static void AddWordClick(string sourceWord, string targetWord)
        {
            string sourceLang = Cb_1.SelectedItem.ToString();
            string targetLang = Cb_2.SelectedItem.ToString();
/*            string sourceWord = Tb_Input.Text;
            string targetWord = Tb_Output.Text;*/

            if (!GetTranslations.ContainsKey(sourceLang))
            {
                GetTranslations[sourceLang] = new Dictionary<string, Dictionary<string, string>>();
            }

            if (!GetTranslations[sourceLang].ContainsKey(targetLang))
            {
                GetTranslations[sourceLang][targetLang] = new Dictionary<string, string>();
            }

            if (!GetTranslations.ContainsKey(targetLang))
            {
                GetTranslations[targetLang] = new Dictionary<string, Dictionary<string, string>>();
            }

            if (!GetTranslations[targetLang].ContainsKey(sourceLang))
            {
                GetTranslations[targetLang][sourceLang] = new Dictionary<string, string>();
            }

            GetTranslations[sourceLang][targetLang][sourceWord] = targetWord;
            GetTranslations[targetLang][sourceLang][targetWord] = sourceWord;
            Translating.SaveTranslation();
            MessageBox.Show("Перевод успешно сохранен.");
        }

    }
}
