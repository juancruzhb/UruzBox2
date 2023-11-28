namespace Presentation_Layer
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelButtons = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAgregarAlumno = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelAgregarAlumno = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtAgregarEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAgregarCelular = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAgregarApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAgregarNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.btnLoginSalir = new System.Windows.Forms.Button();
            this.btnLoginEntrar = new System.Windows.Forms.Button();
            this.txtLoginPass = new System.Windows.Forms.TextBox();
            this.txtLoginUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.panelButtons.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelAgregarAlumno.SuspendLayout();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.button5);
            this.panelButtons.Controls.Add(this.button4);
            this.panelButtons.Controls.Add(this.button3);
            this.panelButtons.Controls.Add(this.button2);
            this.panelButtons.Controls.Add(this.btnAgregarAlumno);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons.Location = new System.Drawing.Point(0, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(913, 135);
            this.panelButtons.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(605, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(123, 72);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(444, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 72);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(301, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 72);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(158, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 72);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnAgregarAlumno
            // 
            this.btnAgregarAlumno.Location = new System.Drawing.Point(16, 12);
            this.btnAgregarAlumno.Name = "btnAgregarAlumno";
            this.btnAgregarAlumno.Size = new System.Drawing.Size(123, 72);
            this.btnAgregarAlumno.TabIndex = 0;
            this.btnAgregarAlumno.Text = "Agregar Alumno";
            this.btnAgregarAlumno.UseVisualStyleBackColor = true;
            this.btnAgregarAlumno.Click += new System.EventHandler(this.btnAgregarAlumno_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelAgregarAlumno);
            this.panelMain.Controls.Add(this.panelLogin);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMain.Location = new System.Drawing.Point(0, 141);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(913, 485);
            this.panelMain.TabIndex = 1;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // panelAgregarAlumno
            // 
            this.panelAgregarAlumno.Controls.Add(this.button6);
            this.panelAgregarAlumno.Controls.Add(this.button1);
            this.panelAgregarAlumno.Controls.Add(this.txtAgregarEmail);
            this.panelAgregarAlumno.Controls.Add(this.label5);
            this.panelAgregarAlumno.Controls.Add(this.txtAgregarCelular);
            this.panelAgregarAlumno.Controls.Add(this.label4);
            this.panelAgregarAlumno.Controls.Add(this.txtAgregarApellido);
            this.panelAgregarAlumno.Controls.Add(this.label3);
            this.panelAgregarAlumno.Controls.Add(this.txtAgregarNombre);
            this.panelAgregarAlumno.Controls.Add(this.lblNombre);
            this.panelAgregarAlumno.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAgregarAlumno.Location = new System.Drawing.Point(0, 3);
            this.panelAgregarAlumno.Name = "panelAgregarAlumno";
            this.panelAgregarAlumno.Size = new System.Drawing.Size(913, 482);
            this.panelAgregarAlumno.TabIndex = 1;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(539, 394);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 11;
            this.button6.Text = "Cancelar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(349, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAgregarEmail
            // 
            this.txtAgregarEmail.Location = new System.Drawing.Point(349, 226);
            this.txtAgregarEmail.Name = "txtAgregarEmail";
            this.txtAgregarEmail.Size = new System.Drawing.Size(265, 22);
            this.txtAgregarEmail.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(276, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Email";
            // 
            // txtAgregarCelular
            // 
            this.txtAgregarCelular.Location = new System.Drawing.Point(349, 171);
            this.txtAgregarCelular.Name = "txtAgregarCelular";
            this.txtAgregarCelular.Size = new System.Drawing.Size(265, 22);
            this.txtAgregarCelular.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Celular";
            // 
            // txtAgregarApellido
            // 
            this.txtAgregarApellido.Location = new System.Drawing.Point(349, 114);
            this.txtAgregarApellido.Name = "txtAgregarApellido";
            this.txtAgregarApellido.Size = new System.Drawing.Size(265, 22);
            this.txtAgregarApellido.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido";
            // 
            // txtAgregarNombre
            // 
            this.txtAgregarNombre.Location = new System.Drawing.Point(349, 62);
            this.txtAgregarNombre.Name = "txtAgregarNombre";
            this.txtAgregarNombre.Size = new System.Drawing.Size(265, 22);
            this.txtAgregarNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(276, 62);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // panelLogin
            // 
            this.panelLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelLogin.Controls.Add(this.btnLoginSalir);
            this.panelLogin.Controls.Add(this.btnLoginEntrar);
            this.panelLogin.Controls.Add(this.txtLoginPass);
            this.panelLogin.Controls.Add(this.txtLoginUser);
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Controls.Add(this.lblUser);
            this.panelLogin.Location = new System.Drawing.Point(234, 117);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(492, 262);
            this.panelLogin.TabIndex = 0;
            // 
            // btnLoginSalir
            // 
            this.btnLoginSalir.Location = new System.Drawing.Point(370, 180);
            this.btnLoginSalir.Name = "btnLoginSalir";
            this.btnLoginSalir.Size = new System.Drawing.Size(89, 34);
            this.btnLoginSalir.TabIndex = 5;
            this.btnLoginSalir.Text = "Salir";
            this.btnLoginSalir.UseVisualStyleBackColor = true;
            // 
            // btnLoginEntrar
            // 
            this.btnLoginEntrar.Location = new System.Drawing.Point(219, 180);
            this.btnLoginEntrar.Name = "btnLoginEntrar";
            this.btnLoginEntrar.Size = new System.Drawing.Size(89, 34);
            this.btnLoginEntrar.TabIndex = 4;
            this.btnLoginEntrar.Text = "Entrar";
            this.btnLoginEntrar.UseVisualStyleBackColor = true;
            this.btnLoginEntrar.Click += new System.EventHandler(this.btnLoginEntrar_Click);
            // 
            // txtLoginPass
            // 
            this.txtLoginPass.Location = new System.Drawing.Point(219, 126);
            this.txtLoginPass.Name = "txtLoginPass";
            this.txtLoginPass.Size = new System.Drawing.Size(240, 22);
            this.txtLoginPass.TabIndex = 3;
            // 
            // txtLoginUser
            // 
            this.txtLoginUser.Location = new System.Drawing.Point(219, 60);
            this.txtLoginUser.Name = "txtLoginUser";
            this.txtLoginUser.Size = new System.Drawing.Size(240, 22);
            this.txtLoginUser.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Password";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(40, 57);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(92, 25);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Usuario:";
            this.lblUser.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 626);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uruz Box System";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.DoubleClick += new System.EventHandler(this.frmMain_DoubleClick);
            this.panelButtons.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelAgregarAlumno.ResumeLayout(false);
            this.panelAgregarAlumno.PerformLayout();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnLoginSalir;
        private System.Windows.Forms.Button btnLoginEntrar;
        private System.Windows.Forms.TextBox txtLoginPass;
        private System.Windows.Forms.TextBox txtLoginUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAgregarAlumno;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panelAgregarAlumno;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtAgregarEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAgregarCelular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAgregarApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAgregarNombre;
        private System.Windows.Forms.Label lblNombre;
    }
}

