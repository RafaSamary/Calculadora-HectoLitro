namespace CalculadorHecto
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_embalagem = new System.Windows.Forms.ComboBox();
            this.lbl_embalagem = new System.Windows.Forms.Label();
            this.lbl_quant = new System.Windows.Forms.Label();
            this.cb_quant = new System.Windows.Forms.ComboBox();
            this.txt_meta = new System.Windows.Forms.TextBox();
            this.lbl_meta = new System.Windows.Forms.Label();
            this.lbl_real = new System.Windows.Forms.Label();
            this.txt_real = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.lbl_70 = new System.Windows.Forms.Label();
            this.txt_70 = new System.Windows.Forms.TextBox();
            this.lbl_70cx = new System.Windows.Forms.Label();
            this.txt_70cx = new System.Windows.Forms.TextBox();
            this.lbl_100cx = new System.Windows.Forms.Label();
            this.txt_100cx = new System.Windows.Forms.TextBox();
            this.lbl_100 = new System.Windows.Forms.Label();
            this.txt_100 = new System.Windows.Forms.TextBox();
            this.btb_limpar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_fator = new System.Windows.Forms.Label();
            this.txt_fator = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(74, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(31, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Calculadora Hecto Litro";
            // 
            // cb_embalagem
            // 
            this.cb_embalagem.FormattingEnabled = true;
            this.cb_embalagem.Items.AddRange(new object[] {
            "0,300",
            "0,355",
            "0,475",
            "0,600",
            "1,000"});
            this.cb_embalagem.Location = new System.Drawing.Point(18, 53);
            this.cb_embalagem.Name = "cb_embalagem";
            this.cb_embalagem.Size = new System.Drawing.Size(117, 24);
            this.cb_embalagem.TabIndex = 2;
            // 
            // lbl_embalagem
            // 
            this.lbl_embalagem.AutoSize = true;
            this.lbl_embalagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_embalagem.Location = new System.Drawing.Point(41, 37);
            this.lbl_embalagem.Name = "lbl_embalagem";
            this.lbl_embalagem.Size = new System.Drawing.Size(71, 13);
            this.lbl_embalagem.TabIndex = 3;
            this.lbl_embalagem.Text = "Embalagem";
            // 
            // lbl_quant
            // 
            this.lbl_quant.AutoSize = true;
            this.lbl_quant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quant.Location = new System.Drawing.Point(182, 37);
            this.lbl_quant.Name = "lbl_quant";
            this.lbl_quant.Size = new System.Drawing.Size(72, 13);
            this.lbl_quant.TabIndex = 5;
            this.lbl_quant.Text = "Quantidade";
            // 
            // cb_quant
            // 
            this.cb_quant.FormattingEnabled = true;
            this.cb_quant.Items.AddRange(new object[] {
            "6",
            "12",
            "24"});
            this.cb_quant.Location = new System.Drawing.Point(159, 53);
            this.cb_quant.Name = "cb_quant";
            this.cb_quant.Size = new System.Drawing.Size(117, 24);
            this.cb_quant.TabIndex = 4;
            // 
            // txt_meta
            // 
            this.txt_meta.Location = new System.Drawing.Point(18, 110);
            this.txt_meta.Name = "txt_meta";
            this.txt_meta.Size = new System.Drawing.Size(117, 23);
            this.txt_meta.TabIndex = 6;
            this.txt_meta.TextChanged += new System.EventHandler(this.txt_meta_TextChanged);
            // 
            // lbl_meta
            // 
            this.lbl_meta.AutoSize = true;
            this.lbl_meta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_meta.Location = new System.Drawing.Point(59, 94);
            this.lbl_meta.Name = "lbl_meta";
            this.lbl_meta.Size = new System.Drawing.Size(35, 13);
            this.lbl_meta.TabIndex = 7;
            this.lbl_meta.Text = "Meta";
            // 
            // lbl_real
            // 
            this.lbl_real.AutoSize = true;
            this.lbl_real.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_real.Location = new System.Drawing.Point(200, 94);
            this.lbl_real.Name = "lbl_real";
            this.lbl_real.Size = new System.Drawing.Size(33, 13);
            this.lbl_real.TabIndex = 9;
            this.lbl_real.Text = "Real";
            // 
            // txt_real
            // 
            this.txt_real.Location = new System.Drawing.Point(158, 110);
            this.txt_real.Name = "txt_real";
            this.txt_real.Size = new System.Drawing.Size(117, 23);
            this.txt_real.TabIndex = 8;
            this.txt_real.TextChanged += new System.EventHandler(this.txt_real_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_real);
            this.groupBox1.Controls.Add(this.txt_real);
            this.groupBox1.Controls.Add(this.lbl_meta);
            this.groupBox1.Controls.Add(this.txt_meta);
            this.groupBox1.Controls.Add(this.lbl_quant);
            this.groupBox1.Controls.Add(this.cb_quant);
            this.groupBox1.Controls.Add(this.lbl_embalagem);
            this.groupBox1.Controls.Add(this.cb_embalagem);
            this.groupBox1.Font = new System.Drawing.Font("News701 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(19, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 148);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione e Digite";
            // 
            // btn_calcular
            // 
            this.btn_calcular.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcular.ForeColor = System.Drawing.Color.Red;
            this.btn_calcular.Location = new System.Drawing.Point(105, 267);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(115, 38);
            this.btn_calcular.TabIndex = 11;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // lbl_70
            // 
            this.lbl_70.AutoSize = true;
            this.lbl_70.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_70.Location = new System.Drawing.Point(33, 23);
            this.lbl_70.Name = "lbl_70";
            this.lbl_70.Size = new System.Drawing.Size(80, 13);
            this.lbl_70.TabIndex = 11;
            this.lbl_70.Text = "70% da Meta";
            // 
            // txt_70
            // 
            this.txt_70.Location = new System.Drawing.Point(11, 39);
            this.txt_70.Name = "txt_70";
            this.txt_70.Size = new System.Drawing.Size(117, 23);
            this.txt_70.TabIndex = 10;
            this.txt_70.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_70cx
            // 
            this.lbl_70cx.AutoSize = true;
            this.lbl_70cx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_70cx.Location = new System.Drawing.Point(191, 23);
            this.lbl_70cx.Name = "lbl_70cx";
            this.lbl_70cx.Size = new System.Drawing.Size(42, 13);
            this.lbl_70cx.TabIndex = 13;
            this.lbl_70cx.Text = "Em Cx";
            // 
            // txt_70cx
            // 
            this.txt_70cx.Location = new System.Drawing.Point(150, 39);
            this.txt_70cx.Name = "txt_70cx";
            this.txt_70cx.Size = new System.Drawing.Size(117, 23);
            this.txt_70cx.TabIndex = 12;
            this.txt_70cx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_100cx
            // 
            this.lbl_100cx.AutoSize = true;
            this.lbl_100cx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_100cx.Location = new System.Drawing.Point(191, 73);
            this.lbl_100cx.Name = "lbl_100cx";
            this.lbl_100cx.Size = new System.Drawing.Size(42, 13);
            this.lbl_100cx.TabIndex = 17;
            this.lbl_100cx.Text = "Em Cx";
            // 
            // txt_100cx
            // 
            this.txt_100cx.Location = new System.Drawing.Point(150, 89);
            this.txt_100cx.Name = "txt_100cx";
            this.txt_100cx.Size = new System.Drawing.Size(117, 23);
            this.txt_100cx.TabIndex = 16;
            this.txt_100cx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_100
            // 
            this.lbl_100.AutoSize = true;
            this.lbl_100.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_100.Location = new System.Drawing.Point(26, 73);
            this.lbl_100.Name = "lbl_100";
            this.lbl_100.Size = new System.Drawing.Size(87, 13);
            this.lbl_100.TabIndex = 15;
            this.lbl_100.Text = "100% da Meta";
            // 
            // txt_100
            // 
            this.txt_100.Location = new System.Drawing.Point(11, 89);
            this.txt_100.Name = "txt_100";
            this.txt_100.Size = new System.Drawing.Size(117, 23);
            this.txt_100.TabIndex = 14;
            this.txt_100.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btb_limpar
            // 
            this.btb_limpar.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btb_limpar.ForeColor = System.Drawing.Color.Red;
            this.btb_limpar.Location = new System.Drawing.Point(105, 491);
            this.btb_limpar.Name = "btb_limpar";
            this.btb_limpar.Size = new System.Drawing.Size(115, 38);
            this.btb_limpar.TabIndex = 18;
            this.btb_limpar.Text = "Limpar";
            this.btb_limpar.UseVisualStyleBackColor = true;
            this.btb_limpar.Click += new System.EventHandler(this.btb_limpar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_fator);
            this.groupBox2.Controls.Add(this.txt_fator);
            this.groupBox2.Controls.Add(this.lbl_100cx);
            this.groupBox2.Controls.Add(this.txt_100cx);
            this.groupBox2.Controls.Add(this.lbl_100);
            this.groupBox2.Controls.Add(this.txt_100);
            this.groupBox2.Controls.Add(this.lbl_70cx);
            this.groupBox2.Controls.Add(this.txt_70cx);
            this.groupBox2.Controls.Add(this.lbl_70);
            this.groupBox2.Controls.Add(this.txt_70);
            this.groupBox2.Font = new System.Drawing.Font("News701 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(21, 311);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 158);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultado";
            // 
            // lbl_fator
            // 
            this.lbl_fator.AutoSize = true;
            this.lbl_fator.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fator.Location = new System.Drawing.Point(122, 113);
            this.lbl_fator.Name = "lbl_fator";
            this.lbl_fator.Size = new System.Drawing.Size(36, 13);
            this.lbl_fator.TabIndex = 19;
            this.lbl_fator.Text = "Fator";
            // 
            // txt_fator
            // 
            this.txt_fator.Location = new System.Drawing.Point(101, 129);
            this.txt_fator.Name = "txt_fator";
            this.txt_fator.Size = new System.Drawing.Size(78, 23);
            this.txt_fator.TabIndex = 18;
            this.txt_fator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 541);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btb_limpar);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Calculadora Hecto Litro";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_embalagem;
        private System.Windows.Forms.Label lbl_embalagem;
        private System.Windows.Forms.Label lbl_quant;
        private System.Windows.Forms.ComboBox cb_quant;
        private System.Windows.Forms.TextBox txt_meta;
        private System.Windows.Forms.Label lbl_meta;
        private System.Windows.Forms.Label lbl_real;
        private System.Windows.Forms.TextBox txt_real;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Label lbl_70;
        private System.Windows.Forms.TextBox txt_70;
        private System.Windows.Forms.Label lbl_70cx;
        private System.Windows.Forms.TextBox txt_70cx;
        private System.Windows.Forms.Label lbl_100cx;
        private System.Windows.Forms.TextBox txt_100cx;
        private System.Windows.Forms.Label lbl_100;
        private System.Windows.Forms.TextBox txt_100;
        private System.Windows.Forms.Button btb_limpar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_fator;
        private System.Windows.Forms.TextBox txt_fator;
    }
}

