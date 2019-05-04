using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using system.dal;
namespace system
{
    public partial class Frm_Sales : Form
    {
        public Frm_Sales()
        {
            InitializeComponent();
        }

        private void Frm_Sales_Load(object sender, EventArgs e)
        {
            this.clienteBindingSource.DataSource = dataContextFactory.DataContext.clientes;
            this.vendaBindingSource.DataSource = dataContextFactory.DataContext.vendas;
            this.produtoBindingSource.DataSource = dataContextFactory.DataContext.produtos;

            this.vendaBindingSource.AddNew();
        }

        private void btn_sales_Click(object sender, EventArgs e)
        {
         //   this.vendaBindingSource.EndEdit();
            dataContextFactory.DataContext.SubmitChanges();//grava na base de dados
            groupBox1.Visible = true;//tornar visivel o group box
            btn_sales.Enabled = false;

            this.itemvendaBindingSource.DataSource = dataContextFactory.DataContext.item_vendas.Where(x => x.id_produto == this.CurrentSale.id_venda);
        }

        private void btn_item_Click(object sender, EventArgs e)
        {
            this.itemvendaBindingSource.EndEdit();
            dataGridView1.Refresh();
            dataContextFactory.DataContext.SubmitChanges();
            NewItem();

        }

        private void NewItem()
        {
            this.itemvendaBindingSource.AddNew();
            this.CurrentItem.id_venda = this.CurrentSale.id_venda;
            this.CurrentItem.quantidade = 1;
        }

        public venda CurrentSale
        {
            get
            {
                return (venda)this.vendaBindingSource.Current;
            }
        }
        public item_venda CurrentItem
        {
            get
            {
                return (item_venda)this.itemvendaBindingSource.Current;
            }
        }

    }
}
