using LayoutYapilanmasi.Models.Products;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace LayoutYapilanmasi.Controllers.Products
{
    public class ProductController : Controller
    {
        public IActionResult sayfa()
        {
            return View();
        }
        public IActionResult Sayfa1()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Sayfa1(ProductControl product)
        {
            string? veri = TempData["verim"].ToString();
            Product? pro = JsonSerializer.Deserialize<Product>(veri);
            if(pro.ad==product.ad && pro.soyad==product.soyad&&pro.email==product.email)
            {
                return RedirectToAction("SayfasonTrue");  
            }
            else
            {
                return RedirectToAction("SayfasonFalse");
            }
            
        }
        public IActionResult Sayfa2()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Sayfa2(Product product)
        {
            Product _product = product;
            string data = JsonSerializer.Serialize(_product).ToString();
            TempData["verim"] = data;

            return View();
        }
        public IActionResult SayfasonTrue()
        {
            string cikti = "Doğru giriş yaptınız,yönlendiriliyorsunuz...";
            ViewData["cikti2"] = cikti;
            return View();
        }
        public IActionResult SayfasonFalse()
        {
            string cikti = "Yanlış giriş yaptınız,yönlendiriliyorsunuz...";
            ViewData["cikti"] = cikti;
            return View();

        }
    }
}
