namespace GUI_Registration
{
    partial class TicketCreationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketCreationForm));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmboxProblemType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dtpCompletionDate = new System.Windows.Forms.DateTimePicker();
            this.rDTables = new GUI_Registration_p1.RDTables();
            this.userinfoTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userinfoTableTableAdapter = new GUI_Registration_p1.RDTablesTableAdapters.userinfoTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.rDTables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userinfoTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 248);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1200, 364);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtUsername.Location = new System.Drawing.Point(160, 72);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.Size = new System.Drawing.Size(391, 31);
            this.txtUsername.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(465, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "Create a Ticket";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Issue Type:";
            // 
            // cmboxProblemType
            // 
            this.cmboxProblemType.FormattingEnabled = true;
            this.cmboxProblemType.Items.AddRange(new object[] {
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
            this.cmboxProblemType.Location = new System.Drawing.Point(160, 117);
            this.cmboxProblemType.Name = "cmboxProblemType";
            this.cmboxProblemType.Size = new System.Drawing.Size(391, 33);
            this.cmboxProblemType.TabIndex = 9;
            this.cmboxProblemType.Text = "  Select Error Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(387, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Describe the error in more detail below:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Location = new System.Drawing.Point(11, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Date of Issue:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(554, 618);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 39);
            this.button1.TabIndex = 11;
            this.button1.Text = "Submit Ticket";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpCompletionDate
            // 
            this.dtpCompletionDate.Location = new System.Drawing.Point(160, 165);
            this.dtpCompletionDate.Name = "dtpCompletionDate";
            this.dtpCompletionDate.Size = new System.Drawing.Size(391, 31);
            this.dtpCompletionDate.TabIndex = 29;
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
            // TicketCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1224, 669);
            this.Controls.Add(this.dtpCompletionDate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmboxProblemType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.richTextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TicketCreationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create a Ticket";
            this.Load += new System.EventHandler(this.TicketCreationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rDTables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userinfoTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmboxProblemType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpCompletionDate;
        private GUI_Registration_p1.RDTables rDTables;
        private System.Windows.Forms.BindingSource userinfoTableBindingSource;
        private GUI_Registration_p1.RDTablesTableAdapters.userinfoTableTableAdapter userinfoTableTableAdapter;
    }
}