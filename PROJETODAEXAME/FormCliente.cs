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
            model1Container = new Model1Container();
            InitializeComponent();
            lerDadosCliente();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearAllText(this);
            btnRegistarCliente.Enabled = true;
            btnRegistarCliente.Visible = true;
            Editar.Enabled = false;
            Editar.Visible = false;
            ListboxCliente.SelectedIndex = -1;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            var myForm = new FormPrincipal();
            myForm.Show();
            this.Close();
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {

            Morada morada = new Morada();

            Cliente clienteSelecionado = (Cliente)ListboxCliente.SelectedItem;
            if (clienteSelecionado == null)
            {
                MessageBox.Show("Selecione um cliente", "Erro");
                return;
            }
            if (string.IsNullOrEmpty(textBoxNome.Text) || string.IsNullOrEmpty(textBoxRua.Text) || string.IsNullOrEmpty(textBoxCidade.Text) || string.IsNullOrEmpty(textBoxCodPost.Text) || string.IsNullOrEmpty(textBoxPais.Text) || string.IsNullOrEmpty(textBoxTele.Text) || string.IsNullOrEmpty(textBoxNumCont.Text))
            {
                MessageBox.Show("Introduza todos os campos no formulário.", "Erro");
                return;
            }
            else
            {
                var cliente = model1Container.PessoaSet.Find(clienteSelecionado.Id);

                cliente.Nome = textBoxNome.Text;

                if (textBoxTele.TextLength < 9)
                {
                    MessageBox.Show("Telemovel Incorreto.", "Erro");
                    return;
                }
                else
                {
                    Int32.TryParse(textBoxTele.Text, out int resultado);
                    cliente.Telemovel = resultado;
                }

                // Introduzir dados da morada
                cliente.Morada.Rua = textBoxRua.Text;
                cliente.Morada.Cidade = textBoxCidade.Text;
                if (textBoxCodPost.TextLength < 7)
                {
                    MessageBox.Show("Código Postal Incorreto", "Erro");
                    return;
                }
                else
                {
                    cliente.Morada.CodPostal = textBoxCodPost.Text;
                }
                cliente.Morada.Pais = textBoxPais.Text;

                model1Container.SaveChanges();
                lerDadosCliente();
                MessageBox.Show("Dados alterados com sucesso!", "Sucesso");

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = (Cliente)ListboxCliente.SelectedItem;
            if (clienteSelecionado == null)
            {
                return;
            }
            string tele = Convert.ToString(clienteSelecionado.Telemovel);
            string numCo = Convert.ToString(clienteSelecionado.NumContribuinte);
            textBoxNome.Text = clienteSelecionado.Nome;
            textBoxTele.Text = tele;

            // Introduzir dados da morada
            textBoxRua.Text = clienteSelecionado.Morada.Rua;
            textBoxCidade.Text = clienteSelecionado.Morada.Cidade;
            textBoxCodPost.Text = clienteSelecionado.Morada.CodPostal;
            textBoxPais.Text = clienteSelecionado.Morada.Pais;
            textBoxNumCont.Text = numCo;


        }

        private void lerDadosCliente()
        {

            ListboxCliente.DataSource = model1Container.PessoaSet.OfType<Cliente>().ToList<Pessoa>();
        }

        private void btnApagarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente clienteSelecionado = (Cliente)ListboxCliente.SelectedItem;
                if (clienteSelecionado == null)
                {
                    MessageBox.Show("Selecione um cliente");
                    return;
                }


                model1Container.PessoaSet.Remove(clienteSelecionado);
                model1Container.SaveChanges();
                lerDadosCliente();
            }
            catch (Exception)
            {
                MessageBox.Show("Não pode apagar este cliente!", "Erro");
            }
        }

        void ClearAllText(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else
                    ClearAllText(c);
            }

        }

        private void btnRegistarCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            Morada morada = new Morada();
            if (string.IsNullOrEmpty(textBoxNome.Text) || string.IsNullOrEmpty(textBoxRua.Text) || string.IsNullOrEmpty(textBoxCidade.Text) || string.IsNullOrEmpty(textBoxCodPost.Text) || string.IsNullOrEmpty(textBoxPais.Text) || string.IsNullOrEmpty(textBoxTele.Text) || string.IsNullOrEmpty(textBoxNumCont.Text))
            {
                MessageBox.Show("Introduza todos os campos no formulário.");
                return;
            }
            else
            {
                Int32.TryParse(textBoxTele.Text, out int resultado);
                Int32.TryParse(textBoxNumCont.Text, out int resultado2);
                // Introduzir dados do cliente
                cliente.Nome = textBoxNome.Text;
                cliente.TotalGasto = 0;
                if (textBoxTele.TextLength < 9)
                {
                    MessageBox.Show("Telemovel Incorreto.");
                    return;
                }
                else
                {
                    cliente.Telemovel = resultado;
                }

                // Introduzir dados da morada
                morada.Rua = textBoxRua.Text;
                morada.Cidade = textBoxCidade.Text;
                if (textBoxCodPost.TextLength < 7)
                {
                    MessageBox.Show("Código Postal Incorreto");
                    return;
                }
                else
                {
                   morada.CodPostal = textBoxCodPost.Text; ;
                }
                morada.Pais = textBoxPais.Text;
                cliente.NumContribuinte = resultado2;

                //adicionar os dados para a base de Dados
                cliente.Morada = morada;
                model1Container.PessoaSet.Add(cliente);
                model1Container.SaveChanges();
                lerDadosCliente();
            }
        }

        private void btnApagarCliente1_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente clienteSelecionado = (Cliente)ListboxCliente.SelectedItem;
                if (clienteSelecionado == null)
                {
                    MessageBox.Show("Selecione um cliente");
                    return;
                }


                model1Container.PessoaSet.Remove(clienteSelecionado);
                model1Container.SaveChanges();
                lerDadosCliente();
            }
            catch (Exception)
            {
                MessageBox.Show("Não pode apagar este cliente!", "Erro");
            }
        }
    }
}
