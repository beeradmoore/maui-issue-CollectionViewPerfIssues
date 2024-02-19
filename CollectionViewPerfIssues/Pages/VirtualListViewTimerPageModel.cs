using System.Collections.ObjectModel;
using CollectionViewPerfIssues.Data;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Maui.Adapters;

namespace CollectionViewPerfIssues.Pages;

public partial class VirtualListViewTimerPageModel : ObservableObject
{
	
	ObservableCollection<EventItem> eventItems { get; } = new ObservableCollection<EventItem>();

	[ObservableProperty]
	ObservableCollectionAdapter<EventItem> eventItemAdapter;
	
	IDispatcherTimer timer;
	
	public VirtualListViewTimerPageModel(IDispatcher dispatcher)
	{
		EventItemAdapter = new ObservableCollectionAdapter<EventItem>(eventItems);

		timer = dispatcher.CreateTimer();
		timer.Interval = TimeSpan.FromSeconds(0.5);
		timer.Tick += (sender, args) =>
		{
			eventItems.Add(EventItem.GenerateEventWithRandomMessage());
		};
	}
	public void StartTimer()
	{
		timer.Start();
	}

	public void StopTimer()
	{
		timer.Stop();
	}
}