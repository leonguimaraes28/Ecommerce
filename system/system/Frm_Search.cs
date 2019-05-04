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
    public partial class Frm_Search : Form
    {
        public Frm_Search()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//btn_search
        {
            this.search(Convert.ToInt32(cb_categories.SelectedValue));
        }

        //produtos porque renomeie no dbml caso contrario seria tb_produtos
        public void search (int IdCategory)
        {
            //variavel IDCategory, depois é verificado pelo datasource se algum campo da tabela produto
            //possui o mesmo codigo do IDCategory
            this.produtoBindingSource.DataSource = dataContextFactory.DataContext.produtos.Where(x => x.id_categoria == IdCategory);

        }

        private void Frm_Search_Load(object sender, EventArgs e)
        {
            this.produtoBindingSource.DataSource = dataContextFactory.DataContext.produtos;
            this.categoriaBindingSource.DataSource = dataContextFactory.DataContext.categorias;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 1)
                e.Value = ((produto)e.Value).nome;
        }
    }
}
