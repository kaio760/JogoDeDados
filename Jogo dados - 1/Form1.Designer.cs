namespace Jogo_dados___1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupComecar = new GroupBox();
            but_start = new Button();
            txt_nome = new TextBox();
            lbl_nome = new Label();
            groupPlacar = new GroupBox();
            lblPonto2 = new Label();
            lblPonto1 = new Label();
            roboPonto = new PictureBox();
            Pb_Vs = new PictureBox();
            usuarioPonto = new PictureBox();
            groupUsuario = new GroupBox();
            Pb_1 = new PictureBox();
            groupComputador = new GroupBox();
            Pb_2 = new PictureBox();
            but_stop = new Button();
            pontoMaquina = new Label();
            groupComecar.SuspendLayout();
            groupPlacar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)roboPonto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pb_Vs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)usuarioPonto).BeginInit();
            groupUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Pb_1).BeginInit();
            groupComputador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Pb_2).BeginInit();
            SuspendLayout();
            // 
            // groupComecar
            // 
            groupComecar.Controls.Add(but_start);
            groupComecar.Controls.Add(txt_nome);
            groupComecar.Controls.Add(lbl_nome);
            groupComecar.Location = new Point(27, 49);
            groupComecar.Name = "groupComecar";
            groupComecar.Size = new Size(280, 238);
            groupComecar.TabIndex = 0;
            groupComecar.TabStop = false;
            groupComecar.Text = "Começar";
            // 
            // but_start
            // 
            but_start.Image = (Image)resources.GetObject("but_start.Image");
            but_start.Location = new Point(51, 73);
            but_start.Name = "but_start";
            but_start.Size = new Size(171, 139);
            but_start.TabIndex = 2;
            but_start.Text = "Start";
            but_start.TextAlign = ContentAlignment.BottomCenter;
            but_start.UseVisualStyleBackColor = true;
            but_start.Click += but_start_Click;
            // 
            // txt_nome
            // 
            txt_nome.Location = new Point(121, 29);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(134, 23);
            txt_nome.TabIndex = 1;
            txt_nome.Click += but_start_Click;
            txt_nome.TextChanged += txt_nome_TextChanged;
            txt_nome.DoubleClick += txt_nome_TextChanged;
            txt_nome.KeyPress += txt_1_KeyPress;
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.Location = new Point(13, 32);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(102, 15);
            lbl_nome.TabIndex = 0;
            lbl_nome.Text = "Nome do usuario:";
            // 
            // groupPlacar
            // 
            groupPlacar.Controls.Add(lblPonto2);
            groupPlacar.Controls.Add(lblPonto1);
            groupPlacar.Controls.Add(roboPonto);
            groupPlacar.Controls.Add(Pb_Vs);
            groupPlacar.Controls.Add(usuarioPonto);
            groupPlacar.Location = new Point(344, 49);
            groupPlacar.Name = "groupPlacar";
            groupPlacar.Size = new Size(606, 238);
            groupPlacar.TabIndex = 1;
            groupPlacar.TabStop = false;
            groupPlacar.Text = "Placar";
            // 
            // lblPonto2
            // 
            lblPonto2.AutoSize = true;
            lblPonto2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPonto2.ForeColor = Color.Red;
            lblPonto2.Location = new Point(466, 192);
            lblPonto2.Name = "lblPonto2";
            lblPonto2.Size = new Size(25, 30);
            lblPonto2.TabIndex = 4;
            lblPonto2.Text = "0";
            // 
            // lblPonto1
            // 
            lblPonto1.AutoSize = true;
            lblPonto1.BackColor = SystemColors.ButtonFace;
            lblPonto1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPonto1.ForeColor = Color.Red;
            lblPonto1.Location = new Point(110, 192);
            lblPonto1.Name = "lblPonto1";
            lblPonto1.Size = new Size(25, 30);
            lblPonto1.TabIndex = 3;
            lblPonto1.Text = "0";
            // 
            // roboPonto
            // 
            roboPonto.Image = (Image)resources.GetObject("roboPonto.Image");
            roboPonto.Location = new Point(392, 22);
            roboPonto.Name = "roboPonto";
            roboPonto.Size = new Size(162, 158);
            roboPonto.SizeMode = PictureBoxSizeMode.StretchImage;
            roboPonto.TabIndex = 2;
            roboPonto.TabStop = false;
            // 
            // Pb_Vs
            // 
            Pb_Vs.Image = (Image)resources.GetObject("Pb_Vs.Image");
            Pb_Vs.Location = new Point(237, 73);
            Pb_Vs.Name = "Pb_Vs";
            Pb_Vs.Size = new Size(105, 94);
            Pb_Vs.SizeMode = PictureBoxSizeMode.StretchImage;
            Pb_Vs.TabIndex = 1;
            Pb_Vs.TabStop = false;
            // 
            // usuarioPonto
            // 
            usuarioPonto.Image = (Image)resources.GetObject("usuarioPonto.Image");
            usuarioPonto.Location = new Point(42, 22);
            usuarioPonto.Name = "usuarioPonto";
            usuarioPonto.Size = new Size(159, 158);
            usuarioPonto.SizeMode = PictureBoxSizeMode.StretchImage;
            usuarioPonto.TabIndex = 0;
            usuarioPonto.TabStop = false;
            // 
            // groupUsuario
            // 
            groupUsuario.Controls.Add(Pb_1);
            groupUsuario.Location = new Point(224, 310);
            groupUsuario.Name = "groupUsuario";
            groupUsuario.Size = new Size(299, 262);
            groupUsuario.TabIndex = 2;
            groupUsuario.TabStop = false;
            groupUsuario.Text = "Usuario";
            // 
            // Pb_1
            // 
            Pb_1.ErrorImage = Properties.Resources.R__1_;
            Pb_1.Image = Properties.Resources.dados;
            Pb_1.Location = new Point(45, 33);
            Pb_1.Name = "Pb_1";
            Pb_1.Size = new Size(210, 210);
            Pb_1.SizeMode = PictureBoxSizeMode.StretchImage;
            Pb_1.TabIndex = 0;
            Pb_1.TabStop = false;
            // 
            // groupComputador
            // 
            groupComputador.Controls.Add(Pb_2);
            groupComputador.Location = new Point(626, 310);
            groupComputador.Name = "groupComputador";
            groupComputador.Size = new Size(299, 262);
            groupComputador.TabIndex = 3;
            groupComputador.TabStop = false;
            groupComputador.Text = "Computador";
            // 
            // Pb_2
            // 
            Pb_2.Image = (Image)resources.GetObject("Pb_2.Image");
            Pb_2.Location = new Point(49, 33);
            Pb_2.Name = "Pb_2";
            Pb_2.Size = new Size(210, 210);
            Pb_2.SizeMode = PictureBoxSizeMode.StretchImage;
            Pb_2.TabIndex = 0;
            Pb_2.TabStop = false;
            // 
            // but_stop
            // 
            but_stop.BackColor = SystemColors.ControlLight;
            but_stop.Image = (Image)resources.GetObject("but_stop.Image");
            but_stop.Location = new Point(37, 377);
            but_stop.Name = "but_stop";
            but_stop.Size = new Size(147, 148);
            but_stop.TabIndex = 4;
            but_stop.Text = "STOP";
            but_stop.TextAlign = ContentAlignment.BottomCenter;
            but_stop.UseVisualStyleBackColor = false;
            but_stop.Click += but_stop_Click;
            // 
            // pontoMaquina
            // 
            pontoMaquina.AutoSize = true;
            pontoMaquina.Location = new Point(765, 581);
            pontoMaquina.Name = "pontoMaquina";
            pontoMaquina.Size = new Size(38, 15);
            pontoMaquina.TabIndex = 5;
            pontoMaquina.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1113, 609);
            Controls.Add(pontoMaquina);
            Controls.Add(but_stop);
            Controls.Add(groupComputador);
            Controls.Add(groupUsuario);
            Controls.Add(groupPlacar);
            Controls.Add(groupComecar);
            Name = "Form1";
            Text = "Form1";
            groupComecar.ResumeLayout(false);
            groupComecar.PerformLayout();
            groupPlacar.ResumeLayout(false);
            groupPlacar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)roboPonto).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pb_Vs).EndInit();
            ((System.ComponentModel.ISupportInitialize)usuarioPonto).EndInit();
            groupUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Pb_1).EndInit();
            groupComputador.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Pb_2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupComecar;
        private Button but_start;
        private TextBox txt_nome;
        private Label lbl_nome;
        private GroupBox groupPlacar;
        private PictureBox roboPonto;
        private PictureBox Pb_Vs;
        private PictureBox usuarioPonto;
        private GroupBox groupUsuario;
        private GroupBox groupComputador;
        private Button but_stop;
        private Label lblPonto1;
        private Label lblPonto2;
        private PictureBox Pb_1;
        private PictureBox Pb_2;
        private Label pontoMaquina;
    }
}