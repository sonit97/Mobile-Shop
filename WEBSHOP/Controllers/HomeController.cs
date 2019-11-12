
using Model.DAO;
using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WEBSHOP.Controllers
{
    public class HomeController : Controller
    {
        MOCK db = new MOCK();
        // GET: Home
        public ActionResult Index()
        {           
            return View();
        }
        [HttpGet]
        public ActionResult DangNhap()
        {
            return View();
        }
        //Tạo action đăng nhập
        [HttpPost]
        public ActionResult DangNhap(FormCollection f)
        {
            //kiểm tra tên đăng nhập và MK
            string sTaiKhoan = f["txtTenDangNhap"].ToString();
            string sMatKhau = f["txtMatKhau"].ToString();
            CUSTOMER tv = db.CUSTOMERS.SingleOrDefault(n=>n.Email==sTaiKhoan && n.Password==sMatKhau);
            if (tv != null)
            {
                Session["TaiKhoan"] = tv;
                return RedirectToAction("Index");
            }
            return Content("Tài khoản hoặc mật khẩu không đúng!!!");
        }
        //Đăng xuất
        public ActionResult DangXuat()
        {
            Session["TaiKhoan"] = null;
            return RedirectToAction("Index");
        }
        //Đăng ký
        [HttpGet]
        public ActionResult DangKy()
        {
           // setViewBag();
            return View();
        }
        [HttpPost]
        public ActionResult DangKy(CUSTOMER tv, FormCollection f)
        {
            //Kiểm tra captcha hợp lệ
            if (ModelState.IsValid)
            {
                ViewBag.ThongBao = "Thêm thành công";
                //Thêm khách hàng vào csdl
                db.CUSTOMERS.Add(tv);
                db.SaveChanges();
            }
            else
            {
                ViewBag.ThongBao = "Thêm thất bại";
            }
            return View();
        }
        //
        public void setViewBag(long? selectedID = null)
        {
            var dao = new CUSTOMERTYPEDAO();
            ViewBag.CustomerTypeID = new SelectList(dao.listall(), "ID", "Name", selectedID);
        }
        //search

        [HttpGet]
        public ActionResult Search()
        {
            return View();
        }
    }
}


    