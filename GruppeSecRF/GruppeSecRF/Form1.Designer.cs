namespace GruppeSecRF
{
    partial class MainForm
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
            recipeFinderLabel = new Label();
            addButton = new Button();
            clearFieldButton = new Button();
            resetButton = new Button();
            ingredientTextBox = new TextBox();
            label1 = new Label();
            FindRecipeButton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // recipeFinderLabel
            // 
            recipeFinderLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            recipeFinderLabel.Font = new Font("Sylfaen", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            recipeFinderLabel.Location = new Point(80, 9);
            recipeFinderLabel.Name = "recipeFinderLabel";
            recipeFinderLabel.Size = new Size(166, 31);
            recipeFinderLabel.TabIndex = 0;
            recipeFinderLabel.Text = "Recipe Finder";
            recipeFinderLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            addButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            addButton.Location = new Point(3, 3);
            addButton.Name = "addButton";
            addButton.Size = new Size(140, 43);
            addButton.TabIndex = 1;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // clearFieldButton
            // 
            clearFieldButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            clearFieldButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            clearFieldButton.Location = new Point(3, 52);
            clearFieldButton.Name = "clearFieldButton";
            clearFieldButton.Size = new Size(140, 43);
            clearFieldButton.TabIndex = 1;
            clearFieldButton.Text = "Clear Field";
            clearFieldButton.UseVisualStyleBackColor = true;
            clearFieldButton.Click += clearFieldButton_Click;
            // 
            // resetButton
            // 
            resetButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            resetButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            resetButton.Location = new Point(149, 3);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(142, 43);
            resetButton.TabIndex = 1;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // ingredientTextBox
            // 
            ingredientTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ingredientTextBox.Location = new Point(12, 78);
            ingredientTextBox.Name = "ingredientTextBox";
            ingredientTextBox.Size = new Size(294, 23);
            ingredientTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 60);
            label1.Name = "label1";
            label1.Size = new Size(286, 15);
            label1.TabIndex = 3;
            label1.Text = "Type in your ingredients one by one and press \"Add\":";
            // 
            // FindRecipeButton
            // 
            FindRecipeButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            FindRecipeButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            FindRecipeButton.Location = new Point(149, 52);
            FindRecipeButton.Name = "FindRecipeButton";
            FindRecipeButton.Size = new Size(142, 43);
            FindRecipeButton.TabIndex = 4;
            FindRecipeButton.Text = "Find Recipe";
            FindRecipeButton.UseVisualStyleBackColor = true;
            FindRecipeButton.Click += FindRecipeButton_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.86226F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.13774F));
            tableLayoutPanel1.Controls.Add(FindRecipeButton, 1, 1);
            tableLayoutPanel1.Controls.Add(addButton, 0, 0);
            tableLayoutPanel1.Controls.Add(clearFieldButton, 0, 1);
            tableLayoutPanel1.Controls.Add(resetButton, 1, 0);
            tableLayoutPanel1.Location = new Point(12, 107);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(294, 98);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 217);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label1);
            Controls.Add(ingredientTextBox);
            Controls.Add(recipeFinderLabel);
            Name = "MainForm";
            Text = "GruppeSec Recipe Finder";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label recipeFinderLabel;
        private Button addButton;
        private Button clearFieldButton;
        private Button resetButton;
        private TextBox ingredientTextBox;
        private Label label1;
        private Button FindRecipeButton;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
