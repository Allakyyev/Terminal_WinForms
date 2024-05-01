namespace DXApplication4 {
    public partial class ucFinishPage : Views.BaseWizardPage {
        IWizardViewModel wizardViewModel { get; set; }
        public ucFinishPage(IWizardViewModel wizardViewModel) {
            InitializeComponent();
            this.wizardViewModel = wizardViewModel;
        }
        void finishButton_Click(object sender, System.EventArgs e) {
            WizardViewModel.Close(false);
        }

        private void labelControl1_Click(object sender, System.EventArgs e) {

        }

        private void button1_Click(object sender, System.EventArgs e) {
            try {
                MainForm.CashCodeValidatorService.ResetCollectedMoneySumCommand();                
            } catch {                
            }
            WizardViewModel.GoToFirst();
        }
    }
}