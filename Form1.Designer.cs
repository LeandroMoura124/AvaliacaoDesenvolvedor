namespace AvaliacaoDesenvolvedor
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
            textBox1 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            listaNumeros = new ListBox();
            button3 = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            ListImg64 = new DataGridView();
            CarregarJson = new Button();
            button6 = new Button();
            tabPage3 = new TabPage();
            button4 = new Button();
            label2 = new Label();
            button5 = new Button();
            listEnd = new ListBox();
            txtCEP = new TextBox();
            tabPage4 = new TabPage();
            ConsultaBanco = new Button();
            dataGridView1 = new DataGridView();
            tabPage5 = new TabPage();
            LeIMG = new ListBox();
            btnDownload = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ListImg64).BeginInit();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage5.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.WindowFrame;
            textBox1.ForeColor = SystemColors.MenuHighlight;
            textBox1.Location = new Point(189, 69);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(208, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.WindowFrame;
            button1.ForeColor = Color.OrangeRed;
            button1.Location = new Point(189, 282);
            button1.Name = "button1";
            button1.Size = new Size(105, 37);
            button1.TabIndex = 1;
            button1.Text = "Ordenar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 12.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(184, 42);
            label1.Name = "label1";
            label1.Size = new Size(213, 24);
            label1.TabIndex = 2;
            label1.Text = "Digite um número e salve";
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.WindowFrame;
            button2.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.OrangeRed;
            button2.Location = new Point(420, 64);
            button2.Name = "button2";
            button2.Size = new Size(74, 33);
            button2.TabIndex = 3;
            button2.Text = "Salvar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // listaNumeros
            // 
            listaNumeros.BackColor = SystemColors.WindowFrame;
            listaNumeros.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            listaNumeros.ForeColor = SystemColors.MenuHighlight;
            listaNumeros.FormattingEnabled = true;
            listaNumeros.ItemHeight = 25;
            listaNumeros.Location = new Point(189, 98);
            listaNumeros.Name = "listaNumeros";
            listaNumeros.Size = new Size(305, 179);
            listaNumeros.TabIndex = 4;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.WindowFrame;
            button3.ForeColor = Color.OrangeRed;
            button3.Location = new Point(389, 282);
            button3.Name = "button3";
            button3.Size = new Size(105, 37);
            button3.TabIndex = 5;
            button3.Text = "Abrir arquivo";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Location = new Point(23, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(697, 426);
            tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(listaNumeros);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(689, 398);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Ordenar Números";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(ListImg64);
            tabPage2.Controls.Add(CarregarJson);
            tabPage2.Controls.Add(button6);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(689, 398);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Lista";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // ListImg64
            // 
            ListImg64.BackgroundColor = SystemColors.WindowFrame;
            ListImg64.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ListImg64.Location = new Point(6, 6);
            ListImg64.Name = "ListImg64";
            ListImg64.RowTemplate.Height = 25;
            ListImg64.Size = new Size(677, 205);
            ListImg64.TabIndex = 2;
            // 
            // CarregarJson
            // 
            CarregarJson.BackColor = SystemColors.WindowFrame;
            CarregarJson.ForeColor = Color.OrangeRed;
            CarregarJson.Location = new Point(422, 248);
            CarregarJson.Name = "CarregarJson";
            CarregarJson.Size = new Size(109, 60);
            CarregarJson.TabIndex = 1;
            CarregarJson.Text = "Carregar Grid";
            CarregarJson.UseVisualStyleBackColor = false;
            CarregarJson.Click += CarregarJson_Click_1;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.WindowFrame;
            button6.ForeColor = Color.OrangeRed;
            button6.Location = new Point(152, 248);
            button6.Name = "button6";
            button6.Size = new Size(112, 60);
            button6.TabIndex = 0;
            button6.Text = "Criar arquivo";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(button4);
            tabPage3.Controls.Add(label2);
            tabPage3.Controls.Add(button5);
            tabPage3.Controls.Add(listEnd);
            tabPage3.Controls.Add(txtCEP);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(689, 398);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Consultar Cep";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.WindowFrame;
            button4.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.OrangeRed;
            button4.Location = new Point(410, 72);
            button4.Name = "button4";
            button4.Size = new Size(96, 34);
            button4.TabIndex = 5;
            button4.Text = "Consultar";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 12.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.OrangeRed;
            label2.Location = new Point(194, 53);
            label2.Name = "label2";
            label2.Size = new Size(127, 24);
            label2.TabIndex = 4;
            label2.Text = "Digite seu CEP";
            // 
            // button5
            // 
            button5.BackColor = SystemColors.WindowFrame;
            button5.ForeColor = Color.OrangeRed;
            button5.Location = new Point(194, 290);
            button5.Name = "button5";
            button5.Size = new Size(99, 40);
            button5.TabIndex = 3;
            button5.Text = "Limpar";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // listEnd
            // 
            listEnd.BackColor = SystemColors.WindowFrame;
            listEnd.Font = new Font("Sitka Small", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            listEnd.ForeColor = SystemColors.Highlight;
            listEnd.FormattingEnabled = true;
            listEnd.ItemHeight = 19;
            listEnd.Location = new Point(194, 109);
            listEnd.Name = "listEnd";
            listEnd.Size = new Size(305, 175);
            listEnd.TabIndex = 2;
            // 
            // txtCEP
            // 
            txtCEP.BackColor = SystemColors.WindowFrame;
            txtCEP.ForeColor = SystemColors.MenuHighlight;
            txtCEP.Location = new Point(194, 80);
            txtCEP.Name = "txtCEP";
            txtCEP.Size = new Size(208, 23);
            txtCEP.TabIndex = 1;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(ConsultaBanco);
            tabPage4.Controls.Add(dataGridView1);
            tabPage4.ForeColor = Color.Firebrick;
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(689, 398);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Bancos";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // ConsultaBanco
            // 
            ConsultaBanco.BackColor = SystemColors.WindowFrame;
            ConsultaBanco.ForeColor = Color.OrangeRed;
            ConsultaBanco.Location = new Point(272, 315);
            ConsultaBanco.Name = "ConsultaBanco";
            ConsultaBanco.Size = new Size(134, 39);
            ConsultaBanco.TabIndex = 1;
            ConsultaBanco.Text = "Consultar Bancos ";
            ConsultaBanco.UseVisualStyleBackColor = false;
            ConsultaBanco.Click += ConsultaBanco_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.WindowFrame;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.Highlight;
            dataGridView1.Location = new Point(115, 75);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(459, 216);
            dataGridView1.TabIndex = 0;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(LeIMG);
            tabPage5.Controls.Add(btnDownload);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(689, 398);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Imagem";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // LeIMG
            // 
            LeIMG.BackColor = SystemColors.WindowFrame;
            LeIMG.ForeColor = SystemColors.MenuHighlight;
            LeIMG.FormattingEnabled = true;
            LeIMG.ItemHeight = 15;
            LeIMG.Location = new Point(9, 3);
            LeIMG.Name = "LeIMG";
            LeIMG.Size = new Size(680, 199);
            LeIMG.TabIndex = 1;
            // 
            // btnDownload
            // 
            btnDownload.BackColor = SystemColors.WindowFrame;
            btnDownload.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDownload.ForeColor = Color.OrangeRed;
            btnDownload.Location = new Point(243, 249);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(195, 61);
            btnDownload.TabIndex = 0;
            btnDownload.Text = "Baixar e lê imagem Redes Services";
            btnDownload.UseVisualStyleBackColor = false;
            btnDownload.Click += btnDownload_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(732, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Avaliação Desenvolvedor .NET";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ListImg64).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Label label1;
        private Button button2;
        private ListBox listaNumeros;
        private Button button3;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private ListBox listEnd;
        private TextBox txtCEP;
        private Button button5;
        private TabPage tabPage4;
        private DataGridView dataGridView1;
        private Button ConsultaBanco;
        private Button button4;
        private Label label2;
        private TabPage tabPage5;
        private ListBox LeIMG;
        private Button btnDownload;
        private DataGridView ListImg64;
        private Button CarregarJson;
        private Button button6;
    }
}