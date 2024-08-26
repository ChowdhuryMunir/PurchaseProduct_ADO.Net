namespace ProductAdo
{
    partial class OrderDetailsForm
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
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewOrderDetails = new System.Windows.Forms.DataGridView();
            this.btnAddOrderDetail = new System.Windows.Forms.Button();
            this.btnDeleteOrderDetail = new System.Windows.Forms.Button();
            this.btnBackToOrderForm = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "OrderID";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(122, 120);
            this.txtOrderID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOrderID.Multiline = true;
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(143, 30);
            this.txtOrderID.TabIndex = 1;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(122, 215);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtQuantity.Multiline = true;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(142, 26);
            this.txtQuantity.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 215);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantity";
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(122, 166);
            this.txtProductID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProductID.Multiline = true;
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(142, 29);
            this.txtProductID.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agency FB", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "ProductID";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(122, 264);
            this.txtUnitPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUnitPrice.Multiline = true;
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(143, 27);
            this.txtUnitPrice.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Agency FB", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 265);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "UnitPrice";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(122, 308);
            this.txtTotalPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTotalPrice.Multiline = true;
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(143, 25);
            this.txtTotalPrice.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Agency FB", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 307);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "TotalPrice";
            // 
            // dataGridViewOrderDetails
            // 
            this.dataGridViewOrderDetails.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderDetails.Location = new System.Drawing.Point(299, 66);
            this.dataGridViewOrderDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewOrderDetails.Name = "dataGridViewOrderDetails";
            this.dataGridViewOrderDetails.RowHeadersWidth = 62;
            this.dataGridViewOrderDetails.RowTemplate.Height = 28;
            this.dataGridViewOrderDetails.Size = new System.Drawing.Size(530, 268);
            this.dataGridViewOrderDetails.TabIndex = 10;
            // 
            // btnAddOrderDetail
            // 
            this.btnAddOrderDetail.AutoSize = true;
            this.btnAddOrderDetail.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAddOrderDetail.Font = new System.Drawing.Font("Agency FB", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOrderDetail.Location = new System.Drawing.Point(305, 354);
            this.btnAddOrderDetail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddOrderDetail.Name = "btnAddOrderDetail";
            this.btnAddOrderDetail.Size = new System.Drawing.Size(137, 36);
            this.btnAddOrderDetail.TabIndex = 11;
            this.btnAddOrderDetail.Text = "Add Order Detail";
            this.btnAddOrderDetail.UseVisualStyleBackColor = false;
            this.btnAddOrderDetail.Click += new System.EventHandler(this.btnAddOrderDetail_Click);
            // 
            // btnDeleteOrderDetail
            // 
            this.btnDeleteOrderDetail.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDeleteOrderDetail.Font = new System.Drawing.Font("Agency FB", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteOrderDetail.Location = new System.Drawing.Point(479, 355);
            this.btnDeleteOrderDetail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteOrderDetail.Name = "btnDeleteOrderDetail";
            this.btnDeleteOrderDetail.Size = new System.Drawing.Size(147, 35);
            this.btnDeleteOrderDetail.TabIndex = 12;
            this.btnDeleteOrderDetail.Text = "Delete Order";
            this.btnDeleteOrderDetail.UseVisualStyleBackColor = false;
            this.btnDeleteOrderDetail.Click += new System.EventHandler(this.btnDeleteOrderDetail_Click);
            // 
            // btnBackToOrderForm
            // 
            this.btnBackToOrderForm.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBackToOrderForm.Font = new System.Drawing.Font("Agency FB", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToOrderForm.Location = new System.Drawing.Point(659, 354);
            this.btnBackToOrderForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBackToOrderForm.Name = "btnBackToOrderForm";
            this.btnBackToOrderForm.Size = new System.Drawing.Size(170, 36);
            this.btnBackToOrderForm.TabIndex = 13;
            this.btnBackToOrderForm.Text = "Go Back to order";
            this.btnBackToOrderForm.UseVisualStyleBackColor = false;
            this.btnBackToOrderForm.Click += new System.EventHandler(this.btnBackToOrderForm_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Agency FB", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 6);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(338, 59);
            this.label6.TabIndex = 14;
            this.label6.Text = "Details Of Purchase";
            // 
            // OrderDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1014, 493);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnBackToOrderForm);
            this.Controls.Add(this.btnDeleteOrderDetail);
            this.Controls.Add(this.btnAddOrderDetail);
            this.Controls.Add(this.dataGridViewOrderDetails);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "OrderDetailsForm";
            this.Text = "OrderDetailsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewOrderDetails;
        private System.Windows.Forms.Button btnAddOrderDetail;
        private System.Windows.Forms.Button btnDeleteOrderDetail;
        private System.Windows.Forms.Button btnBackToOrderForm;
        private System.Windows.Forms.Label label6;
    }
}