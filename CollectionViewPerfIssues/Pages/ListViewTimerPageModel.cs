using System.Collections.ObjectModel;
using System.Diagnostics;
using CollectionViewPerfIssues.Data;

namespace CollectionViewPerfIssues.Pages;

public class ListViewTimerPageModel
{
    public ObservableCollection<EventItem> EventItems { get; } = new ObservableCollection<EventItem>();

    IDispatcherTimer timer;
    
    public ListViewTimerPageModel(IDispatcher dispatcher)
    {
        timer = dispatcher.CreateTimer();
        timer.Interval = TimeSpan.FromSeconds(0.5);
        timer.Tick += (sender, args) =>
        {
            Debug.WriteLine("tick");
            EventItems.Add(EventItem.GenerateEventWithRandomMessage());
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