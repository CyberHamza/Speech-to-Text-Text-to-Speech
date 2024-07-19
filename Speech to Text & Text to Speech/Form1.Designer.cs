namespace Speech_to_Text___Text_to_Speech
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            TS = new Label();
            ST = new Label();
            textBox2 = new TextBox();
            TSB = new Button();
            STB = new Button();
            trackBar1 = new TrackBar();
            label4 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(333, 20);
            label1.Name = "label1";
            label1.Size = new Size(457, 44);
            label1.TabIndex = 0;
            label1.Text = "Speech - Text Manipulation";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(621, 122);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(413, 190);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // TS
            // 
            TS.AutoSize = true;
            TS.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TS.Location = new Point(61, 88);
            TS.Name = "TS";
            TS.Size = new Size(166, 31);
            TS.TabIndex = 2;
            TS.Text = "Text to Speech";
            TS.Click += label2_Click;
            // 
            // ST
            // 
            ST.AutoSize = true;
            ST.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ST.Location = new Point(624, 88);
            ST.Name = "ST";
            ST.Size = new Size(166, 31);
            ST.TabIndex = 3;
            ST.Text = "Speech to Text";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(61, 122);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(413, 190);
            textBox2.TabIndex = 4;
            // 
            // TSB
            // 
            TSB.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TSB.Location = new Point(61, 318);
            TSB.Name = "TSB";
            TSB.Size = new Size(155, 56);
            TSB.TabIndex = 5;
            TSB.Text = "Click to Listen";
            TSB.UseVisualStyleBackColor = true;
            TSB.Click += TSB_Click;
            // 
            // STB
            // 
            STB.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            STB.Location = new Point(879, 318);
            STB.Name = "STB";
            STB.Size = new Size(155, 56);
            STB.TabIndex = 6;
            STB.Text = "Click to Read";
            STB.UseVisualStyleBackColor = true;
            STB.Click += STB_Click_1;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(484, 318);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(130, 56);
            trackBar1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(501, 368);
            label4.Name = "label4";
            label4.Size = new Size(93, 31);
            label4.TabIndex = 8;
            label4.Text = "Volume";
            // 
            // button1
            // 
            button1.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(222, 318);
            button1.Name = "button1";
            button1.Size = new Size(155, 56);
            button1.TabIndex = 9;
            button1.Text = "Upload File";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1125, 445);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(trackBar1);
            Controls.Add(STB);
            Controls.Add(TSB);
            Controls.Add(textBox2);
            Controls.Add(ST);
            Controls.Add(TS);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label TS;
        private Label ST;
        private TextBox textBox2;
        private Button TSB;
        private Button STB;
        private TrackBar trackBar1;
        private Label label4;
        private Button button1;
    }
}
