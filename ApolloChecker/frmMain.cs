using ApolloChecker.Properties;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApolloChecker
{
    public partial class frmMain : Form
    {

        // Nested Types
        public class OnLoginSuccess
        {
            // Properties
            public string findBy { get; set; }
            public string id_Element { get; set; }
            public string class_Name_Element { get; set; }
            public string css_Selector_Element { get; set; }
            public string x_path_element { get; set; }
            public string status_element { get; set; }
            public int position_in_NodeElements { get; set; }
        }

        public class LoginProcess
        {
            // Properties
            public int step { get; set; }
            public string operation { get; set; }
            public string id_Element { get; set; }
            public string class_Name_Element { get; set; }
            public string name_Element { get; set; }
            public string css_Selector_Element { get; set; }
            public string x_path_element { get; set; }
            public int position_in_NodeElements { get; set; }
            public string event_in_Element { get; set; }
            public bool sendKeys_UserOrEmail { get; set; }
            public bool sendKeys_Password { get; set; }
        }

        public class RootJsonConfig
        {

            // Properties
            public string url_login { get; set; }
            public int wait_time_login { get; set; }
            public int wait_time_between_steps { get; set; }
            public int minutes_wait_timeout { get; set; }
            public List<OnLoginSuccess> on_login_success { get; set; }
            public List<LoginProcess> login_process { get; set; }
        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void LoadConfigsJsonFiles()
        {
            foreach (FileInfo FileInfo in new DirectoryInfo("Configs").GetFiles())
            {
                string siteConfig;

                object[] values = new object[]
                {
                    siteConfig = Path.ChangeExtension(FileInfo.Name, null)
                };

                CreatePanelConfig(siteConfig);
            }

        }


        private void CreatePanelConfig(string siteConfig)
        {

            //iconLoadCombo

            Bunifu.Framework.UI.BunifuElipse bunifuElipse = new Bunifu.Framework.UI.BunifuElipse();
            Bunifu.Framework.UI.BunifuFlatButton buttonLoadComboConfing = new Bunifu.Framework.UI.BunifuFlatButton();
            buttonLoadComboConfing.Size = new Size(23, 22);
            buttonLoadComboConfing.Iconimage = Resources.iconLoadCombo;
            buttonLoadComboConfing.IconZoom = 90;
            buttonLoadComboConfing.Normalcolor = Color.FromArgb(60, 80, 250);
            buttonLoadComboConfing.OnHovercolor = Color.FromArgb(60, 80, 250);
            buttonLoadComboConfing.Activecolor = Color.FromArgb(60, 80, 250);

            Panel panelConfig = new Panel();
            
            bunifuElipse.ElipseRadius = 5;
            bunifuElipse.TargetControl = panelConfig;

            buttonLoadComboConfing.Name = string.Format("btnLoadAccounts{0}_{1}", clsUtils.generateRandomNumber(), siteConfig);

            panelConfig.BackColor = Color.FromArgb(60, 80, 250);
            panelConfig.Size = new Size(180, 50);

            buttonLoadComboConfing.Location = new Point(panelConfig.Location.X + 150, panelConfig.Location.Y + 20);
            panelConfig.Controls.Add(buttonLoadComboConfing);

            flowPanelConfigs.Controls.Add(panelConfig);

            panelConfig.Paint += (ss, ee) => 
            {
                ee.Graphics.DrawString(siteConfig, Font, Brushes.LightGray, 22, 20);
            };

            buttonLoadComboConfing.Click += ButtonLoadComboConfing_Click;
          
            flowPanelConfigs.Invalidate();
        }

        private void ButtonLoadComboConfing_Click(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuFlatButton clickedButton = (Bunifu.Framework.UI.BunifuFlatButton)sender;
            LoadAccountsCombo(clickedButton.Name.ToString().Replace("btnLoadAccounts", null).Split('_')[0].ToString(), clickedButton.Name.ToString().Split('_')[1].ToString());
        }

        private void LoadAccountsCombo(string idRandomConfig, string site)
        {
            string[] accountsCombo;

            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "Text files (*.txt) | *.txt"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                accountsCombo = File.ReadAllLines(dialog.FileName);

                createWorkerChecker(idRandomConfig, site, accountsCombo);
            }
        }

        private void createWorkerChecker(string idRandomConfig, string site, string[] accountsCombo)
        {
            clsChecker clsChecker = new clsChecker();
            clsChecker._site = site;
            clsChecker._frmMain = this;
            clsChecker._accounts = accountsCombo;


            Panel panelWorkerChecker = new Panel();
            panelWorkerChecker.Name = string.Format("panelConfig{0}_{1}", idRandomConfig, site);
            panelWorkerChecker.Size = new Size(flowPanelWorkersChecker.Size.Width, 30);
            panelWorkerChecker.BackColor = Color.FromArgb(25, 26, 31);

            Label labelSite = new Label();
            labelSite.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            labelSite.Text = site;
            labelSite.Name = string.Format("lblSite{0}_{1}", idRandomConfig, site);
            labelSite.Location = new Point(panelWorkerChecker.Location.X + 5, panelWorkerChecker.Location.Y + 3);
            labelSite.ForeColor = Color.White;
            labelSite.Size = new Size(180, 18);


            Label labelAccounts = new Label();
            labelAccounts.Text = "0";
            labelAccounts.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            labelAccounts.Name = string.Format("lblAccounts{0}_{1}", idRandomConfig, site);
            labelAccounts.Location = new Point(panelWorkerChecker.Location.X + 215, panelWorkerChecker.Location.Y + 3);
            labelAccounts.ForeColor = Color.White;
            labelAccounts.Size = new Size(30, 18);

            Label labelChecked = new Label();
            labelChecked.Text = "0";
            labelChecked.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            labelChecked.Name = string.Format("lblChecked{0}_{1}", idRandomConfig, site);
            labelChecked.Location = new Point(panelWorkerChecker.Location.X + 353, panelWorkerChecker.Location.Y + 3);
            labelChecked.ForeColor = Color.White;
            labelChecked.Size = new Size(60, 18);

            Label labelWorking = new Label();
            labelWorking.Text = "0";
            labelWorking.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            labelWorking.Name = string.Format("lblWorking{0}_{1}", idRandomConfig, site);
            labelWorking.Location = new Point(panelWorkerChecker.Location.X + 459, panelWorkerChecker.Location.Y + 3);
            labelWorking.ForeColor = Color.White;
            labelWorking.Size = new Size(30, 18);


            Label labelNotWorking = new Label();
            labelNotWorking.Text = "0";
            labelNotWorking.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            labelNotWorking.Name = string.Format("lblNotWorking{0}_{1}", idRandomConfig, site);
            labelNotWorking.Location = new Point(panelWorkerChecker.Location.X + 546, panelWorkerChecker.Location.Y + 3);
            labelNotWorking.ForeColor = Color.White;
            labelNotWorking.Size = new Size(30, 18);

            Label labelProgress = new Label();
            labelProgress.Text = "0,00";
            labelProgress.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            labelProgress.Name = string.Format("lblNotWorking{0}_{1}", idRandomConfig, site);
            labelProgress.Location = new Point(panelWorkerChecker.Location.X + 663, panelWorkerChecker.Location.Y + 3);
            labelProgress.ForeColor = Color.White;
            labelProgress.Size = new Size(60, 18);

            Bunifu.Framework.UI.BunifuFlatButton btnResults = new Bunifu.Framework.UI.BunifuFlatButton();
            btnResults.Name = string.Format("btnResults{0}_{1}", idRandomConfig, site);
            btnResults.Size = new Size(25, 25);
            btnResults.Iconimage = Resources.iconResults;
            btnResults.IconZoom = 90;
            btnResults.Activecolor = Color.FromArgb(25, 26, 31);
            btnResults.Normalcolor = Color.FromArgb(25, 26, 31);
            btnResults.OnHovercolor = Color.FromArgb(25, 26, 31);
            btnResults.Activecolor = Color.FromArgb(25, 26, 31);
            btnResults.Location = new Point(panelWorkerChecker.Location.X + 783, panelWorkerChecker.Location.Y + 3);

            panelWorkerChecker.Controls.Add(labelSite);
            panelWorkerChecker.Controls.Add(labelAccounts);
            panelWorkerChecker.Controls.Add(labelChecked);
            panelWorkerChecker.Controls.Add(labelWorking);
            panelWorkerChecker.Controls.Add(labelNotWorking);
            panelWorkerChecker.Controls.Add(labelProgress);
            panelWorkerChecker.Controls.Add(btnResults);

            flowPanelWorkersChecker.Controls.Add(panelWorkerChecker);

            flowPanelWorkersChecker.Invalidate();

            btnResults.Click += BtnResults_Click;

            Thread thread = new Thread(() => clsChecker.checkAccounts(idRandomConfig, labelWorking, labelNotWorking, labelChecked, labelProgress));
            thread.Start();
        }

        private void BtnResults_Click(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuFlatButton clickedButton = (Bunifu.Framework.UI.BunifuFlatButton)sender;
            string nameFile = clickedButton.Name.ToString().Replace("btnResults", null);
            string site = clickedButton.Name.ToString().Replace("btnResults", null).Split('_')[1].ToString().Replace(".txt", null);

            if (File.Exists(string.Format(@"Results\{0}.txt", nameFile)))
            {
                bool includeSite = MessageBox.Show("Include Site?", "Include Site?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes;

                string[] contentTempFileResults = File.ReadAllLines(string.Format(@"Results\{0}.txt", nameFile));
                string txtFileSave = string.Empty;

                using (SaveFileDialog dialog = new SaveFileDialog())
                {
                    dialog.Filter = "txt files (*.txt)|*.txt";

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        if (includeSite)
                        {
                            for (int i = 0; i < contentTempFileResults.Length; i++)
                            {
                                if (i == 0)
                                {
                                    txtFileSave += string.Format("Site: {0}\nE-mail/User: {1}\nPassword: {2}", site, contentTempFileResults[i].Split(':')[0].ToString(), contentTempFileResults[i].Split(':')[1].ToString());
                                }
                                else
                                {
                                    txtFileSave += string.Format("\n\nSite: {0}\nE-mail/User: {1}\nPassword: {2}", site, contentTempFileResults[i].Split(':')[0].ToString(), contentTempFileResults[i].Split(':')[1].ToString());
                                }
                            }
                        }
                        else
                        {
                            for (int i = 0; i < contentTempFileResults.Length; i++)
                            {
                                if (i == 0)
                                {
                                    txtFileSave += string.Format("E-mail/User: {0}\nPassword: {1}", contentTempFileResults[i].Split(':')[0].ToString(), contentTempFileResults[i].Split(':')[1].ToString());
                                }
                                else
                                {
                                    txtFileSave += string.Format("\n\nE-mail/User: {0}\nPassword: {1}", contentTempFileResults[i].Split(':')[0].ToString(), contentTempFileResults[i].Split(':')[1].ToString());
                                }
                            }
                        }
                    }

                    File.WriteAllText(dialog.FileName, txtFileSave);
                }
            }
            else
            {
                MessageBox.Show("No Results.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            clsUtils.createDirectory("Configs");
            clsUtils.createDirectory("Results");
            clsUtils.deleteOldFilesResults();
            clsUtils.createDefaultSettingsJSON();

            LoadConfigsJsonFiles();
        }

        private void btnAllResults_Click(object sender, EventArgs e)
        {

            bool includeSite = MessageBox.Show("Include Site?", "Include Site?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes;
            string txtFileSave = string.Empty;

            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "txt files (*.txt)|*.txt";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (FileInfo FileInfo in new DirectoryInfo("Results").GetFiles())
                    {
                        string site = Path.ChangeExtension(FileInfo.Name, null).Split('_')[0].ToString();
                        string[] ContentFile = File.ReadAllLines(FileInfo.FullName);

                        if (includeSite)
                        {
                            for (int i = 0; i < ContentFile.Length; i++)
                            {
                                if (i == 0)
                                {
                                    txtFileSave += string.Format("Site: {0}\nE-mail/User: {1}\nPassword: {2}", site, ContentFile[i].Split(':')[0].ToString(), ContentFile[i].Split(':')[0].ToString());
                                }
                                else
                                {
                                    txtFileSave += string.Format("\n\nSite: {0}\nE-mail/User: {1}\nPassword: {2}", site, ContentFile[i].Split(':')[0].ToString(), ContentFile[i].Split(':')[0].ToString());
                                }
                            }
                        }
                        else
                        {
                            for (int i = 0; i < ContentFile.Length; i++)
                            {
                                if (i == 0)
                                {
                                    txtFileSave += string.Format("E-mail/User: {0}\nPassword: {1}", ContentFile[i].Split(':')[0].ToString(), ContentFile[i].Split(':')[1].ToString());
                                }
                                else
                                {
                                    txtFileSave += string.Format("\n\nE-mail/User: {0}\nPassword: {1}", ContentFile[i].Split(':')[0].ToString(), ContentFile[i].Split(':')[1].ToString());
                                }
                            }
                        }
                    }

                    File.WriteAllText(dialog.FileName, txtFileSave);
                }
            }

        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNewConfigWizard_Click(object sender, EventArgs e)
        {
            frmNewConfigWizard frmNewConfigWizard = new frmNewConfigWizard();
            frmNewConfigWizard.ShowDialog();
        }

        private void frmSettings_Click(object sender, EventArgs e)
        {
            frmSettings frmSettings = new frmSettings();
            frmSettings.ShowDialog();
        }
    }
}
