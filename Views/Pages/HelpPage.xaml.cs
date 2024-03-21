using MainProtego.ViewModels.Pages;
using System.Windows.Controls;
using Wpf.Ui.Controls;

namespace MainProtego.Views.Pages
{
    /// <summary>
    /// Interaction logic for HelpPage.xaml
    /// </summary>
    public partial class HelpPage : INavigableView<HelpViewModel>
    {
        public HelpViewModel ViewModel { get; }
        public HelpPage(HelpViewModel viewModel)
        {
            ViewModel = viewModel;
            DataContext = this;

            InitializeComponent();
        }
    }
}
