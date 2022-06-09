using System.Diagnostics;

namespace kwgui
{
    public partial class Form1 : Form
    {
        private Process python;
        private List<float> data = new();
        private List<Process> processs = new();

        public Form1()
        {
            InitializeComponent();

            python = NewPythonProcess();
            python.OutputDataReceived += ReceiveData;
            python.Start();
            python.BeginOutputReadLine();
            python.StandardInput.WriteLine("import test");
        }

        private void SelectedChanged(object sender, EventArgs e)
        {
            Depth.Enabled = true;
            NumOfQubits.Enabled = true;

            if (SelectedDepth.Checked)
                Depth.Enabled = false;
            if (SelectedQubits.Checked)
                NumOfQubits.Enabled = false;
        }

        private void StartTest(object sender, EventArgs e)
        {
            data.Clear();
            CallForData();
        }

        private Process NewPythonProcess()
        {

            var p = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = @"C:\Users\nargatte\miniconda3\envs\qsimcirq\python.exe",
                    Arguments = "-i",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardInput = true,
                    CreateNoWindow = false,
                }
            };
            processs.Add(p);
            return p;
        }

        private void ReceiveData(object sender, DataReceivedEventArgs e)
        {
            if(float.TryParse(e.Data, out float value))
            {
                data.Add(value);
                CallForData();
            }
        }

        private void CallForData()
        {
            var samples = NumOfSamples.Value;
            var threads = NumOfThreads.Value;
            var range = Range.Value;
            var depth = Depth.Value;
            var qubits = NumOfQubits.Value;
            Progress.Invoke(() => Progress.Text = $"{data.Count()}/{range}");
            if (range <= data.Count)
            {
                DrawChart();
                return;
            }
            if (SelectedDepth.Checked)
            {
                python.StandardInput.WriteLine($"test.test({samples},{threads},{qubits},{data.Count+1})");
            }
            else
            {
                python.StandardInput.WriteLine($"test.test({samples},{threads},{data.Count+1},{depth})");
            }
        }

        private void DrawChart()
        {
            var chartProcess = NewPythonProcess();
            chartProcess.Start();
            chartProcess.StandardInput.WriteLine("import matplotlib.pyplot as plt");
            chartProcess.StandardInput.WriteLine("plt.ion()");
            var x = string.Join(", ", Enumerable.Range(1, data.Count));
            var y = string.Join(", ", data);
            chartProcess.StandardInput.WriteLine($"plt.plot([{x}],[{y}])");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach(var p in processs)
            {
                p.CloseMainWindow();
                p.Close();
                p.Dispose();
            }
        }
    }
}