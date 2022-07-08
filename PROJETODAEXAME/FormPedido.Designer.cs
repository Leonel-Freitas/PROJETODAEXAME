namespace PROJETODAEXAME
{
    partial class FormPedido
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
            this.buttonAddPed = new System.Windows.Forms.Button();
            this.listBoxPedido = new System.Windows.Forms.ListBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.labelClienteTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxMenu = new System.Windows.Forms.ListBox();
            this.listBoxCate = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonGerPedi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxCart = new System.Windows.Forms.ListBox();
            this.buttonAddMen = new System.Windows.Forms.Button();
            this.buttonElem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAddPed
            // 
            this.buttonAddPed.Location = new System.Drawing.Point(426, 381);
            this.buttonAddPed.Name = "buttonAddPed";
            this.buttonAddPed.Size = new System.Drawing.Size(149, 46);
            this.buttonAddPed.TabIndex = 103;
            this.buttonAddPed.Text = "Adicionar Pedido";
            this.buttonAddPed.UseVisualStyleBackColor = true;
            this.buttonAddPed.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxPedido
            // 
            this.listBoxPedido.FormattingEnabled = true;
            this.listBoxPedido.ItemHeight = 16;
            this.listBoxPedido.Location = new System.Drawing.Point(628, 93);
            this.listBoxPedido.Name = "listBoxPedido";
            this.listBoxPedido.Size = new System.Drawing.Size(149, 180);
            this.listBoxPedido.TabIndex = 102;
            
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(229, 34);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 24);
            this.comboBox3.TabIndex = 101;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(514, 34);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 100;
            // 
            // labelClienteTotal
            // 
            this.labelClienteTotal.AutoSize = true;
            this.labelClienteTotal.Location = new System.Drawing.Point(732, 63);
            this.labelClienteTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClienteTotal.Name = "labelClienteTotal";
            this.labelClienteTotal.Size = new System.Drawing.Size(41, 16);
            this.labelClienteTotal.TabIndex = 99;
            this.labelClienteTotal.Text = "0,00 €";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(736, 34);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 98;
            this.label6.Text = "Total:";
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVoltar.Location = new System.Drawing.Point(673, 381);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(104, 35);
            this.buttonVoltar.TabIndex = 97;
            this.buttonVoltar.Text = "->";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 96;
            this.label1.Text = "Categoria";
            // 
            // listBoxMenu
            // 
            this.listBoxMenu.FormattingEnabled = true;
            this.listBoxMenu.ItemHeight = 16;
            this.listBoxMenu.Location = new System.Drawing.Point(229, 105);
            this.listBoxMenu.Name = "listBoxMenu";
            this.listBoxMenu.Size = new System.Drawing.Size(149, 180);
            this.listBoxMenu.TabIndex = 95;
            this.listBoxMenu.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // listBoxCate
            // 
            this.listBoxCate.FormattingEnabled = true;
            this.listBoxCate.ItemHeight = 16;
            this.listBoxCate.Location = new System.Drawing.Point(23, 105);
            this.listBoxCate.Name = "listBoxCate";
            this.listBoxCate.Size = new System.Drawing.Size(148, 180);
            this.listBoxCate.TabIndex = 94;
            this.listBoxCate.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(373, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 93;
            // 
            // buttonGerPedi
            // 
            this.buttonGerPedi.Location = new System.Drawing.Point(628, 307);
            this.buttonGerPedi.Name = "buttonGerPedi";
            this.buttonGerPedi.Size = new System.Drawing.Size(132, 40);
            this.buttonGerPedi.TabIndex = 104;
            this.buttonGerPedi.Text = "Gerir Pedidos";
            this.buttonGerPedi.UseVisualStyleBackColor = true;
            this.buttonGerPedi.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 105;
            this.label2.Text = "Menu";
            // 
            // listBoxCart
            // 
            this.listBoxCart.FormattingEnabled = true;
            this.listBoxCart.ItemHeight = 16;
            this.listBoxCart.Location = new System.Drawing.Point(426, 105);
            this.listBoxCart.Name = "listBoxCart";
            this.listBoxCart.Size = new System.Drawing.Size(149, 180);
            this.listBoxCart.TabIndex = 106;
            
            // 
            // buttonAddMen
            // 
            this.buttonAddMen.Location = new System.Drawing.Point(229, 307);
            this.buttonAddMen.Name = "buttonAddMen";
            this.buttonAddMen.Size = new System.Drawing.Size(139, 46);
            this.buttonAddMen.TabIndex = 107;
            this.buttonAddMen.Text = "Adicionar Menu";
            this.buttonAddMen.UseVisualStyleBackColor = true;
            this.buttonAddMen.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonElem
            // 
            this.buttonElem.Location = new System.Drawing.Point(426, 307);
            this.buttonElem.Name = "buttonElem";
            this.buttonElem.Size = new System.Drawing.Size(149, 46);
            this.buttonElem.TabIndex = 108;
            this.buttonElem.Text = "Eleminar Linha";
            this.buttonElem.UseVisualStyleBackColor = true;
            this.buttonElem.Click += new System.EventHandler(this.button5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(423, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 109;
            this.label3.Text = "Cart";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 110;
            this.label4.Text = "Restaurante";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(370, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 111;
            this.label5.Text = "Funcionario";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(511, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 112;
            this.label7.Text = "Cliente";
            // 
            // FormPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 463);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonElem);
            this.Controls.Add(this.buttonAddMen);
            this.Controls.Add(this.listBoxCart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonGerPedi);
            this.Controls.Add(this.buttonAddPed);
            this.Controls.Add(this.listBoxPedido);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.labelClienteTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxMenu);
            this.Controls.Add(this.listBoxCate);
            this.Controls.Add(this.comboBox1);
            this.Name = "FormPedido";
            this.Text = "FormPedido";
            this.Load += new System.EventHandler(this.FormPedido_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddPed;
        private System.Windows.Forms.ListBox listBoxPedido;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label labelClienteTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxMenu;
        private System.Windows.Forms.ListBox listBoxCate;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonGerPedi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxCart;
        private System.Windows.Forms.Button buttonAddMen;
        private System.Windows.Forms.Button buttonElem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
    }
}