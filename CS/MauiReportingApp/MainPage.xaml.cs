using ReportLibrary;
using ReportLibrary.Data;
using DevExpress.Drawing;
using DevExpress.Maui.Pdf;
using DevExpress.XtraReports.UI;

namespace MauiReportingApp;

public partial class MainPage : ContentPage {
    public MainPage() {
        InitializeComponent();

        XtraReport report = CreateTableReportInWizard();

        string resultFile = Path.Combine(FileSystem.Current.AppDataDirectory, report.Name + ".pdf");
        report.ExportToPdf(resultFile);

        pdfViewer.DocumentSource = PdfDocumentSource.FromFile(resultFile);
    }

    public XtraReport CreateTableReportInWizard() {
        XtraReportInstance report = new XtraReportInstance() { Name = "Sample" };
        report.CreateDocument();
        return report;
    }
}
