using System;
using System.Threading;
using System.Windows.Forms;
using Astra.EmailPriceChecker.Service.Service;

namespace Astra.EmailPriceChecker.Manager
{
    public partial class Form1 : Form
    {
        private readonly ServiceRunner _runner;
        private ThreadStart _threadStart;
        private Thread _thread;
        public Form1()
        {
            InitializeComponent();
            _runner = new ServiceRunner();
        }

        private void cmdStop_Click(object sender, EventArgs e)
        {
            _runner.StopService();
        }

        private void cmdStart_Click(object sender, EventArgs e)
        {
            _threadStart = _runner.StartService;
            _thread = new Thread(_threadStart);
            _thread.Start();
            
        }
    }
}
