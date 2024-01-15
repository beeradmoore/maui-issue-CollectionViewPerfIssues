using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionViewPerfIssues.Pages;

public partial class ListViewStaticPage : ContentPage
{
    public ListViewStaticPage(int itemCount)
    {
        InitializeComponent();
        BindingContext = new ListViewStaticPageModel(itemCount);
    }
}