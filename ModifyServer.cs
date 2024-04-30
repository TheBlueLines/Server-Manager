namespace Developer_Tools
{
	public partial class ModifyServer : Form
	{
		public ServerX? server;
		public ModifyServer(ServerX? server = null)
		{
			this.server = server;
			InitializeComponent();
			if (server != null)
			{
				if (!string.IsNullOrEmpty(server.name))
				{
					Text = $"Modify Server ({server.name})";
					serverName.Text = server.name;
				}
				else
				{
					Text = "Modify Server";
				}
				if (!string.IsNullOrEmpty(server.exe))
				{
					serverExe.Text = server.exe;
				}
				if (!string.IsNullOrEmpty(server.path))
				{
					serverPath.Text = server.path;
				}
				if (!string.IsNullOrEmpty(server.args))
				{
					serverArgs.Text = server.args;
				}
			}
			else
			{
				Text = "Add Server";
			}
		}
		private void serverBrowseExe_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog()
			{
				Filter = "Executables (*.exe)|*.exe"
			};
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				serverExe.Text = openFileDialog.FileName;
			}
		}
		private void serverBrowsePath_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				serverPath.Text = folderBrowserDialog.SelectedPath;
			}
		}
		private void save_Click(object sender, EventArgs e)
		{
			server = new()
			{
				name = string.IsNullOrEmpty(serverName.Text) ? null : serverName.Text,
				exe = string.IsNullOrEmpty(serverExe.Text) ? null : serverExe.Text,
				path = string.IsNullOrEmpty(serverPath.Text) ? null : serverPath.Text,
				args = string.IsNullOrEmpty(serverArgs.Text) ? null : serverArgs.Text
			};
			Close();
		}
	}
	public class ServerX
	{
		public string? name { get; set; }
		public string? exe { get; set; }
		public string? path { get; set; }
		public string? args { get; set; }
	}
}