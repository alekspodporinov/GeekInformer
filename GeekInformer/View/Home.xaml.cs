using System;

using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace GeekInformer.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Home : Page
    {
        public Home()
        {
            this.InitializeComponent();
          //  WebViewControl.Navigate(new Uri("http://geekinformer.net/"));
        }

        //private void WebViewControl_NavigationStarting(WebView sender, WebViewNavigationStartingEventArgs args)
        //{
        //  //  throw new System.NotImplementedException();
        //}

        //private void WebViewControl_DOMContentLoaded(WebView sender, WebViewDOMContentLoadedEventArgs args)
        //{
        //    //throw new NotImplementedException();
        //}

        //private void WebViewControl_NavigationCompleted(WebView sender, WebViewNavigationCompletedEventArgs args)
        //{
        //    //throw new NotImplementedException();
        //}

        //private void WebViewControl_ContentLoading(WebView sender, WebViewContentLoadingEventArgs args)
        //{
        //   // throw new NotImplementedException();
        //}

        //private void WebViewControl_UnviewableContentIdentified(WebView sender, WebViewUnviewableContentIdentifiedEventArgs args)
        //{
        //    //throw new NotImplementedException();
        //}
    }
}
