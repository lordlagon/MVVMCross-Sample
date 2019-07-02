using BestSellers.ViewModels;
using MvvmCross.Binding.BindingContext;
using System.Collections.Generic;
using MvvmCross.iOS.Views;
using MvvmCross.Binding.iOS.Views;
using UIKit;
using Foundation;

namespace BestSellers.Touch.Views
{
    public class BookListView : MvxTableViewController
    {
        public new BookListViewModel ViewModel
        {
            get { return (BookListViewModel)base.ViewModel; }
            set { base.ViewModel = value; }
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var source = new MvxActionBasedTableViewSource(
                TableView,
                UITableViewCellStyle.Subtitle,
                new NSString("BookListView"),
                "TitleText Title;DetailText Author;SelectedCommand ViewDetailCommand;ImageUrl AmazonImageUrl",
                UITableViewCellAccessory.DisclosureIndicator);

            source.CellModifier = (cell) =>
                                      {
                                          cell.ImageLoader.DefaultImagePath = "res:icon.png";
                                      };

            this.AddBindings(
                new Dictionary<object, string>()
                    {
                        { source, "ItemsSource List" }
                    });

            TableView.Source = source;
            TableView.ReloadData();
        }
    }
}