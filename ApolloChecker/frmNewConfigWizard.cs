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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApolloChecker
{
    public partial class frmNewConfigWizard : Form
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

        public frmNewConfigWizard()
        {
            InitializeComponent();
        }

        private void ResetWizard()
        {

            tbUrlLogin.Text = string.Empty;


            dtGridViewSteps.Rows.Clear();
            dpDownProcessLogin.selectedIndex = 0;
            dpOperationElementProcessLogin.selectedIndex = 0;


            lblDescriptionElementHTML2.Visible = false;
            tbValueElementHTMLProcessLogin.Text = string.Empty;
            tbValueElementHTMLProcessLogin.Visible = false;

            lblPositionElementProcessLogin.Visible = false;
            tbPositionElementProcessLogin.Text = string.Empty;
            tbPositionElementProcessLogin.Visible = false;

            lblPassword.Visible = false;
            lblUserOrEmail.Visible = false;

            ossSendUserOrEmail.Visible = false;
            ossSendPassword.Visible = false;

            dpDownSucessLogin.selectedIndex = 0;

            lblDescriptionElementHTML.Visible = false;

            tbValueElementHTMLSucessLogin.Text = string.Empty;
            tbValueElementHTMLSucessLogin.Visible = false;

            lblPositionElementSucessLogin.Visible = false;
            tbPositionElementSucessLogin.Text = string.Empty;
            tbPositionElementSucessLogin.Visible = false;

            tbWaitLoadPage.Text = "5000";
            tbWaitEachStepLogin.Text = "2000";
            tbTimeout.Text = "59";

            PanelOnSucessLogin.Location = new Point(1336, 12);
            PanelOptions.Location = new Point(1336, 12);
            PanelProcessLogin.Location = new Point(1336, 12);
            panelUrlLogin.Location = new Point(116, 118);
        }

        private void frmNewConfigWizard_Load(object sender, EventArgs e)
        {
            ResetWizard();
        }

        private void tbUrlLogin_OnValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbUrlLogin.Text.Trim()))
            {
                btnNext_PanelUrlLogin.Enabled = false;
            }
            else
            {
                btnNext_PanelUrlLogin.Enabled = true;
            }
        }

        private void dpDownSucessLogin_onItemSelected(object sender, EventArgs e)
        {
            tbValueElementHTMLSucessLogin.Text = string.Empty;
            tbPositionElementSucessLogin.Text = string.Empty;

            if (dpDownSucessLogin.selectedIndex == 0)
            {
                lblDescriptionElementHTML.Text = "ID Element (HTML)";
                lblDescriptionElementHTML.Visible = true;
                tbValueElementHTMLSucessLogin.Visible = true;

                lblPositionElementSucessLogin.Visible = false;
                tbPositionElementSucessLogin.Visible = false;
                
            }

            if (dpDownSucessLogin.selectedIndex == 1)
            {
                lblDescriptionElementHTML.Text = "Class Name Element (HTML)";
                lblDescriptionElementHTML.Visible = true;
                tbValueElementHTMLSucessLogin.Visible = true;

                lblPositionElementSucessLogin.Visible = true;
                tbPositionElementSucessLogin.Visible = true;
            }

            if (dpDownSucessLogin.selectedIndex == 2)
            {
                lblDescriptionElementHTML.Text = "Css Selector Element (HTML)";
                lblDescriptionElementHTML.Visible = true;
                tbValueElementHTMLSucessLogin.Visible = true;

                lblPositionElementSucessLogin.Visible = true;
                tbPositionElementSucessLogin.Visible = true;
            }

            if (dpDownSucessLogin.selectedIndex == 3)
            {
                lblDescriptionElementHTML.Text = "X Path Element (HTML)";
                lblDescriptionElementHTML.Visible = true;
                tbValueElementHTMLSucessLogin.Visible = true;

                lblPositionElementSucessLogin.Visible = false;
                tbPositionElementSucessLogin.Visible = false;
            }
        }

        private void tbValueElementHTMLSucessLogin_OnValueChanged(object sender, EventArgs e)
        {
            tbValueElementHTMLSucessLogin.ForeColor = Color.White;
            tbPositionElementSucessLogin.ForeColor = Color.White;

            if (string.IsNullOrEmpty(tbValueElementHTMLSucessLogin.Text.Trim()))
            {
                btnNext_OnSucessLogin.Enabled = false;
            }
            else
            {
                if (dpDownSucessLogin.selectedIndex == 1 || dpDownSucessLogin.selectedIndex == 2)
                {
                    if (string.IsNullOrEmpty(tbPositionElementSucessLogin.Text.Trim()))
                    {
                        btnNext_OnSucessLogin.Enabled = false;
                    }
                    else
                    {
                        btnNext_OnSucessLogin.Enabled = true;
                    }
                }
                else
                {
                    btnNext_OnSucessLogin.Enabled = true;
                }
            }
        }

        private void tbPositionElementSucessLogin_OnValueChanged(object sender, EventArgs e)
        {
            tbValueElementHTMLSucessLogin.ForeColor = Color.White;
            tbPositionElementSucessLogin.ForeColor = Color.White;

            if (dpDownSucessLogin.selectedIndex == 1 || dpDownSucessLogin.selectedIndex == 2)
            {
                if (string.IsNullOrEmpty(tbPositionElementSucessLogin.Text.Trim()))
                {
                    btnNext_OnSucessLogin.Enabled = false;
                }
                else if (string.IsNullOrEmpty(tbValueElementHTMLSucessLogin.Text.Trim()))
                {
                    btnNext_OnSucessLogin.Enabled = false;
                }
                else
                {
                    btnNext_OnSucessLogin.Enabled = true;
                }
            }
            else
            {
                if (string.IsNullOrEmpty(tbValueElementHTMLSucessLogin.Text.Trim()))
                {
                    btnNext_OnSucessLogin.Enabled = false;
                }
                else
                {
                    btnNext_OnSucessLogin.Enabled = true;
                }
            }
        }

        private void tbValueElementHTMLSucessLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbValueElementHTMLSucessLogin.ForeColor = Color.White;
            tbPositionElementSucessLogin.ForeColor = Color.White;
        }

        private void tbPositionElementSucessLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbValueElementHTMLSucessLogin.ForeColor = Color.White;
            tbPositionElementSucessLogin.ForeColor = Color.White;
        }

        private void tbValueElementHTMLProcessLogin_OnValueChanged(object sender, EventArgs e)
        {
            tbValueElementHTMLProcessLogin.ForeColor = Color.White;
            tbPositionElementProcessLogin.ForeColor = Color.White;

            if (string.IsNullOrEmpty(tbValueElementHTMLProcessLogin.Text.Trim()))
            {
                btnAddStep.Enabled = false;
            }
            else
            {
                if (dpDownProcessLogin.selectedIndex == 1 || dpDownProcessLogin.selectedIndex == 2)
                {
                    if (string.IsNullOrEmpty(tbPositionElementProcessLogin.Text.Trim()))
                    {
                        btnAddStep.Enabled = false;
                    }
                    else
                    {
                        btnAddStep.Enabled = true;
                    }
                }
                else if (dpOperationElementProcessLogin.selectedIndex == 1)
                {
                    if (!ossSendPassword.Value && !ossSendUserOrEmail.Value)
                    {
                        btnAddStep.Enabled = false;
                    }
                    else
                    {
                        btnAddStep.Enabled = true;
                    }
                }
                else
                {
                    btnAddStep.Enabled = true;
                }
            }
        }

        private void tbPositionElementProcessLogin_OnValueChanged(object sender, EventArgs e)
        {
            tbValueElementHTMLProcessLogin.ForeColor = Color.White;
            tbPositionElementProcessLogin.ForeColor = Color.White;

            if (dpDownProcessLogin.selectedIndex == 1 || dpDownProcessLogin.selectedIndex == 2)
            {
                if (string.IsNullOrEmpty(tbPositionElementProcessLogin.Text.Trim()))
                {
                    btnAddStep.Enabled = false;
                }
                else if (string.IsNullOrEmpty(tbValueElementHTMLProcessLogin.Text.Trim()))
                {
                    btnAddStep.Enabled = false;
                }
                else
                {
                    btnAddStep.Enabled = true;
                }
            }
            else
            {
                if (string.IsNullOrEmpty(tbValueElementHTMLProcessLogin.Text.Trim()))
                {
                    btnAddStep.Enabled = false;
                }
                else if (dpOperationElementProcessLogin.selectedIndex == 1)
                {
                    if (!ossSendPassword.Value && !ossSendUserOrEmail.Value)
                    {
                        btnAddStep.Enabled = false;
                    }
                    else
                    {
                        btnAddStep.Enabled = true;
                    }
                }
                else
                {
                    btnAddStep.Enabled = true;
                }
            }
        }

        private void dpDownProcessLogin_onItemSelected(object sender, EventArgs e)
        {

            tbValueElementHTMLSucessLogin.Text = string.Empty;
            tbPositionElementSucessLogin.Text = string.Empty;

            if (dpDownProcessLogin.selectedIndex == 0)
            {
                lblDescriptionElementHTML2.Text = "ID Element (HTML)";
                lblDescriptionElementHTML2.Visible = true;
                tbValueElementHTMLProcessLogin.Visible = true;

                lblPositionElementProcessLogin.Visible = false;
                tbPositionElementProcessLogin.Visible = false;

            }

            if (dpDownProcessLogin.selectedIndex == 1)
            {
                lblDescriptionElementHTML2.Text = "Class Name Element (HTML)";
                lblDescriptionElementHTML2.Visible = true;
                tbValueElementHTMLProcessLogin.Visible = true;

                lblPositionElementProcessLogin.Visible = true;
                tbPositionElementProcessLogin.Visible = true;
            }

            if (dpDownProcessLogin.selectedIndex == 2)
            {
                lblDescriptionElementHTML2.Text = "Css Selector Element (HTML)";
                lblDescriptionElementHTML2.Visible = true;
                tbValueElementHTMLProcessLogin.Visible = true;

                lblPositionElementProcessLogin.Visible = true;
                tbPositionElementProcessLogin.Visible = true;
            }

            if (dpDownProcessLogin.selectedIndex == 3)
            {
                lblDescriptionElementHTML2.Text = "X Path Element (HTML)";
                lblDescriptionElementHTML2.Visible = true;
                tbValueElementHTMLProcessLogin.Visible = true;

                lblPositionElementProcessLogin.Visible = false;
                tbPositionElementProcessLogin.Visible = false;
            }
        }

        private void dpOperationElementProcessLogin_onItemSelected(object sender, EventArgs e)
        {
            if (dpOperationElementProcessLogin.selectedIndex == 1)
            {
                ossSendPassword.Visible = true;
                ossSendUserOrEmail.Visible = true;
                lblUserOrEmail.Visible = true;
                lblPassword.Visible = true;
            }
            else
            {
                ossSendPassword.Visible = false;
                ossSendUserOrEmail.Visible = false;
                lblUserOrEmail.Visible = false;
                lblPassword.Visible = false;
            }



            tbValueElementHTMLProcessLogin.ForeColor = Color.White;
            tbPositionElementProcessLogin.ForeColor = Color.White;

            if (dpDownProcessLogin.selectedIndex == 1 || dpDownProcessLogin.selectedIndex == 2)
            {
                if (string.IsNullOrEmpty(tbPositionElementProcessLogin.Text.Trim()))
                {
                    btnAddStep.Enabled = false;
                }
                else if (string.IsNullOrEmpty(tbValueElementHTMLProcessLogin.Text.Trim()))
                {
                    btnAddStep.Enabled = false;
                }
                else
                {
                    btnAddStep.Enabled = true;
                }
            }
            else
            {
                if (string.IsNullOrEmpty(tbValueElementHTMLProcessLogin.Text.Trim()))
                {
                    btnAddStep.Enabled = false;
                }
                else if (dpOperationElementProcessLogin.selectedIndex == 1)
                {
                    if (!ossSendPassword.Value && !ossSendUserOrEmail.Value)
                    {
                        btnAddStep.Enabled = false;
                    }
                    else
                    {
                        btnAddStep.Enabled = true;
                    }
                }
                else
                {
                    btnAddStep.Enabled = true;
                }
            }
        }

        private void tbValueElementHTMLProcessLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbValueElementHTMLProcessLogin.ForeColor = Color.White;
        }

        private void tbPositionElementProcessLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbPositionElementProcessLogin.ForeColor = Color.White;
        }

        private void ossSendUserOrEmail_OnValueChange(object sender, EventArgs e)
        {
            tbValueElementHTMLProcessLogin.ForeColor = Color.White;
            tbPositionElementProcessLogin.ForeColor = Color.White;

            if (dpDownProcessLogin.selectedIndex == 1 || dpDownProcessLogin.selectedIndex == 2)
            {
                if (string.IsNullOrEmpty(tbPositionElementProcessLogin.Text.Trim()))
                {
                    btnAddStep.Enabled = false;
                }
                else if (string.IsNullOrEmpty(tbValueElementHTMLProcessLogin.Text.Trim()))
                {
                    btnAddStep.Enabled = false;
                }
                else
                {
                    btnAddStep.Enabled = true;
                }
            }
            else
            {
                if (string.IsNullOrEmpty(tbValueElementHTMLProcessLogin.Text.Trim()))
                {
                    btnAddStep.Enabled = false;
                }
                else if (dpOperationElementProcessLogin.selectedIndex == 1)
                {
                    if (!ossSendPassword.Value && !ossSendUserOrEmail.Value)
                    {
                        btnAddStep.Enabled = false;
                    }
                    else
                    {
                        btnAddStep.Enabled = true;
                    }
                }
                else
                {
                    btnAddStep.Enabled = true;
                }
            }


            if (ossSendUserOrEmail.Value)
            {
                ossSendPassword.Value = false;
            }


        }

        private void ossSendPassword_OnValueChange(object sender, EventArgs e)
        {
            tbValueElementHTMLProcessLogin.ForeColor = Color.White;
            tbPositionElementProcessLogin.ForeColor = Color.White;

            if (dpDownProcessLogin.selectedIndex == 1 || dpDownProcessLogin.selectedIndex == 2)
            {
                if (string.IsNullOrEmpty(tbPositionElementProcessLogin.Text.Trim()))
                {
                    btnAddStep.Enabled = false;
                }
                else if (string.IsNullOrEmpty(tbValueElementHTMLProcessLogin.Text.Trim()))
                {
                    btnAddStep.Enabled = false;
                }
                else
                {
                    btnAddStep.Enabled = true;
                }
            }
            else
            {
                if (string.IsNullOrEmpty(tbValueElementHTMLProcessLogin.Text.Trim()))
                {
                    btnAddStep.Enabled = false;
                }
                else if (dpOperationElementProcessLogin.selectedIndex == 1)
                {
                    if (!ossSendPassword.Value && !ossSendUserOrEmail.Value)
                    {
                        btnAddStep.Enabled = false;
                    }
                    else
                    {
                        btnAddStep.Enabled = true;
                    }
                }
                else
                {
                    btnAddStep.Enabled = true;
                }
            }


            if (ossSendPassword.Value)
            {
                ossSendUserOrEmail.Value = false;
            }
        }

        private void btnNext_PanelUrlLogin_Click(object sender, EventArgs e)
        {

            PanelOnSucessLogin.Location = new Point(1336, 12);
            PanelOptions.Location = new Point(1336, 12);
            panelUrlLogin.Location = new Point(1336, 12);

            PanelProcessLogin.Location = new Point(2,4);

        }

        private void btnFinishWizard_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbWaitLoadPage.Text.Trim()))
            {
                tbWaitLoadPage.Text = "5000";
            }

            if (string.IsNullOrEmpty(tbWaitEachStepLogin.Text.Trim()))
            {
                tbWaitEachStepLogin.Text = "2000";
            }

            if (string.IsNullOrEmpty(tbTimeout.Text.Trim()))
            {
                tbTimeout.Text = "59";
            }

            CreateJSONFile();
        }

        private void CreateJSONFile()
        {
            RootJsonConfig rootJsonConfig = new RootJsonConfig();

            List<LoginProcess> loginProcessLst = new List<LoginProcess>();
            List<OnLoginSuccess> onLoginSuccessLst = new List<OnLoginSuccess>();


           

            for (int i = 0; i < dtGridViewSteps.Rows.Count; i++)
            {
                LoginProcess LoginProcess = new LoginProcess();

                LoginProcess.step = i + 1;
                LoginProcess.operation = dtGridViewSteps.Rows[i].Cells[0].Value.ToString().Equals("Class Name") || dtGridViewSteps.Rows[i].Cells[0].Value.ToString().Equals("Css Selector") ? "FindElementsBy" + dtGridViewSteps.Rows[i].Cells[0].Value.ToString().Replace(" ", null) : "FindElementBy" + dtGridViewSteps.Rows[i].Cells[0].Value.ToString().Replace(" ", null);

                LoginProcess.id_Element = dtGridViewSteps.Rows[i].Cells[0].Value.ToString().Equals("ID") ? dtGridViewSteps.Rows[i].Cells[1].Value.ToString() : null;
                LoginProcess.class_Name_Element = dtGridViewSteps.Rows[i].Cells[0].Value.ToString().Equals("Class Name") ? dtGridViewSteps.Rows[i].Cells[1].Value.ToString() : null;
                LoginProcess.css_Selector_Element = dtGridViewSteps.Rows[i].Cells[0].Value.ToString().Equals("Css Selector") ? dtGridViewSteps.Rows[i].Cells[1].Value.ToString() : null;
                LoginProcess.x_path_element = dpDownProcessLogin.selectedIndex == 0 ? dtGridViewSteps.Rows[i].Cells[1].Value.ToString() : null;
                LoginProcess.position_in_NodeElements = dtGridViewSteps.Rows[i].Cells[0].Value.ToString().Equals("X Path") || dtGridViewSteps.Rows[i].Cells[0].Value.ToString().Equals("Css Selector") ? int.Parse(dtGridViewSteps.Rows[i].Cells[2].Value.ToString()) : 0;
                LoginProcess.event_in_Element = dtGridViewSteps.Rows[i].Cells[5].Value.ToString();
                LoginProcess.sendKeys_UserOrEmail = Convert.ToBoolean(dtGridViewSteps.Rows[i].Cells[3].Value.ToString());
                LoginProcess.sendKeys_Password = Convert.ToBoolean(dtGridViewSteps.Rows[i].Cells[4].Value.ToString());

                loginProcessLst.Add(LoginProcess);
            }


            OnLoginSuccess OnLoginSuccess = new OnLoginSuccess();

            
            if (dpDownSucessLogin.selectedIndex == 0)
            {
                OnLoginSuccess.findBy = "ID";
                OnLoginSuccess.id_Element = tbValueElementHTMLSucessLogin.Text;
                OnLoginSuccess.class_Name_Element = null;
                OnLoginSuccess.css_Selector_Element = null;
                OnLoginSuccess.x_path_element = null;
                OnLoginSuccess.position_in_NodeElements = 0;
                OnLoginSuccess.status_element = "Displayed";
            }

            if (dpDownSucessLogin.selectedIndex == 1)
            {
                OnLoginSuccess.findBy = "Class Name";
                OnLoginSuccess.id_Element = null;
                OnLoginSuccess.class_Name_Element = tbValueElementHTMLSucessLogin.Text;
                OnLoginSuccess.css_Selector_Element = null;
                OnLoginSuccess.x_path_element = null;
                OnLoginSuccess.position_in_NodeElements = int.Parse(tbPositionElementSucessLogin.Text);
                OnLoginSuccess.status_element = "Displayed";
            }

            if (dpDownSucessLogin.selectedIndex == 2)
            {
                OnLoginSuccess.findBy = "Css Selector";
                OnLoginSuccess.id_Element = null;
                OnLoginSuccess.class_Name_Element = null;
                OnLoginSuccess.css_Selector_Element = tbValueElementHTMLSucessLogin.Text;
                OnLoginSuccess.x_path_element = null;
                OnLoginSuccess.position_in_NodeElements = int.Parse(tbPositionElementSucessLogin.Text);
                OnLoginSuccess.status_element = "Displayed";
            }

            if (dpDownSucessLogin.selectedIndex == 3)
            {
                OnLoginSuccess.findBy = "X Path";
                OnLoginSuccess.id_Element = null;
                OnLoginSuccess.class_Name_Element = null;
                OnLoginSuccess.css_Selector_Element = null;
                OnLoginSuccess.x_path_element = tbValueElementHTMLSucessLogin.Text;
                OnLoginSuccess.position_in_NodeElements = 0;
                OnLoginSuccess.status_element = "Displayed";
            }

            onLoginSuccessLst.Add(OnLoginSuccess);

            rootJsonConfig.url_login = tbUrlLogin.Text;
            rootJsonConfig.minutes_wait_timeout = int.Parse(tbTimeout.Text);
            rootJsonConfig.wait_time_between_steps = int.Parse(tbWaitEachStepLogin.Text);
            rootJsonConfig.wait_time_login = int.Parse(tbWaitLoadPage.Text);
            rootJsonConfig.login_process = loginProcessLst;
            rootJsonConfig.on_login_success = onLoginSuccessLst;


            string json = JsonConvert.SerializeObject(rootJsonConfig);

            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "json files (*.json)|*.json";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(dialog.FileName, json);
                    ResetWizard();
                }
            }

        }

        private void btnNext_OnSucessLogin_Click(object sender, EventArgs e)
        {
           
            PanelProcessLogin.Location = new Point(1336, 12);
            PanelOnSucessLogin.Location = new Point(1336, 12);
            panelUrlLogin.Location = new Point(1336, 12);

            PanelOptions.Location = new Point(116, 18);
        }

        private void btnNext_ProcessLogin_Click(object sender, EventArgs e)
        {
            PanelProcessLogin.Location = new Point(1336, 12);
            PanelOptions.Location = new Point(1336, 12);
            panelUrlLogin.Location = new Point(1336, 12);

            PanelOnSucessLogin.Location = new Point(116, 24);
        }

        private void btnAddStep_Click(object sender, EventArgs e)
        {

            string sendUserOrEmail = "false";
            string sendPassword = "false";


            if (ossSendUserOrEmail.Value)
            {
                sendUserOrEmail = "true";
            }

            if (ossSendPassword.Value)
            {
                sendPassword = "true";
            }

            dtGridViewSteps.Rows.Add(dpDownProcessLogin.selectedValue.ToString(), tbValueElementHTMLProcessLogin.Text.Trim(), tbPositionElementProcessLogin.Text, sendUserOrEmail, sendPassword, dpOperationElementProcessLogin.selectedValue.ToString());

          

            tbValueElementHTMLProcessLogin.Text = string.Empty;
            tbValueElementHTMLProcessLogin.Visible = false;
            lblDescriptionElementHTML2.Visible = false;

            lblPositionElementProcessLogin.Visible = false;
            tbPositionElementProcessLogin.Visible = false;

            lblPassword.Visible = false;
            lblUserOrEmail.Visible = false;
            ossSendPassword.Visible = false;
            ossSendUserOrEmail.Visible = false;
        }

        private void dtGridViewSteps_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (dtGridViewSteps.Rows.Count > 0)
            {
                btnNext_ProcessLogin.Enabled = true;
            }
            else
            {
                btnNext_ProcessLogin.Enabled = false;
            }
        }

        private void dtGridViewSteps_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dtGridViewSteps.Rows.Count > 0)
            {
                btnNext_ProcessLogin.Enabled = false;
            }
            else
            {
                btnNext_ProcessLogin.Enabled = false;
            }
        }

        private void btnDeleteStep_Click(object sender, EventArgs e)
        {
            if (dtGridViewSteps.Rows.Count > 0 && dtGridViewSteps.SelectedRows.Count > 0)
            {
                dtGridViewSteps.Rows.RemoveAt(dtGridViewSteps.CurrentRow.Index);
            }
        }

        private void btnBack_ProcessLogin_Click(object sender, EventArgs e)
        {
            PanelOnSucessLogin.Location = new Point(1336, 12);
            PanelOptions.Location = new Point(1336, 12);
            PanelProcessLogin.Location = new Point(1336, 12);
            panelUrlLogin.Location = new Point(116, 118);
        }


        private void btnBack_OnSuccessLogin_Click(object sender, EventArgs e)
        {
            PanelOnSucessLogin.Location = new Point(1336, 12);
            PanelOptions.Location = new Point(1336, 12);
            panelUrlLogin.Location = new Point(1336, 12);

            PanelProcessLogin.Location = new Point(2, 4);
        }

        private void btnBack_Options_Click(object sender, EventArgs e)
        {
            PanelProcessLogin.Location = new Point(1336, 12);
            PanelOptions.Location = new Point(1336, 12);
            panelUrlLogin.Location = new Point(1336, 12);

            PanelOnSucessLogin.Location = new Point(116, 24);
        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
