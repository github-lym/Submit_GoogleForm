
namespace GoogleForm
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.TextBox_Username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NumericUpDown_Temperature = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.RichTextBox_Result = new System.Windows.Forms.RichTextBox();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.RadioButton_Place_False = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RadioButton_Place_True = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RadioButton_Person_True = new System.Windows.Forms.RadioButton();
            this.RadioButton_Person_False = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.CheckedListBox_Symptom = new System.Windows.Forms.CheckedListBox();
            this.RichTextBox_Memo = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Temperature)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(798, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "送出";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_ClickAsync);
            // 
            // TextBox_Username
            // 
            this.TextBox_Username.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TextBox_Username.Location = new System.Drawing.Point(79, 16);
            this.TextBox_Username.Name = "TextBox_Username";
            this.TextBox_Username.ReadOnly = true;
            this.TextBox_Username.Size = new System.Drawing.Size(100, 38);
            this.TextBox_Username.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "姓名";
            // 
            // NumericUpDown_Temperature
            // 
            this.NumericUpDown_Temperature.DecimalPlaces = 1;
            this.NumericUpDown_Temperature.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NumericUpDown_Temperature.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumericUpDown_Temperature.Location = new System.Drawing.Point(282, 16);
            this.NumericUpDown_Temperature.Maximum = new decimal(new int[] {
            422,
            0,
            0,
            65536});
            this.NumericUpDown_Temperature.Minimum = new decimal(new int[] {
            351,
            0,
            0,
            65536});
            this.NumericUpDown_Temperature.Name = "NumericUpDown_Temperature";
            this.NumericUpDown_Temperature.Size = new System.Drawing.Size(81, 38);
            this.NumericUpDown_Temperature.TabIndex = 3;
            this.NumericUpDown_Temperature.Value = new decimal(new int[] {
            361,
            0,
            0,
            65536});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(206, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "體溫";
            // 
            // RichTextBox_Result
            // 
            this.RichTextBox_Result.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RichTextBox_Result.Location = new System.Drawing.Point(411, 395);
            this.RichTextBox_Result.Name = "RichTextBox_Result";
            this.RichTextBox_Result.ReadOnly = true;
            this.RichTextBox_Result.Size = new System.Drawing.Size(457, 96);
            this.RichTextBox_Result.TabIndex = 5;
            this.RichTextBox_Result.Text = "";
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.CalendarFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DateTimePicker.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DateTimePicker.Location = new System.Drawing.Point(411, 18);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(222, 34);
            this.DateTimePicker.TabIndex = 6;
            this.DateTimePicker.Value = new System.DateTime(2021, 11, 1, 0, 0, 0, 0);
            // 
            // RadioButton_Place_False
            // 
            this.RadioButton_Place_False.AutoSize = true;
            this.RadioButton_Place_False.Checked = true;
            this.RadioButton_Place_False.Location = new System.Drawing.Point(6, 68);
            this.RadioButton_Place_False.Name = "RadioButton_Place_False";
            this.RadioButton_Place_False.Size = new System.Drawing.Size(48, 26);
            this.RadioButton_Place_False.TabIndex = 8;
            this.RadioButton_Place_False.TabStop = true;
            this.RadioButton_Place_False.Text = "無";
            this.RadioButton_Place_False.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadioButton_Place_True);
            this.groupBox1.Controls.Add(this.RadioButton_Place_False);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(17, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "過去一週七日內曾去過中央防疫指揮中心公布確診者足跡地點";
            // 
            // RadioButton_Place_True
            // 
            this.RadioButton_Place_True.AutoSize = true;
            this.RadioButton_Place_True.Location = new System.Drawing.Point(151, 68);
            this.RadioButton_Place_True.Name = "RadioButton_Place_True";
            this.RadioButton_Place_True.Size = new System.Drawing.Size(48, 26);
            this.RadioButton_Place_True.TabIndex = 10;
            this.RadioButton_Place_True.Text = "有";
            this.RadioButton_Place_True.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RadioButton_Person_True);
            this.groupBox2.Controls.Add(this.RadioButton_Person_False);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(411, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(346, 100);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "過去7日內曾接觸居家隔離、居家檢疫、疑似或確診新冠肺炎患者";
            // 
            // RadioButton_Person_True
            // 
            this.RadioButton_Person_True.AutoSize = true;
            this.RadioButton_Person_True.Location = new System.Drawing.Point(151, 68);
            this.RadioButton_Person_True.Name = "RadioButton_Person_True";
            this.RadioButton_Person_True.Size = new System.Drawing.Size(48, 26);
            this.RadioButton_Person_True.TabIndex = 10;
            this.RadioButton_Person_True.Text = "有";
            this.RadioButton_Person_True.UseVisualStyleBackColor = true;
            // 
            // RadioButton_Person_False
            // 
            this.RadioButton_Person_False.AutoSize = true;
            this.RadioButton_Person_False.Checked = true;
            this.RadioButton_Person_False.Location = new System.Drawing.Point(6, 68);
            this.RadioButton_Person_False.Name = "RadioButton_Person_False";
            this.RadioButton_Person_False.Size = new System.Drawing.Size(48, 26);
            this.RadioButton_Person_False.TabIndex = 8;
            this.RadioButton_Person_False.TabStop = true;
            this.RadioButton_Person_False.Text = "無";
            this.RadioButton_Person_False.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(17, 194);
            this.label3.MaximumSize = new System.Drawing.Size(400, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(390, 50);
            this.label3.TabIndex = 11;
            this.label3.Text = "過去3天內有發燒呼吸道症狀(咳嗽呼吸急促等)或以下症狀(已服藥者亦請勾選)";
            // 
            // CheckedListBox_Symptom
            // 
            this.CheckedListBox_Symptom.FormattingEnabled = true;
            this.CheckedListBox_Symptom.Items.AddRange(new object[] {
            "皆無",
            "發燒",
            "咳嗽",
            "流鼻涕",
            "喉嚨痛",
            "腹瀉",
            "味覺或嗅覺異常",
            "呼吸急促",
            "倦怠",
            "其他(請於8.備註描述症狀)"});
            this.CheckedListBox_Symptom.Location = new System.Drawing.Point(20, 247);
            this.CheckedListBox_Symptom.Name = "CheckedListBox_Symptom";
            this.CheckedListBox_Symptom.Size = new System.Drawing.Size(215, 244);
            this.CheckedListBox_Symptom.TabIndex = 13;
            // 
            // RichTextBox_Memo
            // 
            this.RichTextBox_Memo.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RichTextBox_Memo.Location = new System.Drawing.Point(411, 247);
            this.RichTextBox_Memo.Name = "RichTextBox_Memo";
            this.RichTextBox_Memo.Size = new System.Drawing.Size(457, 96);
            this.RichTextBox_Memo.TabIndex = 14;
            this.RichTextBox_Memo.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(412, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "備註";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(412, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "結果";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 513);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RichTextBox_Memo);
            this.Controls.Add(this.CheckedListBox_Symptom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.RichTextBox_Result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumericUpDown_Temperature);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBox_Username);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "每日防疫調查表";
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Temperature)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TextBox_Username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NumericUpDown_Temperature;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox RichTextBox_Result;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.RadioButton RadioButton_Place_False;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RadioButton_Place_True;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RadioButton_Person_True;
        private System.Windows.Forms.RadioButton RadioButton_Person_False;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox CheckedListBox_Symptom;
        private System.Windows.Forms.RichTextBox RichTextBox_Memo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

