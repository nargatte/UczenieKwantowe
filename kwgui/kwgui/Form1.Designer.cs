namespace kwgui
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SelectedDepth = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.SelectedQubits = new System.Windows.Forms.RadioButton();
            this.NumOfSamples = new System.Windows.Forms.NumericUpDown();
            this.NumOfThreads = new System.Windows.Forms.NumericUpDown();
            this.Range = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Depth = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.NumOfQubits = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.Progress = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumOfSamples)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumOfThreads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Range)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Depth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumOfQubits)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stworzone przez:\r\nGrzegorz Krzysiak\r\nPiotr Kośkiewicz\r\nKrzysztof Kicun";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Liczba próbek";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Liczba wątków";
            // 
            // SelectedDepth
            // 
            this.SelectedDepth.AutoSize = true;
            this.SelectedDepth.Location = new System.Drawing.Point(12, 104);
            this.SelectedDepth.Name = "SelectedDepth";
            this.SelectedDepth.Size = new System.Drawing.Size(161, 24);
            this.SelectedDepth.TabIndex = 3;
            this.SelectedDepth.TabStop = true;
            this.SelectedDepth.Text = "głębokości obwodu";
            this.SelectedDepth.UseVisualStyleBackColor = true;
            this.SelectedDepth.CheckedChanged += new System.EventHandler(this.SelectedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Pomiar względem:";
            // 
            // SelectedQubits
            // 
            this.SelectedQubits.AutoSize = true;
            this.SelectedQubits.Location = new System.Drawing.Point(12, 134);
            this.SelectedQubits.Name = "SelectedQubits";
            this.SelectedQubits.Size = new System.Drawing.Size(127, 24);
            this.SelectedQubits.TabIndex = 5;
            this.SelectedQubits.TabStop = true;
            this.SelectedQubits.Text = "liczby qubitów";
            this.SelectedQubits.UseVisualStyleBackColor = true;
            this.SelectedQubits.CheckedChanged += new System.EventHandler(this.SelectedChanged);
            // 
            // NumOfSamples
            // 
            this.NumOfSamples.Location = new System.Drawing.Point(146, 7);
            this.NumOfSamples.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.NumOfSamples.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumOfSamples.Name = "NumOfSamples";
            this.NumOfSamples.Size = new System.Drawing.Size(54, 27);
            this.NumOfSamples.TabIndex = 6;
            this.NumOfSamples.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
            // 
            // NumOfThreads
            // 
            this.NumOfThreads.Location = new System.Drawing.Point(146, 40);
            this.NumOfThreads.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.NumOfThreads.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumOfThreads.Name = "NumOfThreads";
            this.NumOfThreads.Size = new System.Drawing.Size(54, 27);
            this.NumOfThreads.TabIndex = 7;
            this.NumOfThreads.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Range
            // 
            this.Range.Location = new System.Drawing.Point(146, 170);
            this.Range.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.Range.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Range.Name = "Range";
            this.Range.Size = new System.Drawing.Size(54, 27);
            this.Range.TabIndex = 8;
            this.Range.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Zakres do";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Głębokość obwodu";
            // 
            // Depth
            // 
            this.Depth.Location = new System.Drawing.Point(146, 203);
            this.Depth.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.Depth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Depth.Name = "Depth";
            this.Depth.Size = new System.Drawing.Size(54, 27);
            this.Depth.TabIndex = 10;
            this.Depth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Liczba qubitów";
            // 
            // NumOfQubits
            // 
            this.NumOfQubits.Location = new System.Drawing.Point(146, 236);
            this.NumOfQubits.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.NumOfQubits.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumOfQubits.Name = "NumOfQubits";
            this.NumOfQubits.Size = new System.Drawing.Size(54, 27);
            this.NumOfQubits.TabIndex = 12;
            this.NumOfQubits.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 29);
            this.button1.TabIndex = 14;
            this.button1.Text = "Rozpocznij test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.StartTest);
            // 
            // Progress
            // 
            this.Progress.AutoSize = true;
            this.Progress.Location = new System.Drawing.Point(12, 343);
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(31, 20);
            this.Progress.TabIndex = 15;
            this.Progress.Text = "0/0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Progress);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NumOfQubits);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Depth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Range);
            this.Controls.Add(this.NumOfThreads);
            this.Controls.Add(this.NumOfSamples);
            this.Controls.Add(this.SelectedQubits);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SelectedDepth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Tester wydajności symulatorów kwantowych";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.NumOfSamples)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumOfThreads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Range)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Depth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumOfQubits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private RadioButton SelectedDepth;
        private Label label4;
        private RadioButton SelectedQubits;
        private NumericUpDown NumOfSamples;
        private NumericUpDown NumOfThreads;
        private NumericUpDown Range;
        private Label label5;
        private Label label6;
        private NumericUpDown Depth;
        private Label label7;
        private NumericUpDown NumOfQubits;
        private Button button1;
        private Label Progress;
    }
}