namespace Funcionario_Projeto
{
    partial class frmProduto
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label20 = new System.Windows.Forms.Label();
            this.btopesquisa = new System.Windows.Forms.Button();
            this.txtdata = new System.Windows.Forms.MaskedTextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbonomevendedor = new System.Windows.Forms.ComboBox();
            this.cboidvendedor = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboqtdedevenda = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtvalordevenda = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbostatus = new System.Windows.Forms.ComboBox();
            this.txtobservacao = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btocadastrar = new System.Windows.Forms.Button();
            this.btoalterar = new System.Windows.Forms.Button();
            this.btosair = new System.Windows.Forms.Button();
            this.btolimpar = new System.Windows.Forms.Button();
            this.btoexcluir = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboqtdedevenda)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 77);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(742, 352);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cboqtdedevenda);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtvalordevenda);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtnome);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.cbonomevendedor);
            this.tabPage1.Controls.Add(this.cbostatus);
            this.tabPage1.Controls.Add(this.cboidvendedor);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.btopesquisa);
            this.tabPage1.Controls.Add(this.txtdata);
            this.tabPage1.Controls.Add(this.txtid);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(734, 324);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Produto";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtobservacao);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(811, 324);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Observações";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(16, 18);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(302, 37);
            this.label20.TabIndex = 4;
            this.label20.Text = "Informações de Produto";
            // 
            // btopesquisa
            // 
            this.btopesquisa.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btopesquisa.Location = new System.Drawing.Point(88, 34);
            this.btopesquisa.Name = "btopesquisa";
            this.btopesquisa.Size = new System.Drawing.Size(38, 36);
            this.btopesquisa.TabIndex = 61;
            this.btopesquisa.Text = "...";
            this.btopesquisa.UseVisualStyleBackColor = true;
            // 
            // txtdata
            // 
            this.txtdata.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtdata.Location = new System.Drawing.Point(238, 37);
            this.txtdata.Mask = "##/##/####";
            this.txtdata.Name = "txtdata";
            this.txtdata.ReadOnly = true;
            this.txtdata.Size = new System.Drawing.Size(121, 32);
            this.txtdata.TabIndex = 59;
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtid.Location = new System.Drawing.Point(6, 37);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(60, 32);
            this.txtid.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(238, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 28);
            this.label2.TabIndex = 58;
            this.label2.Text = "Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 28);
            this.label1.TabIndex = 60;
            this.label1.Text = "ID";
            // 
            // cbonomevendedor
            // 
            this.cbonomevendedor.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbonomevendedor.FormattingEnabled = true;
            this.cbonomevendedor.Location = new System.Drawing.Point(542, 34);
            this.cbonomevendedor.Name = "cbonomevendedor";
            this.cbonomevendedor.Size = new System.Drawing.Size(170, 33);
            this.cbonomevendedor.TabIndex = 64;
            // 
            // cboidvendedor
            // 
            this.cboidvendedor.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboidvendedor.FormattingEnabled = true;
            this.cboidvendedor.Location = new System.Drawing.Point(401, 34);
            this.cboidvendedor.Name = "cboidvendedor";
            this.cboidvendedor.Size = new System.Drawing.Size(77, 33);
            this.cboidvendedor.TabIndex = 65;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(542, 2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 28);
            this.label10.TabIndex = 62;
            this.label10.Text = "Nome vendedor";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(401, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 28);
            this.label9.TabIndex = 63;
            this.label9.Text = "ID vendedor";
            // 
            // txtnome
            // 
            this.txtnome.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtnome.Location = new System.Drawing.Point(6, 113);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(353, 32);
            this.txtnome.TabIndex = 67;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(7, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 28);
            this.label3.TabIndex = 66;
            this.label3.Text = "Nome";
            // 
            // cboqtdedevenda
            // 
            this.cboqtdedevenda.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboqtdedevenda.Location = new System.Drawing.Point(160, 183);
            this.cboqtdedevenda.Name = "cboqtdedevenda";
            this.cboqtdedevenda.Size = new System.Drawing.Size(199, 32);
            this.cboqtdedevenda.TabIndex = 69;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(159, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 28);
            this.label5.TabIndex = 68;
            this.label5.Text = "Quantidade de venda";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(-4, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 28);
            this.label4.TabIndex = 66;
            this.label4.Text = "Valor do produto";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtvalordevenda
            // 
            this.txtvalordevenda.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtvalordevenda.Location = new System.Drawing.Point(6, 183);
            this.txtvalordevenda.Name = "txtvalordevenda";
            this.txtvalordevenda.Size = new System.Drawing.Size(142, 32);
            this.txtvalordevenda.TabIndex = 67;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(6, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 28);
            this.label6.TabIndex = 63;
            this.label6.Text = "Status";
            // 
            // cbostatus
            // 
            this.cbostatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbostatus.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbostatus.FormattingEnabled = true;
            this.cbostatus.Location = new System.Drawing.Point(6, 260);
            this.cbostatus.Name = "cbostatus";
            this.cbostatus.Size = new System.Drawing.Size(142, 33);
            this.cbostatus.TabIndex = 65;
            // 
            // txtobservacao
            // 
            this.txtobservacao.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtobservacao.Location = new System.Drawing.Point(17, 41);
            this.txtobservacao.Multiline = true;
            this.txtobservacao.Name = "txtobservacao";
            this.txtobservacao.Size = new System.Drawing.Size(775, 277);
            this.txtobservacao.TabIndex = 69;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(17, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 28);
            this.label7.TabIndex = 68;
            this.label7.Text = "Nome";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btocadastrar);
            this.groupBox1.Controls.Add(this.btoalterar);
            this.groupBox1.Controls.Add(this.btosair);
            this.groupBox1.Controls.Add(this.btolimpar);
            this.groupBox1.Controls.Add(this.btoexcluir);
            this.groupBox1.Location = new System.Drawing.Point(34, 436);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(720, 63);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btocadastrar
            // 
            this.btocadastrar.Location = new System.Drawing.Point(295, 16);
            this.btocadastrar.Name = "btocadastrar";
            this.btocadastrar.Size = new System.Drawing.Size(75, 41);
            this.btocadastrar.TabIndex = 0;
            this.btocadastrar.Text = "Cadastrar";
            this.btocadastrar.UseVisualStyleBackColor = true;
            this.btocadastrar.Click += new System.EventHandler(this.btocadastrar_Click);
            // 
            // btoalterar
            // 
            this.btoalterar.Location = new System.Drawing.Point(376, 16);
            this.btoalterar.Name = "btoalterar";
            this.btoalterar.Size = new System.Drawing.Size(75, 41);
            this.btoalterar.TabIndex = 1;
            this.btoalterar.Text = "Alterar";
            this.btoalterar.UseVisualStyleBackColor = true;
            // 
            // btosair
            // 
            this.btosair.Location = new System.Drawing.Point(619, 16);
            this.btosair.Name = "btosair";
            this.btosair.Size = new System.Drawing.Size(75, 41);
            this.btosair.TabIndex = 4;
            this.btosair.Text = "Sair";
            this.btosair.UseVisualStyleBackColor = true;
            this.btosair.Click += new System.EventHandler(this.btosair_Click);
            // 
            // btolimpar
            // 
            this.btolimpar.Location = new System.Drawing.Point(538, 16);
            this.btolimpar.Name = "btolimpar";
            this.btolimpar.Size = new System.Drawing.Size(75, 41);
            this.btolimpar.TabIndex = 3;
            this.btolimpar.Text = "Limpar";
            this.btolimpar.UseVisualStyleBackColor = true;
            this.btolimpar.Click += new System.EventHandler(this.btolimpar_Click);
            // 
            // btoexcluir
            // 
            this.btoexcluir.Location = new System.Drawing.Point(457, 16);
            this.btoexcluir.Name = "btoexcluir";
            this.btoexcluir.Size = new System.Drawing.Size(75, 41);
            this.btoexcluir.TabIndex = 2;
            this.btoexcluir.Text = "Excluir ";
            this.btoexcluir.UseVisualStyleBackColor = true;
            // 
            // frmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 511);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmProduto";
            this.Text = "frmProduto";
            this.Load += new System.EventHandler(this.frmProduto_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboqtdedevenda)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label20;
        private Button btopesquisa;
        private MaskedTextBox txtdata;
        private TextBox txtid;
        private Label label2;
        private Label label1;
        private ComboBox cbonomevendedor;
        private ComboBox cboidvendedor;
        private Label label10;
        private Label label9;
        private TextBox txtnome;
        private Label label3;
        private NumericUpDown cboqtdedevenda;
        private Label label5;
        private TextBox txtvalordevenda;
        private Label label4;
        private ComboBox cbostatus;
        private Label label6;
        private TextBox txtobservacao;
        private Label label7;
        private GroupBox groupBox1;
        private Button btocadastrar;
        private Button btoalterar;
        private Button btosair;
        private Button btolimpar;
        private Button btoexcluir;
    }
}