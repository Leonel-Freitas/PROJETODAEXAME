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
    public partial class FormMenu : Form
    {
        Model1Container model1Container;
        public FormMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox3.SelectedItem == null)
            {
                return;
            }
            ItemMenu menu = new ItemMenu();
            Categoria categoria = (Categoria)listBox3.SelectedItem;


            double preço = Convert.ToDouble(textBox4.Text);
            short resultado = Convert.ToInt16(textBox2.Text);
            menu.Nome = textBox1.Text;
            menu.Categoria = categoria;
            menu.Fotografia = resultado;
            menu.Ingredientes = textBox3.Text;
            menu.Preço = preço;
            

            model1Container.ItemMenuSet.Add(menu);
            model1Container.SaveChanges();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            listBox3.ClearSelected();
        }

       

        private void FormMenu_Load(object sender, EventArgs e)
        {
            model1Container = new Model1Container();

            List<Categoria> listaCategorias = model1Container.CategoriaSet.ToList<Categoria>();

            foreach (Categoria categoria in listaCategorias)
            {
                listBox3.Items.Add(categoria);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            var myForm = new FormPrincipal();
            myForm.Show();
            this.Close();
        }
    }
}
