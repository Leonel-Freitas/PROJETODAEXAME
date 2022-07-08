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
            if (string.IsNullOrEmpty(textBoxNomRes.Text) || string.IsNullOrEmpty(textBoxRua.Text) || string.IsNullOrEmpty(textBoxCid.Text) || string.IsNullOrEmpty(textBoxCodPos.Text) || string.IsNullOrEmpty(textBoxPais.Text))
            {
                return;
            }
            model1Container = new Model1Container();
            Restaurante restaurante = new Restaurante();
            Morada morada = new Morada();
            restaurante.Nome = textBoxNomRes.Text;
            morada.Rua = textBoxRua.Text;
            morada.Cidade = textBoxCid.Text;
            morada.CodPostal = textBoxCodPos.Text;
            morada.Pais = textBoxPais.Text;
            restaurante.Morada = morada;

            model1Container.MoradaSet.Add(morada);
            model1Container.RestauranteSet.Add(restaurante);
            model1Container.SaveChanges();

            textBoxNomRes.Clear();
            textBoxRua.Clear();
            textBoxCid.Clear();
            textBoxCodPos.Clear();
            textBoxPais.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCate.Text))
            {
                return;
            }
            model1Container = new Model1Container();
            Categoria categoria = new Categoria();
            categoria.Nome = textBoxCate.Text;

            model1Container.CategoriaSet.Add(categoria);
            model1Container.SaveChanges();
            textBoxCate.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxMetPag.Text))
            {
                return;
            }
            model1Container = new Model1Container();
            MetodoPagamento pagamento = new MetodoPagamento();
            pagamento.TipoPagamento = textBoxMetPag.Text;

            model1Container.MetodoPagamentoSet.Add(pagamento);
            model1Container.SaveChanges();
            textBoxMetPag.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var myForm = new FormRestauranteInd();
            myForm.Show();
            this.Close();
        }
    }
}
