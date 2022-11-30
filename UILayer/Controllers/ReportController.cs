using System.Collections.Generic;
using System.IO;
using System.Linq;
using ClosedXML.Excel;
using DataAccessLayer.Concrete;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using UILayer.Models;

namespace UILayer.Controllers
{
    public class ReportController : Controller
    {
        ExcelPackage excel = new ExcelPackage();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ExcelStaticReport()
        {
            var workSheet = excel.Workbook.Worksheets.Add("Sayfa1");
            workSheet.Cells[1, 1].Value = "Personel";
            workSheet.Cells[1, 2].Value = "Departman";
            workSheet.Cells[1, 3].Value = "Kapasite";

            workSheet.Cells[2, 1].Value = "Mustafa Tuç";
            workSheet.Cells[2, 2].Value = "Yazılım";
            workSheet.Cells[2, 3].Value = "1";

            workSheet.Cells[3, 1].Value = "Mustafa Burak";
            workSheet.Cells[3, 2].Value = "İnsan Kaynakları";
            workSheet.Cells[3, 3].Value = "8";

            var bytes = excel.GetAsByteArray();

            return File(bytes, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "dosyayeni.xlsx");
        }

        public IActionResult ExcelDynamicReport()
        {
            using (var workbook = new XLWorkbook())
            {
                var workSheet = workbook.Worksheets.Add("Personel_Listesi");
                workSheet.Cell(1, 1).Value = "Personel Adı";
                workSheet.Cell(1, 2).Value = "Personel Soyadı";
                workSheet.Cell(1, 3).Value = "Personel Mail";
                workSheet.Cell(1, 4).Value = "Personel Cinsiyeti";

                int rowCount = 2;
                foreach (var item in EmployeeList())
                {
                    workSheet.Cell(rowCount, 1).Value = item.Name;
                    workSheet.Cell(rowCount, 2).Value = item.Surname;
                    workSheet.Cell(rowCount, 3).Value = item.EmployeeMail;
                    workSheet.Cell(rowCount, 4).Value = item.EmployeeGender;
                    rowCount++;
                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                        "dosyadinamik.xlsx");
                }
            }
        }

        public List<EmployeeViewModel> EmployeeList()
        {
            List<EmployeeViewModel> employeeViewModels = new List<EmployeeViewModel>();
            using (var context = new Context())
            {
                employeeViewModels = context.Employees.Select(x => new EmployeeViewModel
                {
                    Name = x.EmployeeName,
                    Surname = x.EmployeeSurname,
                    EmployeeGender = x.EmployeeGender,
                    EmployeeMail = x.EmployeeMail
                }).ToList();
            }

            return employeeViewModels;
        }

        public IActionResult StaticPdfReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pdffiles/dosya1.pdf");
            var stream = new FileStream(path, FileMode.Create);
            Document document = new Document(PageSize.A4, 10, 10, 10, 10);
            PdfWriter.GetInstance(document, stream);
            document.Open();
            Paragraph paragraph = new Paragraph("Merhaba Core Derslerinde Repository Projesi Sona Eriyor");
            document.Add(paragraph);
            document.Close();

            return File("/pdffiles/dosya1.pdf", "application/pdf", "dosya1.pdf");
        }
    }
}
