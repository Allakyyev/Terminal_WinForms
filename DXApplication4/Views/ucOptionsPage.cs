using System;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;

namespace DXApplication4 {
    public partial class ucOptionsPage : Views.BaseWizardPage {
        private bool canAddNumber(string number) {
            if(number.Length < 12) return true;
            return false;
        }
        IWizardViewModel wizardViewModel { get; set; }
        public ucOptionsPage(IWizardViewModel wizardViewModel1) {
            InitializeComponent();
            this.wizardViewModel = wizardViewModel1;
        }
        protected override void OnPaint(PaintEventArgs e) {
            phone_number_label.Text = MainForm.PhoneNumber;
            base.OnPaint(e);
        }
            void textEdit1_Properties_ButtonClick(object sender, ButtonPressedEventArgs e) {

        }
        void textEdit1_EditValueChanged(object sender, System.EventArgs e) {

        }

        private void buttons_1_Click(object sender, System.EventArgs e) {
            if(canAddNumber(phone_number_label.Text))
                phone_number_label.Text += '1';
        }

        private void buttons_2_Click(object sender, System.EventArgs e) {
            if(canAddNumber(phone_number_label.Text))
                phone_number_label.Text += '2';
        }

        private void buttons_3_Click(object sender, System.EventArgs e) {
            if(canAddNumber(phone_number_label.Text))
                phone_number_label.Text += '3';
        }

        private void buttons_4_Click(object sender, System.EventArgs e) {
            if(canAddNumber(phone_number_label.Text))
                phone_number_label.Text += '4';
        }

        private void buttons_5_Click(object sender, System.EventArgs e) {
            if(canAddNumber(phone_number_label.Text))
                phone_number_label.Text += '5';
        }

        private void buttons_6_Click(object sender, System.EventArgs e) {
            if(canAddNumber(phone_number_label.Text))
                phone_number_label.Text += '6';
        }

        private void buttons_7_Click(object sender, System.EventArgs e) {
            if(canAddNumber(phone_number_label.Text))
                phone_number_label.Text += '7';
        }

        private void buttons_8_Click(object sender, System.EventArgs e) {
            if(canAddNumber(phone_number_label.Text))
                phone_number_label.Text += '8';
        }

        private void buttons_9_Click(object sender, System.EventArgs e) {
            if(canAddNumber(phone_number_label.Text))
                phone_number_label.Text += '9';
        }

        private void buttons_0_Click(object sender, System.EventArgs e) {
            if(canAddNumber(phone_number_label.Text))
                phone_number_label.Text += '0';
        }

        private void buttons_delete_Click(object sender, System.EventArgs e) {
            if(phone_number_label.Text.Length > 4)
                phone_number_label.Text = phone_number_label.Text.Substring(0, (phone_number_label.Text.Length - 1));
        }

        private void button_confirm_phone_Click(object sender, System.EventArgs e) {
            if(phone_number_label.Text.Length < 12) return;
            MainForm.PhoneNumber = phone_number_label.Text;
            this.wizardViewModel?.Next();
        }
    }
}