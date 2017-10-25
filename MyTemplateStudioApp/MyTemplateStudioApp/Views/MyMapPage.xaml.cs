using System;

using MyTemplateStudioApp.ViewModels;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace MyTemplateStudioApp.Views
{
    public sealed partial class MyMapPage : Page
    {
        public MyMapViewModel ViewModel { get; } = new MyMapViewModel();

        public MyMapPage()
        {
            InitializeComponent();
        }

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            await ViewModel.InitializeAsync(mapControl);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            ViewModel.Cleanup();
        }
    }
}
