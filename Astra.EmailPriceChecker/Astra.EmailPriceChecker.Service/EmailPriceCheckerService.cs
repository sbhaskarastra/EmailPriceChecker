using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using Astra.EmailPriceChecker.Service.Service;

namespace Astra.EmailPriceChecker.Service
{
    partial class EmailPriceCheckerService : ServiceBase
    {
        private readonly ServiceRunner _runner;

        public EmailPriceCheckerService()
        {
            InitializeComponent();
            _runner = new ServiceRunner();
        }

        protected override void OnStart(string[] args)
        {
            _runner.StartService();
        }

        protected override void OnStop()
        {
            _runner.StopService();
        }
    }
}
