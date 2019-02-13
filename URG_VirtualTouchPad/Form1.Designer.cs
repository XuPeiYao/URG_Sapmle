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
            this.label12 = new System.Windows.Forms.Label();
            this.location = new System.Windows.Forms.ComboBox();
            this.BufferCount = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
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
            this.AutoClickCheckBox = new System.Windows.Forms.CheckBox();
            this.Log = new System.Windows.Forms.TextBox();
            this.BindMouseButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.OffsetY3_Label = new System.Windows.Forms.Label();
            this.OffsetX3_Label = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.offsetY3_Control = new System.Windows.Forms.TrackBar();
            this.offsetX3_Control = new System.Windows.Forms.TrackBar();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.OffsetY2_Label = new System.Windows.Forms.Label();
            this.OffsetX2_Label = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.offsetY2_Control = new System.Windows.Forms.TrackBar();
            this.offsetX2_Control = new System.Windows.Forms.TrackBar();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
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
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BufferCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxY)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.offsetY3_Control)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetX3_Control)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetY2_Control)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetX2_Control)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetY_Control)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetX_Control)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.location);
            this.groupBox1.Controls.Add(this.BufferCount);
            this.groupBox1.Controls.Add(this.label11);
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
            this.groupBox1.Size = new System.Drawing.Size(355, 396);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "環境設定";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 163);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 12);
            this.label12.TabIndex = 17;
            this.label12.Text = "感應器位置:";
            // 
            // location
            // 
            this.location.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.location.FormattingEnabled = true;
            this.location.Items.AddRange(new object[] {
            "螢幕左下方",
            "螢幕右下方"});
            this.location.Location = new System.Drawing.Point(138, 160);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(107, 20);
            this.location.TabIndex = 16;
            this.location.SelectedIndexChanged += new System.EventHandler(this.location_SelectedIndexChanged);
            // 
            // BufferCount
            // 
            this.BufferCount.Location = new System.Drawing.Point(138, 132);
            this.BufferCount.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.BufferCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BufferCount.Name = "BufferCount";
            this.BufferCount.Size = new System.Drawing.Size(106, 22);
            this.BufferCount.TabIndex = 15;
            this.BufferCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BufferCount.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 12);
            this.label11.TabIndex = 14;
            this.label11.Text = "數據緩衝次數:";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(250, 21);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(99, 159);
            this.StartButton.TabIndex = 13;
            this.StartButton.Text = "開始";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // MaxX
            // 
            this.MaxX.Location = new System.Drawing.Point(138, 77);
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
            this.MaxX.Size = new System.Drawing.Size(106, 22);
            this.MaxX.TabIndex = 11;
            this.MaxX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MaxX.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // MinX
            // 
            this.MinX.Location = new System.Drawing.Point(138, 106);
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
            this.MinX.Size = new System.Drawing.Size(106, 22);
            this.MinX.TabIndex = 12;
            this.MinX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MinX.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // MinY
            // 
            this.MinY.Location = new System.Drawing.Point(138, 49);
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
            this.MinY.Size = new System.Drawing.Size(106, 22);
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
            this.MaxY.Location = new System.Drawing.Point(138, 21);
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
            this.MaxY.Size = new System.Drawing.Size(106, 22);
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
            this.label4.Location = new System.Drawing.Point(6, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "C. 螢幕右邊距離(毫米):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "D. 螢幕左邊偏移(毫米):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "B. 螢幕底端高度(毫米):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "A. 螢幕頂端高度(毫米):";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AutoClickCheckBox);
            this.groupBox2.Controls.Add(this.Log);
            this.groupBox2.Controls.Add(this.BindMouseButton);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(12, 414);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(355, 192);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "運行資訊";
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
            // Log
            // 
            this.Log.Location = new System.Drawing.Point(8, 57);
            this.Log.Multiline = true;
            this.Log.Name = "Log";
            this.Log.ReadOnly = true;
            this.Log.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Log.Size = new System.Drawing.Size(341, 128);
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
            this.groupBox3.Controls.Add(this.OffsetY3_Label);
            this.groupBox3.Controls.Add(this.OffsetX3_Label);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.offsetY3_Control);
            this.groupBox3.Controls.Add(this.offsetX3_Control);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Controls.Add(this.OffsetY2_Label);
            this.groupBox3.Controls.Add(this.OffsetX2_Label);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.offsetY2_Control);
            this.groupBox3.Controls.Add(this.offsetX2_Control);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label19);
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
            this.groupBox3.Controls.Add(this.shapeContainer1);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(373, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(445, 496);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "誤差校正";
            // 
            // OffsetY3_Label
            // 
            this.OffsetY3_Label.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OffsetY3_Label.Location = new System.Drawing.Point(176, 408);
            this.OffsetY3_Label.Name = "OffsetY3_Label";
            this.OffsetY3_Label.Size = new System.Drawing.Size(100, 32);
            this.OffsetY3_Label.TabIndex = 29;
            this.OffsetY3_Label.Text = "0px";
            this.OffsetY3_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // OffsetX3_Label
            // 
            this.OffsetX3_Label.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OffsetX3_Label.Location = new System.Drawing.Point(176, 334);
            this.OffsetX3_Label.Name = "OffsetX3_Label";
            this.OffsetX3_Label.Size = new System.Drawing.Size(100, 32);
            this.OffsetX3_Label.TabIndex = 28;
            this.OffsetX3_Label.Text = "0px";
            this.OffsetX3_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(422, 428);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(17, 12);
            this.label22.TabIndex = 27;
            this.label22.Text = "下";
            // 
            // offsetY3_Control
            // 
            this.offsetY3_Control.Location = new System.Drawing.Point(10, 443);
            this.offsetY3_Control.Maximum = 1000;
            this.offsetY3_Control.Minimum = -1000;
            this.offsetY3_Control.Name = "offsetY3_Control";
            this.offsetY3_Control.Size = new System.Drawing.Size(431, 45);
            this.offsetY3_Control.TabIndex = 22;
            this.offsetY3_Control.Scroll += new System.EventHandler(this.offsetY3_Control_Scroll);
            // 
            // offsetX3_Control
            // 
            this.offsetX3_Control.Location = new System.Drawing.Point(8, 368);
            this.offsetX3_Control.Maximum = 1000;
            this.offsetX3_Control.Minimum = -1000;
            this.offsetX3_Control.Name = "offsetX3_Control";
            this.offsetX3_Control.Size = new System.Drawing.Size(431, 45);
            this.offsetX3_Control.TabIndex = 20;
            this.offsetX3_Control.Scroll += new System.EventHandler(this.offsetX3_Control_Scroll);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(8, 428);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(17, 12);
            this.label23.TabIndex = 26;
            this.label23.Text = "上";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(422, 338);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(17, 12);
            this.label24.TabIndex = 25;
            this.label24.Text = "右";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(8, 353);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(17, 12);
            this.label25.TabIndex = 24;
            this.label25.Text = "左";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(8, 416);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(100, 12);
            this.label26.TabIndex = 23;
            this.label26.Text = "垂直偏移校正(遠):";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(8, 340);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(100, 12);
            this.label27.TabIndex = 21;
            this.label27.Text = "水平偏移校正(遠):";
            // 
            // OffsetY2_Label
            // 
            this.OffsetY2_Label.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OffsetY2_Label.Location = new System.Drawing.Point(176, 242);
            this.OffsetY2_Label.Name = "OffsetY2_Label";
            this.OffsetY2_Label.Size = new System.Drawing.Size(100, 32);
            this.OffsetY2_Label.TabIndex = 19;
            this.OffsetY2_Label.Text = "0px";
            this.OffsetY2_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // OffsetX2_Label
            // 
            this.OffsetX2_Label.BackColor = System.Drawing.Color.Transparent;
            this.OffsetX2_Label.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OffsetX2_Label.Location = new System.Drawing.Point(176, 168);
            this.OffsetX2_Label.Name = "OffsetX2_Label";
            this.OffsetX2_Label.Size = new System.Drawing.Size(100, 32);
            this.OffsetX2_Label.TabIndex = 18;
            this.OffsetX2_Label.Text = "0px";
            this.OffsetX2_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(422, 262);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 12);
            this.label14.TabIndex = 17;
            this.label14.Text = "下";
            // 
            // offsetY2_Control
            // 
            this.offsetY2_Control.Location = new System.Drawing.Point(10, 277);
            this.offsetY2_Control.Maximum = 1000;
            this.offsetY2_Control.Minimum = -1000;
            this.offsetY2_Control.Name = "offsetY2_Control";
            this.offsetY2_Control.Size = new System.Drawing.Size(431, 45);
            this.offsetY2_Control.TabIndex = 12;
            this.offsetY2_Control.Scroll += new System.EventHandler(this.offsetY2_Control_Scroll);
            // 
            // offsetX2_Control
            // 
            this.offsetX2_Control.Location = new System.Drawing.Point(8, 202);
            this.offsetX2_Control.Maximum = 1000;
            this.offsetX2_Control.Minimum = -1000;
            this.offsetX2_Control.Name = "offsetX2_Control";
            this.offsetX2_Control.Size = new System.Drawing.Size(431, 45);
            this.offsetX2_Control.TabIndex = 10;
            this.offsetX2_Control.Scroll += new System.EventHandler(this.offsetX2_Control_Scroll);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 262);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 12);
            this.label15.TabIndex = 16;
            this.label15.Text = "上";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(422, 187);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(17, 12);
            this.label16.TabIndex = 15;
            this.label16.Text = "右";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 187);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(17, 12);
            this.label17.TabIndex = 14;
            this.label17.Text = "左";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 250);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 12);
            this.label18.TabIndex = 13;
            this.label18.Text = "垂直偏移校正(中):";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(8, 174);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(100, 12);
            this.label19.TabIndex = 11;
            this.label19.Text = "水平偏移校正(中):";
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
            this.label6.Size = new System.Drawing.Size(100, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "垂直偏移校正(近):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "水平偏移校正(近):";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 18);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(439, 475);
            this.shapeContainer1.TabIndex = 30;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 9;
            this.lineShape2.X2 = 426;
            this.lineShape2.Y1 = 306;
            this.lineShape2.Y2 = 306;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 8;
            this.lineShape1.X2 = 425;
            this.lineShape1.Y1 = 149;
            this.lineShape1.Y2 = 149;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::URG_VirtualTouchPad.Resource.Left;
            this.pictureBox1.Location = new System.Drawing.Point(6, 186);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(343, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 613);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "虛擬觸控板";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BufferCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxY)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.offsetY3_Control)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetX3_Control)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetY2_Control)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetX2_Control)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetY_Control)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetX_Control)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.NumericUpDown BufferCount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label OffsetY3_Label;
        private System.Windows.Forms.Label OffsetX3_Label;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TrackBar offsetY3_Control;
        private System.Windows.Forms.TrackBar offsetX3_Control;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label OffsetY2_Label;
        private System.Windows.Forms.Label OffsetX2_Label;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TrackBar offsetY2_Control;
        private System.Windows.Forms.TrackBar offsetX2_Control;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox location;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

