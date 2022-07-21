namespace PROJETODAEXAME
{
    partial class FormMenu
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
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelNomeRestaurante = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbCategoriasItens = new System.Windows.Forms.ComboBox();
            this.listBoxMenu = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.listBoxItens = new System.Windows.Forms.ListBox();
            this.buttonCancelarAlt = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.btnRemoverMenu = new System.Windows.Forms.Button();
            this.btnAdicionarMenu = new System.Windows.Forms.Button();
            this.groupBoxdadosItem = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbCategoriasCriarItem = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxAtivo = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbPreçoItem = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbIngredientes = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbNomeItem = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnAlterarDadosItem = new System.Windows.Forms.Button();
            this.btnRegistarItem = new System.Windows.Forms.Button();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.groupBoxdadosItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Location = new System.Drawing.Point(1241, 700);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(104, 35);
            this.buttonAdicionar.TabIndex = 128;
            this.buttonAdicionar.Text = "Add";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 29);
            this.label3.TabIndex = 121;
            this.label3.Text = "Menu";
            // 
            // labelNomeRestaurante
            // 
            this.labelNomeRestaurante.AutoSize = true;
            this.labelNomeRestaurante.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeRestaurante.Location = new System.Drawing.Point(37, 9);
            this.labelNomeRestaurante.Name = "labelNomeRestaurante";
            this.labelNomeRestaurante.Size = new System.Drawing.Size(261, 29);
            this.labelNomeRestaurante.TabIndex = 132;
            this.labelNomeRestaurante.Text = "Nome Do restaurante";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(476, 67);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 18);
            this.label9.TabIndex = 64;
            this.label9.Text = "Categoria:";
            // 
            // cbCategoriasItens
            // 
            this.cbCategoriasItens.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoriasItens.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoriasItens.FormattingEnabled = true;
            this.cbCategoriasItens.Location = new System.Drawing.Point(564, 59);
            this.cbCategoriasItens.Margin = new System.Windows.Forms.Padding(4);
            this.cbCategoriasItens.Name = "cbCategoriasItens";
            this.cbCategoriasItens.Size = new System.Drawing.Size(148, 26);
            this.cbCategoriasItens.TabIndex = 63;
            // 
            // listBoxMenu
            // 
            this.listBoxMenu.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxMenu.FormattingEnabled = true;
            this.listBoxMenu.ItemHeight = 24;
            this.listBoxMenu.Location = new System.Drawing.Point(42, 87);
            this.listBoxMenu.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxMenu.Name = "listBoxMenu";
            this.listBoxMenu.Size = new System.Drawing.Size(304, 484);
            this.listBoxMenu.TabIndex = 61;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(380, 48);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 36);
            this.label10.TabIndex = 60;
            this.label10.Text = "Itens";
            // 
            // listBoxItens
            // 
            this.listBoxItens.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxItens.FormattingEnabled = true;
            this.listBoxItens.ItemHeight = 24;
            this.listBoxItens.Location = new System.Drawing.Point(388, 85);
            this.listBoxItens.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxItens.Name = "listBoxItens";
            this.listBoxItens.Size = new System.Drawing.Size(325, 484);
            this.listBoxItens.TabIndex = 59;
            this.listBoxItens.SelectedIndexChanged += new System.EventHandler(this.listBoxItens_SelectedIndexChanged_1);
            // 
            // buttonCancelarAlt
            // 
            this.buttonCancelarAlt.BackColor = System.Drawing.Color.Silver;
            this.buttonCancelarAlt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelarAlt.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelarAlt.Location = new System.Drawing.Point(748, 639);
            this.buttonCancelarAlt.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancelarAlt.Name = "buttonCancelarAlt";
            this.buttonCancelarAlt.Size = new System.Drawing.Size(228, 47);
            this.buttonCancelarAlt.TabIndex = 143;
            this.buttonCancelarAlt.Text = "Cancelar";
            this.buttonCancelarAlt.UseVisualStyleBackColor = false;
            this.buttonCancelarAlt.Visible = false;
            this.buttonCancelarAlt.Click += new System.EventHandler(this.buttonCancelarAlt_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.BackColor = System.Drawing.Color.Silver;
            this.buttonAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAlterar.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlterar.Location = new System.Drawing.Point(741, 562);
            this.buttonAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(228, 47);
            this.buttonAlterar.TabIndex = 142;
            this.buttonAlterar.Text = "Alterar Dados";
            this.buttonAlterar.UseVisualStyleBackColor = false;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Silver;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(1019, 629);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(333, 47);
            this.buttonCancel.TabIndex = 141;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Visible = false;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Silver;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(1020, 574);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(333, 47);
            this.buttonAdd.TabIndex = 140;
            this.buttonAdd.Text = "Adicionar";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // btnRemoverMenu
            // 
            this.btnRemoverMenu.BackColor = System.Drawing.Color.Silver;
            this.btnRemoverMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverMenu.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverMenu.Location = new System.Drawing.Point(42, 584);
            this.btnRemoverMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoverMenu.Name = "btnRemoverMenu";
            this.btnRemoverMenu.Size = new System.Drawing.Size(305, 92);
            this.btnRemoverMenu.TabIndex = 139;
            this.btnRemoverMenu.Text = "Remover do Menu";
            this.btnRemoverMenu.UseVisualStyleBackColor = false;
            // 
            // btnAdicionarMenu
            // 
            this.btnAdicionarMenu.BackColor = System.Drawing.Color.Silver;
            this.btnAdicionarMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarMenu.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarMenu.Location = new System.Drawing.Point(386, 584);
            this.btnAdicionarMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdicionarMenu.Name = "btnAdicionarMenu";
            this.btnAdicionarMenu.Size = new System.Drawing.Size(327, 92);
            this.btnAdicionarMenu.TabIndex = 138;
            this.btnAdicionarMenu.Text = "Adicionar ao Menu";
            this.btnAdicionarMenu.UseVisualStyleBackColor = false;
            this.btnAdicionarMenu.Click += new System.EventHandler(this.btnAdicionarMenu_Click_1);
            // 
            // groupBoxdadosItem
            // 
            this.groupBoxdadosItem.Controls.Add(this.label11);
            this.groupBoxdadosItem.Controls.Add(this.cbCategoriasCriarItem);
            this.groupBoxdadosItem.Controls.Add(this.button1);
            this.groupBoxdadosItem.Controls.Add(this.pictureBox1);
            this.groupBoxdadosItem.Controls.Add(this.label12);
            this.groupBoxdadosItem.Controls.Add(this.comboBoxAtivo);
            this.groupBoxdadosItem.Controls.Add(this.label13);
            this.groupBoxdadosItem.Controls.Add(this.tbPreçoItem);
            this.groupBoxdadosItem.Controls.Add(this.label14);
            this.groupBoxdadosItem.Controls.Add(this.tbIngredientes);
            this.groupBoxdadosItem.Controls.Add(this.label15);
            this.groupBoxdadosItem.Controls.Add(this.tbNomeItem);
            this.groupBoxdadosItem.Controls.Add(this.label16);
            this.groupBoxdadosItem.Controls.Add(this.txtFilePath);
            this.groupBoxdadosItem.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxdadosItem.Location = new System.Drawing.Point(737, 30);
            this.groupBoxdadosItem.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxdadosItem.Name = "groupBoxdadosItem";
            this.groupBoxdadosItem.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxdadosItem.Size = new System.Drawing.Size(624, 543);
            this.groupBoxdadosItem.TabIndex = 137;
            this.groupBoxdadosItem.TabStop = false;
            this.groupBoxdadosItem.Text = "Dados do Item";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(283, 447);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 24);
            this.label11.TabIndex = 56;
            this.label11.Text = "Categoria:";
            // 
            // cbCategoriasCriarItem
            // 
            this.cbCategoriasCriarItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoriasCriarItem.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoriasCriarItem.FormattingEnabled = true;
            this.cbCategoriasCriarItem.Location = new System.Drawing.Point(283, 476);
            this.cbCategoriasCriarItem.Margin = new System.Windows.Forms.Padding(4);
            this.cbCategoriasCriarItem.Name = "cbCategoriasCriarItem";
            this.cbCategoriasCriarItem.Size = new System.Drawing.Size(312, 32);
            this.cbCategoriasCriarItem.TabIndex = 55;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(283, 383);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(313, 47);
            this.button1.TabIndex = 51;
            this.button1.Text = "Procurar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(282, 73);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(313, 302);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(283, 28);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 24);
            this.label12.TabIndex = 52;
            this.label12.Text = "Fotografia:";
            // 
            // comboBoxAtivo
            // 
            this.comboBoxAtivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAtivo.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAtivo.FormattingEnabled = true;
            this.comboBoxAtivo.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.comboBoxAtivo.Location = new System.Drawing.Point(8, 476);
            this.comboBoxAtivo.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxAtivo.Name = "comboBoxAtivo";
            this.comboBoxAtivo.Size = new System.Drawing.Size(227, 32);
            this.comboBoxAtivo.TabIndex = 51;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(8, 447);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 24);
            this.label13.TabIndex = 50;
            this.label13.Text = "Ativo:";
            // 
            // tbPreçoItem
            // 
            this.tbPreçoItem.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPreçoItem.Location = new System.Drawing.Point(8, 410);
            this.tbPreçoItem.Margin = new System.Windows.Forms.Padding(4);
            this.tbPreçoItem.Name = "tbPreçoItem";
            this.tbPreçoItem.Size = new System.Drawing.Size(227, 32);
            this.tbPreçoItem.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(7, 383);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 24);
            this.label14.TabIndex = 11;
            this.label14.Text = "Preço:";
            // 
            // tbIngredientes
            // 
            this.tbIngredientes.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIngredientes.Location = new System.Drawing.Point(4, 135);
            this.tbIngredientes.Margin = new System.Windows.Forms.Padding(4);
            this.tbIngredientes.Multiline = true;
            this.tbIngredientes.Name = "tbIngredientes";
            this.tbIngredientes.Size = new System.Drawing.Size(231, 230);
            this.tbIngredientes.TabIndex = 9;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(3, 108);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(129, 24);
            this.label15.TabIndex = 10;
            this.label15.Text = "Ingredientes:";
            // 
            // tbNomeItem
            // 
            this.tbNomeItem.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomeItem.Location = new System.Drawing.Point(8, 60);
            this.tbNomeItem.Margin = new System.Windows.Forms.Padding(4);
            this.tbNomeItem.Name = "tbNomeItem";
            this.tbNomeItem.Size = new System.Drawing.Size(231, 32);
            this.tbNomeItem.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(8, 33);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 24);
            this.label16.TabIndex = 8;
            this.label16.Text = "Nome:";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(283, 74);
            this.txtFilePath.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilePath.Multiline = true;
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(312, 57);
            this.txtFilePath.TabIndex = 54;
            this.txtFilePath.Visible = false;
            // 
            // btnAlterarDadosItem
            // 
            this.btnAlterarDadosItem.BackColor = System.Drawing.Color.Silver;
            this.btnAlterarDadosItem.Enabled = false;
            this.btnAlterarDadosItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarDadosItem.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarDadosItem.Location = new System.Drawing.Point(749, 584);
            this.btnAlterarDadosItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlterarDadosItem.Name = "btnAlterarDadosItem";
            this.btnAlterarDadosItem.Size = new System.Drawing.Size(228, 47);
            this.btnAlterarDadosItem.TabIndex = 136;
            this.btnAlterarDadosItem.Text = "Confirmar";
            this.btnAlterarDadosItem.UseVisualStyleBackColor = false;
            this.btnAlterarDadosItem.Visible = false;
            this.btnAlterarDadosItem.Click += new System.EventHandler(this.btnAlterarDadosItem_Click);
            // 
            // btnRegistarItem
            // 
            this.btnRegistarItem.BackColor = System.Drawing.Color.Silver;
            this.btnRegistarItem.Enabled = false;
            this.btnRegistarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistarItem.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistarItem.Location = new System.Drawing.Point(1024, 574);
            this.btnRegistarItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistarItem.Name = "btnRegistarItem";
            this.btnRegistarItem.Size = new System.Drawing.Size(333, 47);
            this.btnRegistarItem.TabIndex = 135;
            this.btnRegistarItem.Text = "Confirmar";
            this.btnRegistarItem.UseVisualStyleBackColor = false;
            this.btnRegistarItem.Visible = false;
            this.btnRegistarItem.Click += new System.EventHandler(this.btnRegistarItem_Click);
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVoltar.Location = new System.Drawing.Point(1108, 700);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(104, 35);
            this.buttonVoltar.TabIndex = 144;
            this.buttonVoltar.Text = "->";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 747);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.buttonCancelarAlt);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.btnRemoverMenu);
            this.Controls.Add(this.btnAdicionarMenu);
            this.Controls.Add(this.groupBoxdadosItem);
            this.Controls.Add(this.btnAlterarDadosItem);
            this.Controls.Add(this.btnRegistarItem);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.cbCategoriasItens);
            this.Controls.Add(this.labelNomeRestaurante);
            this.Controls.Add(this.listBoxMenu);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.listBoxItens);
            this.Controls.Add(this.label3);
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.groupBoxdadosItem.ResumeLayout(false);
            this.groupBoxdadosItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelNomeRestaurante;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbCategoriasItens;
        private System.Windows.Forms.ListBox listBoxMenu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox listBoxItens;
        private System.Windows.Forms.Button buttonCancelarAlt;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button btnRemoverMenu;
        private System.Windows.Forms.Button btnAdicionarMenu;
        private System.Windows.Forms.GroupBox groupBoxdadosItem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbCategoriasCriarItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxAtivo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbPreçoItem;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbIngredientes;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbNomeItem;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnAlterarDadosItem;
        private System.Windows.Forms.Button btnRegistarItem;
        private System.Windows.Forms.Button buttonVoltar;
    }
}