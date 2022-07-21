using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJETODAEXAME
{
    public partial class FormMenu : Form
    {
        public Restaurante restauranteSelecionado;
        Model1Container model1Container;
        public FormMenu(Restaurante idRestaurante)
        {
            
            model1Container = new Model1Container();
            this.restauranteSelecionado = model1Container.RestauranteSet.Find(idRestaurante.Id);
            InitializeComponent();

            labelNomeRestaurante.Text = restauranteSelecionado.Nome;

            cbCategoriasItens.Items.Add("Todas");
            LerDadosItems();
            LerDadosMenu();
            LerDadosCategoria();
            cbCategoriasItens.SelectedIndex = 0;

            //comboBoxItemAtivo.Items.Add("Sim");
            //comboBoxItemAtivo.Items.Add("Não");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

       

        private void FormMenu_Load(object sender, EventArgs e)
        {
       
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            var myForm = new FormPrincipal();
            myForm.Show();
            this.Close();
        }

        private void LerDadosItems()
        {

            listBoxItens.Items.Clear();
            if (cbCategoriasItens.SelectedIndex == -1 || cbCategoriasItens.SelectedIndex == 0)
            {
                foreach (var item in model1Container.ItemMenuSet)
                {
                    listBoxItens.Items.Add(item);
                }
            }
            else
            {
                String categoriaSelecionada = (string)cbCategoriasItens.SelectedItem;
                foreach (ItemMenu itemMenu in model1Container.ItemMenuSet)
                {
                    if (itemMenu.Categoria.Nome == categoriaSelecionada)
                    {
                        listBoxItens.Items.Add(itemMenu);
                    }
                }
            }
            
        }

        
        

            private void LerDadosCategoria()
        {
            foreach (var categoria in model1Container.CategoriaSet)
            {
                if (categoria.Ativo == true)
                {
                    cbCategoriasCriarItem.Items.Add(categoria);
                    cbCategoriasItens.Items.Add(categoria.Nome);
                }
            }

        }

        private void cbCategoriasItens_SelectedIndexChanged(object sender, EventArgs e)
        {
            LerDadosItems();
        }

        private void btnAdicionarMenu_Click(object sender, EventArgs e)
        {
            ItemMenu itemSelecionado = (ItemMenu)listBoxItens.SelectedItem;
            restauranteSelecionado.ItemMenu.Add(itemSelecionado);
            model1Container.SaveChanges();
            LerDadosMenu();
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
            pictureBox1.Image = null;
            comboBoxAtivo.SelectedIndex = -1;
            cbCategoriasCriarItem.SelectedIndex = -1;
        }

        private void LerDadosMenu()
        {
            listBoxMenu.DataSource = restauranteSelecionado.ItemMenu.ToList<ItemMenu>();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ClearAllText(this);
            btnRegistarItem.Enabled = true;
            btnRegistarItem.Visible = true;
            buttonAdd.Visible = false;
            buttonAdd.Enabled = false;
            buttonCancel.Visible = true;
            buttonCancel.Enabled = true;
            buttonAlterar.Enabled = false;
            groupBoxdadosItem.Enabled = true;
            listBoxItens.SelectedIndex = -1;
        }

        private void btnRegistarItem_Click(object sender, EventArgs e)
        {
            ItemMenu itemMenu = new ItemMenu();

            try
            {
                if (txtFilePath.Text == null || tbNomeItem.Text == null || tbIngredientes.Text == null || tbPreçoItem.Text == null || comboBoxAtivo.SelectedItem == null || cbCategoriasCriarItem.SelectedItem == null)
                {
                    MessageBox.Show("Introduza todos os dados.", "Erro");
                    return;
                }
                else
                {

                    //Read Image Bytes into a byte array
                    byte[] imageData = ReadFile(txtFilePath.Text);
                    itemMenu.Nome = tbNomeItem.Text;
                    itemMenu.Ingredientes = tbIngredientes.Text;
                    itemMenu.Preço = Convert.ToDouble(tbPreçoItem.Text);
                    if (comboBoxAtivo.SelectedItem.ToString() == "0") 
                    {
                        itemMenu.Ativo = true;
                    }
                    else 
                    { 
                        itemMenu.Ativo = false; 
                    }
                    
                    itemMenu.Fotografia = imageData;
                    itemMenu.Categoria = (Categoria)cbCategoriasCriarItem.SelectedItem;


                    model1Container.ItemMenuSet.Add(itemMenu);
                    model1Container.SaveChanges();
                    LerDadosMenu();
                    LerDadosItems();
                    ClearAllText(this);
                    buttonAlterar.Enabled = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            byte[] ReadFile(string sPath)
            {
                //Initialize byte array with a null value initially.
                byte[] data = null;

                //Use FileInfo object to get file size.
                FileInfo fInfo = new FileInfo(sPath);
                long numBytes = fInfo.Length;

                //Open FileStream to read file
                FileStream fStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);

                //Use BinaryReader to read file stream into byte array.
                BinaryReader br = new BinaryReader(fStream);

                //When you use BinaryReader, you need to supply number of bytes to read from file.
                //In this case we want to read entire file. So supplying total number of bytes.
                data = br.ReadBytes((int)numBytes);
                return data;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Ask user to select file.
            OpenFileDialog dlg = new OpenFileDialog();
            DialogResult dlgRes = dlg.ShowDialog();
            if (dlgRes != DialogResult.Cancel)
            {
                //Set image in picture box
                pictureBox1.ImageLocation = dlg.FileName;

                //Provide file path in txtImagePath text box.
                txtFilePath.Text = dlg.FileName;
            }
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            var myForm = new FormPrincipal();
            myForm.Show();
            this.Close();
        }

        private void listBoxItens_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ItemMenu itemSelecionado = (ItemMenu)listBoxItens.SelectedItem;
            if (itemSelecionado == null)
            {
                return;
            }
            else
            {
                byte[] imageData = itemSelecionado.Fotografia;

                //Initialize image variable
                Image newImage;
                //Read image data into a memory stream
                using (MemoryStream ms = new MemoryStream(imageData, 0, imageData.Length))
                {
                    ms.Write(imageData, 0, imageData.Length);

                    //Set image variable value using memory stream.
                    newImage = Image.FromStream(ms, true);
                }



                tbNomeItem.Text = itemSelecionado.Nome;
                tbIngredientes.Text = itemSelecionado.Ingredientes;
                tbPreçoItem.Text = Convert.ToString(itemSelecionado.Preço);
                if (itemSelecionado.Ativo == true)
                {
                    comboBoxAtivo.SelectedIndex = 0;
                }
                else
                {
                    comboBoxAtivo.SelectedIndex = 1;
                }
                cbCategoriasCriarItem.Text = itemSelecionado.Categoria.Nome;
                pictureBox1.Image = newImage;
                txtFilePath.Text = Convert.ToString(itemSelecionado.Fotografia);
            }
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            if (listBoxItens.SelectedItem == null)
            {
                return;
            }
            btnAlterarDadosItem.Enabled = true;
            btnAlterarDadosItem.Visible = true;
            buttonAlterar.Enabled = false;
            buttonAlterar.Visible = false;
            buttonCancelarAlt.Enabled = true;
            buttonCancelarAlt.Visible = true;
            buttonAdd.Enabled = false;
        }

        private void buttonCancelarAlt_Click(object sender, EventArgs e)
        {
            btnAlterarDadosItem.Enabled = false;
            btnAlterarDadosItem.Visible = false;
            buttonAlterar.Enabled = true;
            buttonAlterar.Visible = true;
            buttonCancelarAlt.Enabled = false;
            buttonCancelarAlt.Visible = false;
            buttonAdd.Enabled = true;
        }

        private void btnAdicionarMenu_Click_1(object sender, EventArgs e)
        {
            ItemMenu itemSelecionado = (ItemMenu)listBoxItens.SelectedItem;
            restauranteSelecionado.ItemMenu.Add(itemSelecionado);
            model1Container.SaveChanges();
            LerDadosMenu();
        }

        private void btnAlterarDadosItem_Click(object sender, EventArgs e)
        {
            ItemMenu itemSelecionado = (ItemMenu)listBoxItens.SelectedItem;
            if (itemSelecionado == null)
            {
                return;
            }

            // Introduzir dados dos items
            itemSelecionado.Nome = tbNomeItem.Text;
            itemSelecionado.Ingredientes = tbIngredientes.Text;
            itemSelecionado.Preço = Convert.ToDouble(tbPreçoItem.Text);
            if (comboBoxAtivo.SelectedIndex.ToString() == "0")
            {
                itemSelecionado.Ativo = true;
            }
            else 
            {
                itemSelecionado.Ativo = false;
            }
            itemSelecionado.Nome = tbNomeItem.Text;
            itemSelecionado.Categoria = (Categoria)cbCategoriasCriarItem.SelectedItem;

            model1Container.SaveChanges();
            LerDadosItems();
            buttonAdd.Enabled = true;
            buttonCancelarAlt.Visible = false;
            btnAlterarDadosItem.Visible = false;
            buttonAlterar.Enabled = true;
            buttonAlterar.Visible = true;
            listBoxItens.SelectedIndex = -1;

        }
    }
}
