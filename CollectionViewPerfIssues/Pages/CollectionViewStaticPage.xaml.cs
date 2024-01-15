using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionViewPerfIssues.Pages;

public partial class CollectionViewStaticPage : ContentPage
{
    public CollectionViewStaticPage(int itemCount)
    {
        InitializeComponent();
        BindingContext = new CollectionViewStaticPageModel(itemCount);
    }
}