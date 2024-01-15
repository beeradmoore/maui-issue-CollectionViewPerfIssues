using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionViewPerfIssues.Pages;

public partial class CollectionViewDynamicPage : ContentPage
{
    public CollectionViewDynamicPage()
    {
        InitializeComponent();
        BindingContext = new CollectionViewDynamicPageModel();
    }
}