using System.Windows.Forms;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;

namespace DXApplication4.ViewModels {
    public class WizardViewModel : IWizardViewModel {
        WindowsUIView view;
        IWizardPageViewModel[] pages;
        MainForm mainForm;
        int index = 0;
        public WizardViewModel(IWizardPageViewModel[] pages, WindowsUIView view, MainForm mainForm) {
            this.pages = pages;
            this.view = view;
            this.mainForm = mainForm;
        }
        public bool CanNext() {
            return (index >= 0) && (index < pages.Length - 1) && CurrentPage.IsComplete;
        }
        public void Next() {
            ActivatePage(++index);
        }
        public void GoToFirst() {
            index = 0;
            ActivatePage(index);
        }
        public bool CanPrev() {
            return index > 0 && index < pages.Length && CurrentPage.CanReturn;
        }
        public void Prev() {
            if(index == 2 && MainForm.CashCodeValidatorService.CollectedMoneySum > 0) {
                // Money inserted and back button clicked
                return;
            }
            ActivatePage(--index);
        }
        public IWizardPageViewModel CurrentPage {
            get { return pages[index]; }
        }
        public void PageCompleted() {
            if(CanNext())
                Next();
        }
        public void ActivatePage(int index) {
            PageGroup pageGroup = view.ContentContainers["pageGroup"] as PageGroup;
            view.ActivateDocument(pageGroup.Items[index]);
            if(index == 2) {
                mainForm.InstallPage.Reset();
            } else {
                try {
                    MainForm.CashCodeValidatorService.DisableBillValidatorCommand();
                } catch {
                    mainForm.InstallPage.Reset();
                    MainForm.CashCodeValidatorService.DisableBillValidatorCommand();
                }
            }
        }
        public bool CanClose() {
            return index >= 0 && index < pages.Length - 1;
        }
        public void Close(bool isClosing) {
            if(isClosing) {
                Flyout flyout = view.ContentContainers["closeFlyout"] as Flyout;
                flyout.Action = new FlyoutAction() {
                    Caption = "Setup Wizard",
                    Description = "Are you sure you want to exit the setup?"
                };
                view.FlyoutHidden += view_FlyoutHidden;
                view.ActivateContainer(flyout);
            } else Close();
        }
        void view_FlyoutHidden(object sender, FlyoutResultEventArgs e) {
            view.FlyoutHidden -= view_FlyoutHidden;
            if(e.Result == System.Windows.Forms.DialogResult.Yes)
                Close();
        }
        void Close() {
            mainForm.BeginInvoke(new System.Action(mainForm.Close));
        }
    }
}