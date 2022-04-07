namespace Calatori_in_timp_si_spatiu
{
    partial class Autentificare
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
            this.btn_admin = new System.Windows.Forms.Button();
            this.btn_turist = new System.Windows.Forms.Button();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_admin
            // 
            this.btn_admin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_admin.Location = new System.Drawing.Point(12, 388);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(148, 50);
            this.btn_admin.TabIndex = 0;
            this.btn_admin.Text = "Administrator";
            this.btn_admin.UseVisualStyleBackColor = false;
            this.btn_admin.Click += new System.EventHandler(this.btn_admin_Click);
            // 
            // btn_turist
            // 
            this.btn_turist.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_turist.Location = new System.Drawing.Point(640, 388);
            this.btn_turist.Name = "btn_turist";
            this.btn_turist.Size = new System.Drawing.Size(148, 50);
            this.btn_turist.TabIndex = 1;
            this.btn_turist.Text = "Turist";
            this.btn_turist.UseVisualStyleBackColor = false;
            this.btn_turist.Click += new System.EventHandler(this.btn_turist_Click);
            // 
            // pb_logo
            // 
            this.pb_logo.BackgroundImage = global::Calatori_in_timp_si_spatiu.Properties.Resources.MSC_Cruises_2020_Logo;
            this.pb_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_logo.Location = new System.Drawing.Point(185, 52);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(428, 244);
            this.pb_logo.TabIndex = 2;
            this.pb_logo.TabStop = false;
            // 
            // Autentificare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pb_logo);
            this.Controls.Add(this.btn_turist);
            this.Controls.Add(this.btn_admin);
            this.Name = "Autentificare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autentificare";
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_admin;
        private System.Windows.Forms.Button btn_turist;
        private System.Windows.Forms.PictureBox pb_logo;
    }
}

