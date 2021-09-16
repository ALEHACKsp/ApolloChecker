namespace ApolloChecker
{
    partial class frmMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.elipseMain = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.sfScrollFrame1 = new Syncfusion.WinForms.Controls.SfScrollFrame();
            this.flowPanelConfigs = new System.Windows.Forms.FlowLayoutPanel();
            this.elipseflowPanelWorkerChecker = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dragControlMain = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flowPanelWorkersChecker = new System.Windows.Forms.FlowLayoutPanel();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblSair = new System.Windows.Forms.Label();
            this.btnNewConfigWizard = new Bunifu.Framework.UI.BunifuFlatButton();
            this.frmSettings = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAllResults = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCards1.SuspendLayout();
            this.SuspendLayout();
            // 
            // elipseMain
            // 
            this.elipseMain.ElipseRadius = 5;
            this.elipseMain.TargetControl = this;
            // 
            // flowPanelConfigs
            // 
            this.flowPanelConfigs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.flowPanelConfigs.Location = new System.Drawing.Point(12, 58);
            this.flowPanelConfigs.Name = "flowPanelConfigs";
            this.flowPanelConfigs.Size = new System.Drawing.Size(194, 423);
            this.flowPanelConfigs.TabIndex = 0;
            // 
            // elipseflowPanelWorkerChecker
            // 
            this.elipseflowPanelWorkerChecker.ElipseRadius = 13;
            this.elipseflowPanelWorkerChecker.TargetControl = this;
            // 
            // dragControlMain
            // 
            this.dragControlMain.Fixed = true;
            this.dragControlMain.Horizontal = true;
            this.dragControlMain.TargetControl = this;
            this.dragControlMain.Vertical = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "ApolloChecker";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Site";
            // 
            // flowPanelWorkersChecker
            // 
            this.flowPanelWorkersChecker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.flowPanelWorkersChecker.Location = new System.Drawing.Point(212, 92);
            this.flowPanelWorkersChecker.Name = "flowPanelWorkersChecker";
            this.flowPanelWorkersChecker.Size = new System.Drawing.Size(904, 389);
            this.flowPanelWorkersChecker.TabIndex = 8;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(250)))));
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(250)))));
            this.bunifuCards1.Controls.Add(this.label9);
            this.bunifuCards1.Controls.Add(this.label8);
            this.bunifuCards1.Controls.Add(this.label7);
            this.bunifuCards1.Controls.Add(this.label6);
            this.bunifuCards1.Controls.Add(this.label5);
            this.bunifuCards1.Controls.Add(this.label4);
            this.bunifuCards1.Controls.Add(this.label3);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(212, 58);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(904, 31);
            this.bunifuCards1.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(775, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Results";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(664, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Progress";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(549, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Not Working";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(461, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Working";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(355, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Checked";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(218, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Accounts";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 8.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(13, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 15);
            this.label10.TabIndex = 12;
            this.label10.Text = "Selenium Driver Edition";
            // 
            // lblSair
            // 
            this.lblSair.AutoSize = true;
            this.lblSair.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSair.ForeColor = System.Drawing.Color.White;
            this.lblSair.Location = new System.Drawing.Point(1098, 9);
            this.lblSair.Name = "lblSair";
            this.lblSair.Size = new System.Drawing.Size(16, 17);
            this.lblSair.TabIndex = 14;
            this.lblSair.Text = "X";
            this.lblSair.Click += new System.EventHandler(this.lblSair_Click);
            // 
            // btnNewConfigWizard
            // 
            this.btnNewConfigWizard.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(250)))));
            this.btnNewConfigWizard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(250)))));
            this.btnNewConfigWizard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewConfigWizard.BorderRadius = 0;
            this.btnNewConfigWizard.ButtonText = "    Add New Config";
            this.btnNewConfigWizard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewConfigWizard.DisabledColor = System.Drawing.Color.Gray;
            this.btnNewConfigWizard.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNewConfigWizard.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnNewConfigWizard.Iconimage")));
            this.btnNewConfigWizard.Iconimage_right = null;
            this.btnNewConfigWizard.Iconimage_right_Selected = null;
            this.btnNewConfigWizard.Iconimage_Selected = null;
            this.btnNewConfigWizard.IconMarginLeft = 0;
            this.btnNewConfigWizard.IconMarginRight = 0;
            this.btnNewConfigWizard.IconRightVisible = true;
            this.btnNewConfigWizard.IconRightZoom = 0D;
            this.btnNewConfigWizard.IconVisible = true;
            this.btnNewConfigWizard.IconZoom = 35D;
            this.btnNewConfigWizard.IsTab = false;
            this.btnNewConfigWizard.Location = new System.Drawing.Point(13, 487);
            this.btnNewConfigWizard.Name = "btnNewConfigWizard";
            this.btnNewConfigWizard.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(250)))));
            this.btnNewConfigWizard.OnHovercolor = System.Drawing.Color.White;
            this.btnNewConfigWizard.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(250)))));
            this.btnNewConfigWizard.selected = false;
            this.btnNewConfigWizard.Size = new System.Drawing.Size(162, 39);
            this.btnNewConfigWizard.TabIndex = 18;
            this.btnNewConfigWizard.Text = "    Add New Config";
            this.btnNewConfigWizard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewConfigWizard.Textcolor = System.Drawing.Color.White;
            this.btnNewConfigWizard.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewConfigWizard.Click += new System.EventHandler(this.btnNewConfigWizard_Click);
            // 
            // frmSettings
            // 
            this.frmSettings.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(250)))));
            this.frmSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(250)))));
            this.frmSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.frmSettings.BorderRadius = 0;
            this.frmSettings.ButtonText = "    Settings";
            this.frmSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.frmSettings.DisabledColor = System.Drawing.Color.Gray;
            this.frmSettings.Iconcolor = System.Drawing.Color.Transparent;
            this.frmSettings.Iconimage = ((System.Drawing.Image)(resources.GetObject("frmSettings.Iconimage")));
            this.frmSettings.Iconimage_right = null;
            this.frmSettings.Iconimage_right_Selected = null;
            this.frmSettings.Iconimage_Selected = null;
            this.frmSettings.IconMarginLeft = 0;
            this.frmSettings.IconMarginRight = 0;
            this.frmSettings.IconRightVisible = true;
            this.frmSettings.IconRightZoom = 0D;
            this.frmSettings.IconVisible = true;
            this.frmSettings.IconZoom = 35D;
            this.frmSettings.IsTab = false;
            this.frmSettings.Location = new System.Drawing.Point(181, 487);
            this.frmSettings.Name = "frmSettings";
            this.frmSettings.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(250)))));
            this.frmSettings.OnHovercolor = System.Drawing.Color.White;
            this.frmSettings.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(250)))));
            this.frmSettings.selected = false;
            this.frmSettings.Size = new System.Drawing.Size(136, 39);
            this.frmSettings.TabIndex = 17;
            this.frmSettings.Text = "    Settings";
            this.frmSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.frmSettings.Textcolor = System.Drawing.Color.White;
            this.frmSettings.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmSettings.Click += new System.EventHandler(this.frmSettings_Click);
            // 
            // btnAllResults
            // 
            this.btnAllResults.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(250)))));
            this.btnAllResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(250)))));
            this.btnAllResults.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAllResults.BorderRadius = 0;
            this.btnAllResults.ButtonText = "    All Results";
            this.btnAllResults.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAllResults.DisabledColor = System.Drawing.Color.Gray;
            this.btnAllResults.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAllResults.Iconimage = global::ApolloChecker.Properties.Resources.iconResults;
            this.btnAllResults.Iconimage_right = null;
            this.btnAllResults.Iconimage_right_Selected = null;
            this.btnAllResults.Iconimage_Selected = null;
            this.btnAllResults.IconMarginLeft = 0;
            this.btnAllResults.IconMarginRight = 0;
            this.btnAllResults.IconRightVisible = true;
            this.btnAllResults.IconRightZoom = 0D;
            this.btnAllResults.IconVisible = true;
            this.btnAllResults.IconZoom = 35D;
            this.btnAllResults.IsTab = false;
            this.btnAllResults.Location = new System.Drawing.Point(980, 487);
            this.btnAllResults.Name = "btnAllResults";
            this.btnAllResults.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(250)))));
            this.btnAllResults.OnHovercolor = System.Drawing.Color.White;
            this.btnAllResults.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(250)))));
            this.btnAllResults.selected = false;
            this.btnAllResults.Size = new System.Drawing.Size(136, 39);
            this.btnAllResults.TabIndex = 10;
            this.btnAllResults.Text = "    All Results";
            this.btnAllResults.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllResults.Textcolor = System.Drawing.Color.White;
            this.btnAllResults.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllResults.Click += new System.EventHandler(this.btnAllResults_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1128, 537);
            this.Controls.Add(this.btnNewConfigWizard);
            this.Controls.Add(this.frmSettings);
            this.Controls.Add(this.lblSair);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnAllResults);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.flowPanelWorkersChecker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowPanelConfigs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse elipseMain;
        private Syncfusion.WinForms.Controls.SfScrollFrame sfScrollFrame1;
        private System.Windows.Forms.FlowLayoutPanel flowPanelConfigs;
        private Bunifu.Framework.UI.BunifuElipse elipseflowPanelWorkerChecker;
        private Bunifu.Framework.UI.BunifuDragControl dragControlMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowPanelWorkersChecker;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuFlatButton btnAllResults;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblSair;
        private Bunifu.Framework.UI.BunifuFlatButton frmSettings;
        private Bunifu.Framework.UI.BunifuFlatButton btnNewConfigWizard;
    }
}

