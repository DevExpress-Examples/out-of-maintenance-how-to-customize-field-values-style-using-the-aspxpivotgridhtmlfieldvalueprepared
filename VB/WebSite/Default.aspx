<%@ Page Language="vb" AutoEventWireup="true" CodeFile="Default.aspx.vb"
		   Inherits="FormatCellValues._Default" %>

<%@ Register Assembly="DevExpress.Web.ASPxPivotGrid.v10.1, Version=10.1.5.0,
		   Culture=neutral, PublicKeyToken=b88d1754d700e49a"
		   Namespace="DevExpress.Web.ASPxPivotGrid"
		   TagPrefix="dx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" 
		  "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<title></title>
</head>
<body>
	<form id="form1" runat="server">
	<div>
		<dx:ASPxPivotGrid ID="ASPxPivotGrid1" runat="server" 
			DataSourceID="AccessDataSource1" 
			onhtmlfieldvalueprepared="ASPxPivotGrid1_HtmlFieldValuePrepared">
			<Fields>
				<dx:PivotGridField ID="fieldCountry" Area="RowArea"
					AreaIndex="0" FieldName="Country">
				</dx:PivotGridField>
				<dx:PivotGridField ID="fieldYear" Area="ColumnArea"
					AreaIndex="0" FieldName="Year">
				</dx:PivotGridField>
				<dx:PivotGridField ID="fieldTotal" Area="DataArea"
					AreaIndex="0" FieldName="Total">
				</dx:PivotGridField>
			</Fields>
		</dx:ASPxPivotGrid>
		<asp:AccessDataSource ID="AccessDataSource1" runat="server" 
			DataFile="~/App_Data/nwind.mdb" 
			SelectCommand="SELECT Customers.Country, Year([OrderDate]) AS [Year], Sum([UnitPrice]*[Quantity]) AS Total
FROM (Customers INNER JOIN Orders ON Customers.CustomerID = Orders.CustomerID) INNER JOIN [Order Details] ON Orders.OrderID = [Order Details].OrderID
GROUP BY Customers.Country, Year([OrderDate])
HAVING (((Customers.Country) In ('Brazil','Argentina','Germany')));
">
		</asp:AccessDataSource>
	</div>
	</form>
</body>
</html>