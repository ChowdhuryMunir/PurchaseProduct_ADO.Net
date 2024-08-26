namespace ProductAdo
{
    partial class OrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.lblCustomer = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DateTime = new System.Windows.Forms.DateTimePicker();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.btnOpenOrderDetailsForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewOrderDetails = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Agency FB", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(27, 116);
            this.lblCustomer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(121, 26);
            this.lblCustomer.TabIndex = 0;
            this.lblCustomer.Text = "Customer Name";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(129, 116);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCustomerName.Multiline = true;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(147, 26);
            this.txtCustomerName.TabIndex = 1;
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Location = new System.Drawing.Point(311, 73);
            this.dataGridViewOrders.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.RowHeadersWidth = 62;
            this.dataGridViewOrders.RowTemplate.Height = 28;
            this.dataGridViewOrders.Size = new System.Drawing.Size(465, 133);
            this.dataGridViewOrders.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "OrderDate";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(129, 186);
            this.txtTotalAmount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTotalAmount.Multiline = true;
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(147, 30);
            this.txtTotalAmount.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agency FB", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 198);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "TotalAmout";
            // 
            // DateTime
            // 
            this.DateTime.Location = new System.Drawing.Point(129, 153);
            this.DateTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DateTime.Name = "DateTime";
            this.DateTime.Size = new System.Drawing.Size(147, 20);
            this.DateTime.TabIndex = 7;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAddOrder.Font = new System.Drawing.Font("Agency FB", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOrder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddOrder.Location = new System.Drawing.Point(15, 245);
            this.btnAddOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(119, 32);
            this.btnAddOrder.TabIndex = 8;
            this.btnAddOrder.Text = "Add New Orders";
            this.btnAddOrder.UseVisualStyleBackColor = false;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDeleteOrder.Font = new System.Drawing.Font("Agency FB", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteOrder.Location = new System.Drawing.Point(148, 245);
            this.btnDeleteOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(131, 32);
            this.btnDeleteOrder.TabIndex = 9;
            this.btnDeleteOrder.Text = "Delete Order";
            this.btnDeleteOrder.UseVisualStyleBackColor = false;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // btnOpenOrderDetailsForm
            // 
            this.btnOpenOrderDetailsForm.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnOpenOrderDetailsForm.Font = new System.Drawing.Font("Agency FB", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenOrderDetailsForm.Location = new System.Drawing.Point(59, 312);
            this.btnOpenOrderDetailsForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOpenOrderDetailsForm.Name = "btnOpenOrderDetailsForm";
            this.btnOpenOrderDetailsForm.Size = new System.Drawing.Size(147, 37);
            this.btnOpenOrderDetailsForm.TabIndex = 10;
            this.btnOpenOrderDetailsForm.Text = "Open Order Details";
            this.btnOpenOrderDetailsForm.UseVisualStyleBackColor = false;
            this.btnOpenOrderDetailsForm.Click += new System.EventHandler(this.btnOpenOrderDetailsForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 59);
            this.label1.TabIndex = 11;
            this.label1.Text = "Place Order";
            // 
            // dataGridViewOrderDetails
            // 
            this.dataGridViewOrderDetails.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderDetails.Location = new System.Drawing.Point(311, 245);
            this.dataGridViewOrderDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewOrderDetails.Name = "dataGridViewOrderDetails";
            this.dataGridViewOrderDetails.RowHeadersWidth = 62;
            this.dataGridViewOrderDetails.RowTemplate.Height = 28;
            this.dataGridViewOrderDetails.Size = new System.Drawing.Size(465, 149);
            this.dataGridViewOrderDetails.TabIndex = 12;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1014, 493);
            this.Controls.Add(this.dataGridViewOrderDetails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpenOrderDetailsForm);
            this.Controls.Add(this.btnDeleteOrder);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.DateTime);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewOrders);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lblCustomer);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DateTime;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.Button btnOpenOrderDetailsForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewOrderDetails;
    }
}