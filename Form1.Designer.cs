namespace Third
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxP = new System.Windows.Forms.TextBox();
            this.textBoxQ = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.encodeButton = new System.Windows.Forms.Button();
            this.yLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.kPubLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.kPrivLabel = new System.Windows.Forms.Label();
            this.xLabel = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "p:";
            // 
            // textBoxP
            // 
            this.textBoxP.Location = new System.Drawing.Point(45, 12);
            this.textBoxP.Name = "textBoxP";
            this.textBoxP.Size = new System.Drawing.Size(100, 23);
            this.textBoxP.TabIndex = 1;
            this.textBoxP.Text = "89";
            this.textBoxP.TextChanged += new System.EventHandler(this.textBoxP_TextChanged);
            // 
            // textBoxQ
            // 
            this.textBoxQ.Location = new System.Drawing.Point(45, 41);
            this.textBoxQ.Name = "textBoxQ";
            this.textBoxQ.Size = new System.Drawing.Size(100, 23);
            this.textBoxQ.TabIndex = 3;
            this.textBoxQ.Text = "97";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "q:";
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(45, 70);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(100, 23);
            this.textBoxX.TabIndex = 5;
            this.textBoxX.Text = "labas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "x:";
            // 
            // encodeButton
            // 
            this.encodeButton.Location = new System.Drawing.Point(45, 114);
            this.encodeButton.Name = "encodeButton";
            this.encodeButton.Size = new System.Drawing.Size(100, 28);
            this.encodeButton.TabIndex = 6;
            this.encodeButton.Text = "Encode";
            this.encodeButton.UseVisualStyleBackColor = true;
            this.encodeButton.Click += new System.EventHandler(this.encodeClick);
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(45, 145);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(0, 15);
            this.yLabel.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 8;
            this.button1.Text = "Save Y";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.saveYClicked);
            // 
            // kPubLabel
            // 
            this.kPubLabel.AutoSize = true;
            this.kPubLabel.Location = new System.Drawing.Point(45, 170);
            this.kPubLabel.Name = "kPubLabel";
            this.kPubLabel.Size = new System.Drawing.Size(0, 15);
            this.kPubLabel.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(45, 265);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 10;
            this.button2.Text = "Save KPub";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.saveKPubClicked);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(262, 114);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 11;
            this.button3.Text = "Decode";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.decode_Click);
            // 
            // kPrivLabel
            // 
            this.kPrivLabel.AutoSize = true;
            this.kPrivLabel.Location = new System.Drawing.Point(45, 195);
            this.kPrivLabel.Name = "kPrivLabel";
            this.kPrivLabel.Size = new System.Drawing.Size(0, 15);
            this.kPrivLabel.TabIndex = 12;
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(262, 145);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(16, 15);
            this.xLabel.TabIndex = 13;
            this.xLabel.Text = "x:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(45, 299);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 28);
            this.button4.TabIndex = 14;
            this.button4.Text = "Save KPriv";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.saveKPrivClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "kPriv:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "kPub:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "y:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(178, 231);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 28);
            this.button5.TabIndex = 18;
            this.button5.Text = "Load Y";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.loadYClicked);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(178, 265);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 28);
            this.button6.TabIndex = 19;
            this.button6.Text = "Load KPub";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.loadKPubClicked);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(178, 299);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 28);
            this.button7.TabIndex = 20;
            this.button7.Text = "Load KPriv";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.loadKPrivClicked);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(303, 281);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(105, 46);
            this.button8.TabIndex = 21;
            this.button8.Text = "Decode Without KPriv";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.decodeWithoutPrivKey_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 423);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.kPrivLabel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.kPubLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.yLabel);
            this.Controls.Add(this.encodeButton);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxQ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxP);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBoxP;
        private TextBox textBoxQ;
        private Label label2;
        private TextBox textBoxX;
        private Label label3;
        private Button encodeButton;
        private Label yLabel;
        private Button button1;
        private Label kPubLabel;
        private Button button2;
        private Button button3;
        private Label kPrivLabel;
        private Label xLabel;
        private Button button4;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
    }
}