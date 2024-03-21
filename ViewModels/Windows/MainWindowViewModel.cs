using System.Collections.ObjectModel;
using Wpf.Ui.Controls;

namespace MainProtego.ViewModels.Windows
{
    public partial class MainWindowViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _applicationTitle = "Protego";

        [ObservableProperty]
        private ObservableCollection<object> _menuItems = new()
        {
            new NavigationViewItem()
            {
                Content = "Home",
                Icon = new SymbolIcon { Symbol = SymbolRegular.Home24 },
                TargetPageType = typeof(Views.Pages.DashboardPage)
                
            },
            new NavigationViewItem()
            {
                Content = "Protect",
                Icon = new SymbolIcon { Symbol = SymbolRegular.LockClosed24},
                TargetPageType = typeof(Views.Pages.DataPage),
                
                
            },
            new NavigationViewItem()
            {
                Content = "Security",
                Icon = new SymbolIcon { Symbol = SymbolRegular.Shield24 },
                TargetPageType = typeof(Views.Pages.SecurityPage)
            },
            new NavigationViewItem()
            {
                Content = "Monitor",
                Icon = new SymbolIcon { Symbol = SymbolRegular.DataBarVertical24 },
                TargetPageType = typeof(Views.Pages.MonitorPage)
            }

        };

        [ObservableProperty]
        private ObservableCollection<object> _footerMenuItems = new()
        {
             new NavigationViewItem()
            {
                Content = "Help",
                Icon = new SymbolIcon { Symbol = SymbolRegular.ChatHelp24 },
                TargetPageType = typeof(Views.Pages.HelpPage)
            },
            new NavigationViewItem()
            {
                Content = "Settings",
                Icon = new SymbolIcon { Symbol = SymbolRegular.Settings24 },
                TargetPageType = typeof(Views.Pages.SettingsPage)
            }
        };

        [ObservableProperty]
        private ObservableCollection<MenuItem> _trayMenuItems = new()
        {
            new MenuItem { Header = "Home", Tag = "tray_home" }
        };
    }
}
