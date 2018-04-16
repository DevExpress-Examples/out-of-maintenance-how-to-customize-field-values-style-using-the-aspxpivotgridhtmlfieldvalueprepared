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
                    e.Cell.Style(HtmlTextWriterStyle.BackgroundColor) = ColorTranslator.ToHtml(Color.LightGreen)
                ElseIf e.Value.ToString() = "Argentina" Then
                    e.Cell.Style(HtmlTextWriterStyle.BackgroundColor) = ColorTranslator.ToHtml(Color.LightBlue)
                Else
                    e.Cell.Style(HtmlTextWriterStyle.BackgroundColor) = ColorTranslator.ToHtml(Color.LightYellow)
                End If
            End If
        End Sub
    End Class
End Namespace
