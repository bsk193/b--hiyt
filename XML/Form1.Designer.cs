namespace XML
{
    partial class Form1
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
            this.txtOrders = new System.Windows.Forms.TextBox();
            this.lbOrders = new System.Windows.Forms.Label();
            this.btnOpenOrders = new System.Windows.Forms.Button();
            this.btnOpenProducts = new System.Windows.Forms.Button();
            this.lbProducts = new System.Windows.Forms.Label();
            this.txtProducts = new System.Windows.Forms.TextBox();
            this.openOrders = new System.Windows.Forms.OpenFileDialog();
            this.openProducts = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // txtOrders
            // 
            this.txtOrders.Location = new System.Drawing.Point(67, 6);
            this.txtOrders.Name = "txtOrders";
            this.txtOrders.Size = new System.Drawing.Size(286, 20);
            this.txtOrders.TabIndex = 0;
            // 
            // lbOrders
            // 
            this.lbOrders.AutoSize = true;
            this.lbOrders.Location = new System.Drawing.Point(12, 9);
            this.lbOrders.Name = "lbOrders";
            this.lbOrders.Size = new System.Drawing.Size(38, 13);
            this.lbOrders.TabIndex = 1;
            this.lbOrders.Text = "Orders";
            // 
            // btnOpenOrders
            // 
            this.btnOpenOrders.Location = new System.Drawing.Point(359, 4);
            this.btnOpenOrders.Name = "btnOpenOrders";
            this.btnOpenOrders.Size = new System.Drawing.Size(66, 23);
            this.btnOpenOrders.TabIndex = 2;
            this.btnOpenOrders.Text = "Open";
            this.btnOpenOrders.UseVisualStyleBackColor = true;
            this.btnOpenOrders.Click += new System.EventHandler(this.btnOpenOrders_Click);
            // 
            // btnOpenProducts
            // 
            this.btnOpenProducts.Location = new System.Drawing.Point(359, 41);
            this.btnOpenProducts.Name = "btnOpenProducts";
            this.btnOpenProducts.Size = new System.Drawing.Size(66, 23);
            this.btnOpenProducts.TabIndex = 5;
            this.btnOpenProducts.Text = "Open";
            this.btnOpenProducts.UseVisualStyleBackColor = true;
            this.btnOpenProducts.Click += new System.EventHandler(this.btnOpenProducts_Click);
            // 
            // lbProducts
            // 
            this.lbProducts.AutoSize = true;
            this.lbProducts.Location = new System.Drawing.Point(12, 46);
            this.lbProducts.Name = "lbProducts";
            this.lbProducts.Size = new System.Drawing.Size(49, 13);
            this.lbProducts.TabIndex = 4;
            this.lbProducts.Text = "Products";
            // 
            // txtProducts
            // 
            this.txtProducts.Location = new System.Drawing.Point(67, 43);
            this.txtProducts.Name = "txtProducts";
            this.txtProducts.Size = new System.Drawing.Size(286, 20);
            this.txtProducts.TabIndex = 3;
            // 
            // openOrders
            // 
            this.openOrders.FileOk += new System.ComponentModel.CancelEventHandler(this.openOrders_FileOk);
            // 
            // openProducts
            // 
            this.openProducts.FileOk += new System.ComponentModel.CancelEventHandler(this.openProducts_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 75);
            this.Controls.Add(this.btnOpenProducts);
            this.Controls.Add(this.lbProducts);
            this.Controls.Add(this.txtProducts);
            this.Controls.Add(this.btnOpenOrders);
            this.Controls.Add(this.lbOrders);
            this.Controls.Add(this.txtOrders);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtOrders;
        private System.Windows.Forms.Label lbOrders;
        private System.Windows.Forms.Button btnOpenOrders;
        private System.Windows.Forms.Button btnOpenProducts;
        private System.Windows.Forms.Label lbProducts;
        private System.Windows.Forms.TextBox txtProducts;
        private System.Windows.Forms.OpenFileDialog openOrders;
        private System.Windows.Forms.OpenFileDialog openProducts;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

