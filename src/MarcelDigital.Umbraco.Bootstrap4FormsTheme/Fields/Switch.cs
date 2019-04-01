using System;
using Umbraco.Forms.Core.Providers.FieldTypes;

namespace MarcelDigital.Umbraco.Bootstrap4FormsTheme.Fields {
    /// <summary>
    ///     A toggle switch field for use with custom checkbox input types. 
    /// </summary>
    public class Switch : CheckBox {
        public Switch() {
            Id = new Guid("3C2A12DB-C1E3-4356-A9E5-EFC3CB1A1C94");
            Name = "Switch";
            Description = "Renders a Switch toggle";
            Icon = "icon-forms-flickr";
            SortOrder = 203;
        }
    }
}