<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128636143/11.1.11%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3782)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# How to change UI localization at runtime

Localization-related settings (for example, the culture) should be set at application startup (before control initialization). To change localization settings (for example, the language) you should restart the application. This example shows how to use the [Application.Restart](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.application.restart?view=windowsdesktop-7.0) method to shut down the application and start a new instance immediately.

> **Note**
>
> Before running this example, unpack the **fr.zip** archive and make sure its contents are copied to the *bin\Debug\fr* folder.


## Files to Review

* [CultureSwitcher.cs](./CS/CultureSwitcher.cs) (VB: [CultureSwitcher.vb](./VB/CultureSwitcher.vb))
* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-change-ui-localization-runtime&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-change-ui-localization-runtime&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
