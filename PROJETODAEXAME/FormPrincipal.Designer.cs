namespace PROJETODAEXAME
{
    partial class FormPrincipal
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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxRestaurantes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(308, 355);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(184, 98);
            this.button4.TabIndex = 15;
            this.button4.Text = "Menu";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(308, 236);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 98);
            this.button3.TabIndex = 14;
            this.button3.Text = "Restaurantes";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(308, 118);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 98);
            this.button2.TabIndex = 13;
            this.button2.Text = "Clientes";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(308, -3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 98);
            this.button1.TabIndex = 12;
            this.button1.Text = "Pedidos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxRestaurantes
            // 
            this.listBoxRestaurantes.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxRestaurantes.FormattingEnabled = true;
            this.listBoxRestaurantes.ItemHeight = 24;
            this.listBoxRestaurantes.Location = new System.Drawing.Point(12, 71);
            this.listBoxRestaurantes.Name = "listBoxRestaurantes";
            this.listBoxRestaurantes.Size = new System.Drawing.Size(239, 292);
            this.listBoxRestaurantes.TabIndex = 16;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 472);
            this.Controls.Add(this.listBoxRestaurantes);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxRestaurantes;
    }
}

