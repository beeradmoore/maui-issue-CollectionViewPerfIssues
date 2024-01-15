using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionViewPerfIssues.Pages;

public partial class CollectionViewTimerPage : ContentPage
{
    public CollectionViewTimerPage()
    {
        InitializeComponent();
        BindingContext = new CollectionViewTimerPageModel(this.Dispatcher);
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        if (BindingContext is CollectionViewTimerPageModel collectionViewTimerPageModel)
        {
            collectionViewTimerPageModel.StartTimer();
        }
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();

        if (BindingContext is CollectionViewTimerPageModel collectionViewTimerPageModel)
        {
            collectionViewTimerPageModel.StopTimer();
        }
    }
}