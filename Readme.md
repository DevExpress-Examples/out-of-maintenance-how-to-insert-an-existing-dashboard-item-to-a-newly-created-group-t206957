<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128580266/14.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T206957)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [WebForm1.aspx.cs](./CS/Dashboard_ChangeLayout/WebForm1.aspx.cs) (VB: [WebForm1.aspx.vb](./VB/Dashboard_ChangeLayout/WebForm1.aspx.vb))
<!-- default file list end -->
# How to insert an existing dashboard item to a newly created group
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/t206957/)**
<!-- run online end -->


<strong>Note:</strong> <em>Starting with v17.1, we recommend using the <a href="https://documentation.devexpress.com/Dashboard/CustomDocument16976.aspx">ASPxDashboard control</a> or a corresponding <a href="https://documentation.devexpress.com/Dashboard/CustomDocument16977.aspx">ASP.NET MVC extension</a> to display dashboards within web applications.</em><br><br>The following example demonstrates how to insert an existing dashboard item in a newly created <a href="http://documentation.devexpress.com/#Dashboard/CustomDocument17586">group</a> using Dashboard API.<br>In this example, the <a href="http://documentation.devexpress.com/#Dashboard/clsDevExpressDashboardWebASPxDashboardViewertopic">ASPxDashboardViewer</a> loads an existing dashboard with the predefined layout from an <a href="http://documentation.devexpress.com/#Dashboard/CustomDocument15405">XML file</a>. <br>The following steps are performed to insert the <a href="http://documentation.devexpress.com/#Dashboard/CustomDocument17659">tree view</a> filter element into a newly created group

* The layout item corresponding to the tree view is obtained using the <a href="http://documentation.devexpress.com/#Dashboard/DevExpressDashboardCommonDashboardLayoutGroup_FindRecursivetopic">FindRecursive</a> method.<br>- The <a href="http://documentation.devexpress.com/#Dashboard/DevExpressDashboardCommonDashboardLayoutNode_InsertLefttopic">InsertLeft</a> method is used to insert the tree view layout item into the newly created layout group which is used to display a new dashboard item group.<br>- Finally, the layout item corresponding to the tree view is removed from the layout tree and added to the layout group's <a href="http://documentation.devexpress.com/#Dashboard/DevExpressDashboardCommonDashboardLayoutGroup_ChildNodestopic">ChildNodes</a> collection.

<br/>


