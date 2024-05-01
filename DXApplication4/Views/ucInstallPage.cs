using System;
using System.Windows.Forms;

namespace DXApplication4 {
    public partial class ucInstallPage : Views.BaseWizardPage {
        IWizardViewModel wizardViewModel { get; set; }
        public ucInstallPage(IWizardViewModel wizardViewModel) {
            InitializeComponent();
            this.wizardViewModel = wizardViewModel;
        }
        private void UpdateLabelText(string newText) {
            if(label_total.InvokeRequired) {
                // If called from a different thread, invoke it on the UI thread
                label_total.Invoke(new Action<string>(UpdateLabelText), new object[] { $"{newText}" });
            } else {
                // Update the label text directly
                label_total.Text = newText;
            }
        }

        public void Reset() {
            MainForm.CashCodeValidatorService.RegisterAction((int x) => {
                UpdateLabelText(MainForm.CashCodeValidatorService.CollectedMoneySum.ToString() + " man");
            });
            MainForm.CashCodeValidatorService.ConnectCommand();
            MainForm.CashCodeValidatorService.EnableBillValidatorCommand();
            MainForm.CashCodeValidatorService.ResetCollectedMoneySumCommand();
        }

        protected override void OnPaint(PaintEventArgs e) {
            if(MainForm.PhoneNumber.Length != 12) {
                this.wizardViewModel?.Prev();
                return;
            }
            label1.Text = MainForm.PhoneNumber;
            label_total.Text = MainForm.CashCodeValidatorService?.CollectedMoneySum.ToString() + " man";
            base.OnPaint(e);

        }
        private void label1_Click(object sender, EventArgs e) {

        }

        private void button_pay_Click(object sender, EventArgs e) {
            if(MainForm.CashCodeValidatorService.CollectedMoneySum > 0) {
                this.wizardViewModel?.Next();
                label_total.Text = "0 man";
                MainForm.CashCodeValidatorService.ResetCollectedMoneySumCommand();
            }
        }
    }
}