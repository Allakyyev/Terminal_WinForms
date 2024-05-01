namespace DXApplication4.ViewModels {
    internal class FinishPageViewModel : IWizardPageViewModel {
        public bool IsComplete { get { return true; } }
        public bool CanReturn { get { return false; } }
    }
}