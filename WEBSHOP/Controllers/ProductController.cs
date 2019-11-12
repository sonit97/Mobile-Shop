using Model.DAO;
using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace WEBSHOP.Controllers
{
    public class ProductController : Controller
    {
        MOCK db = new MOCK();
        // GET: Product
        public ActionResult Index(int id)
        {
           
            if (id == 0)
            {
                var sp = db.PRODUCTS.Where(n => n.Hot == true && n.Sex == "Nam");
                return View(sp);
            }
            else if(id==1)
            {
                var sp = db.PRODUCTS.Where(n => n.Hot == true && n.Sex == "Nữ");
                return View(sp);
            }
            return View();



        }

        //
        public ActionResult XemChiTiet(string productid )
        {
            //kiểm ta tham so truyen vao trống hay không.
            if (productid == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Nếu không thể truy xuất csdl lấy ra sản phẩm tương ứng.
            PRODUCT sp = db.PRODUCTS.SingleOrDefault(n => n.ProductID == productid);
            ViewBag.ImageProduct = new ImageProductDAO().Imagepro(productid);
            if (sp == null)
            {
                //Thông báo khi không có sản phẩm đó.
                return HttpNotFound();
            }

            return View(sp);
        }

        //Menu
        [ChildActionOnly]
        public PartialViewResult ProductType()
        {
            var model = new PRODUCTTYPEDAO().listtype();
            return PartialView(model);

        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
