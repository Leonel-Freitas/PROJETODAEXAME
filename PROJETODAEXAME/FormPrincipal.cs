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
    public partial class FormPrincipal : Form
    {
        public static Model1Container model1Container;
        public FormPrincipal()
        {
            model1Container = new Model1Container();
            InitializeComponent();
            lerDadosRestaurante();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var myForm = new FormPedido();
            myForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var myForm = new FormCliente();
            myForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var myForm = new FormRestauranteInd();
            myForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBoxRestaurantes.SelectedIndex == -1)
            {
                MessageBox.Show("Nenhum restaurante selecionado", "Erro");
                return;
            }
            else
            {
                Restaurante restauranteSelecionado = (Restaurante)listBoxRestaurantes.SelectedItem;
                FormMenu form = new FormMenu(restauranteSelecionado);
                form.Show();
                this.Hide();
            }
            
        }
        private void lerDadosRestaurante()
        {
            listBoxRestaurantes.DataSource = model1Container.RestauranteSet.ToList<Restaurante>();
            listBoxRestaurantes.SelectedIndex = -1;
        }


    }
}
