using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextShield.Portable.Cell;
using TextShield.Portable.Models;
using Xamarin.Forms;

namespace TextShield.Portable.Pages
{
    public class MenuPage : ContentPage
    {
        public ListView listMenu { get; set; }

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="Menu Page"/> class.
        /// </summary>
        public MenuPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);

            Title = "TextShield";

            Icon = "slideout.png";

            MenuLayout();
        }
        #endregion

        /// <summary>
        /// Menu Page Layout.
        /// </summary>
        public void MenuLayout()
        {
            List<MenuModel> data = MenuModel.MenuListData();

            listMenu = new ListView { RowHeight = 40, SeparatorColor = Color.FromHex("#5B5A5F") };

            listMenu.VerticalOptions = LayoutOptions.FillAndExpand;
            listMenu.BackgroundColor = Color.Transparent;

            listMenu.ItemsSource = data;

            var cell = new DataTemplate(typeof(MenuCell));
            cell.SetBinding(MenuCell.TextProperty, "Title");
            cell.SetBinding(MenuCell.ImageSourceProperty, "IconSource");

            listMenu.ItemTemplate = cell;

            //var menuLabel = new ContentView
            //{
            //    Padding = new Thickness(10, 36, 0, 5),
            //    Content = new Label
            //    {
            //        TextColor = Color.FromHex("AAAAAA"),
            //        Text = "MENU",
            //    }
            //};

            this.Content = new StackLayout
            {
                BackgroundColor = Color.White,
                Children = { listMenu }
            };
        }

    }
}
