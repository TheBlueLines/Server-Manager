using System.Diagnostics;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Unicode;

namespace Developer_Tools
{
	public partial class ServerManager : Form
	{
		public List<ServerX> srvrx = new();
		public Dictionary<string, ServerY> srvry = new();
		public string? selected = null;
		public ServerManager()
		{
			LoadServers();
			InitializeComponent();
			ReloadServerList();
		}
		private void ServerManager_FormClosing(object sender, FormClosingEventArgs e)
		{
			foreach (ServerY srvr in srvry.Values)
			{
				srvr.Stop();
				srvr.Dispose();
			}
		}
		private void servers_SelectedIndexChanged(object sender, EventArgs e)
		{
			ListBox? listBox = sender as ListBox;
			if (listBox != null)
			{
				bool mode = listBox.SelectedIndex >= 0;
				terminal.Clear();
				power.Enabled = mode;
				terminal.Enabled = mode;
				UpdateUI();
			}
		}
		private void UpdateUI()
		{
			if (servers.SelectedItem != null)
			{
				string? name = servers.SelectedItem.ToString();
				if (!string.IsNullOrEmpty(name) && srvry.TryGetValue(name, out ServerY? server) && server != null)
				{
					if (!string.IsNullOrEmpty(selected))
					{
						srvry[selected].writeToMaster = false;
					}
					terminal.Text = server.log;
					server.writeToMaster = true;
					power.Text = server.power ? "Stop" : "Start";
					return;
				}
				power.Text = "Start";
			}
		}
		private void power_Click(object sender, EventArgs e)
		{
			if (servers.SelectedItem != null)
			{
				string? name = servers.SelectedItem.ToString();
				if (!string.IsNullOrEmpty(name))
				{
					if (!srvry.ContainsKey(name))
					{
						ServerX serverX = srvrx[servers.SelectedIndex];
						if (!string.IsNullOrEmpty(serverX.exe))
						{
							ServerY serverY = new(terminal, serverX.exe, serverX.path, serverX.args);
							serverY.writeToMaster = true;
							srvry.Add(name, serverY);
							terminal.Clear();
							serverY.Start();
							power.Text = "Stop";
						}
					}
					else
					{
						ServerY serverY = srvry[name];
						if (serverY.power)
						{
							serverY.Stop();
							power.Text = "Start";
						}
						else
						{
							terminal.Clear();
							serverY.Start();
							power.Text = "Stop";
						}
					}
				}
			}
		}
		private void addToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ModifyServer addServer = new();
			addServer.ShowDialog();
			if (addServer.server != null)
			{
				srvrx.Add(addServer.server);
				SaveServers();
				ReloadServerList();
			}
		}
		private void ReloadServerList()
		{
			servers.Items.Clear();
			for (int i = 0; i < srvrx.Count; i++)
			{
				ServerX srvr = srvrx[i];
				servers.Items.Add(string.IsNullOrEmpty(srvr.name) ? $"Server {i}" : srvr.name);
			}
		}
		private JsonSerializerOptions jsonSerializerOptions = new()
		{
			WriteIndented = true,
			Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
			DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
		};
		private void SaveServers()
		{
			string json = JsonSerializer.Serialize(srvrx, jsonSerializerOptions);
			File.WriteAllText("servers.json", json);
		}
		private void LoadServers()
		{
			if (File.Exists("servers.json"))
			{
				string json = File.ReadAllText("servers.json");
				List<ServerX>? temp = JsonSerializer.Deserialize<List<ServerX>>(json, jsonSerializerOptions);
				if (temp != null)
				{
					srvrx = temp;
				}
			}
		}
		private void removeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (servers.SelectedIndex >= 0)
			{
				srvrx.RemoveAt(servers.SelectedIndex);
				servers.Items.RemoveAt(servers.SelectedIndex);
				SaveServers();
			}
		}
		private void configureToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (servers.SelectedIndex >= 0)
			{
				ModifyServer modifyServer = new(srvrx[servers.SelectedIndex]);
				modifyServer.ShowDialog();
				if (modifyServer.server != null)
				{
					srvrx[servers.SelectedIndex] = modifyServer.server;
					SaveServers();
					ReloadServerList();
				}
			}
		}
		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Server Manager v0.1\nCreated by TheBlueLines", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
	public class ServerY
	{
		public ServerY(RichTextBox master, string exe, string? path = null, string? args = null)
		{
			this.master = master;
			process = new()
			{
				EnableRaisingEvents = true,
				StartInfo = new()
				{
					FileName = exe,
					WorkingDirectory = path ?? Path.GetDirectoryName(exe),
					Arguments = args ?? string.Empty,
					UseShellExecute = false,
					RedirectStandardOutput = true,
					RedirectStandardError = true,
					RedirectStandardInput = true,
					CreateNoWindow = true
				}
			};
			process.EnableRaisingEvents = true;
			process.OutputDataReceived += new DataReceivedEventHandler(process_OutputDataReceived);
			process.ErrorDataReceived += new DataReceivedEventHandler(process_ErrorDataReceived);
		}
		public Process process = new();
		public string log = string.Empty;
		public bool power = false;
		public bool writeToMaster = false;
		private RichTextBox master;
		public void Start()
		{
			log = string.Empty;
			power = true;
			process.Start();
			process.BeginErrorReadLine();
			process.BeginOutputReadLine();
		}
		public void Stop()
		{
			power = false;
			process.CancelErrorRead();
			process.CancelOutputRead();
			process.Kill();
			process.WaitForExit();
		}
		public void Dispose()
		{
			process.Dispose();
		}
		public void process_OutputDataReceived(object sender, DataReceivedEventArgs e)
		{
			log += e.Data + "\n";
			if (writeToMaster && master != null)
			{
				master.Text += e.Data + "\n";
				master.ScrollToCaret();
			}
		}
		public void process_ErrorDataReceived(object sender, DataReceivedEventArgs e)
		{
			log += e.Data + "\n";
			if (writeToMaster && master != null)
			{
				master.Text += e.Data + "\n";
				master.ScrollToCaret();
			}
		}
	}
}