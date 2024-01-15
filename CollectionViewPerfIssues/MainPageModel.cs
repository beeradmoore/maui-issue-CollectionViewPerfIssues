using System;
using System.Collections.Generic;
using CollectionViewPerfIssues.Data;
using CommunityToolkit.Mvvm.ComponentModel;

namespace CollectionViewPerfIssues;

public partial class MainPageModel : ObservableObject
{
    public List<TestItemType> TestItems { get; } = new List<TestItemType>();

    public MainPageModel()
    {
        var enumItems = Enum.GetValues(typeof(TestItemType));
        foreach (TestItemType enumItem in enumItems)
        {
            TestItems.Add(enumItem);
        }
    }
}

