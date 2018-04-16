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
                    e.Cell.Style[HtmlTextWriterStyle.BackgroundColor] = ColorTranslator.ToHtml( Color.LightGreen );
                else if (e.Value.ToString() == "Argentina")
                    e.Cell.Style[HtmlTextWriterStyle.BackgroundColor] = ColorTranslator.ToHtml( Color.LightBlue);
                else
                    e.Cell.Style[HtmlTextWriterStyle.BackgroundColor] = ColorTranslator.ToHtml( Color.LightYellow );
            }
        }
    }
}
