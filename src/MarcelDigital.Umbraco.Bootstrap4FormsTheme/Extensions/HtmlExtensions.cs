using System.Web.Mvc;

namespace MarcelDigital.Umbraco.Bootstrap4FormsTheme.Extensions {
    public static class HtmlExtensions {
        public static string ValidationClass(this HtmlHelper htmlHelper,
                                                string fieldId,
                                                string validClass = "",
                                                string invalidClass = "is-invalid") {
            var isValid = htmlHelper.ViewContext.ViewData.ModelState.IsValidField(fieldId);

            return isValid ? validClass : invalidClass;
        }
    }
}
