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
    public partial class Frm_Login : Form
    {
        public bool Logged = false;

        public Frm_Login()
        {
            InitializeComponent();
        }



        private void btn_login_Click(object sender, EventArgs e)
        {
            AdminLogIn();

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void AdminLogIn()
        {
            var admin_user = dataContextFactory.DataContext.admin_users.Count(
                x => x.email == tb_email_admin.Text.Trim() && x.palavra_passe == tb_password_admin.Text.Trim());

            if (admin_user > 0)
            {
                this.Logged = true;//sem o this dá erro, porque a variavel pertence ao formulario
                this.Dispose();//fecha a janela (formulario)
            }
            else
                MessageBox.Show("Email or password invalid!");
        }


    }
}
