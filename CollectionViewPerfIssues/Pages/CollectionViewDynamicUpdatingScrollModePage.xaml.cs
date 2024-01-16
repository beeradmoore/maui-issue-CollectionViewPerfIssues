using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionViewPerfIssues.Pages;

public partial class CollectionViewDynamicUpdatingScrollModePage : ContentPage
{
    public CollectionViewDynamicUpdatingScrollModePage(ItemsUpdatingScrollMode itemsUpdatingScrollMode)
    {
        InitializeComponent();
        BindingContext = new CollectionViewDynamicUpdatingScrollModePageModel(itemsUpdatingScrollMode);
    }
}