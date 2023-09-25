namespace bililive_dm_like_debounce
{
    partial class SettingsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.inputFreq = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.selectInterval = new System.Windows.Forms.RadioButton();
            this.selectFreq = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inputFreq)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "滤波密度";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // inputFreq
            // 
            this.inputFreq.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.inputFreq.Location = new System.Drawing.Point(80, 16);
            this.inputFreq.Maximum = new decimal(new int[] {
            114514000,
            0,
            0,
            0});
            this.inputFreq.Name = "inputFreq";
            this.inputFreq.Size = new System.Drawing.Size(120, 24);
            this.inputFreq.TabIndex = 2;
            this.inputFreq.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "滤波模式";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // selectInterval
            // 
            this.selectInterval.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.selectInterval.Location = new System.Drawing.Point(80, 48);
            this.selectInterval.Name = "selectInterval";
            this.selectInterval.Size = new System.Drawing.Size(120, 24);
            this.selectInterval.TabIndex = 4;
            this.selectInterval.TabStop = true;
            this.selectInterval.Text = "Interval";
            this.selectInterval.UseVisualStyleBackColor = true;
            // 
            // selectFreq
            // 
            this.selectFreq.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.selectFreq.Location = new System.Drawing.Point(80, 72);
            this.selectFreq.Name = "selectFreq";
            this.selectFreq.Size = new System.Drawing.Size(120, 24);
            this.selectFreq.TabIndex = 5;
            this.selectFreq.TabStop = true;
            this.selectFreq.Text = "Frequency";
            this.selectFreq.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(16, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 48);
            this.button1.TabIndex = 6;
            this.button1.Text = "保存配置";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "reset timer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(232, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "右边看着好空";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(424, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "总感觉怪怪的";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightPink;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("宋体", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(216, 156);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(296, 28);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "https://github.com/SakuraKoi/bililive_dm-like-debounce";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(272, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "窗口宽度拉太短了标题也放不下";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(216, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "那就随便打点字吧w";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.Turquoise;
            this.label7.Location = new System.Drawing.Point(232, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "占上地方一下就没什么不对劲了";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label8.Location = new System.Drawing.Point(448, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 26);
            this.label8.TabIndex = 14;
            this.label8.Text = "(迫真";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.LightPink;
            this.label9.Location = new System.Drawing.Point(216, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "最后此项目地址(点头";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.Magenta;
            this.label10.Location = new System.Drawing.Point(440, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 17);
            this.label10.TabIndex = 16;
            this.label10.Text = "这里还是好空";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 200);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.selectFreq);
            this.Controls.Add(this.selectInterval);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputFreq);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Like debouncer | v1-SNAPSHOT | Powered by.SakuraKooi";
            ((System.ComponentModel.ISupportInitialize)(this.inputFreq)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown inputFreq;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton selectInterval;
        private System.Windows.Forms.RadioButton selectFreq;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}