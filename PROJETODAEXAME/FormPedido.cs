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

            //adicionar os valores para as listboxes correspondidas
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
                    listBoxCate.Items.Add(categoria);
            }

            List<Pedido> listaPedidos = model1Container.PedidoSet.ToList<Pedido>();

            foreach (Pedido pedido in listaPedidos)
            {
                if (pedido.Estado.TipoEstado == "Recebido" || pedido.Estado.TipoEstado == "Em Processamento")
                   listBoxPedido.Items.Add(pedido);
            }
            //Só aparece os pedidos que estão como Recebido e em processamento
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Estado estado = new Estado();
            ItemMenu menu = (ItemMenu)listBoxMenu.SelectedItem;
            Trabalhador trabalhador = (Trabalhador)comboBox1.SelectedItem;
            Cliente cliente = (Cliente)comboBox2.SelectedItem;
            Pedido pedido = new Pedido();
            string estadopedido = "Recebido";

            //codigo simples quando o pedido é efetuado o estado fica como "Recebido"
            decimal decima = Convert.ToDecimal(total);
            pedido.Trabalhador = trabalhador;
            pedido.Cliente = cliente;
            pedido.ValorTotal = decima;
            estado.TipoEstado = estadopedido;
            pedido.Estado = estado;

            model1Container.PedidoSet.Add(pedido);
            model1Container.SaveChanges();

            listBoxCate.ClearSelected();
            listBoxMenu.ClearSelected();
            listBoxCart.ClearSelected();
            listBoxCart.Items.Clear();
        }


        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            listBoxMenu.Items.Clear();
            Categoria categoria = (Categoria)listBoxCate.SelectedItem;
            ItemMenu menu = new ItemMenu();
            
            if (listBoxCate.SelectedItem == null)
            {
                return;
            }

            //se selecionar uma categoria na listbox categorias vai aparecer o menu dessas categorias
            List<ItemMenu> listamenu = model1Container.ItemMenuSet.ToList<ItemMenu>();

            
            IEnumerable<ItemMenu> MenuAndando = from itemmenu in listamenu
                                                where itemmenu.Categoria == categoria
                                                where itemmenu.Ativo == true
                                                select itemmenu;

            foreach (ItemMenu itemmenu in MenuAndando)
            {
                listBoxMenu.Items.Add(itemmenu);
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
            if (listBoxCate.SelectedItem == null)
            {
                return;
            }
            ItemMenu menu = (ItemMenu)listBoxMenu.SelectedItem;

        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            var myForm = new FormGestaoPedi();
            myForm.Show();
            this.Close();
        }
        //variavel para fazer a soma do cart
        double total = 0;
        private void button4_Click(object sender, EventArgs e)
        {

            ItemMenu item = (ItemMenu)listBoxMenu.SelectedItem;
            listBoxCart.Items.Add(item.Nome);

            total += item.Preço;
            labelClienteTotal.Text = total.ToString();


        }


        private void button5_Click(object sender, EventArgs e)
        {
            ItemMenu item = (ItemMenu)listBoxMenu.SelectedItem;
            listBoxCart.Items.Remove(item.Nome);

            total -= item.Preço;
            labelClienteTotal.Text = total.ToString();
        }
    }
}
