using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextShield.Portable.Pages
{
    public class TSConversationsPage : BasePage
    {
        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="TSConversations Page"/> class.
        /// </summary>
        public TSConversationsPage()
        {
            TSConversationsPageLayout();
        }
        #endregion

        /// <summary>
        /// TSConversations Page Layout.
        /// </summary>
        public void TSConversationsPageLayout()
        {
            Title = "Conversations";
            Icon = "Contracts.png";
        }
    }
}
