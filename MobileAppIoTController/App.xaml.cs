namespace MobileAppIoTController
{
    public partial class App : Application
    {
        public App()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NNaF1cWWhMYVF+WmFZfVtgdVRMZV5bRXNPMyBoS35Rc0VmW35fcXFXR2VdWEB3VEBU");
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}