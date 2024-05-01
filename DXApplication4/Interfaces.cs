namespace DXApplication4 {
    public interface IWizardViewModel {
        void PageCompleted();
        bool CanPrev();
        void Prev();
        bool CanNext();
        void Next();
        IWizardPageViewModel CurrentPage { get; }
        bool CanClose();
        void Close(bool isClosing);
        void ActivatePage(int  pageIndex);
        void GoToFirst();
    }
    public interface IWizardPageViewModel {
        bool IsComplete { get; }
        bool CanReturn { get; }
    }
}
