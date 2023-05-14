using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace JogoDaForcaForm
{
    partial class TelaForca
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
            lblPalavraSecreta = new Label();
            pbImagemForca = new PictureBox();
            pnlBotoes = new Panel();
            button26 = new Button();
            button25 = new Button();
            button24 = new Button();
            button23 = new Button();
            button22 = new Button();
            button21 = new Button();
            button20 = new Button();
            button19 = new Button();
            button18 = new Button();
            button17 = new Button();
            button16 = new Button();
            button15 = new Button();
            button14 = new Button();
            button13 = new Button();
            button12 = new Button();
            button11 = new Button();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            lblDica = new Label();
            btnReset = new Button();
            statusMensagem = new StatusStrip();
            lblMensagemFinal = new ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)pbImagemForca).BeginInit();
            pnlBotoes.SuspendLayout();
            statusMensagem.SuspendLayout();
            SuspendLayout();
            // 
            // lblPalavraSecreta
            // 
            lblPalavraSecreta.AutoSize = true;
            lblPalavraSecreta.Font = new Font("Sora SemiBold", 28.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            lblPalavraSecreta.ForeColor = Color.White;
            lblPalavraSecreta.Location = new Point(30, 73);
            lblPalavraSecreta.Name = "lblPalavraSecreta";
            lblPalavraSecreta.Size = new Size(251, 72);
            lblPalavraSecreta.TabIndex = 0;
            lblPalavraSecreta.Text = "BANANA";
            // 
            // pbImagemForca
            // 
            pbImagemForca.Image = Properties.Resources._1;
            pbImagemForca.Location = new Point(446, 184);
            pbImagemForca.Margin = new Padding(3, 4, 3, 4);
            pbImagemForca.Name = "pbImagemForca";
            pbImagemForca.Size = new Size(298, 371);
            pbImagemForca.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImagemForca.TabIndex = 1;
            pbImagemForca.TabStop = false;
            // 
            // pnlBotoes
            // 
            pnlBotoes.BackColor = Color.FromArgb(97, 84, 88);
            pnlBotoes.Controls.Add(button26);
            pnlBotoes.Controls.Add(button25);
            pnlBotoes.Controls.Add(button24);
            pnlBotoes.Controls.Add(button23);
            pnlBotoes.Controls.Add(button22);
            pnlBotoes.Controls.Add(button21);
            pnlBotoes.Controls.Add(button20);
            pnlBotoes.Controls.Add(button19);
            pnlBotoes.Controls.Add(button18);
            pnlBotoes.Controls.Add(button17);
            pnlBotoes.Controls.Add(button16);
            pnlBotoes.Controls.Add(button15);
            pnlBotoes.Controls.Add(button14);
            pnlBotoes.Controls.Add(button13);
            pnlBotoes.Controls.Add(button12);
            pnlBotoes.Controls.Add(button11);
            pnlBotoes.Controls.Add(button10);
            pnlBotoes.Controls.Add(button9);
            pnlBotoes.Controls.Add(button8);
            pnlBotoes.Controls.Add(button7);
            pnlBotoes.Controls.Add(button6);
            pnlBotoes.Controls.Add(button5);
            pnlBotoes.Controls.Add(button4);
            pnlBotoes.Controls.Add(button3);
            pnlBotoes.Controls.Add(button2);
            pnlBotoes.Controls.Add(button1);
            pnlBotoes.Location = new Point(30, 188);
            pnlBotoes.Margin = new Padding(3, 4, 3, 4);
            pnlBotoes.Name = "pnlBotoes";
            pnlBotoes.Size = new Size(392, 367);
            pnlBotoes.TabIndex = 2;
            // 
            // button26
            // 
            button26.BackColor = Color.FromArgb(76, 67, 71);
            button26.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button26.ForeColor = Color.White;
            button26.Location = new Point(69, 292);
            button26.Margin = new Padding(3, 4, 3, 4);
            button26.Name = "button26";
            button26.Size = new Size(58, 64);
            button26.TabIndex = 25;
            button26.Text = "Z";
            button26.UseVisualStyleBackColor = false;
            // 
            // button25
            // 
            button25.BackColor = Color.FromArgb(76, 67, 71);
            button25.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button25.ForeColor = Color.White;
            button25.Location = new Point(3, 292);
            button25.Margin = new Padding(3, 4, 3, 4);
            button25.Name = "button25";
            button25.Size = new Size(58, 64);
            button25.TabIndex = 24;
            button25.Text = "Y";
            button25.UseVisualStyleBackColor = false;
            // 
            // button24
            // 
            button24.BackColor = Color.FromArgb(76, 67, 71);
            button24.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button24.ForeColor = Color.White;
            button24.Location = new Point(329, 220);
            button24.Margin = new Padding(3, 4, 3, 4);
            button24.Name = "button24";
            button24.Size = new Size(58, 64);
            button24.TabIndex = 23;
            button24.Text = "X";
            button24.UseVisualStyleBackColor = false;
            // 
            // button23
            // 
            button23.BackColor = Color.FromArgb(76, 67, 71);
            button23.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button23.ForeColor = Color.White;
            button23.Location = new Point(264, 220);
            button23.Margin = new Padding(3, 4, 3, 4);
            button23.Name = "button23";
            button23.Size = new Size(58, 64);
            button23.TabIndex = 22;
            button23.Text = "W";
            button23.UseVisualStyleBackColor = false;
            // 
            // button22
            // 
            button22.BackColor = Color.FromArgb(76, 67, 71);
            button22.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button22.ForeColor = Color.White;
            button22.Location = new Point(199, 220);
            button22.Margin = new Padding(3, 4, 3, 4);
            button22.Name = "button22";
            button22.Size = new Size(58, 64);
            button22.TabIndex = 21;
            button22.Text = "V";
            button22.UseVisualStyleBackColor = false;
            // 
            // button21
            // 
            button21.BackColor = Color.FromArgb(76, 67, 71);
            button21.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button21.ForeColor = Color.White;
            button21.Location = new Point(134, 220);
            button21.Margin = new Padding(3, 4, 3, 4);
            button21.Name = "button21";
            button21.Size = new Size(58, 64);
            button21.TabIndex = 20;
            button21.Text = "U";
            button21.UseVisualStyleBackColor = false;
            // 
            // button20
            // 
            button20.BackColor = Color.FromArgb(76, 67, 71);
            button20.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button20.ForeColor = Color.White;
            button20.Location = new Point(69, 220);
            button20.Margin = new Padding(3, 4, 3, 4);
            button20.Name = "button20";
            button20.Size = new Size(58, 64);
            button20.TabIndex = 19;
            button20.Text = "T";
            button20.UseVisualStyleBackColor = false;
            // 
            // button19
            // 
            button19.BackColor = Color.FromArgb(76, 67, 71);
            button19.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button19.ForeColor = Color.White;
            button19.Location = new Point(3, 220);
            button19.Margin = new Padding(3, 4, 3, 4);
            button19.Name = "button19";
            button19.Size = new Size(58, 64);
            button19.TabIndex = 18;
            button19.Text = "S";
            button19.UseVisualStyleBackColor = false;
            // 
            // button18
            // 
            button18.BackColor = Color.FromArgb(76, 67, 71);
            button18.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button18.ForeColor = Color.White;
            button18.Location = new Point(329, 148);
            button18.Margin = new Padding(3, 4, 3, 4);
            button18.Name = "button18";
            button18.Size = new Size(58, 64);
            button18.TabIndex = 17;
            button18.Text = "R";
            button18.UseVisualStyleBackColor = false;
            // 
            // button17
            // 
            button17.BackColor = Color.FromArgb(76, 67, 71);
            button17.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button17.ForeColor = Color.White;
            button17.Location = new Point(264, 148);
            button17.Margin = new Padding(3, 4, 3, 4);
            button17.Name = "button17";
            button17.Size = new Size(58, 64);
            button17.TabIndex = 16;
            button17.Text = "Q";
            button17.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            button16.BackColor = Color.FromArgb(76, 67, 71);
            button16.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button16.ForeColor = Color.White;
            button16.Location = new Point(199, 148);
            button16.Margin = new Padding(3, 4, 3, 4);
            button16.Name = "button16";
            button16.Size = new Size(58, 64);
            button16.TabIndex = 15;
            button16.Text = "P";
            button16.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            button15.BackColor = Color.FromArgb(76, 67, 71);
            button15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button15.ForeColor = Color.White;
            button15.Location = new Point(134, 148);
            button15.Margin = new Padding(3, 4, 3, 4);
            button15.Name = "button15";
            button15.Size = new Size(58, 64);
            button15.TabIndex = 14;
            button15.Text = "O";
            button15.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            button14.BackColor = Color.FromArgb(76, 67, 71);
            button14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button14.ForeColor = Color.White;
            button14.Location = new Point(69, 148);
            button14.Margin = new Padding(3, 4, 3, 4);
            button14.Name = "button14";
            button14.Size = new Size(58, 64);
            button14.TabIndex = 13;
            button14.Text = "N";
            button14.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            button13.BackColor = Color.FromArgb(76, 67, 71);
            button13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button13.ForeColor = Color.White;
            button13.Location = new Point(3, 148);
            button13.Margin = new Padding(3, 4, 3, 4);
            button13.Name = "button13";
            button13.Size = new Size(58, 64);
            button13.TabIndex = 12;
            button13.Text = "M";
            button13.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            button12.BackColor = Color.FromArgb(76, 67, 71);
            button12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button12.ForeColor = Color.White;
            button12.Location = new Point(329, 76);
            button12.Margin = new Padding(3, 4, 3, 4);
            button12.Name = "button12";
            button12.Size = new Size(58, 64);
            button12.TabIndex = 11;
            button12.Text = "L";
            button12.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            button11.BackColor = Color.FromArgb(76, 67, 71);
            button11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button11.ForeColor = Color.White;
            button11.Location = new Point(264, 76);
            button11.Margin = new Padding(3, 4, 3, 4);
            button11.Name = "button11";
            button11.Size = new Size(58, 64);
            button11.TabIndex = 10;
            button11.Text = "K";
            button11.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            button10.BackColor = Color.FromArgb(76, 67, 71);
            button10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button10.ForeColor = Color.White;
            button10.Location = new Point(199, 76);
            button10.Margin = new Padding(3, 4, 3, 4);
            button10.Name = "button10";
            button10.Size = new Size(58, 64);
            button10.TabIndex = 9;
            button10.Text = "J";
            button10.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(76, 67, 71);
            button9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button9.ForeColor = Color.White;
            button9.Location = new Point(134, 76);
            button9.Margin = new Padding(3, 4, 3, 4);
            button9.Name = "button9";
            button9.Size = new Size(58, 64);
            button9.TabIndex = 8;
            button9.Text = "I";
            button9.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(76, 67, 71);
            button8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button8.ForeColor = Color.White;
            button8.Location = new Point(69, 76);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(58, 64);
            button8.TabIndex = 7;
            button8.Text = "H";
            button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(76, 67, 71);
            button7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = Color.White;
            button7.Location = new Point(3, 76);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(58, 64);
            button7.TabIndex = 6;
            button7.Text = "G";
            button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(76, 67, 71);
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.White;
            button6.Location = new Point(329, 4);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(58, 64);
            button6.TabIndex = 5;
            button6.Text = "F";
            button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(76, 67, 71);
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(264, 4);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(58, 64);
            button5.TabIndex = 4;
            button5.Text = "E";
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(76, 67, 71);
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(199, 4);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(58, 64);
            button4.TabIndex = 3;
            button4.Text = "D";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(76, 67, 71);
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(134, 4);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(58, 64);
            button3.TabIndex = 2;
            button3.Text = "C";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(76, 67, 71);
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(69, 4);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(58, 64);
            button2.TabIndex = 1;
            button2.Text = "B";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(76, 67, 71);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(3, 4);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(58, 64);
            button1.TabIndex = 0;
            button1.Text = "A";
            button1.UseVisualStyleBackColor = false;
            // 
            // lblDica
            // 
            lblDica.AutoSize = true;
            lblDica.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDica.ForeColor = Color.White;
            lblDica.Location = new Point(42, 56);
            lblDica.Name = "lblDica";
            lblDica.Size = new Size(75, 28);
            lblDica.TabIndex = 3;
            lblDica.Text = "6 letras";
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(34, 34, 34);
            btnReset.FlatAppearance.BorderColor = Color.Black;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(446, 96);
            btnReset.Margin = new Padding(3, 4, 3, 4);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(298, 49);
            btnReset.TabIndex = 4;
            btnReset.Text = "Nova Tentativa";
            btnReset.UseVisualStyleBackColor = false;
            // 
            // statusMensagem
            // 
            statusMensagem.ImageScalingSize = new Size(20, 20);
            statusMensagem.Items.AddRange(new ToolStripItem[] { lblMensagemFinal });
            statusMensagem.Location = new Point(0, 632);
            statusMensagem.Name = "statusMensagem";
            statusMensagem.Padding = new Padding(1, 0, 16, 0);
            statusMensagem.Size = new Size(788, 34);
            statusMensagem.TabIndex = 5;
            statusMensagem.Text = "statusStrip1";
            // 
            // lblMensagemFinal
            // 
            lblMensagemFinal.BackColor = Color.White;
            lblMensagemFinal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMensagemFinal.Name = "lblMensagemFinal";
            lblMensagemFinal.Size = new Size(154, 28);
            lblMensagemFinal.Text = "Mensagem Final";
            // 
            // TelaForca
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(110, 92, 98);
            ClientSize = new Size(788, 666);
            Controls.Add(statusMensagem);
            Controls.Add(btnReset);
            Controls.Add(lblDica);
            Controls.Add(pnlBotoes);
            Controls.Add(pbImagemForca);
            Controls.Add(lblPalavraSecreta);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "TelaForca";
            Text = "Jogo Da Forca";
            ((System.ComponentModel.ISupportInitialize)pbImagemForca).EndInit();
            pnlBotoes.ResumeLayout(false);
            statusMensagem.ResumeLayout(false);
            statusMensagem.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPalavraSecreta;
        private PictureBox pbImagemForca;
        private Panel pnlBotoes;
        private Button button26;
        private Button button25;
        private Button button24;
        private Button button23;
        private Button button22;
        private Button button21;
        private Button button20;
        private Button button19;
        private Button button18;
        private Button button17;
        private Button button16;
        private Button button15;
        private Button button14;
        private Button button13;
        private Button button12;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label lblDica;
        private Button btnReset;
        private StatusStrip statusMensagem;
        private ToolStripStatusLabel lblMensagemFinal;
    }
}