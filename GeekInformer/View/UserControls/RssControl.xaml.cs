using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

using GeekInformer.Model.API_Model;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace GeekInformer.View.UserControls
{
    public sealed partial class RssControl : UserControl
    {
        private Rss _newsRss;
        public RssControl(Rss newsRss)
        {
            this.InitializeComponent();
            _newsRss = newsRss;
            if(string.IsNullOrEmpty(_newsRss.Cover))
            {
                Img.Visibility = Visibility.Collapsed;
                Width = double.NaN;
                Height = double.NaN;
            }
            DataContext = _newsRss;
        }
    }
}
