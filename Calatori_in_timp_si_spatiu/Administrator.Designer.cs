namespace Calatori_in_timp_si_spatiu
{
    partial class Administrator
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
            this.textBox_parola = new System.Windows.Forms.TextBox();
            this.label_parola_admin = new System.Windows.Forms.Label();
            this.btn_autentificare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_parola
            // 
            this.textBox_parola.Location = new System.Drawing.Point(306, 204);
            this.textBox_parola.Name = "textBox_parola";
            this.textBox_parola.PasswordChar = '*';
            this.textBox_parola.Size = new System.Drawing.Size(209, 20);
            this.textBox_parola.TabIndex = 0;
            // 
            // label_parola_admin
            // 
            this.label_parola_admin.AutoSize = true;
            this.label_parola_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_parola_admin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_parola_admin.Location = new System.Drawing.Point(251, 207);
            this.label_parola_admin.Name = "label_parola_admin";
            this.label_parola_admin.Size = new System.Drawing.Size(50, 16);
            this.label_parola_admin.TabIndex = 1;
            this.label_parola_admin.Text = "Parola:";
            // 
            // btn_autentificare
            // 
            this.btn_autentificare.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_autentificare.Location = new System.Drawing.Point(653, 381);
            this.btn_autentificare.Name = "btn_autentificare";
            this.btn_autentificare.Size = new System.Drawing.Size(135, 57);
            this.btn_autentificare.TabIndex = 2;
            this.btn_autentificare.Text = "Autentificare";
            this.btn_autentificare.UseVisualStyleBackColor = false;
            this.btn_autentificare.Click += new System.EventHandler(this.btn_autentificare_Click);
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_autentificare);
            this.Controls.Add(this.label_parola_admin);
            this.Controls.Add(this.textBox_parola);
            this.Name = "Administrator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_parola;
        private System.Windows.Forms.Label label_parola_admin;
        private System.Windows.Forms.Button btn_autentificare;
    }
}