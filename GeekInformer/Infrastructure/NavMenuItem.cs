using System;
using Windows.UI.Xaml.Controls;

namespace GeekInformer.Infrastructure
{
    public class NavMenuItem
    {
        public string Name { get; set; }

        public Symbol IconMenu { get; set; }

        public char SymbolAsChar
        {
            get
            {
                return (char)IconMenu;
            }
        }

        public Type DestPage { get; set; }

        public object Args{ get; set; }
    }
}
