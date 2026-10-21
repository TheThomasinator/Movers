using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Movers
{
    public class PdfMaker
    {
        public void CreatePdf(DataGridView dgv, string reportType)
        {
            string docName = reportType + "_" + DateTime.Now.ToString("ddMMYY" + "_HHmm") + ".pdf";
            Document doc = new Document(iTextSharp.text.PageSize.A4, 10, 10, 42, 35);
            PdfWriter pdfWriter = PdfWriter.GetInstance(doc, new FileStream(docName, FileMode.Create));
            doc.Open();
            PdfContentByte pdfContent = pdfWriter.DirectContent;
            iTextSharp.text.Rectangle rectangle = new iTextSharp.text.Rectangle(doc.PageSize);

            rectangle.Left += doc.LeftMargin - 5; rectangle.Right -= doc.RightMargin - 5;
            rectangle.Top -= doc.TopMargin - 5; rectangle.Bottom += doc.BottomMargin - 5;
            pdfContent.SetColorStroke(BaseColor.WHITE);
            pdfContent.Rectangle(rectangle.Left, rectangle.Bottom, rectangle.Width, rectangle.Height);
            pdfContent.Stroke();

            iTextSharp.text.Font headerFont = iTextSharp.text.FontFactory.GetFont(FontFactory.COURIER_BOLD, 25, BaseColor.DARK_GRAY);
            iTextSharp.text.Font font = iTextSharp.text.FontFactory.GetFont(FontFactory.HELVETICA, 12, BaseColor.WHITE);
            Paragraph mytext = new Paragraph();
            mytext.Alignment = Element.ALIGN_CENTER;
            mytext.Add(new Chunk(reportType + " " + DateTime.Now.ToString("dd-MM-yyyy"), headerFont));
            mytext.SetLeading(2.5f, 2.5f);

            Paragraph myText2 = new Paragraph();
            myText2.Add("    ");
            myText2.SetLeading(2.5f, 2.5f);


            PdfPTable myTable = new PdfPTable(dgv.Columns.Count);
            bool col = true;
            for (int j = 0; j < dgv.Columns.Count; j++)
            {
                PdfPCell cell = new PdfPCell();
                cell.BackgroundColor = BaseColor.BLUE;
                cell.AddElement(new Chunk(dgv.Columns[j].HeaderText.ToUpper(), font));
                myTable.AddCell(cell);
            }

            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                if (!col)
                    col = true;
                else
                    col = false;

                myTable.WidthPercentage = 100;
                for (int j = 0; j < dgv.Columns.Count; j++)
                {
                    if (dgv[j, i].Value != null)
                    {
                        PdfPCell cell = new PdfPCell();
                        cell.AddElement(new Phrase(dgv[j, i].Value.ToString()));
                        if (!col)
                            cell.BackgroundColor = BaseColor.WHITE;
                        else
                            cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                        myTable.AddCell(cell);
                    }
                }
            }

            doc.Add(mytext); doc.Add(myText2); doc.Add(myTable);
            doc.Close();
            System.Diagnostics.Process.Start(docName);
        }

        public void CreateSchedulePdf(DataGridView dgv1, DataGridView dgv2, DataGridView dgv3, string reportType, string date)
        {
            string docName = reportType + "_" + date + ".pdf";
            Document doc = new Document(iTextSharp.text.PageSize.A4, 10, 10, 42, 35);
            PdfWriter pdfWriter = PdfWriter.GetInstance(doc, new FileStream(docName, FileMode.Create));
            doc.Open();
            PdfContentByte pdfContent = pdfWriter.DirectContent;
            iTextSharp.text.Rectangle rectangle = new iTextSharp.text.Rectangle(doc.PageSize);

            rectangle.Left += doc.LeftMargin - 5; rectangle.Right -= doc.RightMargin - 5;
            rectangle.Top -= doc.TopMargin - 5; rectangle.Bottom += doc.BottomMargin - 5;
            pdfContent.SetColorStroke(BaseColor.WHITE);
            pdfContent.Rectangle(rectangle.Left, rectangle.Bottom, rectangle.Width, rectangle.Height);
            pdfContent.Stroke();

            iTextSharp.text.Font headerFont = iTextSharp.text.FontFactory.GetFont(FontFactory.COURIER_BOLD, 25, BaseColor.DARK_GRAY);
            iTextSharp.text.Font font = iTextSharp.text.FontFactory.GetFont(FontFactory.HELVETICA, 12, BaseColor.WHITE);
            Paragraph mytext = new Paragraph();
            mytext.Alignment = Element.ALIGN_CENTER;
            mytext.Add(new Chunk(reportType + " " + date, headerFont));
            mytext.SetLeading(2.5f, 2.5f);

            Paragraph myText2 = new Paragraph();
            myText2.Add("    ");
            myText2.SetLeading(2.5f, 2.5f);


            PdfPTable myTable = new PdfPTable(dgv1.Columns.Count);
            bool col = true;
            for (int j = 0; j < dgv1.Columns.Count; j++)
            {
                PdfPCell cell = new PdfPCell();
                cell.BackgroundColor = BaseColor.BLUE;
                cell.AddElement(new Chunk(dgv1.Columns[j].HeaderText.ToUpper(), font));
                myTable.AddCell(cell);
            }

            for (int i = 0; i < dgv1.Rows.Count; i++)
            {
                if (!col)
                    col = true;
                else
                    col = false;

                myTable.WidthPercentage = 100;
                for (int j = 0; j < dgv1.Columns.Count; j++)
                {
                    if (dgv1[j, i].Value != null)
                    {
                        PdfPCell cell = new PdfPCell();
                        cell.AddElement(new Phrase(dgv1[j, i].Value.ToString()));
                        if (!col)
                            cell.BackgroundColor = BaseColor.WHITE;
                        else
                            cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                        myTable.AddCell(cell);
                    }
                }
            }

            PdfPTable myTable2 = new PdfPTable(dgv2.Columns.Count);
            bool col2 = true;
            for (int j = 0; j < dgv2.Columns.Count; j++)
            {
                PdfPCell cell2 = new PdfPCell();
                cell2.BackgroundColor = BaseColor.BLUE;
                cell2.AddElement(new Chunk(dgv2.Columns[j].HeaderText.ToUpper(), font));
                myTable2.AddCell(cell2);
            }

            for (int i = 0; i < dgv2.Rows.Count; i++)
            {
                if (!col2)
                    col2 = true;
                else
                    col2 = false;

                myTable2.WidthPercentage = 100;
                for (int j = 0; j < dgv2.Columns.Count; j++)
                {
                    if (dgv2[j, i].Value != null)
                    {
                        PdfPCell cell2 = new PdfPCell();
                        cell2.AddElement(new Phrase(dgv2[j, i].Value.ToString()));
                        if (!col2)
                            cell2.BackgroundColor = BaseColor.WHITE;
                        else
                            cell2.BackgroundColor = BaseColor.LIGHT_GRAY;
                        myTable2.AddCell(cell2);
                    }
                }
            }

            PdfPTable myTable3 = new PdfPTable(dgv3.Columns.Count);
            bool col3 = true;
            for (int j = 0; j < dgv3.Columns.Count; j++)
            {
                PdfPCell cell3 = new PdfPCell();
                cell3.BackgroundColor = BaseColor.BLUE;
                cell3.AddElement(new Chunk(dgv3.Columns[j].HeaderText.ToUpper(), font));
                myTable3.AddCell(cell3);
            }

            for (int i = 0; i < dgv3.Rows.Count; i++)
            {
                if (!col3)
                    col3 = true;
                else
                    col3 = false;

                myTable.WidthPercentage = 100;
                for (int j = 0; j < dgv3.Columns.Count; j++)
                {
                    if (dgv3[j, i].Value != null)
                    {
                        PdfPCell cell3 = new PdfPCell();
                        cell3.AddElement(new Phrase(dgv3[j, i].Value.ToString()));
                        if (!col)
                            cell3.BackgroundColor = BaseColor.WHITE;
                        else
                            cell3.BackgroundColor = BaseColor.LIGHT_GRAY;
                        myTable3.AddCell(cell3);
                    }
                }
            }

            doc.Add(mytext); doc.Add(myText2); doc.Add(myTable); doc.Add(new Paragraph("\n")); doc.Add(myTable2); doc.Add(new Paragraph("\n")); doc.Add(myTable3);
            doc.Close();
            System.Diagnostics.Process.Start(docName);
        }

        public void CreateOrderPdf(DataGridView dgv, string reportType, decimal cost, string date, string disc, string arrived)
        {
            string docName = reportType + "_" + DateTime.Now.ToString("ddMMYY" + "_HHmm") + ".pdf";
            Document doc = new Document(iTextSharp.text.PageSize.A4, 10, 10, 42, 35);
            PdfWriter pdfWriter = PdfWriter.GetInstance(doc, new FileStream(docName, FileMode.Create));
            doc.Open();
            PdfContentByte pdfContent = pdfWriter.DirectContent;
            iTextSharp.text.Rectangle rectangle = new iTextSharp.text.Rectangle(doc.PageSize);

            rectangle.Left += doc.LeftMargin - 5; rectangle.Right -= doc.RightMargin - 5;
            rectangle.Top -= doc.TopMargin - 5; rectangle.Bottom += doc.BottomMargin - 5;
            pdfContent.SetColorStroke(BaseColor.WHITE);
            pdfContent.Rectangle(rectangle.Left, rectangle.Bottom, rectangle.Width, rectangle.Height);
            pdfContent.Stroke();

            iTextSharp.text.Font headerFont = iTextSharp.text.FontFactory.GetFont(FontFactory.COURIER_BOLD, 25, BaseColor.DARK_GRAY);
            iTextSharp.text.Font font = iTextSharp.text.FontFactory.GetFont(FontFactory.HELVETICA, 12, BaseColor.WHITE);
            Paragraph myText = new Paragraph();
            myText.Alignment = Element.ALIGN_CENTER;
            myText.Add(new Chunk(reportType + " " + DateTime.Now.ToString("dd-MM-yyyy"), headerFont));
            myText.SetLeading(2.5f, 2.5f);

            Paragraph myText2 = new Paragraph();
            myText2.Add("    ");
            myText2.SetLeading(2.5f, 2.5f);

            Paragraph myText3 = new Paragraph();
            myText.Alignment = Element.ALIGN_CENTER;
            myText.Add(new Chunk("\nTotal Cost: £" + cost + "\nDate Ordered: " + date + "\nDiscrepancies: " + disc + "\nOrder Status: " + arrived));
            myText.SetLeading(2.5f, 2.5f);


            PdfPTable myTable = new PdfPTable(dgv.Columns.Count);
            bool col = true;
            for (int j = 0; j < dgv.Columns.Count; j++)
            {
                PdfPCell cell = new PdfPCell();
                cell.BackgroundColor = BaseColor.BLUE;
                cell.AddElement(new Chunk(dgv.Columns[j].HeaderText.ToUpper(), font));
                myTable.AddCell(cell);
            }

            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                if (!col)
                    col = true;
                else
                    col = false;

                myTable.WidthPercentage = 100;
                for (int j = 0; j < dgv.Columns.Count; j++)
                {
                    if (dgv[j, i].Value != null)
                    {
                        PdfPCell cell = new PdfPCell();
                        cell.AddElement(new Phrase(dgv[j, i].Value.ToString()));
                        if (!col)
                            cell.BackgroundColor = BaseColor.WHITE;
                        else
                            cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                        myTable.AddCell(cell);
                    }
                }
            }

            doc.Add(myText); doc.Add(myText2); doc.Add(myText3);  doc.Add(myTable);
            doc.Close();
            System.Diagnostics.Process.Start(docName);
        }
    }
}
