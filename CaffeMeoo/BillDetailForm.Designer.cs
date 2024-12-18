namespace CaffeMeoo
{
    partial class BillDetailForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPaymentTime = new System.Windows.Forms.Label();
            this.lblTableId = new System.Windows.Forms.Label();
            this.lblBillId = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(508, 441);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 37);
            this.button1.TabIndex = 9;
            this.button1.Text = "PAYMENT CONFIRM";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(515, 68);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(46, 18);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "label1";
            // 
            // lblPaymentTime
            // 
            this.lblPaymentTime.AutoSize = true;
            this.lblPaymentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentTime.Location = new System.Drawing.Point(515, 46);
            this.lblPaymentTime.Name = "lblPaymentTime";
            this.lblPaymentTime.Size = new System.Drawing.Size(46, 18);
            this.lblPaymentTime.TabIndex = 7;
            this.lblPaymentTime.Text = "label1";
            // 
            // lblTableId
            // 
            this.lblTableId.AutoSize = true;
            this.lblTableId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableId.Location = new System.Drawing.Point(209, 46);
            this.lblTableId.Name = "lblTableId";
            this.lblTableId.Size = new System.Drawing.Size(46, 18);
            this.lblTableId.TabIndex = 6;
            this.lblTableId.Text = "label1";
            // 
            // lblBillId
            // 
            this.lblBillId.AutoSize = true;
            this.lblBillId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillId.Location = new System.Drawing.Point(350, 9);
            this.lblBillId.Name = "lblBillId";
            this.lblBillId.Size = new System.Drawing.Size(66, 24);
            this.lblBillId.TabIndex = 5;
            this.lblBillId.Text = "label1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(130, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(486, 297);
            this.dataGridView1.TabIndex = 10;
            // 
            // BillDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 615);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblPaymentTime);
            this.Controls.Add(this.lblTableId);
            this.Controls.Add(this.lblBillId);
            this.Name = "BillDetailForm";
            this.Text = "BillDetailForm";
            this.Load += new System.EventHandler(this.BillDetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPaymentTime;
        private System.Windows.Forms.Label lblTableId;
        private System.Windows.Forms.Label lblBillId;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}