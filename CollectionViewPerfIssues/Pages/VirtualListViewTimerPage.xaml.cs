using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionViewPerfIssues.Pages;

public partial class VirtualListViewTimerPage : ContentPage
{
	public VirtualListViewTimerPage()
	{
		InitializeComponent();
		BindingContext = new VirtualListViewTimerPageModel(this.Dispatcher);
	}
	
	protected override void OnAppearing()
	{
		base.OnAppearing();

		if (BindingContext is VirtualListViewTimerPageModel virtualListViewTimerPageModel)
		{
			virtualListViewTimerPageModel.StartTimer();
		}
	}

	protected override void OnDisappearing()
	{
		base.OnDisappearing();

		if (BindingContext is VirtualListViewTimerPageModel virtualListViewTimerPageModel)
		{
			virtualListViewTimerPageModel.StopTimer();
		}
	}
}