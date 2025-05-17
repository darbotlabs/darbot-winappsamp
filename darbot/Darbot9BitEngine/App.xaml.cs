using Microsoft.UI.Xaml;

namespace Darbot9BitEngine
{
    public partial class App : Application
    {
        private Window? m_window;

        protected override void OnLaunched(LaunchActivatedEventArgs args)
        {
            m_window = new MainWindow();
            m_window.Activate();
        }
    }
}
