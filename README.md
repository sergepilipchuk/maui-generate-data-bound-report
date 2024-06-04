<!-- default badges list -->
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# DevExpress Reporting for .NET MAUI - Generate Bound-Data Report

This example generates a data-bound report in the [DevExpress Report Designer](https://docs.devexpress.com/MAUI/404437/reporting/reporting-overview) and displays it in the [PDF Viewer for .NET MAUI](https://docs.devexpress.com/MAUI/404632/pdf-viewer/pdf-viewer). To use Reporting APIs in a .NET MAUI project, you need a license that includes [DevExpress Reporting](https://www.devexpress.com/subscriptions/reporting/).

<img width="40%" alt="DevExpress Reporting for .NET MAUI - Generate Bound-Data Report" src="Images/app-preview.png">

## Included Controls and Their Properties

* [PdfViewer](https://docs.devexpress.com/MAUI/DevExpress.Maui.Pdf.PdfViewer): [ShowToolbar](https://docs.devexpress.com/MAUI/DevExpress.Maui.Pdf.PdfViewer.ShowToolbar), [DocumentSource](https://docs.devexpress.com/MAUI/DevExpress.Maui.Pdf.PdfViewer.DocumentSource)

## Implementation Details

1. Define the `CreateTableReportAsync()` function that creates a new report. Use the `XtraReportInstance()` constructor to generate a report instance. Call the [`CreateDocument()`](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.XtraReport.CreateDocument) method to create a document from the report:

    ```csharp
    public async Task<XtraReport> CreateTableReportAsync() {
        XtraReportInstance report = null;
        await Task.Run(() =>
        {
            report = new XtraReportInstance() { Name = "Sample" };
            report.CreateDocument();
        });
        return report;
    }
    ```

2. Call the `CreateTableReportAsync()` function to generate a new report and get a path to the report:

    ```csharp
    private async void ContentPage_Loaded(object sender, EventArgs e) {
        XtraReport report = await CreateTableReportAsync();
        string resultFile = Path.Combine(FileSystem.Current.AppDataDirectory, report.Name + ".pdf");
        // ...
    }
    ```

3. Call the `ExportToPdf(resultFile)` method to convert the report to PDF:

    ```csharp
    private async void ContentPage_Loaded(object sender, EventArgs e) {
        XtraReport report = await CreateTableReportAsync();
        string resultFile = Path.Combine(FileSystem.Current.AppDataDirectory, report.Name + ".pdf");
        report.ExportToPdf(resultFile);
        // ...    
    }
    ```

4. Use the `PdfViewer.DocumentSource` property to open the report in the PDF Viewer control:

    ```csharp
    private async void ContentPage_Loaded(object sender, EventArgs e) {
        XtraReport report = await CreateTableReportAsync();
        string resultFile = Path.Combine(FileSystem.Current.AppDataDirectory, report.Name + ".pdf");
        report.ExportToPdf(resultFile);
        pdfViewer.DocumentSource = PdfDocumentSource.FromFile(resultFile);
        // ...    
    }
    ```

## Files to Review

- [MainPage.xaml](./CS/MauiReportingApp/MainPage.xaml)
- [MainPage.xaml.cs](./CS/MauiReportingApp/MainPage.xaml.cs)
- [XtraReportInstance.cs](./CS/ReportLibrary/XtraReportInstance.cs)
- [XtraReportInstance.Designer.cs](./CS/ReportLibrary/XtraReportInstance.Designer.cs)

## Documentation

* [PdfViewer](https://docs.devexpress.com/MAUI/DevExpress.Maui.Pdf.PdfViewer)
* [.NET Reporting Tools for Web, Mobile, and Desktop](https://docs.devexpress.com/XtraReports/2162/reporting)
* [.NET Reporting for .NET MAUI](https://www.devexpress.com/subscriptions/reporting/)
* [Configure a Report in the Visual Studio Designer](https://docs.devexpress.com/MAUI/404892/reporting/create-report-vs-designer)
* [Configure a Report in the Visual Studio Code Designer](https://docs.devexpress.com/MAUI/404930/reporting/create-report-in-vs-code-designer)
* [Create a Report in Code](https://docs.devexpress.com/MAUI/404891/reporting/create-report-in-code)

## More Examples

* [DevExpress .NET MAUI Demo Center](https://github.com/DevExpress-Examples/maui-demo-app)
* [Stocks App](https://github.com/DevExpress-Examples/maui-stocks-mini)
* [Data Grid](https://github.com/DevExpress-Examples/maui-data-grid-get-started)
* [Data Form](https://github.com/DevExpress-Examples/maui-data-form-get-started)
* [Data Editors](https://github.com/DevExpress-Examples/maui-editors-get-started)
* [Charts](https://github.com/DevExpress-Examples/maui-charts)
* [Scheduler](https://github.com/DevExpress-Examples/maui-scheduler-get-started)
* [Tab Page](https://github.com/DevExpress-Examples/maui-tab-page-get-started)
* [Tab View](https://github.com/DevExpress-Examples/maui-tab-view-get-started)
* [Drawer Page](https://github.com/DevExpress-Examples/maui-drawer-page-get-started)
* [Drawer View](https://github.com/DevExpress-Examples/maui-drawer-view-get-started)
* [Collection View](https://github.com/DevExpress-Examples/maui-collection-view-get-started)
* [Popup](https://github.com/DevExpress-Examples/maui-popup-get-started)
