using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionViewPerfIssues.Pages;

public partial class ListViewDynamicPage : ContentPage
{
    public ListViewDynamicPage()
    {
        InitializeComponent();
        BindingContext = new ListViewDynamicPageModel();
    }
}