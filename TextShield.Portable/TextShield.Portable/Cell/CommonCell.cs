using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextShield.Portable.Models;
using Xamarin.Forms;

namespace TextShield.Portable.Cell
{
    public class CommonCell : ViewCell
    {
        private ListModel model;

        #region Override methods
        protected override void OnBindingContextChanged()
        {
            model = (ListModel)BindingContext;
            base.OnBindingContextChanged();
            StackLayout stack = CommonCellLayout();

            View = stack;
        }
        #endregion

        #region CommonCellLayout
        /// <summary>
        /// Common cell Layout.
        /// </summary>
        public StackLayout CommonCellLayout()
        {
            Label lblName = new Label
            {
                Text = model.Name,
                TextColor = Color.Black
            };

            StackLayout slName = new StackLayout
            {
                Children = { lblName },
                HorizontalOptions = LayoutOptions.StartAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            Image imgChkbox = new Image
            {
                Source = "Checkmark.png"
            };

            StackLayout slChkMark = new StackLayout
            {
                Children = { imgChkbox },
                HorizontalOptions = LayoutOptions.EndAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            Image imgAerrow = new Image
            {
                Source = "aerrow.png"
            };

            StackLayout slAerrow = new StackLayout
            {
                Children = { imgAerrow },
                HorizontalOptions = LayoutOptions.End,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            StackLayout slLayout = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children = { slName, slChkMark, slAerrow },
                Padding = new Thickness(10, 0, 10, 0),
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            return slLayout;
        }

        #endregion
    }
}
