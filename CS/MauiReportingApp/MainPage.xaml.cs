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
        //XtraReport report = CreateReport();
        //XtraReport report = CreateTableReport();

        string resultFile = Path.Combine(FileSystem.Current.AppDataDirectory, report.Name + ".pdf");
        report.ExportToPdf(resultFile);

        pdfViewer.DocumentSource = PdfDocumentSource.FromFile(resultFile);
    }

    /*
    public XtraReport CreateReport() {
        XtraReport report = new XtraReport() { Name = "Sample" };
        DetailBand detail = new DetailBand();
        XRLabel labelLobster = new XRLabel() {
            Text = "Sample Text Lobster",
            Font = new DevExpress.Drawing.DXFont("Lobster", 24f),
            CanGrow = true,
            SizeF = new System.Drawing.SizeF(report.PageWidth - report.Margins.Left - report.Margins.Right, 200),
        };
        detail.Controls.Add(labelLobster);
        report.Bands.Add(detail);
        report.CreateDocument();
        return report;
    }
    */
    /*
    public XtraReport CreateTableReport() {
        XtraReport report = new XtraReport() { Name = "Sample" };
        report.DataSource = new CountryDataSource();

        ReportHeaderBand headerBand = new ReportHeaderBand();
        headerBand.HeightF = 40;
        headerBand.BackColor = System.Drawing.Color.Beige;
        report.Bands.Add(headerBand);

        XRTable headerTable = new XRTable();
        headerTable.Rows.Add(new XRTableRow());
        XRTableCell cellDetail3 = new XRTableCell() { Text = "Country" };
        XRTableCell cellDetail4 = new XRTableCell() { Text = "Area, km²" };
        headerTable.Rows[0].Cells.AddRange([cellDetail3, cellDetail4]);
        headerTable.WidthF = report.PageWidth - report.Margins.Left - report.Margins.Right;
        headerBand.Controls.Add(headerTable);

        headerTable.BorderColor = System.Drawing.Color.Gray;
        headerTable.Font = new DXFont("Lobster", 30, DXFontStyle.Bold);
        headerTable.Padding = 0;
        headerTable.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;

        DetailBand detailBand = new DetailBand();
        detailBand.HeightF = 25;
        report.Bands.Add(detailBand);

        XRTable table = new XRTable();
        detailBand.Controls.Add(table);

        table.Rows.Add(new XRTableRow());

        XRTableCell cellDetail1 = new XRTableCell();
        XRTableCell cellDetail2 = new XRTableCell();
        cellDetail1.ExpressionBindings.Add(new ExpressionBinding("Text", "[Region]"));
        cellDetail2.ExpressionBindings.Add(new ExpressionBinding("Text", "[Area]"));
        table.Rows[0].Cells.AddRange([cellDetail1, cellDetail2]);

        table.BorderColor = System.Drawing.Color.Gray;
        table.Font = new DXFont("OpenSansRegular", 20);
        table.Padding = 0;
        table.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        table.WidthF = report.PageWidth - report.Margins.Left - report.Margins.Right;

        report.CreateDocument();
        return report;
    }
    */

    public XtraReport CreateTableReportInWizard() {
        XtraReportInstance report = new XtraReportInstance() { Name = "Sample" };
        report.CreateDocument();
        return report;
    }
}
