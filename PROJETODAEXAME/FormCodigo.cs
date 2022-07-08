using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJETODAEXAME
{

    public partial class FormCodigo : Form
    {
        Model1Container model1Container;
        public FormCodigo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var myForm = new FormGestaoPedi();
            myForm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Codigo codigo = new Codigo();
            codigo.Code = textBox1.Text;
            codigo.Descrição = textBox2.Text;
            if(listBox1.SelectedItem.ToString() == "0")
            {
                //codigo.tipo = "Global";
                button1.Enabled = true;
            }
               // codigo.tipo = "Item"
                button2.Enabled = true;
        }

        private void FormCodigo_Load(object sender, EventArgs e)
        {
            //tentativa do formulario de codigo
            model1Container = new Model1Container();

            List<ItemMenu> listamenu = model1Container.ItemMenuSet.ToList<ItemMenu>();

            foreach (ItemMenu menu in listamenu)
            {

                if (menu.Ativo == true)
                {
                    listBox2.Items.Add(menu);
                }
                    
            }

            }
        }
    }

