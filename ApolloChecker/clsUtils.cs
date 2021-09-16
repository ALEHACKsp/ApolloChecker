using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApolloChecker
{
    public static class clsUtils
    {
        // Methods
        public static void createDefaultSettingsJSON()
        {
            if (!File.Exists(@"Settings\settings.json"))
            {
                File.WriteAllText(@"Settings\settings.json", "{\r\n  \"separator_combo\": \":\",\r\n  \"debug_mode\": false\r\n}");
            }
        }

        public static void createDirectory(string directory)
        {
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
        }

        public static void deleteOldFilesResults()
        {
            foreach (FileInfo FileInfo in new DirectoryInfo("Results").GetFiles())
            {
                FileInfo.Delete();
            }
        }

        public static string generateRandomNumber() =>
            DateTime.Now.Millisecond.ToString() + DateTime.Today.Ticks.ToString();

        public static string getSettingsJSON() =>
            File.ReadAllText(@"Settings\settings.json");

        public static int getSizeComboAccounts(string[] accounts) =>
            accounts.Length;

        public static string returnProcessLogin(string site) =>
            File.ReadAllText($"Configs/{site.ToLower()}.json");

        public static void saveAccountsWorkTempFile(string idRandomConfig, string userEmail, string password, string site)
        {
            StreamWriter writer = File.AppendText($"Results/{idRandomConfig}_{site}.txt");
            writer.WriteLine($"{userEmail}:{password}");
            writer.Close();
            writer.Dispose();
        }

        public static void updateAccountsNotWorking(Label _labelAccountsNotWorking, frmMain _frmMain)
        {
            frmMain frmMain = _frmMain;

            _labelAccountsNotWorking.Invoke(new Action(() => _labelAccountsNotWorking.Text = Convert.ToInt32((_labelAccountsNotWorking.Text) + 1).ToString()));

        }

        public static void updateAccountsWorking(Label _labelAccountsWorking, frmMain _frmMain)
        {
            frmMain frmMain = _frmMain;

            _labelAccountsWorking.Invoke(new Action(() => _labelAccountsWorking.Text = Convert.ToInt32((_labelAccountsWorking.Text) + 1).ToString()));            
        }

        public static void updateProgress(Label _labelChecked, int sizeCombo, Label _labelProgress, frmMain _frmMain)
        {
            frmMain frmMain = _frmMain;

            int accountChecked = Convert.ToInt32((_labelChecked.Text) + 1);
            _labelProgress.Invoke(new Action(() => _labelChecked.Text = accountChecked.ToString()));

            decimal progress = (decimal)((accountChecked / sizeCombo) * 100);

            _labelProgress.Invoke(new Action(() => _labelProgress.Text = progress.ToString("N2")));
        }

        public static void updateSettingsJSON(string separatorCombo, string debugMode)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string> {
            {
                "separator_combo",
                separatorCombo
            },
            {
                "debug_mode", debugMode
            }

            };


            string contents = JsonConvert.SerializeObject(dictionary);
            File.WriteAllText(@"Settings\settings.json", contents);
        }

      
    }
}
