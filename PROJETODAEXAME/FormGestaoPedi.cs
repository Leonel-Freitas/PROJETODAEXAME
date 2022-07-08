﻿using System;
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
    public partial class FormGestaoPedi : Form
    {
        Model1Container model1Container;
        public FormGestaoPedi()
        {
            InitializeComponent();
        }

        private void FormGestaoPedi_Load(object sender, EventArgs e)
        {
            model1Container = new Model1Container();
            List<Pedido> listaPedidos = model1Container.PedidoSet.ToList<Pedido>();

            foreach (Pedido pedido in listaPedidos)
            {
                   listBox1.Items.Add(pedido);
            }
            List<MetodoPagamento> listaPagamento = model1Container.MetodoPagamentoSet.ToList<MetodoPagamento>();

            foreach (MetodoPagamento pagamento in listaPagamento)
            {
                comboBox2.Items.Add(pagamento);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                return;
            }

            Pedido pedido = (Pedido)listBox1.SelectedItem;

            if (comboBox1.SelectedIndex.ToString() == "0")
            {
                pedido.Estado.TipoEstado = "Cancelado";
            }
            else
            {
                pedido.Estado.TipoEstado = "Concluido";
            }
            
            

            model1Container.SaveChanges();
            listBox1.ClearSelected();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var myForm = new FormPedido();
            myForm.Show();
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pedido pedido = (Pedido)listBox1.SelectedItem;
            //string valor = Convert.ToString(pedido.ValorTotal);
            //label2.Text = valor;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pedido pedido = (Pedido)listBox1.SelectedItem;
            MetodoPagamento metodoPagamento = (MetodoPagamento)comboBox2.SelectedItem;
            Pagamento pagamento = new Pagamento();
            

            
            pagamento.Valor = pedido.ValorTotal;
            pagamento.Pedido = pedido;
            pagamento.MetodoPagamento = metodoPagamento;
            pedido.Estado.TipoEstado = "Em Processamento";
            pedido.Cliente.TotalGasto += pedido.ValorTotal;

            model1Container.PagamentoSet.Add(pagamento);
            model1Container.SaveChanges();

            listBox1.ClearSelected();
            comboBox2.ResetText();
        }
    }
}