namespace WinKnap
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
            runButton = new Button();
            numberBox = new TextBox();
            capacityBox = new TextBox();
            seedBox = new TextBox();
            number = new Label();
            seed = new Label();
            capacity = new Label();
            results = new Label();
            instances = new Label();
            instanceBox = new ListBox();
            resultBox = new ListBox();
            SuspendLayout();
            // 
            // runButton
            // 
            runButton.Location = new Point(12, 209);
            runButton.Name = "runButton";
            runButton.Size = new Size(75, 23);
            runButton.TabIndex = 0;
            runButton.Text = "run";
            runButton.UseVisualStyleBackColor = true;
            runButton.Click += button1_Click;
            // 
            // numberBox
            // 
            numberBox.BorderStyle = BorderStyle.FixedSingle;
            numberBox.Location = new Point(12, 73);
            numberBox.Name = "numberBox";
            numberBox.Size = new Size(100, 23);
            numberBox.TabIndex = 3;
            // 
            // capacityBox
            // 
            capacityBox.BorderStyle = BorderStyle.FixedSingle;
            capacityBox.Location = new Point(12, 161);
            capacityBox.Name = "capacityBox";
            capacityBox.Size = new Size(100, 23);
            capacityBox.TabIndex = 4;
            // 
            // seedBox
            // 
            seedBox.BorderStyle = BorderStyle.FixedSingle;
            seedBox.Location = new Point(12, 117);
            seedBox.Name = "seedBox";
            seedBox.Size = new Size(100, 23);
            seedBox.TabIndex = 5;
            // 
            // number
            // 
            number.AutoSize = true;
            number.Location = new Point(12, 55);
            number.Name = "number";
            number.Size = new Size(100, 15);
            number.TabIndex = 6;
            number.Text = "numbers of items";
            // 
            // seed
            // 
            seed.AutoSize = true;
            seed.Location = new Point(12, 99);
            seed.Name = "seed";
            seed.Size = new Size(31, 15);
            seed.TabIndex = 7;
            seed.Text = "seed";
            // 
            // capacity
            // 
            capacity.AutoSize = true;
            capacity.Location = new Point(12, 143);
            capacity.Name = "capacity";
            capacity.Size = new Size(51, 15);
            capacity.TabIndex = 8;
            capacity.Text = "capacity";
            // 
            // results
            // 
            results.AutoSize = true;
            results.Location = new Point(12, 394);
            results.Name = "results";
            results.Size = new Size(41, 15);
            results.TabIndex = 9;
            results.Text = "results";
            // 
            // instances
            // 
            instances.AutoSize = true;
            instances.Location = new Point(579, 55);
            instances.Name = "instances";
            instances.Size = new Size(56, 15);
            instances.TabIndex = 10;
            instances.Text = "instances";
            // 
            // instanceBox
            // 
            instanceBox.FormattingEnabled = true;
            instanceBox.ItemHeight = 15;
            instanceBox.Location = new Point(354, 73);
            instanceBox.Name = "instanceBox";
            instanceBox.Size = new Size(281, 649);
            instanceBox.TabIndex = 11;
            // 
            // resultBox
            // 
            resultBox.FormattingEnabled = true;
            resultBox.ItemHeight = 15;
            resultBox.Location = new Point(12, 412);
            resultBox.Name = "resultBox";
            resultBox.Size = new Size(307, 304);
            resultBox.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(647, 733);
            Controls.Add(resultBox);
            Controls.Add(instanceBox);
            Controls.Add(instances);
            Controls.Add(results);
            Controls.Add(capacity);
            Controls.Add(seed);
            Controls.Add(number);
            Controls.Add(seedBox);
            Controls.Add(capacityBox);
            Controls.Add(numberBox);
            Controls.Add(runButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button runButton;
        private TextBox numberBox;
        private TextBox capacityBox;
        private TextBox seedBox;
        private Label number;
        private Label seed;
        private Label capacity;
        private Label results;
        private Label instances;
        private ListBox instanceBox;
        private ListBox resultBox;
    }
}
