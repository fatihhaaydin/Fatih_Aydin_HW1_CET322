using Microsoft.AspNetCore.Mvc;
using FatihAydınHW1Recent.Models;

namespace FatihAydınHW1Recent.Controllers
{
    public class BookController : Controller
    {
        public IActionResult DisplayAction(string book_name,string author,int page_number,DateTime due_date)
        {
            DateTime currentDate = DateTime.Now;
            BookClass book = new BookClass();
            book.book_name = book_name;
            book.author = author;
            book.page_number = page_number;
            book.due_date = due_date;
            TimeSpan remaining_day = due_date - currentDate;
            if (remaining_day.TotalDays > 0)
            {
                book.detector = (int)remaining_day.TotalDays;
            }
            if (remaining_day.TotalDays < 0)
            {
                book.detector = (int)remaining_day.TotalDays;

            }
            if (remaining_day.TotalDays == 0)
            {
                book.detector = (int)remaining_day.TotalDays;
            }

            return View(book);
        }
    }
}
