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
            if (string.IsNullOrEmpty(NomeFunc.Text) || string.IsNullOrEmpty(textBoxRua.Text) || string.IsNullOrEmpty(textBoxCidad.Text) || string.IsNullOrEmpty(textBoxCodPost.Text) || string.IsNullOrEmpty(textBoxPais.Text) || string.IsNullOrEmpty(textBoxTele.Text))
            {
                return;
            }

            Trabalhador trabalhador = new Trabalhador();
            Morada morada = new Morada();
            Restaurante restaurante = (Restaurante)listBoxRestaurantes.SelectedItem;
            if (listBoxRestaurantes.SelectedItem == null)
            {

                return;
            }

            //codigo basico como o cliente
            trabalhador.Nome = NomeFunc.Text;
            morada.Rua = textBoxRua.Text;
            morada.Cidade = textBoxCidad.Text;
            morada.CodPostal = textBoxCodPost.Text;
            morada.Pais = textBoxPais.Text;
            trabalhador.Telemovel = Int32.Parse(textBoxTele.Text);
            trabalhador.Morada = morada;
            trabalhador.Salario = Convert.ToDecimal(textBoxSalario.Text);
            trabalhador.Posicao = textBoxPosicao.Text;
            trabalhador.Restaurante = restaurante;


            model1Container.MoradaSet.Add(morada);
            model1Container.PessoaSet.Add(trabalhador);
            model1Container.SaveChanges();

            NomeFunc.Clear();
            textBoxRua.Clear();
            textBoxCidad.Clear();
            textBoxCodPost.Clear();
            textBoxPais.Clear();
            textBoxTele.Clear();
            textBoxSalario.Clear();
            textBoxPosicao.Clear();


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
                listBoxRestaurantes.Items.Add(restaurante);
            }
            //preencher a listbox restaurante

            List<Categoria> listaCategorias = model1Container.CategoriaSet.ToList<Categoria>();

            foreach (Categoria categoria in listaCategorias)
            {
                listBoxCategorias.Items.Add(categoria);
            }
            //preencher a listbox categoria

            List<MetodoPagamento> listaMetPag = model1Container.MetodoPagamentoSet.ToList<MetodoPagamento>();

            foreach (MetodoPagamento metodoPagamento in listaMetPag)
            {
                listBoxPagamento.Items.Add(metodoPagamento);
            }
            //preencher a listbox MetodoPagamento


        }




        private void button2_Click(object sender, EventArgs e)
        {
            var myForm = new FormRestauranteGer();
            myForm.Show();
            this.Close();
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            ItemMenu itemMenu = (ItemMenu)listBoxMenu.SelectedItem;
            checkBoxNAtivoMe.Checked = !checkBoxAtivoMe.Checked;
            if (listBoxMenu.SelectedItem == null)
            {

                return;
            }
            else

            {


                if (checkBoxAtivoMe.Checked == true)
                {
                    itemMenu.Ativo = true;
                }
                else

                {
                    itemMenu.Ativo = false;
                }




                model1Container.SaveChanges();
                listBoxMenu.ClearSelected();
            }
        }

        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {
            Categoria categoria = (Categoria)listBoxCategorias.SelectedItem;
            checkBoxNAtivoCa.Checked = !checkBoxAtivoCa.Checked;
            if (listBoxCategorias.SelectedItem == null)
            {

                return;
            }
            else

            {


                if (checkBoxAtivoCa.Checked == true)
                {
                    categoria.Ativo = true;
                }
                else

                {
                    categoria.Ativo = false;
                }




                model1Container.SaveChanges();
                listBoxCategorias.ClearSelected();
                
            }
        }

        private void checkBox5_CheckedChanged_1(object sender, EventArgs e)
        {
            MetodoPagamento metodoPagamento = (MetodoPagamento)listBoxPagamento.SelectedItem;
            checkBoxNAtivoPa.Checked = !checkBoxAtivoPa.Checked;
            if (listBoxPagamento.SelectedItem == null)
            {

                return;
            }
            else

            {
                //se uma checkbox estiver ativa a outra desativa-se e vice versa

                if (checkBoxAtivoPa.Checked == true)
                {
                    metodoPagamento.Ativo = true;
                }
                else

                {
                    metodoPagamento.Ativo = false;
                }




                model1Container.SaveChanges();
                listBoxPagamento.ClearSelected();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
            ItemMenu itemmenu = (ItemMenu)listBoxMenu.SelectedItem;
            checkBoxAtivoMe.Checked = !checkBoxNAtivoMe.Checked;
            if (listBoxMenu.SelectedItem == null)
            {

                return;
            }
            else

            {
                //se uma checkbox estiver ativa a outra desativa-se e vice versa

                if (checkBoxNAtivoMe.Checked == true)
                {
                    itemmenu.Ativo = false;
                }
                else

                {
                    itemmenu.Ativo = true;
                }




                model1Container.SaveChanges();
                listBoxMenu.ClearSelected();
            }

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            
            Categoria categoria = (Categoria)listBoxCategorias.SelectedItem;
            checkBoxAtivoCa.Checked = !checkBoxNAtivoCa.Checked;
            if (listBoxCategorias.SelectedItem == null)
            {

                return;
            }
            else

            {
                //se uma checkbox estiver ativa a outra desativa-se e vice versa

                if (checkBoxNAtivoCa.Checked == true)
                {
                    categoria.Ativo = false;
                }
                else

                {
                    categoria.Ativo = true;
                }




                model1Container.SaveChanges();
                listBoxCategorias.ClearSelected();
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            
            MetodoPagamento metodoPagamento = (MetodoPagamento)listBoxPagamento.SelectedItem;
            checkBoxAtivoPa.Checked = !checkBoxNAtivoPa.Checked;
            if (listBoxPagamento.SelectedItem == null)
            {

                return;
            }
            else

            {
                //se uma checkbox estiver ativa a outra desativa-se e vice versa

                if (checkBoxNAtivoPa.Checked == true)
                {
                    metodoPagamento.Ativo = false;
                }
                else

                {
                    metodoPagamento.Ativo = true;
                }




                model1Container.SaveChanges();
                listBoxPagamento.ClearSelected();
            }
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxMenu.Items.Clear();
            Categoria categoria = (Categoria)listBoxCategorias.SelectedItem;
            ItemMenu menu = new ItemMenu();
            if (listBoxCategorias.SelectedItem == null)
            {
                return;
            }

            //se selecionar uma categoria na listbox categorias vai aparecer o menu dessas categorias
            List<ItemMenu> listamenu = model1Container.ItemMenuSet.ToList<ItemMenu>();


            IEnumerable<ItemMenu> MenuAndando = from itemmenu in listamenu
                                                where itemmenu.Categoria == categoria
                                                
                                                select itemmenu;

            foreach (ItemMenu itemmenu in MenuAndando)
            {
                listBoxMenu.Items.Add(itemmenu);
            }
        }

       

        
    }
}
