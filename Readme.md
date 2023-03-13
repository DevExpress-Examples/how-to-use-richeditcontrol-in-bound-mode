<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128611304/22.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3480)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# How to use a RichEditControl in Bound Mode

This example illustrates how to bind the RichEditControl to a data column and load and save **Rtf** content (note that actual data is stored in the SQL Server database). The [RichEditControl.RtfText](https://docs.devexpress.com/WindowsForms/DevExpress.XtraRichEdit.RichEditControl.RtfText) property
is used to bind the RichEditControl to the column.

The client application supports two data persistence levels: control (RichEditControl) level and memory (DateSet) level. The Undo Manager of the RichEditControl controls the first level. We utilize the [RichEditControl.Modified](https://docs.devexpress.com/WindowsForms/DevExpress.XtraRichEdit.RichEditControl.Modified) property to define the current state of this level. The [DataNavigator](https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.DataNavigator) allows users to accept and reject changes, and switch between entries.
The ADO.NET DataTable container maintains the memory level. The changes at this level are accepted/rejected by the user via separate buttons above the RichEditControl. You can find more information on this subject in the following article: [Row States and Row Versions](https://learn.microsoft.com/en-us/dotnet/framework/data/adonet/dataset-datatable-dataview/row-states-and-row-versions).

To test this example locally, you should setup "CarsDB" sample database in your SQL Server instance. Create a database with this name and utilize **Script.sql** file, attached with this example, to generate a sample table schema and data.

The picture below illustrates the sample in action.

![application](./media/2f5e7b7c-fc11-4179-8b04-70209f8a4694.png)

## Files to Look At

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [Program.cs](./CS/Program.cs) (VB: [Program.vb](./VB/Program.vb))
* [Script.sql](./CS/Script.sql)
