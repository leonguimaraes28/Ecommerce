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
    public partial class Frm_Category : Form
    {
        public Frm_Category()
        {
            InitializeComponent();

        }

       

         private void Frm_Category_Load(object sender, EventArgs e)
         {
            this.tbcategoriaBindingSource.DataSource = dataContextFactory.DataContext.categorias;//no evento load do formulário vai ser inseridos os dados 
         }

        /*   private void btn_newCategory_Click(object sender, EventArgs e)
           {   //metodo que permite adicionar

               this.tbcategoriaBindingSource.AddNew();//this é o objeto, quando é criada a conexao é gerado o bindingsource, addnew é propriedade que permite adicionar
           }
           */
       // private void btn_register_Click(object sender, EventArgs e)
        /* {
             if (checkData())
             {
                 this.tbcategoriaBindingSource.EndEdit();
                 dataContextFactory.DataContext.SubmitChanges();
                 MessageBox.Show("Category has been registered","Registered", MessageBoxButtons.OK, MessageBoxIcon.Information);

             }
         }*/

        /* private void btn_delete_Click(object sender, EventArgs e)
         {

             if (DialogResult.Yes == MessageBox.Show("Delete the Category "+selectedCategoryName.ToString()+"?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
             {
                 if (this.categoryHasProducts(getCategory))//verifica se a categoria selecionada tem produtos associados
                     MessageBox.Show("Category cannot be removed, since it has been associated to products", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 else
                 {
                     this.tbcategoriaBindingSource.RemoveCurrent();
                     dataContextFactory.DataContext.SubmitChanges();
                     MessageBox.Show("Category has been removed!","Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 }
             }
         }*/

         private bool checkData()//verifica se o textbox está vazio
         {
             if (!string.IsNullOrEmpty(tb_category.Text.Trim()))
                 return true;
             else
             {
                 MessageBox.Show("Category field cannot be empty!","Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 tb_category.Focus();
                 return false;
             }
         }

         private void btn_exit_Click(object sender, EventArgs e)
         {
             this.tbcategoriaBindingSource.CancelEdit();
         }

         public categoria getCategory
         {
             get
             {
                 return (categoria)this.tbcategoriaBindingSource.Current;//retorna a categoria selecionada
             }
         }

        private void btn_newCategory_Click_1(object sender, EventArgs e)
        {
            this.tbcategoriaBindingSource.AddNew();//this é o objeto, quando é criada a conexao é gerado o bindingsource, addnew é propriedade que permite adicionar

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            /*this.tbcategoriaBindingSource.RemoveCurrent();
            dataContextFactory.DataContext.SubmitChanges();
            MessageBox.Show("categoria excluida com sucesso");
            */


            if (DialogResult.Yes == MessageBox.Show("Delete the selected category?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                if (this.HasProducts(getCategory))//verifica se a categoria selecionada tem produtos associados
                    MessageBox.Show("Category cannot be removed, since it has been associated to products", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    this.tbcategoriaBindingSource.RemoveCurrent();
                    dataContextFactory.DataContext.SubmitChanges();
                    MessageBox.Show("Category has been removed!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


      /*  public categoria selectedCategory
        {
            get
            {
                return (categoria)this.tbcategoriaBindingSource.Current;
            }
        }
        */
        private bool HasProducts(categoria ctg)
        {
            var getProducts = dataContextFactory.DataContext.produtos.Where(x => x.id_categoria == ctg.id_categoria);
            if (getProducts.Count() > 0)
                return true;
            else
                return false;

        }

        private void btn_exit_Click_1(object sender, EventArgs e)
        {
            this.tbcategoriaBindingSource.CancelEdit();

        }

        private void btn_register_Click_1(object sender, EventArgs e)
        {
            if (checkData())//se o textbox não estiver vazio
            {
                this.tbcategoriaBindingSource.EndEdit();
                dataContextFactory.DataContext.SubmitChanges();
                MessageBox.Show("Category has been registered", "Registered", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }





        /*  private bool categoryHasProducts(tb_categoria ctg)//metodo que verifica se a categoria atual possui produtos associados
            {
                var getProducts = dataContextFactory.DataContext.Products.Where(x => x.IdCategory == ctg.IdCategory);
                if (getProducts.Count() > 0)
                    return true;
                else
                    return false;
            }

           public override string ToString()//sem o override ToString() a classe aparece como "system.dal.Category"
            {
                return base.ToString();
            }


            public Category selectedCategoryName
            {
                get
                {

                    return (Category)this.categoryBindingSource.Current;//retorna a categoria selecionada
                }
            }
            */
    }

}
