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
    public class CommonPage : BasePage
    {
        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="Common Page"/> class.
        /// </summary>
        public CommonPage()
        {
            CommonPageLayout();
        }
        #endregion

        /// <summary>
        /// Common Page Layout.
        /// </summary>
        public void CommonPageLayout()
        {
            ListView listMenu = new ListView { RowHeight = 40, BackgroundColor = Color.Transparent, SeparatorColor = Color.Gray };

            listMenu.ItemsSource = ListModel.GetListData();
            listMenu.ItemTemplate = new DataTemplate(() => new CommonCell());

            listMenu.ItemSelected += (sender, e) =>
            {
                if (e.SelectedItem == null) return;
                ListModel objMenu = (ListModel)e.SelectedItem;

                if (objMenu.Id == 1)
                {
                    Navigation.PushAsync(App.AcountBasicPage());
                }
                else if (objMenu.Id == 2)
                {
                    Navigation.PushAsync(App.SetUpCodePage());
                }
            };

            Content = new StackLayout
            {
                BackgroundColor = Color.White,
                Children = {                      
                        listMenu
                    },
            };
        }
    }
}
