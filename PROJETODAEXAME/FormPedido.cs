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
    
    public partial class FormPedido : Form
    {
        Model1Container model1Container;
        public FormPedido()
        {
            InitializeComponent();
        }

        

        private void FormPedido_Load(object sender, EventArgs e)
        {
            model1Container = new Model1Container();

            List<Pessoa> listaPessoas = model1Container.PessoaSet.ToList<Pessoa>();

            foreach (Pessoa pessoa in listaPessoas)
            {
                if (pessoa is Trabalhador)
                {
                    comboBox1.Items.Add(pessoa);
                }

            }

            List<Restaurante> listaRestaurantes = model1Container.RestauranteSet.ToList<Restaurante>();

            foreach (Restaurante restaurante in listaRestaurantes)
            {
                comboBox3.Items.Add(restaurante);
            }

            List<Pessoa> listapessoa1 = model1Container.PessoaSet.ToList<Pessoa>();

            foreach (Pessoa pessoa1 in listapessoa1)
            {
                if (pessoa1 is Cliente)
                {
                    comboBox2.Items.Add(pessoa1);
                }
            }

            List<Categoria> listacategoria = model1Container.CategoriaSet.ToList<Categoria>();

            foreach (Categoria categoria in listacategoria)
            {
                if (categoria.Ativo == true)
                    listBox1.Items.Add(categoria);
            }

            List<Pedido> listaPedidos = model1Container.PedidoSet.ToList<Pedido>();

            foreach (Pedido pedido in listaPedidos)
            {
                if (pedido.Estado.TipoEstado == "Recebido" || pedido.Estado.TipoEstado == "Em Processamento")
                   listBox3.Items.Add(pedido);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Estado estado = new Estado();
            ItemMenu menu = (ItemMenu)listBox2.SelectedItem;
            Trabalhador trabalhador = (Trabalhador)comboBox1.SelectedItem;
            Cliente cliente = (Cliente)comboBox2.SelectedItem;
            Pedido pedido = new Pedido();
            string estadopedido = "Recebido";

            decimal decima = Convert.ToDecimal(total);
            pedido.Trabalhador = trabalhador;
            pedido.Cliente = cliente;
            pedido.ValorTotal = decima;
            estado.TipoEstado = estadopedido;
            pedido.Estado = estado;

            model1Container.PedidoSet.Add(pedido);
            model1Container.SaveChanges();

            listBox1.ClearSelected();
            listBox2.ClearSelected();
            listBox4.ClearSelected();
            listBox4.Items.Clear();
        }

        private void valorCalcu(double valor)
        {
            return;
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            Categoria categoria = (Categoria)listBox1.SelectedItem;
            ItemMenu menu = new ItemMenu();
            if (listBox1.SelectedItem == null)
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

        private void button3_Click_1(object sender, EventArgs e)
        {
            var myForm = new FormPrincipal();
            myForm.Show();
            this.Close();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                return;
            }
            ItemMenu menu = (ItemMenu)listBox2.SelectedItem;

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var myForm = new FormGestaoPedi();
            myForm.Show();
            this.Close();
        }
        double total = 0;
        private void button4_Click(object sender, EventArgs e)
        {

            ItemMenu item = (ItemMenu)listBox2.SelectedItem;
            listBox4.Items.Add(item.Nome);

            total += item.Preço;
            labelClienteTotal.Text = total.ToString();


        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ItemMenu item = (ItemMenu)listBox2.SelectedItem;
            listBox4.Items.Remove(item.Nome);

            total -= item.Preço;
            labelClienteTotal.Text = total.ToString();
        }
    }
}
