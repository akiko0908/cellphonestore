using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using CellphoneStore.Models;
using CellphoneStore.Data;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace CellphoneStore.Controllers
{
    public class CartController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext db;

        public CartController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            db = context;
        }

        // key lưu chuỗi Json của Cart
        public const string CartKey = "cart";

        // lấy cart từ session (danh sách CartItem)
        List<OrderDetail> GetCartItems()
        {
            var session = HttpContext.Session;

            // lấy thông tin từ session
            string jsonCart = session.GetString(CartKey);

            if (jsonCart != null)
            {
                return JsonConvert.DeserializeObject<List<OrderDetail>>(jsonCart);
            }
            return new List<OrderDetail>();
        }

        // Xóa cart khỏi session
        void ClearCart()
        {
            var session = HttpContext.Session;
            session.Remove(CartKey);
        }

        // Lưu Cart (Danh sách orderdetails) vào session
        void SaveCartSession(List<OrderDetail> ls)
        {
            var session = HttpContext.Session;
            string jsoncart = JsonConvert.SerializeObject(ls);
            session.SetString(CartKey, jsoncart);
        }

        // hiển thị danh sách sản phẩm giỏ hàng
        public IActionResult Index()
        {
            var lsProducts = GetCartItems();
            return View(lsProducts);
        }

        public IActionResult AddToCart(int? idProduct)
        {
            var product = db.Products.Where(m => m.product_ID == idProduct).FirstOrDefault();

            if (product == null)
                return NotFound("Không tìm thấy sản phẩm!!!");

            // lấy danh sách sản phẩm trong session
            var cart = GetCartItems();

            var cartItem = cart.Find(m => m.product_ID == idProduct);
            if (cartItem != null)
            {
                cartItem.orderdetail_Quantity++;
            }
            else
            {
                cart.Add(new OrderDetail() { Product = product, orderdetail_Quantity = 1 });
            }

            SaveCartSession(cart);

            return View("Index");
        }

        public IActionResult RemoveCart()
        {

            return View();
        }

        [HttpPost]
        public IActionResult UpdateCart([FromForm] int product_ID, [FromForm] int orderdetail_Quantity)
        {
            return RedirectToAction();
        }

        public IActionResult CheckOut()
        {
            return View();
        }

    }
}
