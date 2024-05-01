using System.Resources;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraEditors;
using DXApplication4.CacheCodeService;

namespace DXApplication4 {
    public partial class MainForm : XtraForm {
        public static string PhoneNumber;
        IWizardViewModel wizardViewModel;
        public static CashCodeValidatorService CashCodeValidatorService;
        public ucStartPage StartPage { get; set; }
        public ucOptionsPage OptionsPage { get; set; }
        public ucInstallPage InstallPage { get; set; }
        private readonly ResourceManager _resourceManager;

        public MainForm(CashCodeValidatorService cashCodeValidatorService) {
            InitializeComponent();
            _resourceManager = new ResourceManager("DXApplication4.Resource", typeof(MainForm).Assembly);
            wizardViewModel = new ViewModels.WizardViewModel(
                new IWizardPageViewModel[]{
                    new ViewModels.StartPageViewModel(),
                    new ViewModels.OptionsPageViewModel(),
                    new ViewModels.InstallPageViewModel(),
                    new ViewModels.FinishPageViewModel()
                },
                windowsUIView1, this);
            CashCodeValidatorService = cashCodeValidatorService;
            StartPage = new ucStartPage(wizardViewModel) { Text = "Start" };
            OptionsPage = new ucOptionsPage(wizardViewModel) { Text = "Options" };
            InstallPage = new ucInstallPage(wizardViewModel) { Text = "Install" };
            windowsUIView1.AddDocument(StartPage);
            windowsUIView1.AddDocument(OptionsPage);
            windowsUIView1.AddDocument(InstallPage);
            windowsUIView1.AddDocument(new ucFinishPage(wizardViewModel) { Text = "Finish" });

            foreach(Document document in windowsUIView1.Documents)
                pageGroup.Items.Add(document);
        }

        void windowsUIView1_NavigationBarsShowing(object sender, NavigationBarsCancelEventArgs e) {
            e.Cancel = true;
        }
        void windowsUIView1_NavigatedTo(object sender, NavigationEventArgs e) {
            e.Parameter = wizardViewModel;
        }
        void windowsUIView1_QueryDocumentActions(object sender, QueryDocumentActionsEventArgs e) {
            e.DocumentActions.Add(new DocumentAction(
                (document) => wizardViewModel.CanPrev(),
                (document) => wizardViewModel.Prev()) { Caption = "Yza", Image = imageList1.Images[0] });
            //e.DocumentActions.Add(new DocumentAction(
            //    (document) => wizardViewModel.CanNext(),
            //    (document) => wizardViewModel.Next()) { Caption = "Tassykla", Image = imageList1.Images[1] });
        }
    }
}