# Umbraco Forms Bootstrap 4 Theme
[![](https://img.shields.io/nuget/v/MarcelDigital.Umbraco.Bootstrap4FormsTheme.svg)](https://www.nuget.org/packages/MarcelDigital.Umbraco.Bootstrap4FormsTheme)

This package adds Bootstrap 4 themes for the Umbraco Forms plugin. Included are two new themes avaliable to Umbraco Forms package to create forms with horizontal or vertical form labels. Both unobtrusive and server side validation supported.

## Installation
This package requirs Umbraco Forms 6.X.X or above because it uses the themeing that was introduced by version 6 onward. To install, add this [NuGet package](https://www.nuget.org/packages/MarcelDigital.Umbraco.Bootstrap4FormsTheme/) and the approriate files will be copied into your project.

```
Install-Package MarcelDigital.Umbraco.Bootstrap4FormsTheme
```

You will also need to have Bootstrap 4 included in your website to style the form fields. For more information on including Bootstrap 4, consult the documentation [here](https://getbootstrap.com/docs/4.2/getting-started/introduction/).

If you are using NuGet for all your dependencies, Bootstrap 4 is also avaliable as a package to install in your project. See the appendix for details.

*Note:* If you are planning on using client side validation (unobtrusive validation) you must use the latest jQuery validate and unobtrusive javascript libraries. 
The libraries which are a part of the [Umbraco Forms tutorial](https://our.umbraco.com/documentation/Add-ons/UmbracoForms/Developer/Prepping-Frontend/) will not work with version 3.X.X of jQuery due to some methods being deprecated and removed.
Instead use the latest from the [Microsoft CDN](https://docs.microsoft.com/en-us/aspnet/ajax/cdn/overview).

```javascript
<script src="https://ajax.aspnetcdn.com/ajax/jquery.validate/1.19.0/jquery.validate.min.js"></script>
<script src="https://ajax.aspnetcdn.com/ajax/mvc/5.2.3/jquery.validate.unobtrusive.min.js"></script>
```

## Included Themes
This package adds the following themes to the list of avaliable options when inserting an Umbraco Form.

![Theme Picking](https://github.com/marceldigital/Umbraco-Forms-Bootstrap-4-Theme/raw/master/docs/img/theme-picking-screenshot.PNG)

### Horizontal
This theme places the labels to the left of the form fields and creates a 2 column layout.

![Horizontal Theme](https://github.com/marceldigital/Umbraco-Forms-Bootstrap-4-Theme/raw/master/docs/img/horizontal-form-screenshot.PNG)

### Vertical
This theme places the labels above the form fields stacking all of the elements.

![Vertical Theme](https://github.com/marceldigital/Umbraco-Forms-Bootstrap-4-Theme/raw/master/docs/img/vertical-form-screenshot.PNG)

## Supported Field Types
- Checkbox
- Checkbox List
- Data Consent
- Date Picker
- Dropdown List
- File Upload
- Password Field
- Radio Button List
- Text
- Textarea
- Textfield

If a field type is not supported it will fall back to the default style just like any other theme.

## Appendix
### Using NuGet for Bootstrap 4
Bootstrap is avaliable via NuGet to add to your project. If you are looking to install the base Bootstrap 4 framework then use the following NuGet command.

```
Install-Package bootstrap
```

Normally, you will want to do some theming to the base Bootstrap framework. You can do this as well by downloading the SASS version. This will give you all of the source Bootstrap 4 files as SASS. From there, you can override the variables to edit the visuals of Bootstrap to match the brand guidlines of the website you are working on. Learn more about Bootstrap 4 Theming [here](https://getbootstrap.com/docs/4.2/getting-started/theming/)

```
Install-Package bootstrap.sass
```
