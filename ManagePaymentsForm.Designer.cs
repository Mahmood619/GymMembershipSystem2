﻿namespace GymMembershipSystem2
{
    partial class ManagePaymentsForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMemberList = new System.Windows.Forms.ComboBox();
            this.txtPaymentAmount = new System.Windows.Forms.TextBox();
            this.txtPaymentMethod = new System.Windows.Forms.TextBox();
            this.btnAddPayment = new System.Windows.Forms.Button();
            this.dataGridViewPayments = new System.Windows.Forms.DataGridView();
            this.btnViewAllPayments = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayments)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "View Member/s";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Amount";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter Payment Method";
            // 
            // cmbMemberList
            // 
            this.cmbMemberList.FormattingEnabled = true;
            this.cmbMemberList.Location = new System.Drawing.Point(165, 53);
            this.cmbMemberList.Name = "cmbMemberList";
            this.cmbMemberList.Size = new System.Drawing.Size(121, 21);
            this.cmbMemberList.TabIndex = 3;
            this.cmbMemberList.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtPaymentAmount
            // 
            this.txtPaymentAmount.Location = new System.Drawing.Point(165, 110);
            this.txtPaymentAmount.Name = "txtPaymentAmount";
            this.txtPaymentAmount.Size = new System.Drawing.Size(121, 20);
            this.txtPaymentAmount.TabIndex = 4;
            // 
            // txtPaymentMethod
            // 
            this.txtPaymentMethod.Location = new System.Drawing.Point(165, 168);
            this.txtPaymentMethod.Name = "txtPaymentMethod";
            this.txtPaymentMethod.Size = new System.Drawing.Size(121, 20);
            this.txtPaymentMethod.TabIndex = 5;
            // 
            // btnAddPayment
            // 
            this.btnAddPayment.Location = new System.Drawing.Point(174, 209);
            this.btnAddPayment.Name = "btnAddPayment";
            this.btnAddPayment.Size = new System.Drawing.Size(104, 23);
            this.btnAddPayment.TabIndex = 6;
            this.btnAddPayment.Text = "Add Payment";
            this.btnAddPayment.UseVisualStyleBackColor = true;
            this.btnAddPayment.Click += new System.EventHandler(this.btnAddPayment_Click);
            // 
            // dataGridViewPayments
            // 
            this.dataGridViewPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPayments.Location = new System.Drawing.Point(485, 72);
            this.dataGridViewPayments.Name = "dataGridViewPayments";
            this.dataGridViewPayments.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewPayments.TabIndex = 9;
            this.dataGridViewPayments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPayments_CellContentClick);
            // 
            // btnViewAllPayments
            // 
            this.btnViewAllPayments.Location = new System.Drawing.Point(562, 32);
            this.btnViewAllPayments.Name = "btnViewAllPayments";
            this.btnViewAllPayments.Size = new System.Drawing.Size(97, 23);
            this.btnViewAllPayments.TabIndex = 10;
            this.btnViewAllPayments.Text = "View Payments";
            this.btnViewAllPayments.UseVisualStyleBackColor = true;
            this.btnViewAllPayments.Click += new System.EventHandler(this.btnViewAllPayments_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Back to Staff Dashboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ManagePaymentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnViewAllPayments);
            this.Controls.Add(this.dataGridViewPayments);
            this.Controls.Add(this.btnAddPayment);
            this.Controls.Add(this.txtPaymentMethod);
            this.Controls.Add(this.txtPaymentAmount);
            this.Controls.Add(this.cmbMemberList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ManagePaymentsForm";
            this.Text = "ManagePaymentsForm";
            this.Load += new System.EventHandler(this.ManagePaymentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMemberList;
        private System.Windows.Forms.TextBox txtPaymentAmount;
        private System.Windows.Forms.TextBox txtPaymentMethod;
        private System.Windows.Forms.Button btnAddPayment;
        private System.Windows.Forms.DataGridView dataGridViewPayments;
        private System.Windows.Forms.Button btnViewAllPayments;
        private System.Windows.Forms.Button button1;
    }
}