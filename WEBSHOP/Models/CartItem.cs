using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEBSHOP.Models
{

    public class CartItem
    {
        public string ProductID { get; set; }

        public string ProductName { get; set; }

        public int SoLuong { get; set; }

        public decimal DonGia { get; set; }

        public decimal ThanhTien { get; set; }

        public string Image { get; set; }

        public CartItem(string iMaSP)
        {
            using (MOCK db = new MOCK())
            {
                this.ProductID = iMaSP;
                PRODUCT sp = db.PRODUCTS.Single(n => n.ProductID == iMaSP);
                this.ProductName = sp.ProductName;
                this.Image = sp.Images;
                this.DonGia = sp.Price.Value;
                this.SoLuong = 1;
                this.ThanhTien = DonGia * SoLuong;

            }

        }
        public CartItem(string iMaSP, int sl)
        {
            using (MOCK db = new MOCK())
            {
                this.ProductID = iMaSP;
                PRODUCT sp = db.PRODUCTS.Single(n => n.ProductID == iMaSP);
                this.ProductName = sp.ProductName;
                this.Image = sp.Images;
                this.DonGia = sp.Price.Value;
                this.SoLuong = sl; 
                this.ThanhTien = DonGia * SoLuong;

            }

        }
        public CartItem()
        {

        }

    }
}