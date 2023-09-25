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
            this.label3.Location = new System.Drawing.Point(216, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "右边看着好空";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(384, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "总感觉怪怪的";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(224, 152);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(248, 21);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "https://github.com/SakuraKoi/bililive_dm-like-debounce";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 200);
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
    }
}