using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;

using static translate.Mainform;

namespace translate.Classes
{
    class Translating
    {
        public static void LoadTranslation()
        {
            try
            {
                string translate = File.ReadAllText("translate.json");
                GetTranslations = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, Dictionary<string, string>>>>(translate);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке файла: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void SaveTranslation()
        {
            string jsonData = JsonConvert.SerializeObject(GetTranslations, Formatting.Indented);
            File.WriteAllText("translate.json", jsonData);
            foreach (var sourceLanguage in GetTranslations.Keys)
            {
                if (!Cb_1.Items.Contains(sourceLanguage))
                {
                    Cb_1.Items.Add(sourceLanguage);
                    Cb_2.Items.Add(sourceLanguage);
                }
            }
        }
    }
}
