using System.Collections.ObjectModel;
using CollectionViewPerfIssues.Data;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CollectionViewPerfIssues.Pages;

public partial class CollectionViewDynamicUpdatingScrollModePageModel : ObservableObject
{
    public ObservableCollection<EventItem> EventItems { get; } = new ObservableCollection<EventItem>();
    
    public ItemsUpdatingScrollMode ItemsUpdatingScrollMode { get; init; }
    
    public CollectionViewDynamicUpdatingScrollModePageModel(ItemsUpdatingScrollMode itemsUpdatingScrollMode)
    {
        ItemsUpdatingScrollMode = itemsUpdatingScrollMode;
    }

    [RelayCommand]
    void AddEvents(string itemCountString)
    {
        if (Int32.TryParse(itemCountString, out int itemCount) == true)
        {
            for (var i = 0; i < itemCount; ++i)
            {
                EventItems.Add(EventItem.GenerateEventWithRandomMessage());
            }
        }
    }
}