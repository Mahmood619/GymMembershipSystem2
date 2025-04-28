namespace GymMembershipSystem2
{
    partial class ManageMembersForm
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
            this.btnRegisterNew = new System.Windows.Forms.Button();
            this.btnViewMembers = new System.Windows.Forms.Button();
            this.btnRemoveMember = new System.Windows.Forms.Button();
            this.dataGridViewMembers = new System.Windows.Forms.DataGridView();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegisterNew
            // 
            this.btnRegisterNew.Location = new System.Drawing.Point(347, 365);
            this.btnRegisterNew.Name = "btnRegisterNew";
            this.btnRegisterNew.Size = new System.Drawing.Size(114, 23);
            this.btnRegisterNew.TabIndex = 0;
            this.btnRegisterNew.Text = "Register Members";
            this.btnRegisterNew.UseVisualStyleBackColor = true;
            this.btnRegisterNew.Click += new System.EventHandler(this.btnRegisterNew_Click);
            // 
            // btnViewMembers
            // 
            this.btnViewMembers.Location = new System.Drawing.Point(215, 100);
            this.btnViewMembers.Name = "btnViewMembers";
            this.btnViewMembers.Size = new System.Drawing.Size(103, 23);
            this.btnViewMembers.TabIndex = 1;
            this.btnViewMembers.Text = "View Member/s";
            this.btnViewMembers.UseVisualStyleBackColor = true;
            this.btnViewMembers.Click += new System.EventHandler(this.btnViewMembers_Click);
            // 
            // btnRemoveMember
            // 
            this.btnRemoveMember.Location = new System.Drawing.Point(484, 100);
            this.btnRemoveMember.Name = "btnRemoveMember";
            this.btnRemoveMember.Size = new System.Drawing.Size(101, 23);
            this.btnRemoveMember.TabIndex = 2;
            this.btnRemoveMember.Text = "Delete Member";
            this.btnRemoveMember.UseVisualStyleBackColor = true;
            this.btnRemoveMember.Click += new System.EventHandler(this.btnRemoveMember_Click);
            // 
            // dataGridViewMembers
            // 
            this.dataGridViewMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMembers.Location = new System.Drawing.Point(196, 129);
            this.dataGridViewMembers.Name = "dataGridViewMembers";
            this.dataGridViewMembers.Size = new System.Drawing.Size(415, 230);
            this.dataGridViewMembers.TabIndex = 3;
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(351, 59);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(100, 20);
            this.txtMemberID.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Member ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Back to Staff Dashboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ManageMembersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.dataGridViewMembers);
            this.Controls.Add(this.btnRemoveMember);
            this.Controls.Add(this.btnViewMembers);
            this.Controls.Add(this.btnRegisterNew);
            this.Name = "ManageMembersForm";
            this.Text = "ManageMembersForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegisterNew;
        private System.Windows.Forms.Button btnViewMembers;
        private System.Windows.Forms.Button btnRemoveMember;
        private System.Windows.Forms.DataGridView dataGridViewMembers;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}