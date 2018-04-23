' Developer Express Code Central Example:
' How to Format Cell Values
' 
' The following example shows how to format data that corresponds to 'Quantity'
' and 'Unit Price' data fields in a sample ASPxPivotGrid control. For the
' 'Quantity' field the PivotFieldBase.CellFormat property is used to format data
' in a custom manner. Values that correspond to this field are enclosed with round
' brackets. The formatting settings specified by the PivotFieldBase.CellFormat
' property also affect the representation of total and grand total cells. The
' 'Unit Price' field is bound to a field that contains currency data. By default
' the cell values that correspond to such fields are formatted as currency amounts
' (the formatting settings are determined by the regional settings). For English
' (United States) culture the currency values are represented using two digits to
' the right of the decimal point. In the example, the
' PivotFieldBase.GrandTotalCellFormat property is used to format grand total cell
' values for the 'Unit Price' field in a different manner. The data in these cells
' is formatted as integer currency values (without fractional portions).
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E1874


Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports System.Drawing

Namespace FormatCellValues
	Partial Public Class _Default
		Inherits System.Web.UI.Page
		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		End Sub

		Protected Sub ASPxPivotGrid1_HtmlFieldValuePrepared(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxPivotGrid.PivotHtmlFieldValuePreparedEventArgs)
			If Object.ReferenceEquals(e.Field, fieldCountry) Then
				If e.Value.ToString() = "Brazil" Then
					e.Cell.Style(HtmlTextWriterStyle.BackgroundColor) = ColorTranslator.ToHtml(Color.Green)
				ElseIf e.Value.ToString() = "Argentina" Then
					e.Cell.Style(HtmlTextWriterStyle.BackgroundColor) = ColorTranslator.ToHtml(Color.LightBlue)
				Else
					e.Cell.Style(HtmlTextWriterStyle.BackgroundColor) = ColorTranslator.ToHtml(Color.Yellow)
				End If
			End If
		End Sub
	End Class
End Namespace
