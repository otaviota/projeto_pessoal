namespace Funcionario_Projeto
{
    partial class frmContrato
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
            this.cbototaldeparcelas = new System.Windows.Forms.NumericUpDown();
            this.cbostatus = new System.Windows.Forms.ComboBox();
            this.cbotipodecontrato = new System.Windows.Forms.ComboBox();
            this.txtvalordecontrato = new System.Windows.Forms.TextBox();
            this.txtdatafinal = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbonomevendedor = new System.Windows.Forms.ComboBox();
            this.cboidvendedor = new System.Windows.Forms.ComboBox();
            this.cbonomefuncionario = new System.Windows.Forms.ComboBox();
            this.cboidfuncionario = new System.Windows.Forms.ComboBox();
            this.btopesquisa = new System.Windows.Forms.Button();
            this.txtdata = new System.Windows.Forms.MaskedTextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtobs = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btocadastrar = new System.Windows.Forms.Button();
            this.btoalterar = new System.Windows.Forms.Button();
            this.btosair = new System.Windows.Forms.Button();
            this.btolimpar = new System.Windows.Forms.Button();
            this.btoexcluir = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbototaldeparcelas)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 50);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(797, 397);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbototaldeparcelas);
            this.tabPage1.Controls.Add(this.cbostatus);
            this.tabPage1.Controls.Add(this.cbotipodecontrato);
            this.tabPage1.Controls.Add(this.txtvalordecontrato);
            this.tabPage1.Controls.Add(this.txtdatafinal);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.cbonomevendedor);
            this.tabPage1.Controls.Add(this.cboidvendedor);
            this.tabPage1.Controls.Add(this.cbonomefuncionario);
            this.tabPage1.Controls.Add(this.cboidfuncionario);
            this.tabPage1.Controls.Add(this.btopesquisa);
            this.tabPage1.Controls.Add(this.txtdata);
            this.tabPage1.Controls.Add(this.txtid);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(789, 369);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Contrato";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbototaldeparcelas
            // 
            this.cbototaldeparcelas.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbototaldeparcelas.Location = new System.Drawing.Point(241, 148);
            this.cbototaldeparcelas.Name = "cbototaldeparcelas";
            this.cbototaldeparcelas.Size = new System.Drawing.Size(156, 32);
            this.cbototaldeparcelas.TabIndex = 65;
            // 
            // cbostatus
            // 
            this.cbostatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbostatus.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbostatus.FormattingEnabled = true;
            this.cbostatus.Items.AddRange(new object[] {
            "ATIVO",
            "INATIVO"});
            this.cbostatus.Location = new System.Drawing.Point(8, 303);
            this.cbostatus.Name = "cbostatus";
            this.cbostatus.Size = new System.Drawing.Size(166, 33);
            this.cbostatus.TabIndex = 64;
            // 
            // cbotipodecontrato
            // 
            this.cbotipodecontrato.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbotipodecontrato.FormattingEnabled = true;
            this.cbotipodecontrato.Items.AddRange(new object[] {
            "EMPRESARIAL",
            "PARCERIA",
            "PUBLICIDADE"});
            this.cbotipodecontrato.Location = new System.Drawing.Point(240, 218);
            this.cbotipodecontrato.Name = "cbotipodecontrato";
            this.cbotipodecontrato.Size = new System.Drawing.Size(157, 33);
            this.cbotipodecontrato.TabIndex = 64;
            // 
            // txtvalordecontrato
            // 
            this.txtvalordecontrato.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtvalordecontrato.Location = new System.Drawing.Point(8, 218);
            this.txtvalordecontrato.Name = "txtvalordecontrato";
            this.txtvalordecontrato.Size = new System.Drawing.Size(194, 32);
            this.txtvalordecontrato.TabIndex = 63;
            // 
            // txtdatafinal
            // 
            this.txtdatafinal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtdatafinal.Location = new System.Drawing.Point(8, 148);
            this.txtdatafinal.Mask = "##/##/####";
            this.txtdatafinal.Name = "txtdatafinal";
            this.txtdatafinal.Size = new System.Drawing.Size(194, 32);
            this.txtdatafinal.TabIndex = 62;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(8, 272);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 28);
            this.label12.TabIndex = 59;
            this.label12.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(8, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 28);
            this.label4.TabIndex = 58;
            this.label4.Text = "Valor do contrato";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(240, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 28);
            this.label6.TabIndex = 59;
            this.label6.Text = "Tipo de contrato";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(240, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 28);
            this.label5.TabIndex = 59;
            this.label5.Text = "Total de parcelas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(8, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 28);
            this.label3.TabIndex = 59;
            this.label3.Text = "Data final ";
            // 
            // cbonomevendedor
            // 
            this.cbonomevendedor.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbonomevendedor.FormattingEnabled = true;
            this.cbonomevendedor.Location = new System.Drawing.Point(601, 41);
            this.cbonomevendedor.Name = "cbonomevendedor";
            this.cbonomevendedor.Size = new System.Drawing.Size(170, 33);
            this.cbonomevendedor.TabIndex = 57;
            // 
            // cboidvendedor
            // 
            this.cboidvendedor.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboidvendedor.FormattingEnabled = true;
            this.cboidvendedor.Location = new System.Drawing.Point(460, 41);
            this.cboidvendedor.Name = "cboidvendedor";
            this.cboidvendedor.Size = new System.Drawing.Size(77, 33);
            this.cboidvendedor.TabIndex = 57;
            // 
            // cbonomefuncionario
            // 
            this.cbonomefuncionario.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbonomefuncionario.FormattingEnabled = true;
            this.cbonomefuncionario.Location = new System.Drawing.Point(601, 117);
            this.cbonomefuncionario.Name = "cbonomefuncionario";
            this.cbonomefuncionario.Size = new System.Drawing.Size(170, 33);
            this.cbonomefuncionario.TabIndex = 57;
            // 
            // cboidfuncionario
            // 
            this.cboidfuncionario.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboidfuncionario.FormattingEnabled = true;
            this.cboidfuncionario.Location = new System.Drawing.Point(460, 117);
            this.cboidfuncionario.Name = "cboidfuncionario";
            this.cboidfuncionario.Size = new System.Drawing.Size(77, 33);
            this.cboidfuncionario.TabIndex = 57;
            // 
            // btopesquisa
            // 
            this.btopesquisa.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btopesquisa.Location = new System.Drawing.Point(90, 38);
            this.btopesquisa.Name = "btopesquisa";
            this.btopesquisa.Size = new System.Drawing.Size(38, 36);
            this.btopesquisa.TabIndex = 56;
            this.btopesquisa.Text = "...";
            this.btopesquisa.UseVisualStyleBackColor = true;
            this.btopesquisa.Click += new System.EventHandler(this.btopesquisa_Click);
            // 
            // txtdata
            // 
            this.txtdata.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtdata.Location = new System.Drawing.Point(240, 41);
            this.txtdata.Mask = "##/##/####";
            this.txtdata.Name = "txtdata";
            this.txtdata.ReadOnly = true;
            this.txtdata.Size = new System.Drawing.Size(121, 32);
            this.txtdata.TabIndex = 38;
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtid.Location = new System.Drawing.Point(8, 41);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(60, 32);
            this.txtid.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(601, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 28);
            this.label10.TabIndex = 39;
            this.label10.Text = "Nome vendedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(240, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 28);
            this.label2.TabIndex = 33;
            this.label2.Text = "Data";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(460, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 28);
            this.label9.TabIndex = 39;
            this.label9.Text = "ID vendedor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(601, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 28);
            this.label8.TabIndex = 39;
            this.label8.Text = "Nome funcionario";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(460, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 28);
            this.label7.TabIndex = 39;
            this.label7.Text = "ID funcionario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 28);
            this.label1.TabIndex = 39;
            this.label1.Text = "ID";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtobs);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(789, 369);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Observação";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtobs
            // 
            this.txtobs.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtobs.Location = new System.Drawing.Point(14, 54);
            this.txtobs.Multiline = true;
            this.txtobs.Name = "txtobs";
            this.txtobs.Size = new System.Drawing.Size(760, 300);
            this.txtobs.TabIndex = 65;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(14, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 28);
            this.label11.TabIndex = 64;
            this.label11.Text = "Observação";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(12, 10);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(311, 37);
            this.label20.TabIndex = 3;
            this.label20.Text = "Informações de Contrato";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btocadastrar);
            this.groupBox1.Controls.Add(this.btoalterar);
            this.groupBox1.Controls.Add(this.btosair);
            this.groupBox1.Controls.Add(this.btolimpar);
            this.groupBox1.Controls.Add(this.btoexcluir);
            this.groupBox1.Location = new System.Drawing.Point(16, 453);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(793, 63);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btocadastrar
            // 
            this.btocadastrar.Location = new System.Drawing.Point(390, 16);
            this.btocadastrar.Name = "btocadastrar";
            this.btocadastrar.Size = new System.Drawing.Size(75, 41);
            this.btocadastrar.TabIndex = 0;
            this.btocadastrar.Text = "Cadastrar";
            this.btocadastrar.UseVisualStyleBackColor = true;
            this.btocadastrar.Click += new System.EventHandler(this.btocadastrar_Click);
            // 
            // btoalterar
            // 
            this.btoalterar.Location = new System.Drawing.Point(471, 16);
            this.btoalterar.Name = "btoalterar";
            this.btoalterar.Size = new System.Drawing.Size(75, 41);
            this.btoalterar.TabIndex = 1;
            this.btoalterar.Text = "Alterar";
            this.btoalterar.UseVisualStyleBackColor = true;
            this.btoalterar.Click += new System.EventHandler(this.btoalterar_Click);
            // 
            // btosair
            // 
            this.btosair.Location = new System.Drawing.Point(714, 16);
            this.btosair.Name = "btosair";
            this.btosair.Size = new System.Drawing.Size(75, 41);
            this.btosair.TabIndex = 4;
            this.btosair.Text = "Sair";
            this.btosair.UseVisualStyleBackColor = true;
            this.btosair.Click += new System.EventHandler(this.btosair_Click);
            // 
            // btolimpar
            // 
            this.btolimpar.Location = new System.Drawing.Point(633, 16);
            this.btolimpar.Name = "btolimpar";
            this.btolimpar.Size = new System.Drawing.Size(75, 41);
            this.btolimpar.TabIndex = 3;
            this.btolimpar.Text = "Limpar";
            this.btolimpar.UseVisualStyleBackColor = true;
            this.btolimpar.Click += new System.EventHandler(this.btolimpar_Click);
            // 
            // btoexcluir
            // 
            this.btoexcluir.Location = new System.Drawing.Point(552, 16);
            this.btoexcluir.Name = "btoexcluir";
            this.btoexcluir.Size = new System.Drawing.Size(75, 41);
            this.btoexcluir.TabIndex = 2;
            this.btoexcluir.Text = "Excluir ";
            this.btoexcluir.UseVisualStyleBackColor = true;
            this.btoexcluir.Click += new System.EventHandler(this.btoexcluir_Click);
            // 
            // frmContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 524);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmContrato";
            this.Text = "frmContrato";
            this.Load += new System.EventHandler(this.frmContrato_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbototaldeparcelas)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label20;
        private ComboBox cbonomefuncionario;
        private ComboBox cboidfuncionario;
        private Button btopesquisa;
        private MaskedTextBox txtdata;
        private TextBox txtid;
        private Label label2;
        private Label label1;
        private ComboBox cbotipodecontrato;
        private TextBox txtvalordecontrato;
        private MaskedTextBox txtdatafinal;
        private Label label4;
        private Label label6;
        private Label label5;
        private Label label3;
        private ComboBox cbonomevendedor;
        private ComboBox cboidvendedor;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private GroupBox groupBox1;
        private Button btocadastrar;
        private Button btoalterar;
        private Button btosair;
        private Button btolimpar;
        private Button btoexcluir;
        private TabPage tabPage2;
        private TextBox txtobs;
        private Label label11;
        private NumericUpDown cbototaldeparcelas;
        private ComboBox cbostatus;
        private Label label12;
    }
}