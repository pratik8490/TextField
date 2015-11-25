using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TextShield.Portable
{
    public class BasePage : ContentPage
    {
        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="BasePage"/> class.
        /// </summary>
        public BasePage()
        {
            LoadingInit();
        }
        #endregion

        ActivityIndicator LoadingIndicator;
        private void LoadingInit()
        {
            LoadingIndicator = new ActivityIndicator
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Color = Color.Black,
                IsVisible = false
            };
            this.Content = new StackLayout
            {
                Children = {                    
                    LoadingIndicator,                    
                },
                BackgroundColor = Color.White,
            };
        }
        protected override void OnAppearing()
        {
            LoadingIndicator.IsRunning = IsLoading;
            LoadingIndicator.IsVisible = IsLoading;

            BindToolbar();
        }
        public void BindToolbar()
        {
            List<ToolbarItem> lstToolbarItem = new List<ToolbarItem>();

            ExtendedToolbarItem menuToolbarItem = new ExtendedToolbarItem("Menu", "line_menu.png", ToolbarItemOrder.Primary, CategoryMenu);

            lstToolbarItem.Add(menuToolbarItem);

            foreach (ToolbarItem item in lstToolbarItem)
            {
                this.ToolbarItems.Add(item);
            }
        }

        private void CategoryMenu()
        {
            if ((ParentView.ParentView).GetType().Name != "NavigationPage")
                ((MasterDetailPage)(ParentView).ParentView).IsPresented = !((MasterDetailPage)(ParentView).ParentView).IsPresented;
            else
                ((MasterDetailPage)ParentView).IsPresented = !((MasterDetailPage)ParentView).IsPresented;
        }

        protected override void OnDisappearing()
        {
            LoadingIndicator.IsRunning = false;
            LoadingIndicator.IsVisible = false;

            this.ToolbarItems.Clear();
        }

        private bool _isLoading;
        public bool IsLoading
        {
            get { return _isLoading; }
            set
            {
                _isLoading = value;
                OnPropertyChanged();
            }
        }
    }
    public class ExtendedToolbarItem : ToolbarItem
    {
        public ExtendedToolbarItem(string text, string icon, ToolbarItemOrder itemOrder, Action doCommand)
        {
            Text = text;
            Icon = icon;
            Order = itemOrder;
            Command = new Command(doCommand);
        }
    }
}
