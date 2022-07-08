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
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox5.Text) || string.IsNullOrEmpty(textBox6.Text) || string.IsNullOrEmpty(textBox7.Text))
            {
                return;
            }
            
            Cliente cliente = new Cliente();
            Morada morada = new Morada();

            Int32.TryParse(textBox6.Text, out int resultado);
            Int32.TryParse(textBox7.Text, out int resultado2);
            cliente.Nome = textBox1.Text;
            morada.Rua = textBox2.Text;
            morada.Cidade = textBox3.Text;
            morada.CodPostal = textBox4.Text;
            morada.Pais = textBox5.Text;
            cliente.Telemovel = resultado;
            cliente.NumContribuinte = resultado2;
            cliente.Morada = morada;

            model1Container.MoradaSet.Add(morada);
            model1Container.PessoaSet.Add(cliente);
            model1Container.SaveChanges();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();



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
                    listBox1.Items.Add(pessoa1);
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)listBox1.SelectedItem;
            Morada morada = new Morada();
            Int32.TryParse(textBox6.Text, out int resultado);
            Int32.TryParse(textBox7.Text, out int resultado2);
            cliente.Nome = textBox1.Text;
            morada.Rua = textBox2.Text;
            morada.Cidade = textBox3.Text;
            morada.CodPostal = textBox4.Text;
            morada.Pais = textBox5.Text;
            cliente.Telemovel = resultado;
            cliente.NumContribuinte = resultado2;
            cliente.Morada = morada;

            model1Container.SaveChanges();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            Cliente cliente = (Cliente)listBox1.SelectedItem;
            Pedido pedido = new Pedido();
            ItemMenu menu = new ItemMenu();
            if (listBox1.SelectedItem == null)
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

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
