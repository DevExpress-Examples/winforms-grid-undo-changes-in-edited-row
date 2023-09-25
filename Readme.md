<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128629368/15.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4883)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WinForms Data Grid - Cancel current row modifications at the GridView level

Windows Forms binding allows you to discard changes made in a data item (row/record). This feature is available for data objects that implement [IEditableObject](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.ieditableobject?view=net-7.0&redirectedfrom=MSDN) ([CurrencyManager.CancelCurrentEdit](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.currencymanager.cancelcurrentedit?view=windowsdesktop-7.0)).

Entity Framework 4 comes with [POCO](https://en.wikipedia.org/wiki/Plain_old_CLR_object) support that allows developers to define entities (base classes are not required). By not inheriting from the underlying entities of the framework, developers lost the built-in implementations of `IEditableObject` and `INotifyPropertyChanged` interfaces (for example, the capability to undo changes to a grid control if data validation fails).

This example demonstrates how to address this issue at the GridView level. The example [creates a custom Grid View](https://supportcenter.devexpress.com/ticket/details/e900/winforms-data-grid-how-to-create-a-gridview-descendant-and-use-it-at-design-time). The custom GridView uses a new data controller (inherited from the `CurrencyDataController` class) and overrides the following methods: `BeginCurrentRowEdit`, `EndCurrentRowEdit`, and `CancelCurrentRowEdit`.


## Files to Review

* [Form1.cs](./CS/DxSample/Form1.cs) (VB: [Form1.vb](./VB/DxSample/Form1.vb))
* [CancellingChangesDataController.cs](./CS/DxSample/Grid/CancellingChangesDataController.cs) (VB: [CancellingChangesDataController.vb](./VB/DxSample/Grid/CancellingChangesDataController.vb))
* [GridControlEx.cs](./CS/DxSample/Grid/GridControlEx.cs) (VB: [GridControlEx.vb](./VB/DxSample/Grid/GridControlEx.vb))
* [GridViewEx.cs](./CS/DxSample/Grid/GridViewEx.cs) (VB: [GridViewEx.vb](./VB/DxSample/Grid/GridViewEx.vb))
* [GridViewExInfoRegistrator.cs](./CS/DxSample/Grid/GridViewExInfoRegistrator.cs) (VB: [GridViewExInfoRegistrator.vb](./VB/DxSample/Grid/GridViewExInfoRegistrator.vb))
* [GridViewExOptionsBehavior.cs](./CS/DxSample/Grid/GridViewExOptionsBehavior.cs) (VB: [GridViewExOptionsBehavior.vb](./VB/DxSample/Grid/GridViewExOptionsBehavior.vb))
* [Person.cs](./CS/DxSample/Person.cs) (VB: [Person.vb](./VB/DxSample/Person.vb))
