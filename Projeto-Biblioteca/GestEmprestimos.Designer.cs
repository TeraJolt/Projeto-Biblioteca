
namespace Projeto_Biblioteca
{
    partial class GestEmprestimos
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
            this.txtNomeAssociado = new System.Windows.Forms.TextBox();
            this.listNomeAssociado = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPesquisaNomeAssociado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.listTituloLivro = new System.Windows.Forms.ListBox();
            this.btnPesquisaTituloLivro = new System.Windows.Forms.Button();
            this.txtTituloLivro = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.RegEmprestimo = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelAssociado = new System.Windows.Forms.Label();
            this.labelLivro = new System.Windows.Forms.Label();
            this.selecionaData = new System.Windows.Forms.DateTimePicker();
            this.btnInserir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnOkDev = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.nomeAssociadoDev = new System.Windows.Forms.Label();
            this.dataEmprestimoDev = new System.Windows.Forms.Label();
            this.listaExemplaresDev = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNomeAssociadoDev = new System.Windows.Forms.TextBox();
            this.btnPesquisaNomeAssociadoDev = new System.Windows.Forms.Button();
            this.dGridNomeAssociado = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.RegEmprestimo.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridNomeAssociado)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomeAssociado
            // 
            this.txtNomeAssociado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeAssociado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeAssociado.Location = new System.Drawing.Point(3, 9);
            this.txtNomeAssociado.Name = "txtNomeAssociado";
            this.txtNomeAssociado.Size = new System.Drawing.Size(320, 26);
            this.txtNomeAssociado.TabIndex = 2;
            this.txtNomeAssociado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeAssociado_KeyPress);
            // 
            // listNomeAssociado
            // 
            this.listNomeAssociado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listNomeAssociado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listNomeAssociado.FormattingEnabled = true;
            this.listNomeAssociado.ItemHeight = 20;
            this.listNomeAssociado.Location = new System.Drawing.Point(3, 47);
            this.listNomeAssociado.Name = "listNomeAssociado";
            this.listNomeAssociado.Size = new System.Drawing.Size(320, 222);
            this.listNomeAssociado.TabIndex = 3;
            this.listNomeAssociado.SelectedIndexChanged += new System.EventHandler(this.listNomeAssociado_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 98);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(753, 312);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(379, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(371, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pesquise o o Título do Livro";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel2.Controls.Add(this.btnPesquisaNomeAssociado, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.listNomeAssociado, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtNomeAssociado, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 33);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(370, 276);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnPesquisaNomeAssociado
            // 
            this.btnPesquisaNomeAssociado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisaNomeAssociado.AutoSize = true;
            this.btnPesquisaNomeAssociado.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisaNomeAssociado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisaNomeAssociado.Image = global::Projeto_Biblioteca.Properties.Resources.search;
            this.btnPesquisaNomeAssociado.Location = new System.Drawing.Point(329, 3);
            this.btnPesquisaNomeAssociado.Name = "btnPesquisaNomeAssociado";
            this.btnPesquisaNomeAssociado.Size = new System.Drawing.Size(38, 38);
            this.btnPesquisaNomeAssociado.TabIndex = 4;
            this.btnPesquisaNomeAssociado.UseVisualStyleBackColor = false;
            this.btnPesquisaNomeAssociado.Click += new System.EventHandler(this.btnPesquisaNomeAssociado_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pesquise o nome do Associado:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel3.Controls.Add(this.listTituloLivro, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnPesquisaTituloLivro, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtTituloLivro, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(379, 33);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(371, 276);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // listTituloLivro
            // 
            this.listTituloLivro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listTituloLivro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listTituloLivro.FormattingEnabled = true;
            this.listTituloLivro.ItemHeight = 20;
            this.listTituloLivro.Location = new System.Drawing.Point(3, 47);
            this.listTituloLivro.Name = "listTituloLivro";
            this.listTituloLivro.Size = new System.Drawing.Size(321, 222);
            this.listTituloLivro.TabIndex = 5;
            this.listTituloLivro.SelectedIndexChanged += new System.EventHandler(this.listTituloLivro_SelectedIndexChanged);
            // 
            // btnPesquisaTituloLivro
            // 
            this.btnPesquisaTituloLivro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisaTituloLivro.AutoSize = true;
            this.btnPesquisaTituloLivro.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisaTituloLivro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisaTituloLivro.Image = global::Projeto_Biblioteca.Properties.Resources.search;
            this.btnPesquisaTituloLivro.Location = new System.Drawing.Point(330, 3);
            this.btnPesquisaTituloLivro.Name = "btnPesquisaTituloLivro";
            this.btnPesquisaTituloLivro.Size = new System.Drawing.Size(38, 38);
            this.btnPesquisaTituloLivro.TabIndex = 4;
            this.btnPesquisaTituloLivro.UseVisualStyleBackColor = false;
            this.btnPesquisaTituloLivro.Click += new System.EventHandler(this.btnPesquisaTituloLivro_Click);
            // 
            // txtTituloLivro
            // 
            this.txtTituloLivro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTituloLivro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTituloLivro.Location = new System.Drawing.Point(3, 9);
            this.txtTituloLivro.Name = "txtTituloLivro";
            this.txtTituloLivro.Size = new System.Drawing.Size(321, 26);
            this.txtTituloLivro.TabIndex = 2;
            this.txtTituloLivro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTituloLivro_KeyPress);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.RegEmprestimo);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(18, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(773, 449);
            this.tabControl1.TabIndex = 2;
            // 
            // RegEmprestimo
            // 
            this.RegEmprestimo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(240)))));
            this.RegEmprestimo.Controls.Add(this.tableLayoutPanel4);
            this.RegEmprestimo.Controls.Add(this.tableLayoutPanel1);
            this.RegEmprestimo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.RegEmprestimo.Location = new System.Drawing.Point(4, 29);
            this.RegEmprestimo.Name = "RegEmprestimo";
            this.RegEmprestimo.Padding = new System.Windows.Forms.Padding(3);
            this.RegEmprestimo.Size = new System.Drawing.Size(765, 416);
            this.RegEmprestimo.TabIndex = 0;
            this.RegEmprestimo.Text = "Registrar Empréstimo";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel4.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.labelAssociado, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.labelLivro, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.selecionaData, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.btnInserir, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.label11, 3, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(6, 4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(753, 88);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 42);
            this.label4.TabIndex = 2;
            this.label4.Text = "Título do Livro:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 42);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nome do Associado:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAssociado
            // 
            this.labelAssociado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAssociado.AutoSize = true;
            this.labelAssociado.Location = new System.Drawing.Point(4, 44);
            this.labelAssociado.Name = "labelAssociado";
            this.labelAssociado.Size = new System.Drawing.Size(233, 43);
            this.labelAssociado.TabIndex = 1;
            this.labelAssociado.Text = "--";
            this.labelAssociado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLivro
            // 
            this.labelLivro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLivro.AutoSize = true;
            this.labelLivro.Location = new System.Drawing.Point(244, 44);
            this.labelLivro.Name = "labelLivro";
            this.labelLivro.Size = new System.Drawing.Size(233, 43);
            this.labelLivro.TabIndex = 3;
            this.labelLivro.Text = "--";
            this.labelLivro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // selecionaData
            // 
            this.selecionaData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.selecionaData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.selecionaData.Location = new System.Drawing.Point(484, 52);
            this.selecionaData.Name = "selecionaData";
            this.selecionaData.Size = new System.Drawing.Size(128, 26);
            this.selecionaData.TabIndex = 4;
            // 
            // btnInserir
            // 
            this.btnInserir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnInserir.AutoSize = true;
            this.btnInserir.BackColor = System.Drawing.Color.Transparent;
            this.btnInserir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnInserir.Location = new System.Drawing.Point(674, 50);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 30);
            this.btnInserir.TabIndex = 6;
            this.btnInserir.Text = "Ok";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(484, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 42);
            this.label5.TabIndex = 5;
            this.label5.Text = "Data:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(619, 1);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 42);
            this.label11.TabIndex = 7;
            this.label11.Text = "Registrar Empréstimo:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(240)))));
            this.tabPage2.Controls.Add(this.tableLayoutPanel6);
            this.tabPage2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(765, 416);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Gerenciamento de Devolução";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel9, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel8, 0, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(759, 410);
            this.tableLayoutPanel6.TabIndex = 9;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.listaExemplaresDev, 0, 2);
            this.tableLayoutPanel9.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel9.Location = new System.Drawing.Point(306, 3);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 3;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel9.Size = new System.Drawing.Size(450, 404);
            this.tableLayoutPanel9.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel5.Controls.Add(this.label9, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnOkDev, 2, 1);
            this.tableLayoutPanel5.Controls.Add(this.label6, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.nomeAssociadoDev, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.dataEmprestimoDev, 1, 1);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(444, 94);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(314, 1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 44);
            this.label9.TabIndex = 6;
            this.label9.Text = "Registrar Devolução:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 44);
            this.label8.TabIndex = 0;
            this.label8.Text = "Nome do Associado:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnOkDev
            // 
            this.btnOkDev.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnOkDev.AutoSize = true;
            this.btnOkDev.BackColor = System.Drawing.Color.Transparent;
            this.btnOkDev.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOkDev.Location = new System.Drawing.Point(383, 54);
            this.btnOkDev.Name = "btnOkDev";
            this.btnOkDev.Size = new System.Drawing.Size(57, 30);
            this.btnOkDev.TabIndex = 6;
            this.btnOkDev.Text = "Ok";
            this.btnOkDev.UseVisualStyleBackColor = false;
            this.btnOkDev.Click += new System.EventHandler(this.btnOkDev_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(181, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 44);
            this.label6.TabIndex = 5;
            this.label6.Text = "Data:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nomeAssociadoDev
            // 
            this.nomeAssociadoDev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nomeAssociadoDev.AutoSize = true;
            this.nomeAssociadoDev.Location = new System.Drawing.Point(4, 59);
            this.nomeAssociadoDev.Name = "nomeAssociadoDev";
            this.nomeAssociadoDev.Size = new System.Drawing.Size(170, 20);
            this.nomeAssociadoDev.TabIndex = 1;
            this.nomeAssociadoDev.Text = "--";
            this.nomeAssociadoDev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataEmprestimoDev
            // 
            this.dataEmprestimoDev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataEmprestimoDev.AutoSize = true;
            this.dataEmprestimoDev.Location = new System.Drawing.Point(181, 59);
            this.dataEmprestimoDev.Name = "dataEmprestimoDev";
            this.dataEmprestimoDev.Size = new System.Drawing.Size(126, 20);
            this.dataEmprestimoDev.TabIndex = 7;
            this.dataEmprestimoDev.Text = "--";
            this.dataEmprestimoDev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listaExemplaresDev
            // 
            this.listaExemplaresDev.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listaExemplaresDev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listaExemplaresDev.FormattingEnabled = true;
            this.listaExemplaresDev.ItemHeight = 20;
            this.listaExemplaresDev.Location = new System.Drawing.Point(3, 147);
            this.listaExemplaresDev.Name = "listaExemplaresDev";
            this.listaExemplaresDev.Size = new System.Drawing.Size(444, 242);
            this.listaExemplaresDev.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(444, 44);
            this.label7.TabIndex = 6;
            this.label7.Text = "Livros do Empréstimo:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel8.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.txtNomeAssociadoDev, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.btnPesquisaNomeAssociadoDev, 1, 1);
            this.tableLayoutPanel8.Controls.Add(this.dGridNomeAssociado, 0, 2);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 3;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.Size = new System.Drawing.Size(297, 404);
            this.tableLayoutPanel8.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(247, 44);
            this.label10.TabIndex = 5;
            this.label10.Text = "Insira o Nome do Associado:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNomeAssociadoDev
            // 
            this.txtNomeAssociadoDev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeAssociadoDev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeAssociadoDev.Location = new System.Drawing.Point(3, 53);
            this.txtNomeAssociadoDev.Name = "txtNomeAssociadoDev";
            this.txtNomeAssociadoDev.Size = new System.Drawing.Size(247, 26);
            this.txtNomeAssociadoDev.TabIndex = 2;
            this.txtNomeAssociadoDev.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeAssociadoDev_KeyPress);
            // 
            // btnPesquisaNomeAssociadoDev
            // 
            this.btnPesquisaNomeAssociadoDev.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisaNomeAssociadoDev.AutoSize = true;
            this.btnPesquisaNomeAssociadoDev.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisaNomeAssociadoDev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisaNomeAssociadoDev.Image = global::Projeto_Biblioteca.Properties.Resources.search;
            this.btnPesquisaNomeAssociadoDev.Location = new System.Drawing.Point(256, 47);
            this.btnPesquisaNomeAssociadoDev.Name = "btnPesquisaNomeAssociadoDev";
            this.btnPesquisaNomeAssociadoDev.Size = new System.Drawing.Size(38, 38);
            this.btnPesquisaNomeAssociadoDev.TabIndex = 4;
            this.btnPesquisaNomeAssociadoDev.UseVisualStyleBackColor = false;
            this.btnPesquisaNomeAssociadoDev.Click += new System.EventHandler(this.btnPesquisaNomeAssociadoDev_Click);
            // 
            // dGridNomeAssociado
            // 
            this.dGridNomeAssociado.AllowUserToAddRows = false;
            this.dGridNomeAssociado.AllowUserToDeleteRows = false;
            this.dGridNomeAssociado.AllowUserToResizeColumns = false;
            this.dGridNomeAssociado.AllowUserToResizeRows = false;
            this.dGridNomeAssociado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGridNomeAssociado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGridNomeAssociado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGridNomeAssociado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridNomeAssociado.Location = new System.Drawing.Point(3, 91);
            this.dGridNomeAssociado.MultiSelect = false;
            this.dGridNomeAssociado.Name = "dGridNomeAssociado";
            this.dGridNomeAssociado.ReadOnly = true;
            this.dGridNomeAssociado.RowHeadersWidth = 15;
            this.dGridNomeAssociado.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dGridNomeAssociado.RowTemplate.Height = 28;
            this.dGridNomeAssociado.ShowEditingIcon = false;
            this.dGridNomeAssociado.Size = new System.Drawing.Size(247, 310);
            this.dGridNomeAssociado.TabIndex = 6;
            this.dGridNomeAssociado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridNomeAssociado_CellClick);
            // 
            // GestEmprestimos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(803, 474);
            this.Controls.Add(this.tabControl1);
            this.Name = "GestEmprestimos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Library - Gestão de Empréstimos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GestEmprestimos_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.RegEmprestimo.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridNomeAssociado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtNomeAssociado;
        private System.Windows.Forms.ListBox listNomeAssociado;
        private System.Windows.Forms.Button btnPesquisaNomeAssociado;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ListBox listTituloLivro;
        private System.Windows.Forms.Button btnPesquisaTituloLivro;
        private System.Windows.Forms.TextBox txtTituloLivro;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage RegEmprestimo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelAssociado;
        private System.Windows.Forms.Label labelLivro;
        private System.Windows.Forms.DateTimePicker selecionaData;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listaExemplaresDev;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label nomeAssociadoDev;
        private System.Windows.Forms.Button btnOkDev;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNomeAssociadoDev;
        private System.Windows.Forms.Button btnPesquisaNomeAssociadoDev;
        private System.Windows.Forms.DataGridView dGridNomeAssociado;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Label dataEmprestimoDev;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
    }
}