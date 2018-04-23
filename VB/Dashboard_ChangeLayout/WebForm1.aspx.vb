Imports System
Imports DevExpress.DashboardWeb
Imports DevExpress.DataAccess.ConnectionParameters
Imports DevExpress.DashboardCommon

Namespace Dashboard_ChangeLayout
    Partial Public Class WebForm1
        Inherits System.Web.UI.Page

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Protected Sub ASPxDashboardViewer1_DashboardLoaded(ByVal sender As Object, _
                                           ByVal e As DashboardLoadedWebEventArgs)
            Dim group1 As DashboardItemGroup = e.Dashboard.CreateGroup()
            group1.Name = "Filters"
            group1.InteractivityOptions.IsMasterFilter = True
            Dim treeView1 As TreeViewDashboardItem =
                CType(e.Dashboard.Items("treeViewDashboardItem1"), TreeViewDashboardItem)
            treeView1.Group = group1

            Dim root As DashboardLayoutGroup = e.Dashboard.LayoutRoot
            Dim treeViewLayoutItem As DashboardLayoutItem = root.FindRecursive(treeView1)
            Dim groupItem As New DashboardLayoutGroup(group1)
            groupItem.Weight = treeViewLayoutItem.Weight
            treeViewLayoutItem.InsertLeft(groupItem)
            root.RemoveRecursive(treeViewLayoutItem)
            groupItem.ChildNodes.Add(treeViewLayoutItem)
        End Sub

        Protected Sub ASPxDashboardViewer1_ConfigureDataConnection(ByVal sender As Object, _
                                           ByVal e As ConfigureDataConnectionWebEventArgs)
            If e.ConnectionName = "nwindConnection" Then
                Dim parameters As Access97ConnectionParameters = CType(e.ConnectionParameters,  _
                    Access97ConnectionParameters)
                Dim databasePath As String = Server.MapPath("App_Data/nwind.mdb")
                parameters.FileName = databasePath
            End If
        End Sub
    End Class
End Namespace