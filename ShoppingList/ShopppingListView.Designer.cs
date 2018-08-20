namespace ShoppingList
{
    partial class ShopppingListView
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
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.NewItemName = new System.Windows.Forms.TextBox();
            this.ProductsList = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.Enabled = false;
            this.AddButton.Location = new System.Drawing.Point(140, 200);
            this.AddButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(69, 19);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.Enabled = false;
            this.DeleteButton.Location = new System.Drawing.Point(9, 223);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(200, 19);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // NewItemName
            // 
            this.NewItemName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NewItemName.Location = new System.Drawing.Point(9, 200);
            this.NewItemName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NewItemName.Name = "NewItemName";
            this.NewItemName.Size = new System.Drawing.Size(127, 20);
            this.NewItemName.TabIndex = 3;
            this.NewItemName.TextChanged += new System.EventHandler(this.NewItemName_TextChanged);
            // 
            // ProductsList
            // 
            this.ProductsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductsList.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ProductsList.FormattingEnabled = true;
            this.ProductsList.Location = new System.Drawing.Point(9, 11);
            this.ProductsList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProductsList.Name = "ProductsList";
            this.ProductsList.Size = new System.Drawing.Size(200, 169);
            this.ProductsList.TabIndex = 4;
            this.ProductsList.SelectedIndexChanged += new System.EventHandler(this.ProductsList_SelectedIndexChanged);
            // 
            // ShopppingListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 255);
            this.Controls.Add(this.ProductsList);
            this.Controls.Add(this.NewItemName);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(200, 200);
            this.Name = "ShopppingListView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shopping List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.TextBox NewItemName;
        private System.Windows.Forms.CheckedListBox ProductsList;
    }
}

