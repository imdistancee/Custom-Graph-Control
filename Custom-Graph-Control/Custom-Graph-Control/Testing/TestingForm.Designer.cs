namespace Custom_Graph_Control.Testing
{
    partial class TestingForm
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
            this.txtX = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddPoint = new System.Windows.Forms.Button();
            this.txtY = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.myGraphControl = new GraphControl.Graph();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboLines = new System.Windows.Forms.ComboBox();
            this.numericLineSize = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericLineSize)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(12, 29);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(67, 20);
            this.txtX.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddPoint);
            this.groupBox1.Controls.Add(this.txtY);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtX);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 90);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add a point";
            // 
            // btnAddPoint
            // 
            this.btnAddPoint.Location = new System.Drawing.Point(11, 55);
            this.btnAddPoint.Name = "btnAddPoint";
            this.btnAddPoint.Size = new System.Drawing.Size(141, 23);
            this.btnAddPoint.TabIndex = 4;
            this.btnAddPoint.Text = "Add Point";
            this.btnAddPoint.UseVisualStyleBackColor = true;
            this.btnAddPoint.Click += new System.EventHandler(this.btnAddPoint_Click);
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(85, 29);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(67, 20);
            this.txtY.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Y";
            // 
            // myGraphControl
            // 
            this.myGraphControl.BackColor = System.Drawing.Color.White;
            this.myGraphControl.graphColor = System.Drawing.Color.Empty;
            this.myGraphControl.lineType = GraphControl.Graph.LineType.CURVE;
            this.myGraphControl.Location = new System.Drawing.Point(12, 108);
            this.myGraphControl.Name = "myGraphControl";
            this.myGraphControl.lineSize = 2;
            this.myGraphControl.Size = new System.Drawing.Size(487, 243);
            this.myGraphControl.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericLineSize);
            this.groupBox2.Controls.Add(this.comboLines);
            this.groupBox2.Location = new System.Drawing.Point(179, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 90);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Set the line properties";
            // 
            // comboLines
            // 
            this.comboLines.FormattingEnabled = true;
            this.comboLines.Location = new System.Drawing.Point(6, 27);
            this.comboLines.Name = "comboLines";
            this.comboLines.Size = new System.Drawing.Size(308, 22);
            this.comboLines.TabIndex = 0;
            this.comboLines.SelectedIndexChanged += new System.EventHandler(this.comboLines_SelectedIndexChanged);
            // 
            // numericLineSize
            // 
            this.numericLineSize.Location = new System.Drawing.Point(6, 55);
            this.numericLineSize.Name = "numericLineSize";
            this.numericLineSize.Size = new System.Drawing.Size(308, 20);
            this.numericLineSize.TabIndex = 1;
            this.numericLineSize.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericLineSize.ValueChanged += new System.EventHandler(this.numericLineSize_ValueChanged);
            // 
            // TestingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 363);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.myGraphControl);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TestingForm";
            this.Text = "Graph Control Testing";
            this.Load += new System.EventHandler(this.TestingForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericLineSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddPoint;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Label label2;
        private GraphControl.Graph myGraphControl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboLines;
        private System.Windows.Forms.NumericUpDown numericLineSize;
    }
}

