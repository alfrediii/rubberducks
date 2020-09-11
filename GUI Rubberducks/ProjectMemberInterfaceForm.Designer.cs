namespace GUI_Registration_p1
{
	partial class ProjectMemberInterfaceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectMemberInterfaceForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.UserDropDownMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOnlineHelp = new System.Windows.Forms.Button();
            this.btnSolvedTickets = new System.Windows.Forms.Button();
            this.btnOpenTickets = new System.Windows.Forms.Button();
            this.ticketTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rDTables = new GUI_Registration_p1.RDTables();
            this.btnRaise = new System.Windows.Forms.Button();
            this.ticketTableTableAdapter1 = new GUI_Registration_p1.RDTablesTableAdapters.ticketTableTableAdapter();
            this.btnViewTicket = new System.Windows.Forms.Button();
            this.lsbTickets = new System.Windows.Forms.ListBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDTables)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UserDropDownMenu});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1274, 42);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // UserDropDownMenu
            // 
            this.UserDropDownMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UserDropDownMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.UserDropDownMenu.Image = ((System.Drawing.Image)(resources.GetObject("UserDropDownMenu.Image")));
            this.UserDropDownMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UserDropDownMenu.Name = "UserDropDownMenu";
            this.UserDropDownMenu.Size = new System.Drawing.Size(54, 36);
            this.UserDropDownMenu.Text = "User Dropdown Menu";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(275, 44);
            this.profileToolStripMenuItem.Text = "View Profile";
            this.profileToolStripMenuItem.Click += new System.EventHandler(this.profileToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(275, 44);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // btnOnlineHelp
            // 
            this.btnOnlineHelp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOnlineHelp.Location = new System.Drawing.Point(1028, 89);
            this.btnOnlineHelp.Margin = new System.Windows.Forms.Padding(6);
            this.btnOnlineHelp.Name = "btnOnlineHelp";
            this.btnOnlineHelp.Size = new System.Drawing.Size(230, 50);
            this.btnOnlineHelp.TabIndex = 12;
            this.btnOnlineHelp.Text = "Online Help";
            this.btnOnlineHelp.UseVisualStyleBackColor = true;
            this.btnOnlineHelp.Click += new System.EventHandler(this.btnOnlineHelp_Click);
            // 
            // btnSolvedTickets
            // 
            this.btnSolvedTickets.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSolvedTickets.Location = new System.Drawing.Point(320, 89);
            this.btnSolvedTickets.Margin = new System.Windows.Forms.Padding(6);
            this.btnSolvedTickets.Name = "btnSolvedTickets";
            this.btnSolvedTickets.Size = new System.Drawing.Size(230, 50);
            this.btnSolvedTickets.TabIndex = 11;
            this.btnSolvedTickets.Text = "Solved Tickets";
            this.btnSolvedTickets.UseVisualStyleBackColor = true;
            this.btnSolvedTickets.Click += new System.EventHandler(this.btnSolvedTickets_Click);
            // 
            // btnOpenTickets
            // 
            this.btnOpenTickets.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOpenTickets.Location = new System.Drawing.Point(12, 89);
            this.btnOpenTickets.Margin = new System.Windows.Forms.Padding(6);
            this.btnOpenTickets.Name = "btnOpenTickets";
            this.btnOpenTickets.Size = new System.Drawing.Size(228, 50);
            this.btnOpenTickets.TabIndex = 10;
            this.btnOpenTickets.Text = "Open Tickets";
            this.btnOpenTickets.UseVisualStyleBackColor = true;
            this.btnOpenTickets.Click += new System.EventHandler(this.btnOpenTickets_Click_1);
            // 
            // ticketTableBindingSource
            // 
            this.ticketTableBindingSource.DataMember = "ticketTable";
            this.ticketTableBindingSource.DataSource = this.rDTables;
            // 
            // rDTables
            // 
            this.rDTables.DataSetName = "RDTables";
            this.rDTables.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnRaise
            // 
            this.btnRaise.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRaise.Location = new System.Drawing.Point(677, 89);
            this.btnRaise.Margin = new System.Windows.Forms.Padding(6);
            this.btnRaise.Name = "btnRaise";
            this.btnRaise.Size = new System.Drawing.Size(230, 50);
            this.btnRaise.TabIndex = 8;
            this.btnRaise.Text = "Raise Ticket";
            this.btnRaise.UseVisualStyleBackColor = true;
            this.btnRaise.Click += new System.EventHandler(this.btnRaise_Click);
            // 
            // ticketTableTableAdapter1
            // 
            this.ticketTableTableAdapter1.ClearBeforeFill = true;
            // 
            // btnViewTicket
            // 
            this.btnViewTicket.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnViewTicket.Location = new System.Drawing.Point(508, 778);
            this.btnViewTicket.Name = "btnViewTicket";
            this.btnViewTicket.Size = new System.Drawing.Size(209, 54);
            this.btnViewTicket.TabIndex = 14;
            this.btnViewTicket.Text = "View Ticket";
            this.btnViewTicket.UseVisualStyleBackColor = true;
            this.btnViewTicket.Click += new System.EventHandler(this.btnViewTicket_Click);
            // 
            // lsbTickets
            // 
            this.lsbTickets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsbTickets.Font = new System.Drawing.Font("Courier New", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbTickets.FormattingEnabled = true;
            this.lsbTickets.HorizontalScrollbar = true;
            this.lsbTickets.ItemHeight = 30;
            this.lsbTickets.Location = new System.Drawing.Point(13, 148);
            this.lsbTickets.Name = "lsbTickets";
            this.lsbTickets.Size = new System.Drawing.Size(1245, 604);
            this.lsbTickets.TabIndex = 15;
            this.lsbTickets.SelectedIndexChanged += new System.EventHandler(this.lsbTickets_SelectedIndexChanged_1);
            // 
            // ProjectMemberInterfaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1274, 868);
            this.Controls.Add(this.lsbTickets);
            this.Controls.Add(this.btnViewTicket);
            this.Controls.Add(this.btnOnlineHelp);
            this.Controls.Add(this.btnSolvedTickets);
            this.Controls.Add(this.btnOpenTickets);
            this.Controls.Add(this.btnRaise);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProjectMemberInterfaceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticket Management System | Project Member";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProjectMemberInterface_FormClosed);
            this.Load += new System.EventHandler(this.ProjectMemberInterface_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDTables)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripDropDownButton UserDropDownMenu;
		private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Button btnOnlineHelp;
        private System.Windows.Forms.Button btnSolvedTickets;
        private System.Windows.Forms.Button btnOpenTickets;
        private System.Windows.Forms.Button btnRaise;
        private RDTablesTableAdapters.ticketTableTableAdapter ticketTableTableAdapter1;
        private System.Windows.Forms.BindingSource ticketTableBindingSource;
        private RDTables rDTables;
        private System.Windows.Forms.Button btnViewTicket;
        private System.Windows.Forms.ListBox lsbTickets;
    }
}