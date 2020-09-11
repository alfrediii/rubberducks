namespace GUI_Registration_p1
{
    partial class TicketForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketForm));
			this.lblTicketID = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.btnEdit = new System.Windows.Forms.Button();
			this.rtbDescription = new System.Windows.Forms.RichTextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lblDate = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblRaisedBy = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblStatus = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbProblemType = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.cmbAssignedTo = new System.Windows.Forms.ComboBox();
			this.userinfoTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.rDTables = new GUI_Registration_p1.RDTables();
			this.userinfoTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.userinfoTableTableAdapter = new GUI_Registration_p1.RDTablesTableAdapters.userinfoTableTableAdapter();
			this.lblProblemType = new System.Windows.Forms.Label();
			this.lblAssignedTo = new System.Windows.Forms.Label();
			this.btnReopen = new System.Windows.Forms.Button();
			this.btnResolve = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.userinfoTableBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rDTables)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.userinfoTableBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// lblTicketID
			// 
			this.lblTicketID.AutoSize = true;
			this.lblTicketID.Location = new System.Drawing.Point(941, 34);
			this.lblTicketID.Name = "lblTicketID";
			this.lblTicketID.Size = new System.Drawing.Size(32, 25);
			this.lblTicketID.TabIndex = 35;
			this.lblTicketID.Text = "\" \"";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(800, 34);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(112, 25);
			this.label6.TabIndex = 34;
			this.label6.Text = "Ticket ID:";
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(165, 737);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(165, 58);
			this.btnEdit.TabIndex = 33;
			this.btnEdit.Text = "Edit";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Visible = false;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// rtbDescription
			// 
			this.rtbDescription.Location = new System.Drawing.Point(82, 325);
			this.rtbDescription.Name = "rtbDescription";
			this.rtbDescription.ReadOnly = true;
			this.rtbDescription.Size = new System.Drawing.Size(1031, 362);
			this.rtbDescription.TabIndex = 32;
			this.rtbDescription.Text = "";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(77, 297);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(115, 25);
			this.label5.TabIndex = 31;
			this.label5.Text = "Decription:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(78, 224);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(75, 25);
			this.label4.TabIndex = 30;
			this.label4.Text = "Issue:";
			// 
			// lblDate
			// 
			this.lblDate.AutoSize = true;
			this.lblDate.Location = new System.Drawing.Point(261, 159);
			this.lblDate.Name = "lblDate";
			this.lblDate.Size = new System.Drawing.Size(32, 25);
			this.lblDate.TabIndex = 29;
			this.lblDate.Text = "\" \"";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(78, 160);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(158, 25);
			this.label3.TabIndex = 28;
			this.label3.Text = "Date of Issue:";
			// 
			// lblRaisedBy
			// 
			this.lblRaisedBy.AutoSize = true;
			this.lblRaisedBy.Location = new System.Drawing.Point(256, 95);
			this.lblRaisedBy.Name = "lblRaisedBy";
			this.lblRaisedBy.Size = new System.Drawing.Size(32, 25);
			this.lblRaisedBy.TabIndex = 27;
			this.lblRaisedBy.Text = "\" \"";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(78, 95);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(124, 25);
			this.label2.TabIndex = 26;
			this.label2.Text = "Raised by:";
			// 
			// lblStatus
			// 
			this.lblStatus.AutoSize = true;
			this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblStatus.Location = new System.Drawing.Point(256, 34);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(137, 25);
			this.lblStatus.TabIndex = 25;
			this.lblStatus.Text = "Closed/Open";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(78, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(157, 25);
			this.label1.TabIndex = 24;
			this.label1.Text = "Ticket Status:";
			// 
			// cmbProblemType
			// 
			this.cmbProblemType.FormattingEnabled = true;
			this.cmbProblemType.Items.AddRange(new object[] {
            "Broken Printer",
            "Green/Blue Screen on Laptop",
            "I can\'t access the internet",
            "I can\'t change my password",
            "I deleted an important file",
            "I logged out without saving a document",
            "I think my account has been breached",
            "My computer is lagging frequently",
            "My computer won\'t recognize my USB",
            "My user type is not accurate",
            "Other"});
			this.cmbProblemType.Location = new System.Drawing.Point(165, 216);
			this.cmbProblemType.Name = "cmbProblemType";
			this.cmbProblemType.Size = new System.Drawing.Size(391, 33);
			this.cmbProblemType.TabIndex = 23;
			this.cmbProblemType.Text = "  Select Error Type";
			this.cmbProblemType.Visible = false;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(769, 74);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(143, 25);
			this.label7.TabIndex = 36;
			this.label7.Text = "Assigned to:";
			// 
			// cmbAssignedTo
			// 
			this.cmbAssignedTo.FormattingEnabled = true;
			this.cmbAssignedTo.Items.AddRange(new object[] {
            "cmraymo1"});
			this.cmbAssignedTo.Location = new System.Drawing.Point(918, 74);
			this.cmbAssignedTo.Name = "cmbAssignedTo";
			this.cmbAssignedTo.Size = new System.Drawing.Size(265, 33);
			this.cmbAssignedTo.TabIndex = 37;
			this.cmbAssignedTo.Visible = false;
			this.cmbAssignedTo.SelectedIndexChanged += new System.EventHandler(this.cmbAssignedTo_SelectedIndexChanged);
			// 
			// userinfoTableBindingSource1
			// 
			this.userinfoTableBindingSource1.DataMember = "userinfoTable";
			this.userinfoTableBindingSource1.DataSource = this.rDTables;
			// 
			// rDTables
			// 
			this.rDTables.DataSetName = "RDTables";
			this.rDTables.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// userinfoTableBindingSource
			// 
			this.userinfoTableBindingSource.DataMember = "userinfoTable";
			this.userinfoTableBindingSource.DataSource = this.rDTables;
			// 
			// userinfoTableTableAdapter
			// 
			this.userinfoTableTableAdapter.ClearBeforeFill = true;
			// 
			// lblProblemType
			// 
			this.lblProblemType.AutoSize = true;
			this.lblProblemType.Location = new System.Drawing.Point(256, 224);
			this.lblProblemType.Name = "lblProblemType";
			this.lblProblemType.Size = new System.Drawing.Size(32, 25);
			this.lblProblemType.TabIndex = 38;
			this.lblProblemType.Text = "\" \"";
			// 
			// lblAssignedTo
			// 
			this.lblAssignedTo.AutoSize = true;
			this.lblAssignedTo.Location = new System.Drawing.Point(941, 77);
			this.lblAssignedTo.Name = "lblAssignedTo";
			this.lblAssignedTo.Size = new System.Drawing.Size(32, 25);
			this.lblAssignedTo.TabIndex = 39;
			this.lblAssignedTo.Text = "\" \"";
			// 
			// btnReopen
			// 
			this.btnReopen.Location = new System.Drawing.Point(498, 737);
			this.btnReopen.Name = "btnReopen";
			this.btnReopen.Size = new System.Drawing.Size(165, 58);
			this.btnReopen.TabIndex = 40;
			this.btnReopen.Text = "Reopen";
			this.btnReopen.UseVisualStyleBackColor = true;
			this.btnReopen.Visible = false;
			this.btnReopen.Click += new System.EventHandler(this.btnReopen_Click);
			// 
			// btnResolve
			// 
			this.btnResolve.Location = new System.Drawing.Point(819, 737);
			this.btnResolve.Name = "btnResolve";
			this.btnResolve.Size = new System.Drawing.Size(165, 58);
			this.btnResolve.TabIndex = 41;
			this.btnResolve.Text = "Resolve";
			this.btnResolve.UseVisualStyleBackColor = true;
			this.btnResolve.Visible = false;
			this.btnResolve.Click += new System.EventHandler(this.btnResolve_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(819, 737);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(165, 58);
			this.btnCancel.TabIndex = 42;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Visible = false;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// TicketForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Pink;
			this.ClientSize = new System.Drawing.Size(1191, 827);
			this.Controls.Add(this.btnResolve);
			this.Controls.Add(this.btnReopen);
			this.Controls.Add(this.lblAssignedTo);
			this.Controls.Add(this.lblProblemType);
			this.Controls.Add(this.cmbAssignedTo);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.lblTicketID);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.rtbDescription);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lblDate);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblRaisedBy);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblStatus);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmbProblemType);
			this.Controls.Add(this.btnCancel);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "TicketForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ticket";
			this.Load += new System.EventHandler(this.TicketForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.userinfoTableBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rDTables)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.userinfoTableBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTicketID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRaisedBy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProblemType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbAssignedTo;
        private RDTables rDTables;
        private System.Windows.Forms.BindingSource userinfoTableBindingSource;
        private RDTablesTableAdapters.userinfoTableTableAdapter userinfoTableTableAdapter;
		private System.Windows.Forms.BindingSource userinfoTableBindingSource1;
		private System.Windows.Forms.Label lblProblemType;
		private System.Windows.Forms.Label lblAssignedTo;
		private System.Windows.Forms.Button btnReopen;
		private System.Windows.Forms.Button btnResolve;
		private System.Windows.Forms.Button btnCancel;
	}
}