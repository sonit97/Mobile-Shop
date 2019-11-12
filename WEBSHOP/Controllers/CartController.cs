using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using WEBSHOP.Models;

namespace WEBSHOP.Controllers
{
    public class CartController : Controller
    {
        MOCK db = new MOCK();
        //lấy giỏ hàng
        public List<CartItem> LayGioHang()
        {
            //Giỏ hàng đã tồn tại.
            List<CartItem> listGioHang = Session["Giohang"] as List<CartItem>;
            if (listGioHang == null)
            {
                //Nếu session giỏ hàng chưa tồn tại thì khởi tạo giỏ hàng.
                listGioHang = new List<CartItem>();
                Session["GioHang"] = listGioHang;

            }
            return listGioHang;


        }

        //Thêm giỏ hàng
        public ActionResult ThemGioHang(string MaSP, string strURL)
        {
            //kiểm tra sản phẩm có tồn tại trong CSDL  hay  không
            PRODUCT sp = db.PRODUCTS.SingleOrDefault(n => n.ProductID == MaSP);
        
            if (sp == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            //Lấy giỏ hàng
            List<CartItem> listGioHang = LayGioHang();
            
            CartItem spCheck = listGioHang.SingleOrDefault(n => n.ProductID == MaSP);
            if (spCheck != null)
            {
                //kiểm tra số lượng trước khi cho khach hàng mua hàng.
                if (sp.Quantity < spCheck.SoLuong)
                {
                    return View("ThongBao");
                }
                spCheck.SoLuong++;
                spCheck.ThanhTien = spCheck.SoLuong * spCheck.DonGia;
                return Redirect(strURL);

            }

            CartItem itemGH = new CartItem(MaSP);
            if (sp.Quantity < itemGH.SoLuong)
            {
                return View("ThongBao");
            }
            listGioHang.Add(itemGH);
            return Redirect(strURL);
        }


        //Xóa giỏ hàng
        public ActionResult XoaGioHang(string MaSP)
        {
            //Kiểm tra session gio hàng tồn tại chưa
            if (Session["GioHang"] == null)
            {
                return RedirectToAction("Index", "Home");
            }
            //kiểm tra sản phẩm có tồn tại trong CSDL  hay  không
            PRODUCT sp = db.PRODUCTS.SingleOrDefault(n => n.ProductID == MaSP);
            if (sp == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            //Lấy list giỏ hàng từ session
            List<CartItem> listGioHang = LayGioHang();
            //kiểm tra xem sp đó có tồn tại trong GH hay k
            CartItem spCheck = listGioHang.SingleOrDefault(n => n.ProductID == MaSP);
            if (spCheck == null)
            {
                return RedirectToAction("Index", "Home");
            }
            //Xóa item trong giỏ hàng
            listGioHang.Remove(spCheck);
            return RedirectToAction("XemGioHang");
        }
        //Tính số lượng
        public double TinhTongSoLuong()
        {
            //Lấy giỏ hàng
            List<CartItem> listGioHang = Session["GioHang"] as List<CartItem>;
            if (listGioHang == null)
            {
                return 0;
            }
            return listGioHang.Sum(n => n.SoLuong);
        }
        //Tính tổng tiền
        public decimal TinhTongTien()
        {

            //Lấy giỏ hàng
            List<CartItem> listGioHang = Session["GioHang"] as List<CartItem>;
            if (listGioHang == null)
            {
                return 0;
            }
            return listGioHang.Sum(n => n.ThanhTien);
        }

        //Chỉnh sửa giỏ hàng
        [HttpGet]
        public ActionResult SuaGioHang(string MaSP)
        {

          
          
            //Kiểm tra session gio hàng tồn tại chưa
            if (Session["GioHang"] == null)
            {
                return RedirectToAction("Index", "Home");
            }
            //kiểm tra sản phẩm có tồn tại trong CSDL  hay  không
            PRODUCT sp = db.PRODUCTS.SingleOrDefault(n => n.ProductID == MaSP);
            if (sp == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            //Lấy list giỏ hàng từ session
            List<CartItem> listGioHang = LayGioHang();
            //kiểm tra xem sp đó có tồn tại trong GH hay k
            CartItem spCheck = listGioHang.SingleOrDefault(n => n.ProductID == MaSP);
            if (spCheck == null)
            {
                return RedirectToAction("Index", "Home");
            }
            //Lấy list giỏ hàng tại giao diện
            ViewBag.GioHang = listGioHang;
            //nếu tồn tại rồi
            return View(spCheck);
        }

      


       




        // GET: Cart   
        public ActionResult XemGioHang()
        {

            //Lấy giỏ hang
            List<CartItem> listGioHang = LayGioHang();
            ViewBag.TongSoLuong = TinhTongSoLuong();
            ViewBag.TongTien = TinhTongTien();
            return View(listGioHang);
           
        }

        public ActionResult GioHangPartial()
        {
            if (TinhTongSoLuong() == 0)
            {
                ViewBag.TongSoLuong = 0;
                ViewBag.TongTien = 0;
                return PartialView();
            }
            ViewBag.TongSoLuong = TinhTongSoLuong();
            ViewBag.TongTien = TinhTongTien();
            return PartialView();
        }

        public ActionResult Test()
        {
            return View();
        }

    }
}