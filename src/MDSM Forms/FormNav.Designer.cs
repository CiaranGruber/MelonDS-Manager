
namespace MDSMForms
{
    partial class FormNav
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
            this.Lbl_Loading = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_Loading
            // 
            this.Lbl_Loading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_Loading.Font = new System.Drawing.Font("Proxy 1", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Loading.Location = new System.Drawing.Point(0, 0);
            this.Lbl_Loading.Name = "Lbl_Loading";
            this.Lbl_Loading.Size = new System.Drawing.Size(300, 100);
            this.Lbl_Loading.TabIndex = 0;
            this.Lbl_Loading.Text = "Loading...";
            this.Lbl_Loading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormNav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 100);
            this.Controls.Add(this.Lbl_Loading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNav";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading...";
            this.Load += new System.EventHandler(this.FormNav_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Loading;
    }
}

