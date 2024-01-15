using System.Collections.ObjectModel;
using CollectionViewPerfIssues.Data;

namespace CollectionViewPerfIssues.Pages;

public class CollectionViewTimerPageModel
{
    public ObservableCollection<EventItem> EventItems { get; } = new ObservableCollection<EventItem>();

    IDispatcherTimer timer;
    
    public CollectionViewTimerPageModel(IDispatcher dispatcher)
    {
        timer = dispatcher.CreateTimer();
        timer.Interval = TimeSpan.FromSeconds(0.5);
        timer.Tick += (sender, args) =>
        {
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