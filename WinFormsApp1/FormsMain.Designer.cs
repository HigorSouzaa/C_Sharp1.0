namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btLogin = new Button();
            btCadastro = new Button();
            SuspendLayout();
            // 
            // btLogin
            // 
            btLogin.BackColor = Color.Transparent;
            btLogin.BackgroundImage = Properties.Resources.btLogin;
            btLogin.BackgroundImageLayout = ImageLayout.Center;
            btLogin.FlatAppearance.BorderSize = 0;
            btLogin.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btLogin.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btLogin.FlatStyle = FlatStyle.Flat;
            btLogin.Location = new Point(68, 344);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(232, 63);
            btLogin.TabIndex = 0;
            btLogin.UseVisualStyleBackColor = false;
            btLogin.MouseEnter += BtLogin_MouseEnter;
            btLogin.MouseLeave += BtLogin_MouseLeave;
            // 
            // btCadastro
            // 
            btCadastro.BackColor = Color.Transparent;
            btCadastro.BackgroundImage = Properties.Resources.btCadastro;
            btCadastro.BackgroundImageLayout = ImageLayout.Center;
            btCadastro.FlatAppearance.BorderSize = 0;
            btCadastro.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btCadastro.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btCadastro.FlatStyle = FlatStyle.Flat;
            btCadastro.Location = new Point(493, 344);
            btCadastro.Name = "btCadastro";
            btCadastro.Size = new Size(232, 63);
            btCadastro.TabIndex = 1;
            btCadastro.UseVisualStyleBackColor = false;
            btCadastro.MouseEnter += BtCadastro_MouseEnter;
            btCadastro.MouseLeave += BtCadastro_MouseLeave;
            btCadastro.MouseClick += BtCadastro_MouseClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BackGround;
            ClientSize = new Size(800, 450);
            Controls.Add(btCadastro);
            Controls.Add(btLogin);
            Name = "Menu Principal";
            Text = "Menu Principal";
            ResumeLayout(false);
        }

        private void BtCadastro_MouseClick(object sender, MouseEventArgs e)
        {
            FormsCadastro formsCadastro = new FormsCadastro();
            formsCadastro.Show();
            this.Hide();
        }

        private void BtLogin_MouseLeave(object sender, EventArgs e)
        {
            btLogin.BackgroundImage = Properties.Resources.btLogin;
        }

        private void BtLogin_MouseEnter(object sender, EventArgs e)
        {
            btLogin.BackgroundImage= Properties.Resources.btLoginHover;
        }

        private void BtCadastro_MouseLeave(object sender, EventArgs e)
        {
            btCadastro.BackgroundImage = Properties.Resources.btCadastro;
        }

        private void BtCadastro_MouseEnter(object sender, EventArgs e)
        {
            btCadastro.BackgroundImage = Properties.Resources.btCadastoHover;
        }
        #endregion

        private Button btLogin;
        private Button btCadastro;
    }
}
