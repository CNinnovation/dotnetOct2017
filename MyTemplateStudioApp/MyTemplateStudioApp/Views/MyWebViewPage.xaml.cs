using System;

using MyTemplateStudioApp.ViewModels;

using Windows.UI.Xaml.Controls;

namespace MyTemplateStudioApp.Views
{
    public sealed partial class MyWebViewPage : Page
    {
        public MyWebViewViewModel ViewModel { get; } = new MyWebViewViewModel();

        public MyWebViewPage()
        {
            InitializeComponent();
            ViewModel.Initialize(webView);
        }
    }
}
