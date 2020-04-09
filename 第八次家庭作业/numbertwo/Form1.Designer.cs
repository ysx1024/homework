namespace numbertwo
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rB_Co = new System.Windows.Forms.RadioButton();
            this.rB_Cu = new System.Windows.Forms.RadioButton();
            this.rB_ID = new System.Windows.Forms.RadioButton();
            this.btn_Inq = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceSumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_Cu = new System.Windows.Forms.TextBox();
            this.txt_Pr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btn_Inq);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 141);
            this.panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(519, 22);
            this.textBox1.MaximumSize = new System.Drawing.Size(230, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 28);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.rB_Co);
            this.panel2.Controls.Add(this.rB_Cu);
            this.panel2.Controls.Add(this.rB_ID);
            this.panel2.Location = new System.Drawing.Point(379, 3);
            this.panel2.MaximumSize = new System.Drawing.Size(125, 127);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(125, 127);
            this.panel2.TabIndex = 3;
            // 
            // rB_Co
            // 
            this.rB_Co.AutoSize = true;
            this.rB_Co.Location = new System.Drawing.Point(17, 87);
            this.rB_Co.Name = "rB_Co";
            this.rB_Co.Size = new System.Drawing.Size(69, 22);
            this.rB_Co.TabIndex = 2;
            this.rB_Co.TabStop = true;
            this.rB_Co.Text = "商品";
            this.rB_Co.UseVisualStyleBackColor = true;
            this.rB_Co.CheckedChanged += new System.EventHandler(this.rB_Co_CheckedChanged);
            // 
            // rB_Cu
            // 
            this.rB_Cu.AutoSize = true;
            this.rB_Cu.Location = new System.Drawing.Point(17, 56);
            this.rB_Cu.Name = "rB_Cu";
            this.rB_Cu.Size = new System.Drawing.Size(69, 22);
            this.rB_Cu.TabIndex = 1;
            this.rB_Cu.TabStop = true;
            this.rB_Cu.Text = "客户";
            this.rB_Cu.UseVisualStyleBackColor = true;
            this.rB_Cu.CheckedChanged += new System.EventHandler(this.rB_Cu_CheckedChanged);
            // 
            // rB_ID
            // 
            this.rB_ID.AutoSize = true;
            this.rB_ID.Location = new System.Drawing.Point(17, 22);
            this.rB_ID.Name = "rB_ID";
            this.rB_ID.Size = new System.Drawing.Size(87, 22);
            this.rB_ID.TabIndex = 0;
            this.rB_ID.TabStop = true;
            this.rB_ID.Text = "订单号";
            this.rB_ID.UseVisualStyleBackColor = true;
            this.rB_ID.CheckedChanged += new System.EventHandler(this.rB_ID_CheckedChanged);
            // 
            // btn_Inq
            // 
            this.btn_Inq.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Inq.Location = new System.Drawing.Point(580, 73);
            this.btn_Inq.MaximumSize = new System.Drawing.Size(150, 50);
            this.btn_Inq.Name = "btn_Inq";
            this.btn_Inq.Size = new System.Drawing.Size(149, 50);
            this.btn_Inq.TabIndex = 2;
            this.btn_Inq.Text = "查询订单";
            this.btn_Inq.UseVisualStyleBackColor = true;
            this.btn_Inq.Click += new System.EventHandler(this.btn_Inq_Click);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add.Location = new System.Drawing.Point(207, 76);
            this.btn_add.MaximumSize = new System.Drawing.Size(150, 50);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(150, 50);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "添加订单";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn,
            this.priceSumDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(761, 333);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 141);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 0);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.Frozen = true;
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "订单号";
            this.orderIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "客户";
            this.customerDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            this.customerDataGridViewTextBoxColumn.Width = 150;
            // 
            // priceSumDataGridViewTextBoxColumn
            // 
            this.priceSumDataGridViewTextBoxColumn.DataPropertyName = "PriceSum";
            this.priceSumDataGridViewTextBoxColumn.HeaderText = "总价";
            this.priceSumDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.priceSumDataGridViewTextBoxColumn.Name = "priceSumDataGridViewTextBoxColumn";
            this.priceSumDataGridViewTextBoxColumn.Width = 150;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(numberone.Order);
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txt_Pr);
            this.panel3.Controls.Add(this.txt_Cu);
            this.panel3.Controls.Add(this.txt_ID);
            this.panel3.Location = new System.Drawing.Point(12, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(178, 140);
            this.panel3.TabIndex = 5;
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(81, 16);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(91, 28);
            this.txt_ID.TabIndex = 0;
            // 
            // txt_Cu
            // 
            this.txt_Cu.Location = new System.Drawing.Point(82, 62);
            this.txt_Cu.Name = "txt_Cu";
            this.txt_Cu.Size = new System.Drawing.Size(89, 28);
            this.txt_Cu.TabIndex = 1;
            // 
            // txt_Pr
            // 
            this.txt_Pr.Location = new System.Drawing.Point(84, 109);
            this.txt_Pr.Name = "txt_Pr";
            this.txt_Pr.Size = new System.Drawing.Size(86, 28);
            this.txt_Pr.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "订单号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "客户";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "总价";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 474);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_Inq;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceSumDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rB_Co;
        private System.Windows.Forms.RadioButton rB_Cu;
        private System.Windows.Forms.RadioButton rB_ID;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Pr;
        private System.Windows.Forms.TextBox txt_Cu;
        private System.Windows.Forms.TextBox txt_ID;
    }
}

