﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs"
           Inherits="FormatCellValues._Default" %>

<%@ Register Assembly="DevExpress.Web.ASPxPivotGrid.v21.2, Version=21.2.7.0,
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
            DataSourceID="SqlDataSource1" Theme="Metropolis"
            onhtmlfieldvalueprepared="ASPxPivotGrid1_HtmlFieldValuePrepared" ClientIDMode="AutoID" IsMaterialDesign="False">
            <Fields>
                <dx:PivotGridField ID="fieldCountry" Area="RowArea"
                    AreaIndex="0">
                    <DataBindingSerializable>
                        <dx:DataSourceColumnBinding ColumnName="Country" />
                    </DataBindingSerializable>
                </dx:PivotGridField>
                <dx:PivotGridField ID="fieldYear" Area="ColumnArea"
                    AreaIndex="0">
                    <DataBindingSerializable>
                        <dx:DataSourceColumnBinding ColumnName="Year" />
                    </DataBindingSerializable>
                </dx:PivotGridField>
                <dx:PivotGridField ID="fieldTotal" Area="DataArea"
                    AreaIndex="0">
                    <DataBindingSerializable>
                        <dx:DataSourceColumnBinding ColumnName="Total" />
                    </DataBindingSerializable>
                </dx:PivotGridField>
            </Fields>
            <OptionsData DataProcessingEngine="Optimized" />
        </dx:ASPxPivotGrid>
        		    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
            ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" 
            SelectCommand="SELECT Customers.Country, Year([OrderDate]) AS [Year], Sum([UnitPrice]*[Quantity]) AS Total
FROM (Customers INNER JOIN Orders ON Customers.CustomerID = Orders.CustomerID) INNER JOIN [Order Details] ON Orders.OrderID = [Order Details].OrderID
GROUP BY Customers.Country, Year([OrderDate])
HAVING (((Customers.Country) In ('Brazil','Argentina','Germany','USA', 'UK')));
"></asp:SqlDataSource>
    </div>
    </form>
</body>
</html>
