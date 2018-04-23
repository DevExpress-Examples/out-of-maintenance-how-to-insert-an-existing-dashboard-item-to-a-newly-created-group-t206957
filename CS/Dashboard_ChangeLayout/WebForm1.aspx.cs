using System;
using DevExpress.DashboardWeb;
using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.DashboardCommon;

namespace Dashboard_ChangeLayout {
    public partial class WebForm1 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
        }

        protected void ASPxDashboardViewer1_DashboardLoaded(object sender, 
            DashboardLoadedWebEventArgs e) {            
            DashboardItemGroup group1 = e.Dashboard.CreateGroup();
            group1.Name = "Filters"; group1.InteractivityOptions.IsMasterFilter = true;
            TreeViewDashboardItem treeView1 = 
                (TreeViewDashboardItem)e.Dashboard.Items["treeViewDashboardItem1"];
            treeView1.Group = group1;

            DashboardLayoutGroup root = e.Dashboard.LayoutRoot;
            DashboardLayoutItem treeViewLayoutItem = root.FindRecursive(treeView1);
            DashboardLayoutGroup groupItem = new DashboardLayoutGroup(group1);
            groupItem.Weight = treeViewLayoutItem.Weight;
            treeViewLayoutItem.InsertLeft(groupItem);
            root.RemoveRecursive(treeViewLayoutItem);
            groupItem.ChildNodes.Add(treeViewLayoutItem);
        }
        
        protected void ASPxDashboardViewer1_ConfigureDataConnection(object sender, 
            ConfigureDataConnectionWebEventArgs e) {
            if (e.ConnectionName == "nwindConnection") {
                Access97ConnectionParameters parameters =
                    (Access97ConnectionParameters)e.ConnectionParameters;
                string databasePath = Server.MapPath("App_Data/nwind.mdb");                   
                parameters.FileName = databasePath;
            }
        }
    }
}