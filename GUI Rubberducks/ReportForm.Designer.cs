namespace GUI_Registration_p1
{
    partial class ReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lsbUsername = new System.Windows.Forms.ListBox();
            this.userinfoTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rDTables = new GUI_Registration_p1.RDTables();
            this.userinfoTableTableAdapter = new GUI_Registration_p1.RDTablesTableAdapters.userinfoTableTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.lblSubject = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.userinfoTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDTables)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 86);
            this.richTextBox1.MaxLength = 500;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(800, 352);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Recipient:";
            // 
            // lsbUsername
            // 
            this.lsbUsername.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.userinfoTableBindingSource, "Username ", true));
            this.lsbUsername.DataSource = this.userinfoTableBindingSource;
            this.lsbUsername.DisplayMember = "Username ";
            this.lsbUsername.FormattingEnabled = true;
            this.lsbUsername.ItemHeight = 25;
            this.lsbUsername.Location = new System.Drawing.Point(162, 11);
            this.lsbUsername.Name = "lsbUsername";
            this.lsbUsername.Size = new System.Drawing.Size(308, 29);
            this.lsbUsername.TabIndex = 3;
            this.lsbUsername.ValueMember = "Username ";
            // 
            // userinfoTableBindingSource
            // 
            this.userinfoTableBindingSource.DataMember = "userinfoTable";
            this.userinfoTableBindingSource.DataSource = this.rDTables;
            // 
            // rDTables
            // 
            this.rDTables.DataSetName = "RDTables";
            this.rDTables.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userinfoTableTableAdapter
            // 
            this.userinfoTableTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(295, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 48);
            this.button1.TabIndex = 4;
            this.button1.Text = "Submit Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(19, 49);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(137, 25);
            this.lblSubject.TabIndex = 5;
            this.lblSubject.Text = "Subject Line:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(162, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(308, 31);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "(Enter subject)";
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(824, 504);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lsbUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create a Report";
            this.Load += new System.EventHandler(this.MockReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userinfoTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDTables)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lsbUsername;
        private RDTables rDTables;
        private System.Windows.Forms.BindingSource userinfoTableBindingSource;
        private RDTablesTableAdapters.userinfoTableTableAdapter userinfoTableTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.TextBox textBox1;
    }
}