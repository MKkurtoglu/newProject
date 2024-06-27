using ClosedXML;
using ClosedXML.Excel;
using DataAccessLayer.Contrete;
using Microsoft.AspNetCore.Mvc;
using newProject.Models;
using OfficeOpenXml;

namespace newProject.Controllers
{
    public class ReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult staticReport()
        {
            ExcelPackage excelPackage = new ExcelPackage();
            var workbook = excelPackage.Workbook.Worksheets.Add("Dosya1");
            workbook.Cells[1, 1].Value = "Ürün Adı";
            workbook.Cells[1, 2].Value = "Ürün Türü";
            workbook.Cells[1, 3].Value = "Ürün Stok";

            workbook.Cells[2, 1].Value = "nohut";
            workbook.Cells[2, 2].Value = "Baklagil";
            workbook.Cells[2, 3].Value = "126 Ton";

            workbook.Cells[3, 1].Value = "Kırmızı Mercimek";
            workbook.Cells[3, 2].Value = "Baklagil ";
            workbook.Cells[3, 3].Value = "100 Ton";

            var bytes = excelPackage.GetAsByteArray();
            return File(bytes, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "BakliyatRaporu.xlsx");
        }

       

        public List<ContactModel> ContactList()
        {
            List<ContactModel> contactModels = new List<ContactModel>();
            using (var context = new ProjectDbContext())
            {
                contactModels = context.Contacts.Select(x=> new ContactModel()
                {
                    ContactID = x.ContactID,
                    ContactName=x.Name,
                    ContactMessage=x.Message,
                    ContactMail=x.Mail,
                    ContactDate=x.MessageDate
                }).ToList();
            }
            return contactModels;
        }



        public IActionResult contactReport()
        {
            using (var workbook = new ClosedXML.Excel.XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Mesaj Listesi");
                worksheet.Cell(1, 1).Value = "Mesaj ID";
                worksheet.Cell(1, 2).Value = "Mesaj Gönderen";
                worksheet.Cell(1, 3).Value = "Mail Adresi";
                worksheet.Cell(1, 4).Value = "Mesaj İçeriği";
                worksheet.Cell(1, 5).Value = "Mesaj Tarihi";
                int contactRowValue = 2;
                foreach (var item in ContactList())
                {
                    worksheet.Cell(contactRowValue, 1).Value = item.ContactID;
                    worksheet.Cell(contactRowValue, 2).Value = item.ContactName;
                    worksheet.Cell(contactRowValue, 3).Value = item.ContactMail;
                    worksheet.Cell(contactRowValue, 4).Value = item.ContactMessage;
                    worksheet.Cell(contactRowValue, 5).Value = item.ContactDate;
                    contactRowValue++;
                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "MesajRaporları.xlsx");
                }
            }
           
        }
        public List<NewsModel> NewsList()
        {
            List<NewsModel> newsModels = new List<NewsModel>();
            using (var context = new ProjectDbContext())
            {
                newsModels = context.Newses.Select(x=> new NewsModel()
                {
                    NewsID = x.NewsID,
                    NewsDate = x.NewsDate,
                    Title = x.Title,
                    Image = x.Image,
                    Description = x.Description,
                }).ToList();
            }
            return newsModels;
        }
        public IActionResult newsReport ()
        {
            XLWorkbook workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Duyuru Mesajları");
            worksheet.Cell(1, 1).Value = "Duyuru ID";
            worksheet.Cell(1, 2).Value = "Duyuru Tarih";
            worksheet.Cell(1, 3).Value = "Duyuru Başlık";
            worksheet.Cell(1, 4).Value = "Duyuru Resim Uzantısı";
            worksheet.Cell(1, 5).Value = "Duyuru Açıklama";

            int newsrow = 2;
            foreach (var item in NewsList())
            {
                worksheet.Cell(newsrow, 1).Value = item.NewsID;
                worksheet.Cell(newsrow, 2).Value = item.NewsDate;
                worksheet.Cell(newsrow, 3).Value = item.Title;
                worksheet.Cell(newsrow, 4).Value = item.Image;
                worksheet.Cell(newsrow, 5).Value = item.Description;
                newsrow++;
            }
            using (var stream = new MemoryStream())
            {
                workbook.SaveAs(stream);
                var content = stream.ToArray();
                return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "DuyuruRaporları.xlsx");
            }
            
        }
    }

    
}








