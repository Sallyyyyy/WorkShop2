using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WorkShop2.Controllers
{
    public class LibraryController : Controller
    {
        // GET: Library
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Search()
        {
            Models.BookSearch booksearch = new Models.BookSearch();
            booksearch.BookClassName = "旅遊類";
            booksearch.BookId = 0;
            booksearch.BookName = "在顛沛流離的世界你還有我啊";
            booksearch.BookStatus = "A";
            booksearch.MemberName = "李小姐";
            List<SelectListItem> bookclassdata = new List<SelectListItem>();
            bookclassdata.Add(new SelectListItem()
            {
                Value = "Travel",
                Text = "旅遊類"
            });
            bookclassdata.Add(new SelectListItem()
            {
                Value = "Language",
                Text = "語言類"
            });
            bookclassdata.Add(new SelectListItem()
            {
                Value = "Education",
                Text = "教育類"
            });
            ViewBag.BookClassData = bookclassdata;
            List<SelectListItem> memberdata = new List<SelectListItem>();
            memberdata.Add(new SelectListItem()
            {
                Value = "Sally",
                Text = "李"
            });
            memberdata.Add(new SelectListItem()
            {
                Value = "Jenny",
                Text = "康"
            });
            memberdata.Add(new SelectListItem()
            {
                Value = "Jassica",
                Text = "徐"
            });
            ViewBag.MemberData = memberdata;
            List<SelectListItem> bookstatusdata = new List<SelectListItem>();
            bookstatusdata.Add(new SelectListItem()
            {
                Value = "A",
                Text = "可以借出"
            });
            bookstatusdata.Add(new SelectListItem()
            {
                Value = "B",
                Text = "已借出"
            });
            bookstatusdata.Add(new SelectListItem()
            {
                Value = "U",
                Text = "不可借出"
            });
            bookstatusdata.Add(new SelectListItem()
            {
                Value = "C",
                Text = "已借出(未領)"
            });
            ViewBag.BookStatusData = bookstatusdata;
            return View(booksearch);
        }
    }
}