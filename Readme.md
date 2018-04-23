# How to insert an existing dashboard item to a newly created group


<strong>Note:</strong> <em>Starting with v17.1, we recommend using the <a href="https://documentation.devexpress.com/Dashboard/CustomDocument16976.aspx">ASPxDashboard control</a> or a corresponding <a href="https://documentation.devexpress.com/Dashboard/CustomDocument16977.aspx">ASP.NET MVC extension</a> to display dashboards within web applications.</em><br><br>The following example demonstrates how to insert an existing dashboard item in a newly created <a href="http://documentation.devexpress.com/#Dashboard/CustomDocument17586">group</a> using Dashboard API.<br>In this example, the <a href="http://documentation.devexpress.com/#Dashboard/clsDevExpressDashboardWebASPxDashboardViewertopic">ASPxDashboardViewer</a> loads an existing dashboard with the predefined layout from an <a href="http://documentation.devexpress.com/#Dashboard/CustomDocument15405">XML file</a>. <br>The following steps are performed to insert the <a href="http://documentation.devexpress.com/#Dashboard/CustomDocument17659">tree view</a> filter element into a newly created group

* The layout item corresponding to the tree view is obtained using the <a href="http://documentation.devexpress.com/#Dashboard/DevExpressDashboardCommonDashboardLayoutGroup_FindRecursivetopic">FindRecursive</a> method.<br>- The <a href="http://documentation.devexpress.com/#Dashboard/DevExpressDashboardCommonDashboardLayoutNode_InsertLefttopic">InsertLeft</a> method is used to insert the tree view layout item into the newly created layout group which is used to display a new dashboard item group.<br>- Finally, the layout item corresponding to the tree view is removed from the layout tree and added to the layout group's <a href="http://documentation.devexpress.com/#Dashboard/DevExpressDashboardCommonDashboardLayoutGroup_ChildNodestopic">ChildNodes</a> collection.

<br/>


