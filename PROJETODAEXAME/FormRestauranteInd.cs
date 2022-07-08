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
    public partial class FormRestauranteInd : Form
    {
        Model1Container model1Container;
        public FormRestauranteInd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox5.Text) || string.IsNullOrEmpty(textBox6.Text))
            {
                return;
            }

            Trabalhador trabalhador = new Trabalhador();
            Morada morada = new Morada();
            Restaurante restaurante = (Restaurante)listBox1.SelectedItem;
            if (listBox1.SelectedItem == null)
            {

                return;
            }


            trabalhador.Nome = textBox1.Text;
            morada.Rua = textBox2.Text;
            morada.Cidade = textBox3.Text;
            morada.CodPostal = textBox4.Text;
            morada.Pais = textBox5.Text;
            trabalhador.Telemovel = Int32.Parse(textBox6.Text);
            trabalhador.Morada = morada;
            trabalhador.Salario = Convert.ToDecimal(textBox7.Text);
            trabalhador.Posicao = textBox8.Text;
            trabalhador.Restaurante = restaurante;


            model1Container.MoradaSet.Add(morada);
            model1Container.PessoaSet.Add(trabalhador);
            model1Container.SaveChanges();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            var myForm = new FormPrincipal();
            myForm.Show();
            this.Close();
        }

        private void FormRestauranteInd_Load(object sender, EventArgs e)
        {
            model1Container = new Model1Container();


            List<Restaurante> listaRestaurantes = model1Container.RestauranteSet.ToList<Restaurante>();

            foreach (Restaurante restaurante in listaRestaurantes)
            {
                listBox1.Items.Add(restaurante);
            }

            List<Categoria> listaCategorias = model1Container.CategoriaSet.ToList<Categoria>();

            foreach (Categoria categoria in listaCategorias)
            {
                listBox3.Items.Add(categoria);
            }

            List<MetodoPagamento> listaMetPag = model1Container.MetodoPagamentoSet.ToList<MetodoPagamento>();

            foreach (MetodoPagamento metodoPagamento in listaMetPag)
            {
                listBox4.Items.Add(metodoPagamento);
            }

            
        }




        private void button2_Click(object sender, EventArgs e)
        {
            var myForm = new FormRestauranteGer();
            myForm.Show();
            this.Close();
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            ItemMenu itemMenu = (ItemMenu)listBox2.SelectedItem;
            checkBox2.Checked = !checkBox1.Checked;
            if (listBox2.SelectedItem == null)
            {

                return;
            }
            else

            {


                if (checkBox1.Checked == true)
                {
                    itemMenu.Ativo = true;
                }
                else

                {
                    itemMenu.Ativo = false;
                }




                model1Container.SaveChanges();
                listBox2.ClearSelected();
            }
        }

        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {
            Categoria categoria = (Categoria)listBox3.SelectedItem;
            checkBox4.Checked = !checkBox3.Checked;
            if (listBox3.SelectedItem == null)
            {

                return;
            }
            else

            {


                if (checkBox3.Checked == true)
                {
                    categoria.Ativo = true;
                }
                else

                {
                    categoria.Ativo = false;
                }




                model1Container.SaveChanges();
                listBox3.ClearSelected();
                
            }
        }

        private void checkBox5_CheckedChanged_1(object sender, EventArgs e)
        {
            MetodoPagamento metodoPagamento = (MetodoPagamento)listBox4.SelectedItem;
            checkBox6.Checked = !checkBox5.Checked;
            if (listBox4.SelectedItem == null)
            {

                return;
            }
            else

            {


                if (checkBox5.Checked == true)
                {
                    metodoPagamento.Ativo = true;
                }
                else

                {
                    metodoPagamento.Ativo = false;
                }




                model1Container.SaveChanges();
                listBox4.ClearSelected();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
            ItemMenu itemmenu = (ItemMenu)listBox2.SelectedItem;
            checkBox1.Checked = !checkBox2.Checked;
            if (listBox2.SelectedItem == null)
            {

                return;
            }
            else

            {


                if (checkBox2.Checked == true)
                {
                    itemmenu.Ativo = false;
                }
                else

                {
                    itemmenu.Ativo = true;
                }




                model1Container.SaveChanges();
                listBox2.ClearSelected();
            }

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            
            Categoria categoria = (Categoria)listBox3.SelectedItem;
            checkBox3.Checked = !checkBox4.Checked;
            if (listBox3.SelectedItem == null)
            {

                return;
            }
            else

            {


                if (checkBox4.Checked == true)
                {
                    categoria.Ativo = false;
                }
                else

                {
                    categoria.Ativo = true;
                }




                model1Container.SaveChanges();
                listBox3.ClearSelected();
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            
            MetodoPagamento metodoPagamento = (MetodoPagamento)listBox4.SelectedItem;
            checkBox5.Checked = !checkBox6.Checked;
            if (listBox4.SelectedItem == null)
            {

                return;
            }
            else

            {


                if (checkBox6.Checked == true)
                {
                    metodoPagamento.Ativo = false;
                }
                else

                {
                    metodoPagamento.Ativo = true;
                }




                model1Container.SaveChanges();
                listBox4.ClearSelected();
            }
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            Categoria categoria = (Categoria)listBox3.SelectedItem;
            ItemMenu menu = new ItemMenu();
            if (listBox3.SelectedItem == null)
            {
                return;
            }


            List<ItemMenu> listamenu = model1Container.ItemMenuSet.ToList<ItemMenu>();


            IEnumerable<ItemMenu> MenuAndando = from itemmenu in listamenu
                                                where itemmenu.Categoria == categoria
                                                where itemmenu.Ativo == true
                                                select itemmenu;

            foreach (ItemMenu itemmenu in MenuAndando)
            {
                listBox2.Items.Add(itemmenu);
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
