using System;
using System.Collections.ObjectModel;

using MyTemplateStudioApp.Helpers;
using MyTemplateStudioApp.Models;
using MyTemplateStudioApp.Services;

namespace MyTemplateStudioApp.ViewModels
{
    public class Chart1ViewModel : Observable
    {
        public Chart1ViewModel()
        {
        }

        public ObservableCollection<DataPoint> Source
        {
            get
            {
                // TODO WTS: Replace this with your actual data
                return SampleDataService.GetChartSampleData();
            }
        }
    }
}
