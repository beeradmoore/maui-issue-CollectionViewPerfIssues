using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionViewPerfIssues.Pages;

public partial class ListViewTimerPage : ContentPage
{
    public ListViewTimerPage()
    {
        InitializeComponent();
        BindingContext = new ListViewTimerPageModel(this.Dispatcher);
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        if (BindingContext is ListViewTimerPageModel listViewTimerPageModel)
        {
            listViewTimerPageModel.StartTimer();
        }
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();

        if (BindingContext is ListViewTimerPageModel listViewTimerPageModel)
        {
            listViewTimerPageModel.StopTimer();
        }
    }
}