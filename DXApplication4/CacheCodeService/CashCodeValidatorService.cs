using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using BillValidator.CashCode.Driver;
using BillValidator.CashCode.Driver.BillsDefinition;
using BillValidator.CashCode.Driver.Models;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;

namespace DXApplication4.CacheCodeService {
    public class CashCodeValidatorService {
        CashCodeBillValidator _cacheCodeValidator = new CashCodeBillValidator();
        Action<int> onBillAccepted;
        public CashCodeValidatorService(string port) {
            BillValidatorPort = port;
            IsAutoAcceptBill = true;

            _cacheCodeValidator.BillReceived += HandleBillReceived;
            _cacheCodeValidator.BillStacking += HandleBillStacking;
            _cacheCodeValidator.BillCassetteStatusEvent += HandleBillCassetteStatusEvent;
        }

        private string _billValidatorPort;
        public string BillValidatorPort {
            get => _billValidatorPort;
            set { _billValidatorPort = value; }
        }

        private bool _isAutoAcceptBill;
        public bool IsAutoAcceptBill {
            get => _isAutoAcceptBill;
            set { _isAutoAcceptBill = value; }
        }

        private int _collectedMoneySum;
        public int CollectedMoneySum {
            get => _collectedMoneySum;
            set { _collectedMoneySum = value; }
        }
        private void HandleBillReceived(object sender, BillReceivedEventArgs e) {
            if(e.Status == BillRecievedStatus.Rejected) {

            } else if(e.Status == BillRecievedStatus.Accepted) {
                CollectedMoneySum += e.Bill.MoneyValue;
                if(this.onBillAccepted != null)
                    this.onBillAccepted(e.Bill.MoneyValue);
            }
            
        }

        private async Task HandleBillStacking(object sender, BillStackedEventArgs e) {
            if(IsAutoAcceptBill) {
                e.HasToRejectBill = false;
                //LogOperation($"Auto-accepted bill {e.Bill.Description}");
            } else {
                /*
                LogOperation("Choose if accept bill or not");
                var answer = await NavigationService.PopUpMessage("Question", $"Do you accept {e.Bill.Description}?", MessageDialogStyle.AffirmativeAndNegative);
                e.HasToRejectBill = answer == MessageDialogResult.Negative;
                */
            }
        }

        private void HandleBillCassetteStatusEvent(object sender, BillCassetteEventArgs e) {
            //LogOperation($"Bill casette status changed to {e.Status}");
        }
        public void DisconnectCommand() {
            try {
                _cacheCodeValidator.Dispose();
            } catch(Exception e) {
                MessageBox.Show("Nasazlyk yuze cyk", e.Message);
            }

        }

        public void EnableBillValidatorCommand() {
            _cacheCodeValidator.Enable();

        }

        public void DisableBillValidatorCommand() {            
            _cacheCodeValidator.Disable();

        }

        public void ResetCollectedMoneySumCommand() {
            CollectedMoneySum = 0;
        }

        public void ConnectCommand(){
            if(_cacheCodeValidator.IsConnected)
                return;
            _cacheCodeValidator.Connect(BillValidatorPort, new TurkmenBillsDefinition());
            if(_cacheCodeValidator.IsConnected) {
                _cacheCodeValidator.PowerUp();
                _cacheCodeValidator.StartListening();
                _cacheCodeValidator.Enable();        
            } else {
                //LogOperation("Could not connect to bill validator, check Device Manager for COM port number");
            }
        }

        public void RegisterAction(Action<int> onBillAccepted) {
            this.onBillAccepted = onBillAccepted;
        }
    }
}
