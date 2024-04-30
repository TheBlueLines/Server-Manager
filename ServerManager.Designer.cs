namespace Developer_Tools
{
	partial class ServerManager
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerManager));
			servers = new ListBox();
			terminal = new RichTextBox();
			menu = new MenuStrip();
			serversToolStripMenuItem = new ToolStripMenuItem();
			addToolStripMenuItem = new ToolStripMenuItem();
			removeToolStripMenuItem = new ToolStripMenuItem();
			configureToolStripMenuItem = new ToolStripMenuItem();
			power = new Button();
			aboutToolStripMenuItem = new ToolStripMenuItem();
			menu.SuspendLayout();
			SuspendLayout();
			// 
			// servers
			// 
			servers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			servers.FormattingEnabled = true;
			servers.ItemHeight = 15;
			servers.Location = new Point(12, 27);
			servers.Name = "servers";
			servers.Size = new Size(120, 379);
			servers.TabIndex = 0;
			servers.SelectedIndexChanged += servers_SelectedIndexChanged;
			// 
			// terminal
			// 
			terminal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			terminal.BorderStyle = BorderStyle.FixedSingle;
			terminal.Enabled = false;
			terminal.Location = new Point(138, 27);
			terminal.Name = "terminal";
			terminal.ReadOnly = true;
			terminal.Size = new Size(650, 411);
			terminal.TabIndex = 1;
			terminal.Text = "";
			// 
			// menu
			// 
			menu.Items.AddRange(new ToolStripItem[] { serversToolStripMenuItem, aboutToolStripMenuItem });
			menu.Location = new Point(0, 0);
			menu.Name = "menu";
			menu.Size = new Size(800, 24);
			menu.TabIndex = 2;
			menu.Text = "menu";
			// 
			// serversToolStripMenuItem
			// 
			serversToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addToolStripMenuItem, removeToolStripMenuItem, configureToolStripMenuItem });
			serversToolStripMenuItem.Name = "serversToolStripMenuItem";
			serversToolStripMenuItem.Size = new Size(56, 20);
			serversToolStripMenuItem.Text = "Servers";
			// 
			// addToolStripMenuItem
			// 
			addToolStripMenuItem.Name = "addToolStripMenuItem";
			addToolStripMenuItem.Size = new Size(180, 22);
			addToolStripMenuItem.Text = "Add";
			addToolStripMenuItem.Click += addToolStripMenuItem_Click;
			// 
			// removeToolStripMenuItem
			// 
			removeToolStripMenuItem.Name = "removeToolStripMenuItem";
			removeToolStripMenuItem.Size = new Size(180, 22);
			removeToolStripMenuItem.Text = "Remove";
			removeToolStripMenuItem.Click += removeToolStripMenuItem_Click;
			// 
			// configureToolStripMenuItem
			// 
			configureToolStripMenuItem.Name = "configureToolStripMenuItem";
			configureToolStripMenuItem.Size = new Size(180, 22);
			configureToolStripMenuItem.Text = "Configure";
			configureToolStripMenuItem.Click += configureToolStripMenuItem_Click;
			// 
			// power
			// 
			power.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			power.Enabled = false;
			power.Location = new Point(12, 412);
			power.Name = "power";
			power.Size = new Size(120, 26);
			power.TabIndex = 3;
			power.Text = "Start";
			power.UseVisualStyleBackColor = true;
			power.Click += power_Click;
			// 
			// aboutToolStripMenuItem
			// 
			aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			aboutToolStripMenuItem.Size = new Size(52, 20);
			aboutToolStripMenuItem.Text = "About";
			aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
			// 
			// ServerManager
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(power);
			Controls.Add(terminal);
			Controls.Add(servers);
			Controls.Add(menu);
			Icon = (Icon)resources.GetObject("$this.Icon");
			MainMenuStrip = menu;
			Name = "ServerManager";
			Text = "Server Manager";
			FormClosing += ServerManager_FormClosing;
			menu.ResumeLayout(false);
			menu.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ListBox servers;
		private RichTextBox terminal;
		private MenuStrip menu;
		private ToolStripMenuItem serversToolStripMenuItem;
		private ToolStripMenuItem addToolStripMenuItem;
		private ToolStripMenuItem removeToolStripMenuItem;
		private ToolStripMenuItem configureToolStripMenuItem;
		private Button power;
		private ToolStripMenuItem aboutToolStripMenuItem;
	}
}