namespace PROJETODAEXAME
{
    partial class FormCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCliente));
            this.Voltar = new System.Windows.Forms.Button();
            this.Adiciona = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxNumCont = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxTele = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPais = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCodPost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxRua = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.Editar = new System.Windows.Forms.Button();
            this.ListboxCliente = new System.Windows.Forms.ListBox();
            this.btnRegistarCliente = new System.Windows.Forms.Button();
            this.btnApagarCliente1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Voltar
            // 
            this.Voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Voltar.Location = new System.Drawing.Point(740, 437);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(104, 35);
            this.Voltar.TabIndex = 84;
            this.Voltar.Text = "->";
            this.Voltar.UseVisualStyleBackColor = true;
            this.Voltar.Click += new System.EventHandler(this.button2_Click);
            // 
            // Adiciona
            // 
            this.Adiciona.Location = new System.Drawing.Point(514, 318);
            this.Adiciona.Name = "Adiciona";
            this.Adiciona.Size = new System.Drawing.Size(314, 35);
            this.Adiciona.TabIndex = 83;
            this.Adiciona.Text = "Add Cliente";
            this.Adiciona.UseVisualStyleBackColor = true;
            this.Adiciona.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(61, 379);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 16);
            this.label9.TabIndex = 82;
            this.label9.Text = "Numero De Contribuinte";
            // 
            // textBoxNumCont
            // 
            this.textBoxNumCont.Location = new System.Drawing.Point(89, 398);
            this.textBoxNumCont.Name = "textBoxNumCont";
            this.textBoxNumCont.Size = new System.Drawing.Size(200, 22);
            this.textBoxNumCont.TabIndex = 81;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 29);
            this.label1.TabIndex = 80;
            this.label1.Text = "Gestão de Clientes";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 318);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 79;
            this.label8.Text = "Telemovel";
            // 
            // textBoxTele
            // 
            this.textBoxTele.Location = new System.Drawing.Point(89, 337);
            this.textBoxTele.Name = "textBoxTele";
            this.textBoxTele.Size = new System.Drawing.Size(200, 22);
            this.textBoxTele.TabIndex = 78;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(101, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 16);
            this.label7.TabIndex = 77;
            this.label7.Text = "Pais";
            // 
            // textBoxPais
            // 
            this.textBoxPais.Location = new System.Drawing.Point(217, 278);
            this.textBoxPais.Name = "textBoxPais";
            this.textBoxPais.Size = new System.Drawing.Size(141, 22);
            this.textBoxPais.TabIndex = 76;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(101, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 16);
            this.label6.TabIndex = 75;
            this.label6.Text = "Codigo Postal";
            // 
            // textBoxCodPost
            // 
            this.textBoxCodPost.Location = new System.Drawing.Point(217, 253);
            this.textBoxCodPost.Name = "textBoxCodPost";
            this.textBoxCodPost.Size = new System.Drawing.Size(141, 22);
            this.textBoxCodPost.TabIndex = 74;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 73;
            this.label5.Text = "Cidade";
            // 
            // textBoxCidade
            // 
            this.textBoxCidade.Location = new System.Drawing.Point(217, 225);
            this.textBoxCidade.Name = "textBoxCidade";
            this.textBoxCidade.Size = new System.Drawing.Size(141, 22);
            this.textBoxCidade.TabIndex = 72;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 71;
            this.label4.Text = "Rua";
            // 
            // textBoxRua
            // 
            this.textBoxRua.Location = new System.Drawing.Point(217, 197);
            this.textBoxRua.Name = "textBoxRua";
            this.textBoxRua.Size = new System.Drawing.Size(141, 22);
            this.textBoxRua.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 69;
            this.label3.Text = "Morada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 68;
            this.label2.Text = "Nome Cliente";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(89, 105);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(200, 22);
            this.textBoxNome.TabIndex = 67;
            // 
            // Editar
            // 
            this.Editar.Location = new System.Drawing.Point(683, 364);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(145, 58);
            this.Editar.TabIndex = 86;
            this.Editar.Text = "Edit";
            this.Editar.UseVisualStyleBackColor = true;
            this.Editar.Click += new System.EventHandler(this.button3_Click);
            // 
            // ListboxCliente
            // 
            this.ListboxCliente.FormattingEnabled = true;
            this.ListboxCliente.ItemHeight = 16;
            this.ListboxCliente.Location = new System.Drawing.Point(514, 61);
            this.ListboxCliente.Name = "ListboxCliente";
            this.ListboxCliente.Size = new System.Drawing.Size(314, 244);
            this.ListboxCliente.TabIndex = 87;
            this.ListboxCliente.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnRegistarCliente
            // 
            this.btnRegistarCliente.Location = new System.Drawing.Point(514, 437);
            this.btnRegistarCliente.Name = "btnRegistarCliente";
            this.btnRegistarCliente.Size = new System.Drawing.Size(145, 58);
            this.btnRegistarCliente.TabIndex = 90;
            this.btnRegistarCliente.Text = "Adicionar Dados";
            this.btnRegistarCliente.UseVisualStyleBackColor = true;
            this.btnRegistarCliente.Click += new System.EventHandler(this.btnRegistarCliente_Click);
            // 
            // btnApagarCliente1
            // 
            this.btnApagarCliente1.Location = new System.Drawing.Point(514, 364);
            this.btnApagarCliente1.Name = "btnApagarCliente1";
            this.btnApagarCliente1.Size = new System.Drawing.Size(145, 58);
            this.btnApagarCliente1.TabIndex = 91;
            this.btnApagarCliente1.Text = "Apagar";
            this.btnApagarCliente1.UseVisualStyleBackColor = true;
            this.btnApagarCliente1.Click += new System.EventHandler(this.btnApagarCliente1_Click);
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 513);
            this.Controls.Add(this.btnApagarCliente1);
            this.Controls.Add(this.btnRegistarCliente);
            this.Controls.Add(this.ListboxCliente);
            this.Controls.Add(this.Editar);
            this.Controls.Add(this.Voltar);
            this.Controls.Add(this.Adiciona);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxNumCont);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxTele);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxPais);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxCodPost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxCidade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxRua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNome);
            this.Name = "FormCliente";
            this.Text = resources.GetString("$this.Text");
            this.Load += new System.EventHandler(this.FormCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Voltar;
        private System.Windows.Forms.Button Adiciona;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxNumCont;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxTele;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPais;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCodPost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxRua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Button Editar;
        private System.Windows.Forms.ListBox ListboxCliente;
        private System.Windows.Forms.Button btnRegistarCliente;
        private System.Windows.Forms.Button btnApagarCliente1;
    }
}