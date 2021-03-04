
namespace MDSMForms
{
    partial class MainMenu
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
            this.Lbl_Title = new System.Windows.Forms.Label();
            this.Pnl_Menu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_RomManager = new System.Windows.Forms.Button();
            this.Pnl_Installer = new System.Windows.Forms.Panel();
            this.Btn_Installer = new System.Windows.Forms.Button();
            this.Pnl_Menu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Pnl_Installer.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_Title
            // 
            this.Lbl_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Title.Location = new System.Drawing.Point(0, 0);
            this.Lbl_Title.Name = "Lbl_Title";
            this.Lbl_Title.Padding = new System.Windows.Forms.Padding(25, 20, 25, 20);
            this.Lbl_Title.Size = new System.Drawing.Size(382, 102);
            this.Lbl_Title.TabIndex = 1;
            this.Lbl_Title.Text = "MelonDS Manager";
            this.Lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pnl_Menu
            // 
            this.Pnl_Menu.Controls.Add(this.panel1);
            this.Pnl_Menu.Controls.Add(this.Pnl_Installer);
            this.Pnl_Menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_Menu.Location = new System.Drawing.Point(0, 102);
            this.Pnl_Menu.Name = "Pnl_Menu";
            this.Pnl_Menu.Padding = new System.Windows.Forms.Padding(50, 20, 50, 20);
            this.Pnl_Menu.Size = new System.Drawing.Size(382, 251);
            this.Pnl_Menu.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_RomManager);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(50, 80);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.panel1.Size = new System.Drawing.Size(282, 60);
            this.panel1.TabIndex = 2;
            // 
            // Btn_RomManager
            // 
            this.Btn_RomManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_RomManager.Location = new System.Drawing.Point(0, 0);
            this.Btn_RomManager.Name = "Btn_RomManager";
            this.Btn_RomManager.Size = new System.Drawing.Size(282, 50);
            this.Btn_RomManager.TabIndex = 0;
            this.Btn_RomManager.Text = "ROM Manager";
            this.Btn_RomManager.UseVisualStyleBackColor = true;
            this.Btn_RomManager.Click += new System.EventHandler(this.Btn_RomManager_Click);
            // 
            // Pnl_Installer
            // 
            this.Pnl_Installer.Controls.Add(this.Btn_Installer);
            this.Pnl_Installer.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_Installer.Location = new System.Drawing.Point(50, 20);
            this.Pnl_Installer.Name = "Pnl_Installer";
            this.Pnl_Installer.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.Pnl_Installer.Size = new System.Drawing.Size(282, 60);
            this.Pnl_Installer.TabIndex = 1;
            // 
            // Btn_Installer
            // 
            this.Btn_Installer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Installer.Location = new System.Drawing.Point(0, 0);
            this.Btn_Installer.Name = "Btn_Installer";
            this.Btn_Installer.Size = new System.Drawing.Size(282, 50);
            this.Btn_Installer.TabIndex = 0;
            this.Btn_Installer.Text = "MelonDS Installer";
            this.Btn_Installer.UseVisualStyleBackColor = true;
            this.Btn_Installer.Click += new System.EventHandler(this.Btn_Installer_Click);
            // 
            // MDSMMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 353);
            this.Controls.Add(this.Pnl_Menu);
            this.Controls.Add(this.Lbl_Title);
            this.Name = "MDSMMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MelonDS Manager";
            this.Load += new System.EventHandler(this.MDSMMainMenu_Load);
            this.Pnl_Menu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.Pnl_Installer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Title;
        private System.Windows.Forms.Panel Pnl_Menu;
        private System.Windows.Forms.Button Btn_Installer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_RomManager;
        private System.Windows.Forms.Panel Pnl_Installer;
    }
}