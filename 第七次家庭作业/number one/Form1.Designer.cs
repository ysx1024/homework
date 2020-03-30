namespace number_one
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLeng = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPer1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPer2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTh1 = new System.Windows.Forms.TextBox();
            this.txtTh2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rdoColor1 = new System.Windows.Forms.RadioButton();
            this.rdoColor2 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(728, 455);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 59);
            this.button1.TabIndex = 0;
            this.button1.Text = "draw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(816, 65);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(109, 28);
            this.txtN.TabIndex = 1;
            this.txtN.TextChanged += new System.EventHandler(this.txtN_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(695, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "深度";
            // 
            // txtLeng
            // 
            this.txtLeng.Location = new System.Drawing.Point(816, 122);
            this.txtLeng.Name = "txtLeng";
            this.txtLeng.Size = new System.Drawing.Size(109, 28);
            this.txtLeng.TabIndex = 3;
            this.txtLeng.TextChanged += new System.EventHandler(this.txtLeng_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(687, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "主干长度";
            // 
            // txtPer1
            // 
            this.txtPer1.Location = new System.Drawing.Point(816, 171);
            this.txtPer1.Name = "txtPer1";
            this.txtPer1.Size = new System.Drawing.Size(109, 28);
            this.txtPer1.TabIndex = 5;
            this.txtPer1.TextChanged += new System.EventHandler(this.txtPer1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(687, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "右分支长度比";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtPer2
            // 
            this.txtPer2.Location = new System.Drawing.Point(816, 224);
            this.txtPer2.Name = "txtPer2";
            this.txtPer2.Size = new System.Drawing.Size(109, 28);
            this.txtPer2.TabIndex = 7;
            this.txtPer2.TextChanged += new System.EventHandler(this.txtPer2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(687, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "左分支长度比";
            // 
            // txtTh1
            // 
            this.txtTh1.Location = new System.Drawing.Point(816, 283);
            this.txtTh1.Name = "txtTh1";
            this.txtTh1.Size = new System.Drawing.Size(109, 28);
            this.txtTh1.TabIndex = 9;
            this.txtTh1.TextChanged += new System.EventHandler(this.txtTh1_TextChanged);
            // 
            // txtTh2
            // 
            this.txtTh2.Location = new System.Drawing.Point(816, 330);
            this.txtTh2.Name = "txtTh2";
            this.txtTh2.Size = new System.Drawing.Size(109, 28);
            this.txtTh2.TabIndex = 10;
            this.txtTh2.TextChanged += new System.EventHandler(this.txtTh2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(687, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "右分支角度";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(687, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "左分支角度";
            // 
            // rdoColor1
            // 
            this.rdoColor1.AutoSize = true;
            this.rdoColor1.Location = new System.Drawing.Point(715, 397);
            this.rdoColor1.Name = "rdoColor1";
            this.rdoColor1.Size = new System.Drawing.Size(69, 22);
            this.rdoColor1.TabIndex = 13;
            this.rdoColor1.TabStop = true;
            this.rdoColor1.Text = "蓝色";
            this.rdoColor1.UseVisualStyleBackColor = true;
            this.rdoColor1.CheckedChanged += new System.EventHandler(this.rdoColor1_CheckedChanged);
            // 
            // rdoColor2
            // 
            this.rdoColor2.AutoSize = true;
            this.rdoColor2.Location = new System.Drawing.Point(816, 397);
            this.rdoColor2.Name = "rdoColor2";
            this.rdoColor2.Size = new System.Drawing.Size(69, 22);
            this.rdoColor2.TabIndex = 14;
            this.rdoColor2.TabStop = true;
            this.rdoColor2.Text = "橙色";
            this.rdoColor2.UseVisualStyleBackColor = true;
            this.rdoColor2.CheckedChanged += new System.EventHandler(this.rdoColor2_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(627, 517);
            this.panel1.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 526);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rdoColor2);
            this.Controls.Add(this.rdoColor1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTh2);
            this.Controls.Add(this.txtTh1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPer2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLeng);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Cayley树";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLeng;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPer2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTh1;
        private System.Windows.Forms.TextBox txtTh2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdoColor1;
        private System.Windows.Forms.RadioButton rdoColor2;
        private System.Windows.Forms.Panel panel1;
    }
}

