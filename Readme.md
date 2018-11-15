<!-- default file list -->
*Files to look at*:

* **[CancellingChangesDataController.cs](./CS/DxSample/Grid/CancellingChangesDataController.cs) (VB: [CancellingChangesDataController.vb](./VB/DxSample/Grid/CancellingChangesDataController.vb))**
<!-- default file list end -->
# How to implement a capability to cancel current row modifications at the GridView level


<p>WinForms binding provides a capability to discard modifications made  in a current item. As it is stated in the MSDN, this feature is supported only if objects contained by the datasource implement the <a href="http://msdn.microsoft.com/en-us/library/system.componentmodel.ieditableobject.aspx"><u>IEditableObject</u></a> interface: <a href="http://msdn.microsoft.com/en-us/library/system.windows.forms.currencymanager.cancelcurrentedit.aspx"><u>CurrencyManager.CancelCurrentEdit Method</u></a>.</p><p>Entity Framework 4 comes with <a href="http://en.wikipedia.org/wiki/Plain_Old_CLR_Object"><u>POCO</u></a> support allowing developers to define entities without requiring base classes. However, giving up inheriting from framework base entities developers lost built-in implementations of interfaces required in WinForms binding: <a href="http://msdn.microsoft.com/en-us/library/system.componentmodel.ieditableobject.aspx">IEditableObject</a> and <a href="http://msdn.microsoft.com/en-us/library/System.ComponentModel.INotifyPropertyChanged.aspx">INotifyPropertyChanged</a>. The lack of these interfaces implementation in entities causes loosing a corresponding functionality in data aware controls. For instance, the capability to cancel changes in GridView after validation failes.</p><p>There are many workarounds for this problem. This example demonstrates how to address the issue at the GridControl level without affecting other code. In this example, we create a GridView descendant according to recommendations provided in the <a href="https://www.devexpress.com/Support/Center/p/A859">How to create a GridView descendant class and register it for design-time use</a> Knowledge Base article. The extended GridView uses the new data controller inherited from the CurrencyDataController and extended with a new feature by overriding several methods: BeginCurrentRowEdit, EndCurrentRowEdit, and CancelCurrentRowEdit.</p>


<h3>Description</h3>

<p>Starting from version 2013 vol 1 the minimum required .NET Framework version is 4.0.</p>

<br/>


