using LogListBoxPractice.Domain;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace LogListBoxPractice {
    internal class LogService : ILogService {

        private ObservableCollection<string> _logMessages;

        public LogService(ObservableCollection<string> logMessages) {
            _logMessages = logMessages;
        }

        public void Log(string message) {
            _logMessages.Add(message);
        }
    }
}
