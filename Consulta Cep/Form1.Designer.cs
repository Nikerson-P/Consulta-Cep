namespace Consulta_Cep
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.cep = new System.Windows.Forms.TextBox();
            this.labelLogra = new System.Windows.Forms.Label();
            this.labelComple = new System.Windows.Forms.Label();
            this.labelLocal = new System.Windows.Forms.Label();
            this.labelUF = new System.Windows.Forms.Label();
            this.labelIBGE = new System.Windows.Forms.Label();
            this.labelGIA = new System.Windows.Forms.Label();
            this.labelDDD = new System.Windows.Forms.Label();
            this.labelSIAFI = new System.Windows.Forms.Label();
            this.logra = new System.Windows.Forms.TextBox();
            this.ibge = new System.Windows.Forms.TextBox();
            this.local = new System.Windows.Forms.TextBox();
            this.ddd = new System.Windows.Forms.TextBox();
            this.comple = new System.Windows.Forms.TextBox();
            this.gia = new System.Windows.Forms.TextBox();
            this.uf = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.siafi = new System.Windows.Forms.TextBox();
            this.labelBairro = new System.Windows.Forms.Label();
            this.bairro = new System.Windows.Forms.TextBox();
            this.consultar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite o seu cep:";
            // 
            // cep
            // 
            this.cep.Location = new System.Drawing.Point(105, 42);
            this.cep.MaxLength = 9;
            this.cep.Name = "cep";
            this.cep.Size = new System.Drawing.Size(100, 20);
            this.cep.TabIndex = 2;
            this.cep.Text = "000000000";
            this.cep.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelLogra
            // 
            this.labelLogra.AutoSize = true;
            this.labelLogra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogra.Location = new System.Drawing.Point(3, 0);
            this.labelLogra.Name = "labelLogra";
            this.labelLogra.Size = new System.Drawing.Size(91, 20);
            this.labelLogra.TabIndex = 3;
            this.labelLogra.Text = "Logradouro";
            // 
            // labelComple
            // 
            this.labelComple.AutoSize = true;
            this.labelComple.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComple.Location = new System.Drawing.Point(3, 39);
            this.labelComple.Name = "labelComple";
            this.labelComple.Size = new System.Drawing.Size(108, 20);
            this.labelComple.TabIndex = 4;
            this.labelComple.Text = "Complemento";
            // 
            // labelLocal
            // 
            this.labelLocal.AutoSize = true;
            this.labelLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocal.Location = new System.Drawing.Point(3, 78);
            this.labelLocal.Name = "labelLocal";
            this.labelLocal.Size = new System.Drawing.Size(86, 20);
            this.labelLocal.TabIndex = 5;
            this.labelLocal.Text = "Localidade";
            // 
            // labelUF
            // 
            this.labelUF.AutoSize = true;
            this.labelUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUF.Location = new System.Drawing.Point(3, 117);
            this.labelUF.Name = "labelUF";
            this.labelUF.Size = new System.Drawing.Size(31, 20);
            this.labelUF.TabIndex = 6;
            this.labelUF.Text = "UF";
            // 
            // labelIBGE
            // 
            this.labelIBGE.AutoSize = true;
            this.labelIBGE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIBGE.Location = new System.Drawing.Point(3, 156);
            this.labelIBGE.Name = "labelIBGE";
            this.labelIBGE.Size = new System.Drawing.Size(49, 20);
            this.labelIBGE.TabIndex = 7;
            this.labelIBGE.Text = "IBGE";
            // 
            // labelGIA
            // 
            this.labelGIA.AutoSize = true;
            this.labelGIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGIA.Location = new System.Drawing.Point(3, 195);
            this.labelGIA.Name = "labelGIA";
            this.labelGIA.Size = new System.Drawing.Size(34, 20);
            this.labelGIA.TabIndex = 8;
            this.labelGIA.Text = "Gia";
            // 
            // labelDDD
            // 
            this.labelDDD.AutoSize = true;
            this.labelDDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDDD.Location = new System.Drawing.Point(3, 234);
            this.labelDDD.Name = "labelDDD";
            this.labelDDD.Size = new System.Drawing.Size(45, 20);
            this.labelDDD.TabIndex = 9;
            this.labelDDD.Text = "DDD";
            // 
            // labelSIAFI
            // 
            this.labelSIAFI.AutoSize = true;
            this.labelSIAFI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSIAFI.Location = new System.Drawing.Point(3, 273);
            this.labelSIAFI.Name = "labelSIAFI";
            this.labelSIAFI.Size = new System.Drawing.Size(40, 20);
            this.labelSIAFI.TabIndex = 10;
            this.labelSIAFI.Text = "Siafi";
            // 
            // logra
            // 
            this.logra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logra.Location = new System.Drawing.Point(127, 3);
            this.logra.Name = "logra";
            this.logra.Size = new System.Drawing.Size(207, 20);
            this.logra.TabIndex = 11;
            // 
            // ibge
            // 
            this.ibge.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ibge.Location = new System.Drawing.Point(127, 159);
            this.ibge.Name = "ibge";
            this.ibge.Size = new System.Drawing.Size(207, 20);
            this.ibge.TabIndex = 12;
            // 
            // local
            // 
            this.local.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.local.Location = new System.Drawing.Point(127, 81);
            this.local.Name = "local";
            this.local.Size = new System.Drawing.Size(207, 20);
            this.local.TabIndex = 13;
            // 
            // ddd
            // 
            this.ddd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ddd.Location = new System.Drawing.Point(127, 237);
            this.ddd.Name = "ddd";
            this.ddd.Size = new System.Drawing.Size(207, 20);
            this.ddd.TabIndex = 14;
            // 
            // comple
            // 
            this.comple.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comple.Location = new System.Drawing.Point(127, 42);
            this.comple.Name = "comple";
            this.comple.Size = new System.Drawing.Size(207, 20);
            this.comple.TabIndex = 15;
            // 
            // gia
            // 
            this.gia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gia.Location = new System.Drawing.Point(127, 198);
            this.gia.Name = "gia";
            this.gia.Size = new System.Drawing.Size(207, 20);
            this.gia.TabIndex = 16;
            // 
            // uf
            // 
            this.uf.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uf.Location = new System.Drawing.Point(127, 120);
            this.uf.Name = "uf";
            this.uf.Size = new System.Drawing.Size(207, 20);
            this.uf.TabIndex = 17;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.09199F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.90801F));
            this.tableLayoutPanel2.Controls.Add(this.ddd, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.gia, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.ibge, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.uf, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.local, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.comple, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.logra, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelComple, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelSIAFI, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.labelLocal, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.labelDDD, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.labelUF, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.labelGIA, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.labelIBGE, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.siafi, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.labelLogra, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelBairro, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.bairro, 1, 8);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(15, 80);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 9;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(337, 337);
            this.tableLayoutPanel2.TabIndex = 19;
            // 
            // siafi
            // 
            this.siafi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.siafi.Location = new System.Drawing.Point(127, 276);
            this.siafi.Name = "siafi";
            this.siafi.Size = new System.Drawing.Size(207, 20);
            this.siafi.TabIndex = 18;
            // 
            // labelBairro
            // 
            this.labelBairro.AutoSize = true;
            this.labelBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBairro.Location = new System.Drawing.Point(3, 312);
            this.labelBairro.Name = "labelBairro";
            this.labelBairro.Size = new System.Drawing.Size(51, 20);
            this.labelBairro.TabIndex = 19;
            this.labelBairro.Text = "Bairro";
            // 
            // bairro
            // 
            this.bairro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bairro.Location = new System.Drawing.Point(127, 315);
            this.bairro.Name = "bairro";
            this.bairro.Size = new System.Drawing.Size(207, 20);
            this.bairro.TabIndex = 20;
            // 
            // consultar
            // 
            this.consultar.Location = new System.Drawing.Point(211, 40);
            this.consultar.Name = "consultar";
            this.consultar.Size = new System.Drawing.Size(75, 23);
            this.consultar.TabIndex = 20;
            this.consultar.Text = "Consultar";
            this.consultar.UseVisualStyleBackColor = true;
            this.consultar.Click += new System.EventHandler(this.consultar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "Consulta de Cep";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(364, 442);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.consultar);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.cep);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Name = "Form1";
            this.Text = "Consulta de Cep";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cep;
        private System.Windows.Forms.Label labelLogra;
        private System.Windows.Forms.Label labelComple;
        private System.Windows.Forms.Label labelLocal;
        private System.Windows.Forms.Label labelUF;
        private System.Windows.Forms.Label labelIBGE;
        private System.Windows.Forms.Label labelGIA;
        private System.Windows.Forms.Label labelDDD;
        private System.Windows.Forms.Label labelSIAFI;
        private System.Windows.Forms.TextBox logra;
        private System.Windows.Forms.TextBox ibge;
        private System.Windows.Forms.TextBox local;
        private System.Windows.Forms.TextBox ddd;
        private System.Windows.Forms.TextBox comple;
        private System.Windows.Forms.TextBox gia;
        private System.Windows.Forms.TextBox uf;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox siafi;
        private System.Windows.Forms.Button consultar;
        private System.Windows.Forms.Label labelBairro;
        private System.Windows.Forms.TextBox bairro;
        private System.Windows.Forms.Label label1;
    }
}

