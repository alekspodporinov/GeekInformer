using System.Collections.Generic;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using GeekInformer.Infrastructure;
using GeekInformer.Views;

namespace GeekInformer.View
{
    public sealed partial class Layout : Page
    {
        public List<NavMenuItem> MenuList { set; get; }

        public Layout()
        {
            MenuList = new List<NavMenuItem>(
           new[]
           {
                new NavMenuItem()
                {
                     DestPage = typeof(Home),
                     Name = "Главная",
                     IconMenu = Symbol.Home
                },
                new NavMenuItem()
                {
                     DestPage = typeof(News),
                     Name = "Новости",
                     IconMenu = Symbol.Favorite
                },
                new NavMenuItem()
                {
                     DestPage = typeof(Account),
                     Name = "Акаунт",
                     IconMenu = Symbol.Account
                },
                new NavMenuItem()
                {
                     DestPage = typeof(View.Settings),
                     Name = "Настройки",
                     IconMenu = Symbol.Setting
                },
           });
            this.InitializeComponent();
            Loaded += (sender, args) => { myFrame.Navigate(typeof(Home)); };
        }


        private void NavMenuOnItemClick(object sender, ItemClickEventArgs e)
        {
            var a = (NavMenuItem)e.ClickedItem;
            myFrame.Navigate(a.DestPage);
        }

        private void HamburgerButtonClick(object sender, RoutedEventArgs e)
        {
           mySplitView.IsPaneOpen = !mySplitView.IsPaneOpen;
        }

        private void AddItem(object sender, RoutedEventArgs e)
        {
       //     throw new System.NotImplementedException();
        }

        private void DeleteItem(object sender, RoutedEventArgs e)
        {
//throw new System.NotImplementedException();
        }

        private void DeleteItems(object sender, RoutedEventArgs e)
        {
          //  throw new System.NotImplementedException();
        }

        private void CancelSelection(object sender, RoutedEventArgs e)
        {
           // throw new System.NotImplementedException();
        }

        private void SelectItems(object sender, RoutedEventArgs e)
        {
          //  throw new System.NotImplementedException();
        }

        private void Layout_OnSizeChanged(object sender, SizeChangedEventArgs e)
        {

            MyAutoSuggestBox.PlaceholderText = $"{Window.Current.Bounds.Width}x{Window.Current.Bounds.Height}";
        }
    }
}
