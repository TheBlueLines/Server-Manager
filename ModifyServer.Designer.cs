namespace Developer_Tools
{
	partial class ModifyServer
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyServer));
			serverName = new TextBox();
			serverNameText = new Label();
			serverExeText = new Label();
			serverExe = new TextBox();
			serverPath = new TextBox();
			serverPathText = new Label();
			serverBrowsePath = new Button();
			serverBrowseExe = new Button();
			save = new Button();
			serverArgs = new TextBox();
			serverArgsText = new Label();
			SuspendLayout();
			// 
			// serverName
			// 
			serverName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			serverName.BorderStyle = BorderStyle.FixedSingle;
			serverName.Font = new Font("Roboto", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
			serverName.Location = new Point(12, 62);
			serverName.Name = "serverName";
			serverName.Size = new Size(400, 40);
			serverName.TabIndex = 0;
			// 
			// serverNameText
			// 
			serverNameText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			serverNameText.Font = new Font("Roboto", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
			serverNameText.Location = new Point(12, 9);
			serverNameText.Name = "serverNameText";
			serverNameText.Size = new Size(400, 50);
			serverNameText.TabIndex = 1;
			serverNameText.Text = "Server Name:";
			serverNameText.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// serverExeText
			// 
			serverExeText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			serverExeText.Font = new Font("Roboto", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
			serverExeText.Location = new Point(12, 105);
			serverExeText.Name = "serverExeText";
			serverExeText.Size = new Size(400, 50);
			serverExeText.TabIndex = 2;
			serverExeText.Text = "Executable Location:";
			serverExeText.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// serverExe
			// 
			serverExe.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			serverExe.BorderStyle = BorderStyle.FixedSingle;
			serverExe.Font = new Font("Roboto", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
			serverExe.Location = new Point(12, 158);
			serverExe.Name = "serverExe";
			serverExe.Size = new Size(360, 40);
			serverExe.TabIndex = 3;
			// 
			// serverPath
			// 
			serverPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			serverPath.BorderStyle = BorderStyle.FixedSingle;
			serverPath.Font = new Font("Roboto", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
			serverPath.Location = new Point(12, 254);
			serverPath.Name = "serverPath";
			serverPath.Size = new Size(360, 40);
			serverPath.TabIndex = 5;
			// 
			// serverPathText
			// 
			serverPathText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			serverPathText.Font = new Font("Roboto", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
			serverPathText.Location = new Point(12, 201);
			serverPathText.Name = "serverPathText";
			serverPathText.Size = new Size(400, 50);
			serverPathText.TabIndex = 4;
			serverPathText.Text = "Working Directory:";
			serverPathText.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// serverBrowsePath
			// 
			serverBrowsePath.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			serverBrowsePath.Font = new Font("Roboto", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
			serverBrowsePath.Location = new Point(372, 254);
			serverBrowsePath.Name = "serverBrowsePath";
			serverBrowsePath.Size = new Size(40, 40);
			serverBrowsePath.TabIndex = 6;
			serverBrowsePath.Text = "...";
			serverBrowsePath.UseVisualStyleBackColor = true;
			serverBrowsePath.Click += serverBrowsePath_Click;
			// 
			// serverBrowseExe
			// 
			serverBrowseExe.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			serverBrowseExe.Font = new Font("Roboto", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
			serverBrowseExe.Location = new Point(372, 158);
			serverBrowseExe.Name = "serverBrowseExe";
			serverBrowseExe.Size = new Size(40, 40);
			serverBrowseExe.TabIndex = 7;
			serverBrowseExe.Text = "...";
			serverBrowseExe.UseVisualStyleBackColor = true;
			serverBrowseExe.Click += serverBrowseExe_Click;
			// 
			// save
			// 
			save.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			save.Font = new Font("Roboto", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
			save.Location = new Point(12, 396);
			save.Name = "save";
			save.Size = new Size(400, 49);
			save.TabIndex = 8;
			save.Text = "Save";
			save.UseVisualStyleBackColor = true;
			save.Click += save_Click;
			// 
			// serverArgs
			// 
			serverArgs.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			serverArgs.BorderStyle = BorderStyle.FixedSingle;
			serverArgs.Font = new Font("Roboto", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
			serverArgs.Location = new Point(12, 350);
			serverArgs.Name = "serverArgs";
			serverArgs.Size = new Size(400, 40);
			serverArgs.TabIndex = 10;
			// 
			// serverArgsText
			// 
			serverArgsText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			serverArgsText.Font = new Font("Roboto", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
			serverArgsText.Location = new Point(12, 297);
			serverArgsText.Name = "serverArgsText";
			serverArgsText.Size = new Size(400, 50);
			serverArgsText.TabIndex = 9;
			serverArgsText.Text = "Start Arguments:";
			serverArgsText.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// ModifyServer
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(424, 457);
			Controls.Add(serverArgs);
			Controls.Add(serverArgsText);
			Controls.Add(save);
			Controls.Add(serverBrowseExe);
			Controls.Add(serverBrowsePath);
			Controls.Add(serverPath);
			Controls.Add(serverPathText);
			Controls.Add(serverExe);
			Controls.Add(serverExeText);
			Controls.Add(serverNameText);
			Controls.Add(serverName);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "ModifyServer";
			Text = "Modify Server";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox serverName;
		private Label serverNameText;
		private Label serverExeText;
		private TextBox serverExe;
		private TextBox serverPath;
		private Label serverPathText;
		private Button serverBrowsePath;
		private Button serverBrowseExe;
		private Button save;
		private TextBox serverArgs;
		private Label serverArgsText;
	}
}