<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128611304/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3480)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [Program.cs](./CS/Program.cs) (VB: [Program.vb](./VB/Program.vb))
<!-- default file list end -->
# How to use a RichEditControl in bound mode


<p>This example illustrates how to bind the RichEditControl to an Rtf data column and handle Rtf content saving/loading operations (note that actual data is stored in the SQL Server database). The major aspects covered by this example are:</p><p>1) Choosing the SQL column data type for Rtf content. Most often, the <strong>varchar(max)</strong> type is sufficient for this purpose (note that <a href="http://en.wikipedia.org/wiki/Rich_Text_Format"><u>Rich Text Format</u></a> is an 8-bit format). We have discussed this topic in the context of the <a href="https://www.devexpress.com/Support/Center/p/Q311679">save RTF-document to database - which column-type is the best</a> thread. See also: <a href="http://msdn.microsoft.com/en-us/library/bb386947.aspx"><u>SQL-CLR Type Mapping</u></a>.</p><p>2) Supporting two data persistence levels in the client application: control (RichEditControl) level and memory (DateSet) level. The first level is controlled by the Undo Manager of the RichEditControl (see the <a href="http://community.devexpress.com/blogs/rachelreese/archive/2011/07/14/winforms-xtrarichedit-undo-redo-an-illusion-of-simplicity.aspx"><u>WinForms XtraRichEdit – A History of Undo and Redo</u></a> blog post to learn more on this subject). We utilize the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraRichEditRichEditControl_Modifiedtopic"><u>RichEditControl.Modified Property</u></a> to define the current state of this level. The changes at this level are accepted/rejected by the end-user via the <a href="http://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraEditorsDataNavigatortopic"><u>DataNavigator</u></a>. Memory level is maintained by the ADO.NET DataTable container. You can find more information on this subject in the <a href="http://msdn.microsoft.com/en-us/library/ww3k31w0.aspx"><u>Row States and Row Versions</u></a> webpage. The changes at this level are accepted/rejected by the end-user via separate buttons above the RichEditControl.</p><p>The actual RichEditControl binding to the <strong>RtfContent</strong> column is established via the bindable <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraRichEditRichEditControl_RtfTexttopic"><u>RichEditControl.RtfText Property</u></a> in the Form1_Load event handler.</p><p>To test this example locally, you should setup "CarsDB" sample database in your SQL Server instance. Create a database with this name and utilize Script.sql file, attached with this example, to generate a sample table schema and data.</p><p>The picture below illustrates the sample in action.</p><p><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-use-a-richeditcontrol-in-bound-mode-e3480/13.1.4+/media/2f5e7b7c-fc11-4179-8b04-70209f8a4694.png"></p>

<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=how-to-use-richeditcontrol-in-bound-mode&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=how-to-use-richeditcontrol-in-bound-mode&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
