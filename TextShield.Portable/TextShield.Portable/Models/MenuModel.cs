using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextShield.Portable.Pages;

namespace TextShield.Portable.Models
{
    public class MenuModel
    {
        public string Title { get; set; }

        public string IconSource { get; set; }

        public Type TargetType { get; set; }

        public static List<MenuModel> MenuListData()
        {
            List<MenuModel> MenuList = new List<MenuModel>();

            MenuList.Add(new MenuModel()
            {
                Title = "Conversations",
                //IconSource = "contacts.png",
                //TargetType = typeof(TSConversationsPage)
            });

            MenuList.Add(new MenuModel()
            {
                Title = "Contacts",
                //IconSource = "leads.png",
                //TargetType = typeof(TSContactsPage)
            });

            MenuList.Add(new MenuModel()
            {
                Title = "Settings",
                //IconSource = "accounts.png",
                //TargetType = typeof(TSSettingsPage)
            });

            MenuList.Add(new MenuModel()
            {
                Title = "Reports",
                //IconSource = "opportunities.png",
                //TargetType = typeof(TSReportingPage)
            });

            return MenuList;
        }
    }


    public class ListModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public static List<ListModel> GetListData()
        {
            List<ListModel> lstListData = new List<ListModel>();

            lstListData.Add(new ListModel { Id = 1, Name = "Account Basics" });
            lstListData.Add(new ListModel { Id = 2, Name = "Setup Codes" });
            lstListData.Add(new ListModel { Id = 3, Name = "Department" });
            lstListData.Add(new ListModel { Id = 4, Name = "Advanced" });
            lstListData.Add(new ListModel { Id = 5, Name = "Invite Agents" });

            return lstListData;
        }

    }

}
