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
    public partial class FormCliente : Form
    {
        Model1Container model1Container;
        public FormCliente()
        {
            InitializeComponent();
        }
         
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNome.Text) || string.IsNullOrEmpty(textBoxRua.Text) || string.IsNullOrEmpty(textBoxCidade.Text) || string.IsNullOrEmpty(textBoxCodPost.Text) || string.IsNullOrEmpty(textBoxPais.Text) || string.IsNullOrEmpty(textBoxTele.Text) || string.IsNullOrEmpty(textBoxNumCont.Text))
            {
                return;
            }
            
            Cliente cliente = new Cliente();
            Morada morada = new Morada();

            Int32.TryParse(textBoxTele.Text, out int resultado);
            Int32.TryParse(textBoxNumCont.Text, out int resultado2);
            cliente.Nome = textBoxNome.Text;
            morada.Rua = textBoxRua.Text;
            morada.Cidade = textBoxCidade.Text;
            morada.CodPostal = textBoxCodPost.Text;
            morada.Pais = textBoxPais.Text;
            cliente.Telemovel = resultado;
            cliente.NumContribuinte = resultado2;
            cliente.Morada = morada;
            //adicionar os dados para a base de Dados
            model1Container.MoradaSet.Add(morada);
            model1Container.PessoaSet.Add(cliente);
            model1Container.SaveChanges();

            //Limpar as TextBoxes
            textBoxNome.Clear();
            textBoxRua.Clear();
            textBoxCidade.Clear();
            textBoxCodPost.Clear();
            textBoxPais.Clear();
            textBoxTele.Clear();
            textBoxNumCont.Clear();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            var myForm = new FormPrincipal();
            myForm.Show();
            this.Close();
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            model1Container = new Model1Container();
            List<Pessoa> listapessoa1 = model1Container.PessoaSet.ToList<Pessoa>();

            foreach (Pessoa pessoa1 in listapessoa1)
            {
                if (pessoa1 is Cliente)
                {
                    Cliente.Items.Add(pessoa1);
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)Cliente.SelectedItem;
            Morada morada = new Morada();
            Int32.TryParse(textBoxTele.Text, out int resultado);
            Int32.TryParse(textBoxNumCont.Text, out int resultado2);
            cliente.Nome = textBoxNome.Text;
            morada.Rua = textBoxRua.Text;
            morada.Cidade = textBoxCidade.Text;
            morada.CodPostal = textBoxCodPost.Text;
            morada.Pais = textBoxPais.Text;
            cliente.Telemovel = resultado;
            cliente.NumContribuinte = resultado2;
            cliente.Morada = morada;

            //editar os dados para a base de Dados
            model1Container.SaveChanges();

            //Limpar as TextBoxes
            textBoxNome.Clear();
            textBoxRua.Clear();
            textBoxCidade.Clear();
            textBoxCodPost.Clear();
            textBoxPais.Clear();
            textBoxTele.Clear();
            textBoxNumCont.Clear();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //tentativa do produto mais consumido pelo cliente
            listBox2.Items.Clear();
            Cliente cliente = (Cliente)Cliente.SelectedItem;
            Pedido pedido = new Pedido();
            ItemMenu menu = new ItemMenu();
            if (Cliente.SelectedItem == null)
            {
                return;
            }


            List<ItemMenu> listamenu = model1Container.ItemMenuSet.ToList<ItemMenu>();


            IEnumerable<ItemMenu> MenuAndando = from itemmenu in listamenu
                                                
                                                where itemmenu.Ativo == true
                                                select itemmenu;

            foreach (ItemMenu itemmenu in MenuAndando)
            {
                listBox2.Items.Add(itemmenu);
            }
        }

       
    }
}
