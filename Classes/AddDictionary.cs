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

using static translate.Mainform;

namespace translate.Classes
{
    public class AddDictionary
    {
        public static void AddNewDictionary()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON files (*.json)|*.json";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string jsonData = File.ReadAllText(filePath);
                var newTranslations = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, Dictionary<string, string>>>>(jsonData);

                foreach (var sourceLang in newTranslations.Keys)
                {
                    if (!GetTranslations.ContainsKey(sourceLang))
                    {
                        GetTranslations[sourceLang] = new Dictionary<string, Dictionary<string, string>>();
                    }
                    else
                    {
                        MessageBox.Show($"Словарь {sourceLang} уже существует");
                        return;
                    }

                    foreach (var targetLang in newTranslations[sourceLang].Keys)
                    {
                        if (!GetTranslations[sourceLang].ContainsKey(targetLang))
                        {
                            GetTranslations[sourceLang][targetLang] = new Dictionary<string, string>();
                        }

                        foreach (var word in newTranslations[sourceLang][targetLang])
                        {
                            GetTranslations[sourceLang][targetLang][word.Key] = word.Value;
                        }
                    }
                }
                Translating.SaveTranslation();
                Translating.LoadTranslation();
                Init.InitComboboxes(Cb_1, Cb_2);
                MessageBox.Show("Словарь успешно добавлен!");
            }
        }
        public static void AddEmptyDictionary(string sourceLang, string targetLang)
        {
            if (!GetTranslations.ContainsKey(sourceLang))
            {
                GetTranslations[sourceLang] = new Dictionary<string, Dictionary<string, string>>();
            }

            if (!GetTranslations[sourceLang].ContainsKey(targetLang))
            {
                GetTranslations[sourceLang][targetLang] = new Dictionary<string, string>();
            }

            Translating.SaveTranslation();
            Init.InitComboboxes(Cb_1, Cb_2);
            MessageBox.Show("Пустой словарь успешно добавлен!");
        }
    }
}
