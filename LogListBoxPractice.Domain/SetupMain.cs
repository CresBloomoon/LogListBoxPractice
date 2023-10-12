using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogListBoxPractice.Domain {
    public sealed class SetupMain {
        private readonly ILogService _logService;

        public SetupMain(ILogService logService) {
            _logService = logService;
        }

        public void Start() {
            _logService.Log("Start");

            Step1();
            Step2();
            Step3();

            _logService.Log("End");
        }

        private void Step1() {
            _logService.Log("Step1");
        }

        private void Step2() {
            _logService.Log("Step2");
        }

        private void Step3() {
            _logService.Log("Step3");
        }
    }
}
