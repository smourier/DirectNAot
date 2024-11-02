using Microsoft.UI.Xaml;

namespace DirectN.Samples.WinUI3.MinimalD3D11
{
    public partial class App : Microsoft.UI.Xaml.Application
    {
        private Microsoft.UI.Xaml.Window _window;

        public App()
        {
            InitializeComponent();
        }

        protected override void OnLaunched(LaunchActivatedEventArgs args)
        {
            _window = new MainWindow();
            _window.Activate();
        }
    }
}
