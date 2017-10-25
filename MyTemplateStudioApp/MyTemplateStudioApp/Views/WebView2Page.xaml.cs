using System;

using MyTemplateStudioApp.ViewModels;

using Windows.UI.Xaml.Controls;

namespace MyTemplateStudioApp.Views
{
    public sealed partial class WebView2Page : Page
    {
        public WebView2ViewModel ViewModel { get; } = new WebView2ViewModel();

        public WebView2Page()
        {
            InitializeComponent();
            ViewModel.Initialize(webView);
        }
    }
}
