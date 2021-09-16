namespace ApolloChecker
{
    partial class frmSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.ElipseFrmSettings = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lblSair = new System.Windows.Forms.Label();
            this.btnSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tbSeparator = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.ossDebugMode = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.label2 = new System.Windows.Forms.Label();
            this.DragControlFrmSettings = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.SuspendLayout();
            // 
            // ElipseFrmSettings
            // 
            this.ElipseFrmSettings.ElipseRadius = 5;
            this.ElipseFrmSettings.TargetControl = this;
            // 
            // lblSair
            // 
            this.lblSair.AutoSize = true;
            this.lblSair.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSair.ForeColor = System.Drawing.Color.White;
            this.lblSair.Location = new System.Drawing.Point(334, 4);
            this.lblSair.Name = "lblSair";
            this.lblSair.Size = new System.Drawing.Size(16, 17);
            this.lblSair.TabIndex = 16;
            this.lblSair.Text = "X";
            this.lblSair.Click += new System.EventHandler(this.lblSair_Click);
            // 
            // btnSave
            // 
            this.btnSave.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(250)))));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(250)))));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.BorderRadius = 0;
            this.btnSave.ButtonText = "       Save";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DisabledColor = System.Drawing.Color.Gray;
            this.btnSave.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSave.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSave.Iconimage")));
            this.btnSave.Iconimage_right = null;
            this.btnSave.Iconimage_right_Selected = null;
            this.btnSave.Iconimage_Selected = null;
            this.btnSave.IconMarginLeft = 0;
            this.btnSave.IconMarginRight = 0;
            this.btnSave.IconRightVisible = true;
            this.btnSave.IconRightZoom = 0D;
            this.btnSave.IconVisible = true;
            this.btnSave.IconZoom = 35D;
            this.btnSave.IsTab = false;
            this.btnSave.Location = new System.Drawing.Point(208, 176);
            this.btnSave.Name = "btnSave";
            this.btnSave.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(250)))));
            this.btnSave.OnHovercolor = System.Drawing.Color.White;
            this.btnSave.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(250)))));
            this.btnSave.selected = false;
            this.btnSave.Size = new System.Drawing.Size(136, 39);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "       Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Textcolor = System.Drawing.Color.White;
            this.btnSave.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbSeparator
            // 
            this.tbSeparator.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSeparator.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbSeparator.ForeColor = System.Drawing.Color.White;
            this.tbSeparator.HintForeColor = System.Drawing.Color.White;
            this.tbSeparator.HintText = "";
            this.tbSeparator.isPassword = false;
            this.tbSeparator.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(250)))));
            this.tbSeparator.LineIdleColor = System.Drawing.Color.Gray;
            this.tbSeparator.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(250)))));
            this.tbSeparator.LineThickness = 3;
            this.tbSeparator.Location = new System.Drawing.Point(144, 62);
            this.tbSeparator.Margin = new System.Windows.Forms.Padding(4);
            this.tbSeparator.Name = "tbSeparator";
            this.tbSeparator.Size = new System.Drawing.Size(39, 33);
            this.tbSeparator.TabIndex = 18;
            this.tbSeparator.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Separator (Combo):";
            // 
            // ossDebugMode
            // 
            this.ossDebugMode.BackColor = System.Drawing.Color.Transparent;
            this.ossDebugMode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ossDebugMode.BackgroundImage")));
            this.ossDebugMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ossDebugMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ossDebugMode.Location = new System.Drawing.Point(144, 111);
            this.ossDebugMode.Name = "ossDebugMode";
            this.ossDebugMode.OffColor = System.Drawing.Color.Gray;
            this.ossDebugMode.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(250)))));
            this.ossDebugMode.Size = new System.Drawing.Size(35, 20);
            this.ossDebugMode.TabIndex = 20;
            this.ossDebugMode.Value = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(48, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Debug Mode:";
            // 
            // DragControlFrmSettings
            // 
            this.DragControlFrmSettings.Fixed = true;
            this.DragControlFrmSettings.Horizontal = true;
            this.DragControlFrmSettings.TargetControl = this;
            this.DragControlFrmSettings.Vertical = true;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(356, 227);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ossDebugMode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSeparator);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse ElipseFrmSettings;
        private System.Windows.Forms.Label lblSair;
        private Bunifu.Framework.UI.BunifuFlatButton btnSave;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbSeparator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuiOSSwitch ossDebugMode;
        private Bunifu.Framework.UI.BunifuDragControl DragControlFrmSettings;
    }
}