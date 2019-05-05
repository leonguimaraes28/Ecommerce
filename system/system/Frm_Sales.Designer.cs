namespace system
{
    partial class Frm_Sales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Cliente = new System.Windows.Forms.Label();
            this.cb_client = new System.Windows.Forms.ComboBox();
            this.vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_sales = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.itemvendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_value = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_item = new System.Windows.Forms.Button();
            this.idprodutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_value_sales = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_descount_sales = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_total_value = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_finish_request = new System.Windows.Forms.Button();
            this.btn_finish_sale = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemvendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Cliente
            // 
            this.Cliente.AutoSize = true;
            this.Cliente.Location = new System.Drawing.Point(195, 51);
            this.Cliente.Name = "Cliente";
            this.Cliente.Size = new System.Drawing.Size(51, 17);
            this.Cliente.TabIndex = 0;
            this.Cliente.Text = "Cliente";
            // 
            // cb_client
            // 
            this.cb_client.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vendaBindingSource, "id_venda", true));
            this.cb_client.DataSource = this.clienteBindingSource;
            this.cb_client.DisplayMember = "nome_cliente";
            this.cb_client.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_client.FormattingEnabled = true;
            this.cb_client.Location = new System.Drawing.Point(293, 48);
            this.cb_client.Name = "cb_client";
            this.cb_client.Size = new System.Drawing.Size(157, 24);
            this.cb_client.TabIndex = 1;
            this.cb_client.ValueMember = "id_cliente";
            // 
            // vendaBindingSource
            // 
            this.vendaBindingSource.DataSource = typeof(system.dal.venda);
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(system.dal.cliente);
            // 
            // btn_sales
            // 
            this.btn_sales.Location = new System.Drawing.Point(484, 45);
            this.btn_sales.Name = "btn_sales";
            this.btn_sales.Size = new System.Drawing.Size(115, 23);
            this.btn_sales.TabIndex = 2;
            this.btn_sales.Text = "Nova venda";
            this.btn_sales.UseVisualStyleBackColor = true;
            this.btn_sales.Click += new System.EventHandler(this.btn_sales_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_item);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.tb_value);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(49, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1016, 415);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nova venda";
            this.groupBox1.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itemvendaBindingSource, "id_produto", true));
            this.comboBox1.DataSource = this.produtoBindingSource;
            this.comboBox1.DisplayMember = "nome";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(223, 88);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.ValueMember = "id_produto";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idprodutoDataGridViewTextBoxColumn,
            this.produtoDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn,
            this.vendaDataGridViewTextBoxColumn,
            this.Column1});
            this.dataGridView1.DataSource = this.itemvendaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 215);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1004, 200);
            this.dataGridView1.TabIndex = 8;
            // 
            // itemvendaBindingSource
            // 
            this.itemvendaBindingSource.DataSource = typeof(system.dal.item_venda);
            // 
            // tb_value
            // 
            this.tb_value.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "preco", true));
            this.tb_value.Location = new System.Drawing.Point(223, 167);
            this.tb_value.Name = "tb_value";
            this.tb_value.ReadOnly = true;
            this.tb_value.Size = new System.Drawing.Size(121, 22);
            this.tb_value.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(223, 127);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 22);
            this.textBox3.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(223, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(121, 22);
            this.textBox1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantidade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo Produto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo da Venda";
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataSource = typeof(system.dal.produto);
            // 
            // btn_item
            // 
            this.btn_item.Location = new System.Drawing.Point(399, 166);
            this.btn_item.Name = "btn_item";
            this.btn_item.Size = new System.Drawing.Size(115, 23);
            this.btn_item.TabIndex = 4;
            this.btn_item.Text = "Novo Item";
            this.btn_item.UseVisualStyleBackColor = true;
            this.btn_item.Click += new System.EventHandler(this.btn_item_Click);
            // 
            // idprodutoDataGridViewTextBoxColumn
            // 
            this.idprodutoDataGridViewTextBoxColumn.DataPropertyName = "id_produto";
            this.idprodutoDataGridViewTextBoxColumn.HeaderText = "id_produto";
            this.idprodutoDataGridViewTextBoxColumn.Name = "idprodutoDataGridViewTextBoxColumn";
            this.idprodutoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // produtoDataGridViewTextBoxColumn
            // 
            this.produtoDataGridViewTextBoxColumn.DataPropertyName = "produto";
            this.produtoDataGridViewTextBoxColumn.HeaderText = "produto";
            this.produtoDataGridViewTextBoxColumn.Name = "produtoDataGridViewTextBoxColumn";
            this.produtoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            this.quantidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "valor";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.valorDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.valorDataGridViewTextBoxColumn.HeaderText = "valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            this.valorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vendaDataGridViewTextBoxColumn
            // 
            this.vendaDataGridViewTextBoxColumn.DataPropertyName = "venda";
            this.vendaDataGridViewTextBoxColumn.HeaderText = "venda";
            this.vendaDataGridViewTextBoxColumn.Name = "vendaDataGridViewTextBoxColumn";
            this.vendaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id_item";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "Total Value";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // tb_value_sales
            // 
            this.tb_value_sales.Location = new System.Drawing.Point(741, 523);
            this.tb_value_sales.Name = "tb_value_sales";
            this.tb_value_sales.ReadOnly = true;
            this.tb_value_sales.Size = new System.Drawing.Size(121, 22);
            this.tb_value_sales.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(598, 523);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Codigo da Venda";
            // 
            // tb_descount_sales
            // 
            this.tb_descount_sales.Location = new System.Drawing.Point(741, 571);
            this.tb_descount_sales.Name = "tb_descount_sales";
            this.tb_descount_sales.ReadOnly = true;
            this.tb_descount_sales.Size = new System.Drawing.Size(121, 22);
            this.tb_descount_sales.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(598, 571);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Codigo da Venda";
            // 
            // tb_total_value
            // 
            this.tb_total_value.Location = new System.Drawing.Point(741, 621);
            this.tb_total_value.Name = "tb_total_value";
            this.tb_total_value.ReadOnly = true;
            this.tb_total_value.Size = new System.Drawing.Size(121, 22);
            this.tb_total_value.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(598, 621);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Codigo da Venda";
            // 
            // btn_finish_request
            // 
            this.btn_finish_request.Location = new System.Drawing.Point(899, 523);
            this.btn_finish_request.Name = "btn_finish_request";
            this.btn_finish_request.Size = new System.Drawing.Size(160, 23);
            this.btn_finish_request.TabIndex = 10;
            this.btn_finish_request.Text = "Finish Request";
            this.btn_finish_request.UseVisualStyleBackColor = true;
            // 
            // btn_finish_sale
            // 
            this.btn_finish_sale.Location = new System.Drawing.Point(899, 565);
            this.btn_finish_sale.Name = "btn_finish_sale";
            this.btn_finish_sale.Size = new System.Drawing.Size(160, 23);
            this.btn_finish_sale.TabIndex = 11;
            this.btn_finish_sale.Text = "Finish Sale";
            this.btn_finish_sale.UseVisualStyleBackColor = true;
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(893, 618);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(166, 23);
            this.btn_print.TabIndex = 12;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = true;
            // 
            // Frm_Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 667);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.btn_finish_sale);
            this.Controls.Add(this.btn_finish_request);
            this.Controls.Add(this.tb_total_value);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_descount_sales);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_value_sales);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_sales);
            this.Controls.Add(this.cb_client);
            this.Controls.Add(this.Cliente);
            this.Name = "Frm_Sales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.Frm_Sales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemvendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Cliente;
        private System.Windows.Forms.ComboBox cb_client;
        private System.Windows.Forms.Button btn_sales;
        private System.Windows.Forms.BindingSource vendaBindingSource;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tb_value;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource itemvendaBindingSource;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private System.Windows.Forms.Button btn_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprodutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produtoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.TextBox tb_value_sales;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_descount_sales;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_total_value;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_finish_request;
        private System.Windows.Forms.Button btn_finish_sale;
        private System.Windows.Forms.Button btn_print;
    }
}