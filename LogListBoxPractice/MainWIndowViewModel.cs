using LogListBoxPractice.Domain;
using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogListBoxPractice {
    public sealed class MainWIndowViewModel {

        public ReactiveCommandSlim ExecuteCommand { get; } = new ReactiveCommandSlim();

        public ObservableCollection<string> LogMessages { get; set; }
        public ILogService LogService { get; }
        private readonly SetupMain _setupMain;

        public MainWIndowViewModel() {
            LogMessages = new ObservableCollection<string>();
            LogService = new LogService(LogMessages);
            ExecuteCommand.Subscribe(_ => ExecuteButtonExecute());
            _setupMain = new SetupMain(LogService);
        }

        private void ExecuteButtonExecute() {
            LogService.Log("ExecuteButton clicked.");
            _setupMain.Start();
        }
    }
}
