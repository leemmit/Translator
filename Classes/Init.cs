using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;

using static translate.Mainform;

namespace translate.Classes
{
    class Init
    {
        public static void InitComboboxes(ComboBox cb_1, ComboBox cb_2)
        {
            string translate = File.ReadAllText("translate.json");
            GetTranslations = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, Dictionary<string, string>>>>(translate);
            cb_1.Items.Clear();
            cb_2.Items.Clear();
            foreach (var sourceLanguage in GetTranslations.Keys)
            {
                if (!cb_1.Items.Contains(sourceLanguage))
                {
                    cb_1.Items.Add(sourceLanguage);
                    cb_2.Items.Add(sourceLanguage);
                }

                foreach (var targetLanguage in GetTranslations[sourceLanguage].Keys)
                {
                    if (!cb_1.Items.Contains(targetLanguage))
                    {
                        cb_1.Items.Add(targetLanguage);
                        cb_2.Items.Add(targetLanguage);
                    }
                }
            }
            cb_1.SelectedIndex = 0;
            cb_2.SelectedIndex = 1;
        }
    }
}
