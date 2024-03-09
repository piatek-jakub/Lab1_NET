
namespace WinFormsKnapsack
{
    partial class Knapsack
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
            components = new System.ComponentModel.Container();
            numberOfItems = new TextBox();
            seed = new TextBox();
            capacity = new TextBox();
            results = new TextBox();
            instance = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            run = new Button();
            numberOfItemsLabel = new Label();
            seedLabel = new Label();
            capacityLabel = new Label();
            resultsLabel = new Label();
            instanceLabel = new Label();
            SuspendLayout();
            // 
            // numberOfItems
            // 
            numberOfItems.Location = new Point(47, 55);
            numberOfItems.Name = "numberOfItems";
            numberOfItems.Size = new Size(100, 23);
            numberOfItems.TabIndex = 0;
            numberOfItems.TextChanged += number_TextChanged;
            // 
            // seed
            // 
            seed.Location = new Point(47, 115);
            seed.Name = "seed";
            seed.Size = new Size(100, 23);
            seed.TabIndex = 1;
            seed.TextChanged += number_TextChanged;
            // 
            // capacity
            // 
            capacity.Location = new Point(47, 168);
            capacity.Name = "capacity";
            capacity.Size = new Size(100, 23);
            capacity.TabIndex = 2;
            capacity.TextChanged += number_TextChanged;
            // 
            // results
            // 
            results.Location = new Point(47, 250);
            results.Multiline = true;
            results.Name = "results";
            results.Size = new Size(234, 299);
            results.TabIndex = 3;
            results.TextChanged += results_TextChanged;
            // 
            // instance
            // 
            instance.Location = new Point(297, 50);
            instance.Multiline = true;
            instance.Name = "instance";
            instance.Size = new Size(275, 499);
            instance.TabIndex = 4;
            instance.TextChanged += instance_TextChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // run
            // 
            run.Location = new Point(47, 214);
            run.Name = "run";
            run.Size = new Size(100, 30);
            run.TabIndex = 6;
            run.Text = "run";
            run.UseVisualStyleBackColor = true;
            run.Click += run_Click;
            // 
            // numberOfItemsLabel
            // 
            numberOfItemsLabel.AutoSize = true;
            numberOfItemsLabel.Location = new Point(47, 37);
            numberOfItemsLabel.Name = "numberOfItemsLabel";
            numberOfItemsLabel.Size = new Size(95, 15);
            numberOfItemsLabel.TabIndex = 7;
            numberOfItemsLabel.Text = "number of items";
            numberOfItemsLabel.Click += numberOfItemsLabel_Click;
            // 
            // seedLabel
            // 
            seedLabel.AutoSize = true;
            seedLabel.Location = new Point(47, 97);
            seedLabel.Name = "seedLabel";
            seedLabel.Size = new Size(31, 15);
            seedLabel.TabIndex = 8;
            seedLabel.Text = "seed";
            // 
            // capacityLabel
            // 
            capacityLabel.AutoSize = true;
            capacityLabel.Location = new Point(47, 150);
            capacityLabel.Name = "capacityLabel";
            capacityLabel.Size = new Size(51, 15);
            capacityLabel.TabIndex = 9;
            capacityLabel.Text = "capacity";
            // 
            // resultsLabel
            // 
            resultsLabel.AutoSize = true;
            resultsLabel.Location = new Point(240, 232);
            resultsLabel.Name = "resultsLabel";
            resultsLabel.Size = new Size(41, 15);
            resultsLabel.TabIndex = 10;
            resultsLabel.Text = "results";
            resultsLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // instanceLabel
            // 
            instanceLabel.AutoSize = true;
            instanceLabel.Location = new Point(521, 32);
            instanceLabel.Name = "instanceLabel";
            instanceLabel.Size = new Size(51, 15);
            instanceLabel.TabIndex = 11;
            instanceLabel.Text = "instance";
            instanceLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // Knapsack
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 561);
            Controls.Add(instanceLabel);
            Controls.Add(resultsLabel);
            Controls.Add(capacityLabel);
            Controls.Add(seedLabel);
            Controls.Add(numberOfItemsLabel);
            Controls.Add(run);
            Controls.Add(instance);
            Controls.Add(results);
            Controls.Add(capacity);
            Controls.Add(seed);
            Controls.Add(numberOfItems);
            Name = "Knapsack";
            Text = "Knapsack";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void number_TextChanged(object sender, EventArgs e)
        {
            if(sender is TextBox textbox)
            {
                if(string.IsNullOrEmpty(textbox.Text))
                {
                    textbox.BackColor = Color.White;
                }
                else
                {
                    if (int.TryParse(textbox.Text, out int number))
                    {
                        textbox.BackColor = Color.LightGreen;
                    }
                    else
                    {
                        textbox.BackColor = Color.PaleVioletRed;
                    }
                }
            }
        }

        private void results_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void instance_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void run_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void numberOfItemsLabel_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TextBox numberOfItems;
        private TextBox seed;
        private TextBox capacity;
        private TextBox results;
        private TextBox instance;
        private ContextMenuStrip contextMenuStrip1;
        private Button run;
        private Label numberOfItemsLabel;
        private Label seedLabel;
        private Label capacityLabel;
        private Label resultsLabel;
        private Label instanceLabel;
    }
}
