using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApolloChecker
{
    public partial class frmSettings : Form
    {
        public class RootJsonSettings
        {
            // Properties
            public char separator_combo { get; set; }

            public bool debug_mode { get; set; }
        }

        public frmSettings()
        {
            InitializeComponent();
        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadSettings()
        {
            RootJsonSettings settings = JsonConvert.DeserializeObject<RootJsonSettings>(clsUtils.getSettingsJSON());
            this.tbSeparator.Text = settings.separator_combo.ToString();
            this.ossDebugMode.Value = settings.debug_mode;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.tbSeparator.Text))
            {
                this.tbSeparator.Text = ":";
            }
            clsUtils.updateSettingsJSON(this.tbSeparator.Text[0].ToString(), this.ossDebugMode.Value.ToString().ToLower());

            this.Close();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }
    }
}
