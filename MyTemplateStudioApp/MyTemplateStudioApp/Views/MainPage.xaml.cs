using System;

using MyTemplateStudioApp.ViewModels;

using Windows.UI.Xaml.Controls;

namespace MyTemplateStudioApp.Views
{
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel { get; } = new MainViewModel();

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
