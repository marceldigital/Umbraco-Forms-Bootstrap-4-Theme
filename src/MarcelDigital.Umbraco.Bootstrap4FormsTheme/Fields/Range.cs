using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Forms.Core;
using Umbraco.Forms.Core.Attributes;

namespace MarcelDigital.Umbraco.Bootstrap4FormsTheme.Fields {
    /// <summary>
    ///     Range field that allows the user to select from a preset range of numbers 
    ///     on a slider.
    /// </summary>
    public class Range : FieldType {
        public Range() {
            Id = new Guid("3C2A12DB-C1E3-4356-A9E5-EFC3CB1A1C83");
            Name = "Range";
            Description = "Renders a range slider, for entering a number whose exact value is not important (like a slider control)";
            Icon = "icon-width";
            DataType = FieldDataType.String; // To support decimals
            SortOrder = 201;
        }

        /// <summary>
        ///     The minimum value for the range.
        /// </summary>
        [Setting("Minimum", alias = "min", description = "The minimum value for the range.", view = "decimal")]
        public string Min { get; set; }

        /// <summary>
        ///     The minimum value for the range.
        /// </summary>
        [Setting("Maximum", alias = "max", description = "The maximum value for the range.", view = "decimal")]
        public string Max { get; set; }

        /// <summary>
        ///     The step value for the range.
        /// </summary>
        [Setting("Step", alias = "step", description = "The step value for the range when it is changed.", view = "decimal")]
        public string Step { get; set; }

        /// <summary>
        ///     The defalut value for the range.
        /// </summary>
        [Setting("Default Value", alias = "defaultValue", description = "The default value of the range.", view = "decimal")]
        public string DefaultValue { get; set; }

        /// <summary>
        ///     Custom validation override to ensure that the value that is submitted is a number or decimal.
        /// </summary>
        public override IEnumerable<string> ValidateField(Form form, Field field, IEnumerable<object> postedValues, HttpContextBase context) {
            var returnStrings = new List<string>();

            if (postedValues.Any(value => !double.TryParse(value.ToString(), out double result))) {
                returnStrings.Add("The value must be a number or decimal.");
            }

            // Also validate it against the original default method.
            returnStrings.AddRange(base.ValidateField(form, field, postedValues, context));

            return returnStrings;
        }
    }
}
