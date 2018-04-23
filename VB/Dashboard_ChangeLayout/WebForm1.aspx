<%@ Page Language="vb" AutoEventWireup="true" CodeBehind="WebForm1.aspx.vb" Inherits="Dashboard_ChangeLayout.WebForm1" %>

<%@ Register Assembly="DevExpress.Dashboard.v14.2.Web, Version=14.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.DashboardWeb" TagPrefix="dx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <dx:ASPxDashboardViewer ID="ASPxDashboardViewer1" runat="server" 
            DashboardSource="~/App_Data/Dashboard.xml" Height="600px" 
            onconfiguredataconnection="ASPxDashboardViewer1_ConfigureDataConnection" 
            Width="1100px" ondashboardloaded="ASPxDashboardViewer1_DashboardLoaded">
        </dx:ASPxDashboardViewer>
    </div>
    </form>
</body>
</html>