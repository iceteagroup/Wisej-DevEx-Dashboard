<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyPage.aspx.cs" Inherits="Wisej.Web.Ext.DevExpress.Dashboard.Sample.MyDXDashboard" %>

<%@ Register Assembly="DevExpress.Dashboard.v20.2.Web.WebForms, Version=20.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.DashboardWeb" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title>My Dashboard</title>
	<style type="text/css">
		html, body, form {  
			height: 100%;  
			margin: 0;  
			padding: 0;  
			overflow: hidden;  
		}
	</style>
</head>
<body>
	<form id="form1" runat="server">
		<dx:ASPxDashboard ID="MyDXDashboard1" runat="server" Height="100%" 
			OnDataLoading="MyDXDashboard1_DataLoading">
		</dx:ASPxDashboard>
	</form>
</body>
</html>
