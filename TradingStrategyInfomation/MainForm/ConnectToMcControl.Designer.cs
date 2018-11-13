namespace TradingStrategyInfomation.MainForm
{
    partial class ConnectToMcControl
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_PositionClass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_ConMc = new System.Windows.Forms.Button();
            this.textBox_title = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_NowMcItem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_publish = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_PositionClass);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button_ConMc);
            this.groupBox1.Controls.Add(this.textBox_title);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(419, 111);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "尝试连接Multichars";
            // 
            // textBox_PositionClass
            // 
            this.textBox_PositionClass.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBox_PositionClass.Location = new System.Drawing.Point(214, 51);
            this.textBox_PositionClass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_PositionClass.Name = "textBox_PositionClass";
            this.textBox_PositionClass.ReadOnly = true;
            this.textBox_PositionClass.Size = new System.Drawing.Size(171, 21);
            this.textBox_PositionClass.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 29);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "目标输出窗口的类名：";
            // 
            // button_ConMc
            // 
            this.button_ConMc.ForeColor = System.Drawing.Color.OrangeRed;
            this.button_ConMc.Location = new System.Drawing.Point(278, 79);
            this.button_ConMc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_ConMc.Name = "button_ConMc";
            this.button_ConMc.Size = new System.Drawing.Size(97, 18);
            this.button_ConMc.TabIndex = 2;
            this.button_ConMc.Text = "开始链接";
            this.button_ConMc.UseVisualStyleBackColor = true;
            this.button_ConMc.Click += new System.EventHandler(this.button_ConMc_Click);
            // 
            // textBox_title
            // 
            this.textBox_title.Location = new System.Drawing.Point(20, 51);
            this.textBox_title.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.Size = new System.Drawing.Size(171, 21);
            this.textBox_title.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "填写Multicharts-公式编辑器句柄：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_publish);
            this.groupBox2.Controls.Add(this.textBox_NowMcItem);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(0, 111);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(419, 189);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "获取品种属性";
            // 
            // textBox_NowMcItem
            // 
            this.textBox_NowMcItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBox_NowMcItem.Location = new System.Drawing.Point(140, 51);
            this.textBox_NowMcItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_NowMcItem.Name = "textBox_NowMcItem";
            this.textBox_NowMcItem.ReadOnly = true;
            this.textBox_NowMcItem.Size = new System.Drawing.Size(210, 21);
            this.textBox_NowMcItem.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 56);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "公式编辑器最新条目;";
            // 
            // button_publish
            // 
            this.button_publish.ForeColor = System.Drawing.Color.OrangeRed;
            this.button_publish.Location = new System.Drawing.Point(278, 95);
            this.button_publish.Margin = new System.Windows.Forms.Padding(2);
            this.button_publish.Name = "button_publish";
            this.button_publish.Size = new System.Drawing.Size(97, 18);
            this.button_publish.TabIndex = 6;
            this.button_publish.Text = "发布行情到redis";
            this.button_publish.UseVisualStyleBackColor = true;
            this.button_publish.Click += new System.EventHandler(this.button_publish_Click);
            // 
            // ConnectToMcControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ConnectToMcControl";
            this.Size = new System.Drawing.Size(419, 300);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_title;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_ConMc;
        private System.Windows.Forms.TextBox textBox_NowMcItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_PositionClass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_publish;
    }
}
