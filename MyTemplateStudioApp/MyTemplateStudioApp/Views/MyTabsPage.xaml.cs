using System;

using MyTemplateStudioApp.ViewModels;

using Windows.UI.Xaml.Controls;

namespace MyTemplateStudioApp.Views
{
    public sealed partial class MyTabsPage : Page
    {
        public MyTabsViewModel ViewModel { get; } = new MyTabsViewModel();

        public MyTabsPage()
        {
            InitializeComponent();
        }
    }
}
