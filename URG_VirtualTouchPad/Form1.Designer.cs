namespace URG_VirtualTouchPad {
    partial class Form1 {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent() {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.MaxX = new System.Windows.Forms.NumericUpDown();
            this.MinX = new System.Windows.Forms.NumericUpDown();
            this.MinY = new System.Windows.Forms.NumericUpDown();
            this.MaxY = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Log = new System.Windows.Forms.TextBox();
            this.BindMouseButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.OffsetY_Label = new System.Windows.Forms.Label();
            this.OffsetX_Label = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.offsetY_Control = new System.Windows.Forms.TrackBar();
            this.offsetX_Control = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AutoClickCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxY)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.offsetY_Control)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetX_Control)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StartButton);
            this.groupBox1.Controls.Add(this.MaxX);
            this.groupBox1.Controls.Add(this.MinX);
            this.groupBox1.Controls.Add(this.MinY);
            this.groupBox1.Controls.Add(this.MaxY);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 141);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "環境設定";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(250, 21);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(99, 109);
            this.StartButton.TabIndex = 13;
            this.StartButton.Text = "開始";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // MaxX
            // 
            this.MaxX.Location = new System.Drawing.Point(124, 104);
            this.MaxX.Maximum = new decimal(new int[] {
            6000,
            0,
            0,
            0});
            this.MaxX.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.MaxX.Name = "MaxX";
            this.MaxX.Size = new System.Drawing.Size(120, 22);
            this.MaxX.TabIndex = 12;
            this.MaxX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MaxX.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // MinX
            // 
            this.MinX.Location = new System.Drawing.Point(124, 77);
            this.MinX.Maximum = new decimal(new int[] {
            6000,
            0,
            0,
            0});
            this.MinX.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.MinX.Name = "MinX";
            this.MinX.Size = new System.Drawing.Size(120, 22);
            this.MinX.TabIndex = 11;
            this.MinX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MinX.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // MinY
            // 
            this.MinY.Location = new System.Drawing.Point(124, 49);
            this.MinY.Maximum = new decimal(new int[] {
            6000,
            0,
            0,
            0});
            this.MinY.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.MinY.Name = "MinY";
            this.MinY.Size = new System.Drawing.Size(120, 22);
            this.MinY.TabIndex = 10;
            this.MinY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MinY.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // MaxY
            // 
            this.MaxY.Location = new System.Drawing.Point(124, 21);
            this.MaxY.Maximum = new decimal(new int[] {
            6000,
            0,
            0,
            0});
            this.MaxY.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.MaxY.Name = "MaxY";
            this.MaxY.Size = new System.Drawing.Size(120, 22);
            this.MaxY.TabIndex = 9;
            this.MaxY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MaxY.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "螢幕右邊距離(毫米):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "螢幕左邊偏移(毫米):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "螢幕底端高度(毫米):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "螢幕頂端高度(毫米):";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AutoClickCheckBox);
            this.groupBox2.Controls.Add(this.Log);
            this.groupBox2.Controls.Add(this.BindMouseButton);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(12, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 278);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "運行資訊";
            // 
            // Log
            // 
            this.Log.Location = new System.Drawing.Point(8, 57);
            this.Log.Multiline = true;
            this.Log.Name = "Log";
            this.Log.ReadOnly = true;
            this.Log.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Log.Size = new System.Drawing.Size(335, 215);
            this.Log.TabIndex = 1;
            // 
            // BindMouseButton
            // 
            this.BindMouseButton.Location = new System.Drawing.Point(8, 21);
            this.BindMouseButton.Name = "BindMouseButton";
            this.BindMouseButton.Size = new System.Drawing.Size(252, 30);
            this.BindMouseButton.TabIndex = 0;
            this.BindMouseButton.Text = "啟用滑鼠連動";
            this.BindMouseButton.UseVisualStyleBackColor = true;
            this.BindMouseButton.Click += new System.EventHandler(this.BindMouseButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.OffsetY_Label);
            this.groupBox3.Controls.Add(this.OffsetX_Label);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.offsetY_Control);
            this.groupBox3.Controls.Add(this.offsetX_Control);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(373, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(445, 425);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "誤差校正";
            // 
            // OffsetY_Label
            // 
            this.OffsetY_Label.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OffsetY_Label.Location = new System.Drawing.Point(174, 86);
            this.OffsetY_Label.Name = "OffsetY_Label";
            this.OffsetY_Label.Size = new System.Drawing.Size(100, 32);
            this.OffsetY_Label.TabIndex = 9;
            this.OffsetY_Label.Text = "0px";
            this.OffsetY_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // OffsetX_Label
            // 
            this.OffsetX_Label.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OffsetX_Label.Location = new System.Drawing.Point(174, 11);
            this.OffsetX_Label.Name = "OffsetX_Label";
            this.OffsetX_Label.Size = new System.Drawing.Size(100, 32);
            this.OffsetX_Label.TabIndex = 8;
            this.OffsetX_Label.Text = "0px";
            this.OffsetX_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(420, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 12);
            this.label10.TabIndex = 7;
            this.label10.Text = "下";
            // 
            // offsetY_Control
            // 
            this.offsetY_Control.Location = new System.Drawing.Point(8, 121);
            this.offsetY_Control.Maximum = 1000;
            this.offsetY_Control.Minimum = -1000;
            this.offsetY_Control.Name = "offsetY_Control";
            this.offsetY_Control.Size = new System.Drawing.Size(431, 45);
            this.offsetY_Control.TabIndex = 2;
            this.offsetY_Control.Scroll += new System.EventHandler(this.offsetY_Control_Scroll);
            // 
            // offsetX_Control
            // 
            this.offsetX_Control.Location = new System.Drawing.Point(6, 46);
            this.offsetX_Control.Maximum = 1000;
            this.offsetX_Control.Minimum = -1000;
            this.offsetX_Control.Name = "offsetX_Control";
            this.offsetX_Control.Size = new System.Drawing.Size(431, 45);
            this.offsetX_Control.TabIndex = 0;
            this.offsetX_Control.Scroll += new System.EventHandler(this.offsetX_Control_Scroll);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 12);
            this.label9.TabIndex = 6;
            this.label9.Text = "上";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(420, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 5;
            this.label8.Text = "右";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "左";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "垂直校正:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "水平校正:";
            // 
            // AutoClickCheckBox
            // 
            this.AutoClickCheckBox.AutoSize = true;
            this.AutoClickCheckBox.Checked = true;
            this.AutoClickCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AutoClickCheckBox.Location = new System.Drawing.Point(266, 29);
            this.AutoClickCheckBox.Name = "AutoClickCheckBox";
            this.AutoClickCheckBox.Size = new System.Drawing.Size(72, 16);
            this.AutoClickCheckBox.TabIndex = 2;
            this.AutoClickCheckBox.Text = "自動點擊";
            this.AutoClickCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 449);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "虛擬觸控板";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxY)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.offsetY_Control)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetX_Control)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.NumericUpDown MaxX;
        private System.Windows.Forms.NumericUpDown MinX;
        private System.Windows.Forms.NumericUpDown MinY;
        private System.Windows.Forms.NumericUpDown MaxY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BindMouseButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox Log;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar offsetY_Control;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar offsetX_Control;
        private System.Windows.Forms.Label OffsetY_Label;
        private System.Windows.Forms.Label OffsetX_Label;
        private System.Windows.Forms.CheckBox AutoClickCheckBox;
    }
}

