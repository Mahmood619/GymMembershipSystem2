namespace GymMembershipSystem2
{
    partial class ManageEquipmentForm
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
            this.components = new System.ComponentModel.Container();
            this.txtEquipmentName = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtEquipmentCategory = new System.Windows.Forms.TextBox();
            this.txtEquipmentQuantity = new System.Windows.Forms.TextBox();
            this.dataGridViewEquipment = new System.Windows.Forms.DataGridView();
            this.btnUpdateEquipment = new System.Windows.Forms.Button();
            this.btnAddEquipment = new System.Windows.Forms.Button();
            this.btnRemoveEquipment = new System.Windows.Forms.Button();
            this.btnViewEquipment = new System.Windows.Forms.Button();
            this.dtpLastServiced = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEquipment)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEquipmentName
            // 
            this.txtEquipmentName.Location = new System.Drawing.Point(134, 43);
            this.txtEquipmentName.Name = "txtEquipmentName";
            this.txtEquipmentName.Size = new System.Drawing.Size(135, 20);
            this.txtEquipmentName.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtEquipmentCategory
            // 
            this.txtEquipmentCategory.Location = new System.Drawing.Point(134, 86);
            this.txtEquipmentCategory.Name = "txtEquipmentCategory";
            this.txtEquipmentCategory.Size = new System.Drawing.Size(135, 20);
            this.txtEquipmentCategory.TabIndex = 2;
            // 
            // txtEquipmentQuantity
            // 
            this.txtEquipmentQuantity.Location = new System.Drawing.Point(134, 131);
            this.txtEquipmentQuantity.Name = "txtEquipmentQuantity";
            this.txtEquipmentQuantity.Size = new System.Drawing.Size(135, 20);
            this.txtEquipmentQuantity.TabIndex = 3;
            this.txtEquipmentQuantity.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // dataGridViewEquipment
            // 
            this.dataGridViewEquipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEquipment.Location = new System.Drawing.Point(497, 86);
            this.dataGridViewEquipment.Name = "dataGridViewEquipment";
            this.dataGridViewEquipment.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewEquipment.TabIndex = 4;
            // 
            // btnUpdateEquipment
            // 
            this.btnUpdateEquipment.Location = new System.Drawing.Point(160, 226);
            this.btnUpdateEquipment.Name = "btnUpdateEquipment";
            this.btnUpdateEquipment.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateEquipment.TabIndex = 5;
            this.btnUpdateEquipment.Text = "Update";
            this.btnUpdateEquipment.UseVisualStyleBackColor = true;
            this.btnUpdateEquipment.Click += new System.EventHandler(this.btnUpdateEquipment_Click);
            // 
            // btnAddEquipment
            // 
            this.btnAddEquipment.Location = new System.Drawing.Point(45, 226);
            this.btnAddEquipment.Name = "btnAddEquipment";
            this.btnAddEquipment.Size = new System.Drawing.Size(75, 23);
            this.btnAddEquipment.TabIndex = 6;
            this.btnAddEquipment.Text = "Add ";
            this.btnAddEquipment.UseVisualStyleBackColor = true;
            this.btnAddEquipment.Click += new System.EventHandler(this.btnAddEquipment_Click);
            // 
            // btnRemoveEquipment
            // 
            this.btnRemoveEquipment.Location = new System.Drawing.Point(280, 226);
            this.btnRemoveEquipment.Name = "btnRemoveEquipment";
            this.btnRemoveEquipment.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveEquipment.TabIndex = 7;
            this.btnRemoveEquipment.Text = "Delete";
            this.btnRemoveEquipment.UseVisualStyleBackColor = true;
            this.btnRemoveEquipment.Click += new System.EventHandler(this.btnRemoveEquipment_Click);
            // 
            // btnViewEquipment
            // 
            this.btnViewEquipment.Location = new System.Drawing.Point(560, 40);
            this.btnViewEquipment.Name = "btnViewEquipment";
            this.btnViewEquipment.Size = new System.Drawing.Size(118, 23);
            this.btnViewEquipment.TabIndex = 9;
            this.btnViewEquipment.Text = "View Equipment";
            this.btnViewEquipment.UseVisualStyleBackColor = true;
            this.btnViewEquipment.Click += new System.EventHandler(this.btnViewEquipment_Click);
            // 
            // dtpLastServiced
            // 
            this.dtpLastServiced.Location = new System.Drawing.Point(134, 171);
            this.dtpLastServiced.Name = "dtpLastServiced";
            this.dtpLastServiced.Size = new System.Drawing.Size(135, 20);
            this.dtpLastServiced.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Category ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Quantity ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Date";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Back to Staff Dashboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ManageEquipmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpLastServiced);
            this.Controls.Add(this.btnViewEquipment);
            this.Controls.Add(this.btnRemoveEquipment);
            this.Controls.Add(this.btnAddEquipment);
            this.Controls.Add(this.btnUpdateEquipment);
            this.Controls.Add(this.dataGridViewEquipment);
            this.Controls.Add(this.txtEquipmentQuantity);
            this.Controls.Add(this.txtEquipmentCategory);
            this.Controls.Add(this.txtEquipmentName);
            this.Name = "ManageEquipmentForm";
            this.Text = "ManageEquipmentForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEquipment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEquipmentName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtEquipmentCategory;
        private System.Windows.Forms.TextBox txtEquipmentQuantity;
        private System.Windows.Forms.DataGridView dataGridViewEquipment;
        private System.Windows.Forms.Button btnUpdateEquipment;
        private System.Windows.Forms.Button btnAddEquipment;
        private System.Windows.Forms.Button btnRemoveEquipment;
        private System.Windows.Forms.Button btnViewEquipment;
        private System.Windows.Forms.DateTimePicker dtpLastServiced;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}