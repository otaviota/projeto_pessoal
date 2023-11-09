namespace Funcionario_Projeto
{
    partial class frmContasaReceber
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txttipodeconta = new System.Windows.Forms.ComboBox();
            this.cbostatus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtvalorconta = new System.Windows.Forms.TextBox();
            this.txtqtdeparcelas = new System.Windows.Forms.NumericUpDown();
            this.btopesquisa = new System.Windows.Forms.Button();
            this.txtdata = new System.Windows.Forms.MaskedTextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.txtobs = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btosair = new System.Windows.Forms.Button();
            this.btolimpar = new System.Windows.Forms.Button();
            this.btoexcluir = new System.Windows.Forms.Button();
            this.btoalterar = new System.Windows.Forms.Button();
            this.btocadastrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtqtdeparcelas)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 71);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(602, 395);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txttipodeconta);
            this.tabPage1.Controls.Add(this.cbostatus);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtvalorconta);
            this.tabPage1.Controls.Add(this.txtqtdeparcelas);
            this.tabPage1.Controls.Add(this.btopesquisa);
            this.tabPage1.Controls.Add(this.txtdata);
            this.tabPage1.Controls.Add(this.txtid);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(594, 367);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Contas a receber";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txttipodeconta
            // 
            this.txttipodeconta.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txttipodeconta.FormattingEnabled = true;
            this.txttipodeconta.Items.AddRange(new object[] {
            "Manutençao ",
            "Publicidade",
            "Energia",
            "Agua"});
            this.txttipodeconta.Location = new System.Drawing.Point(302, 219);
            this.txttipodeconta.Name = "txttipodeconta";
            this.txttipodeconta.Size = new System.Drawing.Size(163, 33);
            this.txttipodeconta.TabIndex = 28;
            // 
            // cbostatus
            // 
            this.cbostatus.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbostatus.FormattingEnabled = true;
            this.cbostatus.Items.AddRange(new object[] {
            "ATIVO",
            "INATIVO"});
            this.cbostatus.Location = new System.Drawing.Point(3, 219);
            this.cbostatus.Name = "cbostatus";
            this.cbostatus.Size = new System.Drawing.Size(155, 33);
            this.cbostatus.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(302, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 25);
            this.label5.TabIndex = 26;
            this.label5.Text = "Tipo de conta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(6, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 25);
            this.label7.TabIndex = 26;
            this.label7.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(302, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "Valor de conta";
            // 
            // txtvalorconta
            // 
            this.txtvalorconta.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtvalorconta.Location = new System.Drawing.Point(302, 146);
            this.txtvalorconta.Name = "txtvalorconta";
            this.txtvalorconta.Size = new System.Drawing.Size(163, 32);
            this.txtvalorconta.TabIndex = 25;
            // 
            // txtqtdeparcelas
            // 
            this.txtqtdeparcelas.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtqtdeparcelas.Location = new System.Drawing.Point(6, 147);
            this.txtqtdeparcelas.Name = "txtqtdeparcelas";
            this.txtqtdeparcelas.Size = new System.Drawing.Size(155, 32);
            this.txtqtdeparcelas.TabIndex = 24;
            this.txtqtdeparcelas.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // btopesquisa
            // 
            this.btopesquisa.Location = new System.Drawing.Point(371, 17);
            this.btopesquisa.Name = "btopesquisa";
            this.btopesquisa.Size = new System.Drawing.Size(38, 36);
            this.btopesquisa.TabIndex = 23;
            this.btopesquisa.Text = "...";
            this.btopesquisa.UseVisualStyleBackColor = true;
            this.btopesquisa.Click += new System.EventHandler(this.btopesquisa_Click);
            // 
            // txtdata
            // 
            this.txtdata.Location = new System.Drawing.Point(192, 25);
            this.txtdata.Mask = "##/##/####";
            this.txtdata.Name = "txtdata";
            this.txtdata.ReadOnly = true;
            this.txtdata.Size = new System.Drawing.Size(173, 23);
            this.txtdata.TabIndex = 20;
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtid.Location = new System.Drawing.Point(47, 25);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(60, 32);
            this.txtid.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 28);
            this.label3.TabIndex = 21;
            this.label3.Text = "Quantidade de Parcelas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(134, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 28);
            this.label2.TabIndex = 21;
            this.label2.Text = "Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 28);
            this.label1.TabIndex = 22;
            this.label1.Text = "ID";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtobs);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(594, 367);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Observação";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(6, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 25);
            this.label6.TabIndex = 28;
            this.label6.Text = "Observação";
            // 
            // txtobs
            // 
            this.txtobs.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtobs.Location = new System.Drawing.Point(6, 53);
            this.txtobs.Multiline = true;
            this.txtobs.Name = "txtobs";
            this.txtobs.Size = new System.Drawing.Size(582, 308);
            this.txtobs.TabIndex = 27;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(12, 20);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(215, 37);
            this.label20.TabIndex = 3;
            this.label20.Text = "Contas a receber";
            // 
            // btosair
            // 
            this.btosair.Location = new System.Drawing.Point(521, 10);
            this.btosair.Name = "btosair";
            this.btosair.Size = new System.Drawing.Size(75, 41);
            this.btosair.TabIndex = 4;
            this.btosair.Text = "Sair";
            this.btosair.UseVisualStyleBackColor = true;
            this.btosair.Click += new System.EventHandler(this.btosair_Click);
            // 
            // btolimpar
            // 
            this.btolimpar.Location = new System.Drawing.Point(440, 10);
            this.btolimpar.Name = "btolimpar";
            this.btolimpar.Size = new System.Drawing.Size(75, 41);
            this.btolimpar.TabIndex = 3;
            this.btolimpar.Text = "Limpar";
            this.btolimpar.UseVisualStyleBackColor = true;
            this.btolimpar.Click += new System.EventHandler(this.btolimpar_Click);
            // 
            // btoexcluir
            // 
            this.btoexcluir.Location = new System.Drawing.Point(359, 10);
            this.btoexcluir.Name = "btoexcluir";
            this.btoexcluir.Size = new System.Drawing.Size(75, 41);
            this.btoexcluir.TabIndex = 2;
            this.btoexcluir.Text = "Excluir ";
            this.btoexcluir.UseVisualStyleBackColor = true;
            this.btoexcluir.Click += new System.EventHandler(this.btoexcluir_Click);
            // 
            // btoalterar
            // 
            this.btoalterar.Location = new System.Drawing.Point(278, 10);
            this.btoalterar.Name = "btoalterar";
            this.btoalterar.Size = new System.Drawing.Size(75, 41);
            this.btoalterar.TabIndex = 1;
            this.btoalterar.Text = "Alterar";
            this.btoalterar.UseVisualStyleBackColor = true;
            this.btoalterar.Click += new System.EventHandler(this.btoalterar_Click);
            // 
            // btocadastrar
            // 
            this.btocadastrar.Location = new System.Drawing.Point(197, 10);
            this.btocadastrar.Name = "btocadastrar";
            this.btocadastrar.Size = new System.Drawing.Size(75, 41);
            this.btocadastrar.TabIndex = 0;
            this.btocadastrar.Text = "Cadastrar";
            this.btocadastrar.UseVisualStyleBackColor = true;
            this.btocadastrar.Click += new System.EventHandler(this.btocadastrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btocadastrar);
            this.groupBox1.Controls.Add(this.btoalterar);
            this.groupBox1.Controls.Add(this.btosair);
            this.groupBox1.Controls.Add(this.btolimpar);
            this.groupBox1.Controls.Add(this.btoexcluir);
            this.groupBox1.Location = new System.Drawing.Point(12, 478);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 57);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // frmContasaReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 547);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmContasaReceber";
            this.Text = "frmContasaReceber";
            this.Load += new System.EventHandler(this.frmContasaReceber_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtqtdeparcelas)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button btopesquisa;
        private MaskedTextBox txtdata;
        private TextBox txtid;
        private Label label2;
        private Label label1;
        private TabPage tabPage2;
        private NumericUpDown txtqtdeparcelas;
        private Label label3;
        private Label label4;
        private TextBox txtvalorconta;
        private ComboBox cbostatus;
        private Label label5;
        private Label label7;
        private Label label6;
        private TextBox txtobs;
        private Label label20;
        private Button btosair;
        private Button btolimpar;
        private Button btoexcluir;
        private Button btoalterar;
        private Button btocadastrar;
        private GroupBox groupBox1;
        private ComboBox txttipodeconta;
    }
}