// Developer Express Code Central Example:
// How to Format Cell Values
// 
// The following example shows how to format data that corresponds to 'Quantity'
// and 'Unit Price' data fields in a sample ASPxPivotGrid control. For the
// 'Quantity' field the PivotFieldBase.CellFormat property is used to format data
// in a custom manner. Values that correspond to this field are enclosed with round
// brackets. The formatting settings specified by the PivotFieldBase.CellFormat
// property also affect the representation of total and grand total cells. The
// 'Unit Price' field is bound to a field that contains currency data. By default
// the cell values that correspond to such fields are formatted as currency amounts
// (the formatting settings are determined by the regional settings). For English
// (United States) culture the currency values are represented using two digits to
// the right of the decimal point. In the example, the
// PivotFieldBase.GrandTotalCellFormat property is used to format grand total cell
// values for the 'Unit Price' field in a different manner. The data in these cells
// is formatted as integer currency values (without fractional portions).
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E1874

using System;
using System.Web.UI;
using System.Drawing;

namespace FormatCellValues {
    public partial class _Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
        }

        protected void ASPxPivotGrid1_HtmlFieldValuePrepared(object sender, DevExpress.Web.ASPxPivotGrid.PivotHtmlFieldValuePreparedEventArgs e) {
            if(Object.ReferenceEquals( e.Field, fieldCountry))
            {
                if (e.Value.ToString() == "Brazil")
                    e.Cell.Style[HtmlTextWriterStyle.BackgroundColor] = ColorTranslator.ToHtml( Color.Green );
                else if (e.Value.ToString() == "Argentina")
                    e.Cell.Style[HtmlTextWriterStyle.BackgroundColor] = ColorTranslator.ToHtml( Color.LightBlue);
                else
                    e.Cell.Style[HtmlTextWriterStyle.BackgroundColor] = ColorTranslator.ToHtml( Color.Yellow );
            }
        }
    }
}
