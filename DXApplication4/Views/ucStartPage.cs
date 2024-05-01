namespace DXApplication4 {
    public partial class ucStartPage : Views.BaseWizardPage {
        IWizardViewModel wizardViewModel1 { get; set; }
        public ucStartPage(IWizardViewModel wizardViewModel) {
            InitializeComponent();
            this.wizardViewModel1 = wizardViewModel;
        }

        private void pictureBox1_Click(object sender, System.EventArgs e) {
            MainForm.PhoneNumber = "+993";
            this.wizardViewModel1?.Next();
        }
    }
}