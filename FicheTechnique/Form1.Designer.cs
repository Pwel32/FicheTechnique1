namespace FicheTechnique
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnHeader = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pnSideMenu = new System.Windows.Forms.Panel();
            this.btnMonitorTester = new System.Windows.Forms.Button();
            this.btnKeyboardTester = new System.Windows.Forms.Button();
            this.btnBatteryTester = new System.Windows.Forms.Button();
            this.btnHwInfo = new System.Windows.Forms.Button();
            this.btnMainPage = new System.Windows.Forms.Button();
            this.pnHeader.SuspendLayout();
            this.pnSideMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.LightBlue;
            this.pnHeader.Controls.Add(this.lbTitle);
            this.pnHeader.Location = new System.Drawing.Point(7, 12);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(1093, 112);
            this.pnHeader.TabIndex = 0;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 43F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(419, 25);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(270, 67);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Welcome";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnSideMenu
            // 
            this.pnSideMenu.Controls.Add(this.btnMonitorTester);
            this.pnSideMenu.Controls.Add(this.btnKeyboardTester);
            this.pnSideMenu.Controls.Add(this.btnBatteryTester);
            this.pnSideMenu.Controls.Add(this.btnHwInfo);
            this.pnSideMenu.Controls.Add(this.btnMainPage);
            this.pnSideMenu.Location = new System.Drawing.Point(7, 113);
            this.pnSideMenu.Name = "pnSideMenu";
            this.pnSideMenu.Size = new System.Drawing.Size(221, 510);
            this.pnSideMenu.TabIndex = 1;
            // 
            // btnMonitorTester
            // 
            this.btnMonitorTester.BackColor = System.Drawing.Color.LightBlue;
            this.btnMonitorTester.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.btnMonitorTester.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonitorTester.Location = new System.Drawing.Point(0, 408);
            this.btnMonitorTester.Name = "btnMonitorTester";
            this.btnMonitorTester.Size = new System.Drawing.Size(221, 102);
            this.btnMonitorTester.TabIndex = 4;
            this.btnMonitorTester.Text = "Monitor Tester";
            this.btnMonitorTester.UseVisualStyleBackColor = false;
            // 
            // btnKeyboardTester
            // 
            this.btnKeyboardTester.BackColor = System.Drawing.Color.LightBlue;
            this.btnKeyboardTester.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.btnKeyboardTester.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeyboardTester.Location = new System.Drawing.Point(0, 306);
            this.btnKeyboardTester.Name = "btnKeyboardTester";
            this.btnKeyboardTester.Size = new System.Drawing.Size(221, 102);
            this.btnKeyboardTester.TabIndex = 3;
            this.btnKeyboardTester.Text = "Keyboard Tester";
            this.btnKeyboardTester.UseVisualStyleBackColor = false;
            // 
            // btnBatteryTester
            // 
            this.btnBatteryTester.BackColor = System.Drawing.Color.LightBlue;
            this.btnBatteryTester.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.btnBatteryTester.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatteryTester.Location = new System.Drawing.Point(0, 204);
            this.btnBatteryTester.Name = "btnBatteryTester";
            this.btnBatteryTester.Size = new System.Drawing.Size(221, 102);
            this.btnBatteryTester.TabIndex = 2;
            this.btnBatteryTester.Text = "Battery Tester";
            this.btnBatteryTester.UseVisualStyleBackColor = false;
            // 
            // btnHwInfo
            // 
            this.btnHwInfo.BackColor = System.Drawing.Color.LightBlue;
            this.btnHwInfo.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.btnHwInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHwInfo.Location = new System.Drawing.Point(0, 102);
            this.btnHwInfo.Name = "btnHwInfo";
            this.btnHwInfo.Size = new System.Drawing.Size(221, 102);
            this.btnHwInfo.TabIndex = 1;
            this.btnHwInfo.Text = "Hardware Information";
            this.btnHwInfo.UseVisualStyleBackColor = false;
            // 
            // btnMainPage
            // 
            this.btnMainPage.BackColor = System.Drawing.Color.LightBlue;
            this.btnMainPage.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.btnMainPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainPage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMainPage.Location = new System.Drawing.Point(0, 0);
            this.btnMainPage.Name = "btnMainPage";
            this.btnMainPage.Size = new System.Drawing.Size(221, 102);
            this.btnMainPage.TabIndex = 0;
            this.btnMainPage.Text = "Main Page";
            this.btnMainPage.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 628);
            this.Controls.Add(this.pnSideMenu);
            this.Controls.Add(this.pnHeader);
            this.MaximumSize = new System.Drawing.Size(1128, 667);
            this.MinimumSize = new System.Drawing.Size(1128, 667);
            this.Name = "Form1";
            this.Text = "Fiche Technique";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            this.pnSideMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel pnSideMenu;
        private System.Windows.Forms.Button btnHwInfo;
        private System.Windows.Forms.Button btnMainPage;
        private System.Windows.Forms.Button btnBatteryTester;
        private System.Windows.Forms.Button btnMonitorTester;
        private System.Windows.Forms.Button btnKeyboardTester;
    }
}

