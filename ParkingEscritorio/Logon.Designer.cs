namespace ParkingEscritorio
{
    partial class Logon
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
            this.MTBUSUARIO = new MetroFramework.Controls.MetroTextBox();
            this.MTBPASS = new MetroFramework.Controls.MetroTextBox();
            this.MBENTRAR = new MetroFramework.Controls.MetroButton();
            this.MLUSUARIO = new MetroFramework.Controls.MetroLabel();
            this.MLPASS = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // MTBUSUARIO
            // 
            this.MTBUSUARIO.Lines = new string[0];
            this.MTBUSUARIO.Location = new System.Drawing.Point(126, 122);
            this.MTBUSUARIO.MaxLength = 32767;
            this.MTBUSUARIO.Name = "MTBUSUARIO";
            this.MTBUSUARIO.PasswordChar = '\0';
            this.MTBUSUARIO.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MTBUSUARIO.SelectedText = "";
            this.MTBUSUARIO.Size = new System.Drawing.Size(101, 23);
            this.MTBUSUARIO.TabIndex = 0;
            this.MTBUSUARIO.UseSelectable = true;
            // 
            // MTBPASS
            // 
            this.MTBPASS.Lines = new string[0];
            this.MTBPASS.Location = new System.Drawing.Point(126, 184);
            this.MTBPASS.MaxLength = 32767;
            this.MTBPASS.Name = "MTBPASS";
            this.MTBPASS.PasswordChar = '\0';
            this.MTBPASS.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MTBPASS.SelectedText = "";
            this.MTBPASS.Size = new System.Drawing.Size(101, 23);
            this.MTBPASS.TabIndex = 1;
            this.MTBPASS.UseSelectable = true;
            // 
            // MBENTRAR
            // 
            this.MBENTRAR.Location = new System.Drawing.Point(139, 222);
            this.MBENTRAR.Name = "MBENTRAR";
            this.MBENTRAR.Size = new System.Drawing.Size(75, 23);
            this.MBENTRAR.TabIndex = 2;
            this.MBENTRAR.Text = "Entrar";
            this.MBENTRAR.UseSelectable = true;
            this.MBENTRAR.Click += new System.EventHandler(this.inciarParking);
            // 
            // MLUSUARIO
            // 
            this.MLUSUARIO.AutoSize = true;
            this.MLUSUARIO.Location = new System.Drawing.Point(149, 100);
            this.MLUSUARIO.Name = "MLUSUARIO";
            this.MLUSUARIO.Size = new System.Drawing.Size(53, 19);
            this.MLUSUARIO.TabIndex = 3;
            this.MLUSUARIO.Text = "Usuario";
            // 
            // MLPASS
            // 
            this.MLPASS.AutoSize = true;
            this.MLPASS.Location = new System.Drawing.Point(139, 162);
            this.MLPASS.Name = "MLPASS";
            this.MLPASS.Size = new System.Drawing.Size(75, 19);
            this.MLPASS.TabIndex = 4;
            this.MLPASS.Text = "Contraseña";
            // 
            // Logon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 311);
            this.Controls.Add(this.MLPASS);
            this.Controls.Add(this.MLUSUARIO);
            this.Controls.Add(this.MBENTRAR);
            this.Controls.Add(this.MTBPASS);
            this.Controls.Add(this.MTBUSUARIO);
            this.Name = "Logon";
            this.Text = "Logon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox MTBUSUARIO;
        private MetroFramework.Controls.MetroTextBox MTBPASS;
        private MetroFramework.Controls.MetroButton MBENTRAR;
        private MetroFramework.Controls.MetroLabel MLUSUARIO;
        private MetroFramework.Controls.MetroLabel MLPASS;
    }
}