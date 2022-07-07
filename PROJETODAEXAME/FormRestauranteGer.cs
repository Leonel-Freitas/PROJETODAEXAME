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
    public partial class FormRestauranteGer : Form
    {
        Model1Container model1Container;
        public FormRestauranteGer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox5.Text))
            {
                return;
            }
            model1Container = new Model1Container();
            Restaurante restaurante = new Restaurante();
            Morada morada = new Morada();
            restaurante.Nome = textBox1.Text;
            morada.Rua = textBox2.Text;
            morada.Cidade = textBox3.Text;
            morada.CodPostal = textBox4.Text;
            morada.Pais = textBox5.Text;
            restaurante.Morada = morada;

            model1Container.MoradaSet.Add(morada);
            model1Container.RestauranteSet.Add(restaurante);
            model1Container.SaveChanges();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox6.Text))
            {
                return;
            }
            model1Container = new Model1Container();
            Categoria categoria = new Categoria();
            categoria.Nome = textBox6.Text;

            model1Container.CategoriaSet.Add(categoria);
            model1Container.SaveChanges();
            textBox6.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox7.Text))
            {
                return;
            }
            model1Container = new Model1Container();
            MetodoPagamento pagamento = new MetodoPagamento();
            pagamento.TipoPagamento = textBox7.Text;

            model1Container.MetodoPagamentoSet.Add(pagamento);
            model1Container.SaveChanges();
            textBox7.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var myForm = new FormRestauranteInd();
            myForm.Show();
            this.Close();
        }
    }
}
