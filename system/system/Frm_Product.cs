using system.dal;//classe system.dal
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace system
{
    public partial class Frm_Product : Form
    {
        SqlConnection cn;

        public Frm_Product()
        {
            InitializeComponent();
        }

        private void Frm_Product_Load(object sender, EventArgs e)
        {
            //permite alimentar o gridview e o dropdown com os dados das tabelas produtos e categoria de produtos
            this.tbprodutoBindingSource.DataSource = dataContextFactory.DataContext.produtos;
            this.categoriaBindingSource.DataSource = dataContextFactory.DataContext.categorias;

        }


        private void btn_exit_Click(object sender, EventArgs e)
        {   //permite cancelar o registo de produtos no formulario
            this.tbprodutoBindingSource.CancelEdit();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            //metodo que permite adicionar produto à base de dados
            this.tbprodutoBindingSource.AddNew();
            //this é o objeto, quando é criada a conexao é gerado o bindingsource, addnew é propriedade que permite adicionar

        }


        private bool checkData()//verifica se o textbox está vazio
        {
            if (string.IsNullOrEmpty(tb_name.Text) && string.IsNullOrEmpty(tb_description.Text) && string.IsNullOrEmpty(tb_ref.Text)
                && string.IsNullOrEmpty(tb_stock.Text) && string.IsNullOrEmpty(cb_category.Text))
            {
                MessageBox.Show("Para inserir produtos os campos não podem estar vazios!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }



        private void btn_register_Click(object sender, EventArgs e)
        {

            if (checkData())//se nenhum dos campos estiverem vazios
            {
                tbprodutoBindingSource.EndEdit();
                dataContextFactory.DataContext.SubmitChanges(); //faz as modificações na base de dados
                dataGridView1.Refresh();//permite que o griedview atualize
                MessageBox.Show("Produto inserido com sucesso");
            }
        }

        private void btn_new_Click_1(object sender, EventArgs e)
        {
            this.tbprodutoBindingSource.AddNew();//adicionar registo ao gridview
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
             {
                 string selectedFile = openFileDialog1.FileName;
             }*/



            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
            if (open.ShowDialog() == DialogResult.OK)
            {
                tb_image.Text = open.FileName;
            }
            try
            {
                if (cn == null)
                    cn = dataContextFactory.DataContext().;

                if ()
            }
            catch (Exception)
            {

                throw;
            }
            string image = tb_image.Text;
            Bitmap bmp = new Bitmap(image);
            FileStream fs = new FileStream(image, FileMode.Open, FileAccess.Read);
            byte[] bimage = new byte[fs.Length];
            fs.Read(bimage, 0, Convert.ToInt32(fs.Length));
            fs.Close();
            SqlCommand cmd = new SqlCommand("insert into tb_produto(imagem) values(@imgdata)", cn);
            cmd.Parameters.AddWithValue("@imgdata", SqlDbType.Image).Value = bimage;
            cmd.ExecuteNonQuery();
            cn.Close();

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Delete the selected category?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                //    if (this.HasProducts(getCategory))//verifica se a categoria selecionada tem produtos associados
                //      MessageBox.Show("Category cannot be removed, since it has been associated to products", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //else
                {
                    this.tbprodutoBindingSource.RemoveCurrent();
                    dataContextFactory.DataContext.SubmitChanges();
                    MessageBox.Show("Category has been removed!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btn_exit_Click_1(object sender, EventArgs e)
        {
            this.tbprodutoBindingSource.CancelEdit();

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
          //  if (e.Value != null && e.ColumnIndex == 5)//coluna 5 contem a descrição do tipo de categoria do produto
            //    e.Value = Convert.ToInt32(((categoria)e.Value).tipo_categoria);
        }
    }
}
