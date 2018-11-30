using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcelDigital.Umbraco.Bootstrap4FormsTheme.Extensions {
    public class HtmlExtensions {
        public static string ValidationClass(this HtmlHelper htmlHelper,
                                                string fieldId,
                                                string validClass = "",
                                                string invalidClass = "is-invalid") {
            var isValid = htmlHelper.ViewContext.ViewData.ModelState.IsValidField(fieldId);

            return isValid ? validClass : invalidClass;
        }
    }
}
