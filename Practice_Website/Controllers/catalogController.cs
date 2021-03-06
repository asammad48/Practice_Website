using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Practice_Website.Models;

namespace Practice_Website.Controllers
{
    public class catalogController : Controller
    {
        string Baseurl = "https://localhost:44344/";
        public async Task<IActionResult> Index()
        {
            Products_With_Categories Products_with_categories = new Products_With_Categories();

            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri(Baseurl);

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                HttpResponseMessage Res = await client.GetAsync("api/Home");

                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var All_Product = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Employee list  
                    Products_with_categories = JsonConvert.DeserializeObject<Products_With_Categories>(All_Product);

                }

                //returning the employee list to view  
                return View(Products_with_categories);
            }
        }
        public async Task<IActionResult> Product(int id,int variant)
        {
            Product p = new Product();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);

                client.DefaultRequestHeaders.Clear();
                
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                HttpResponseMessage Res = await client.GetAsync("api/Products/"+id);

                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var All_Product = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Employee list  
                    p = JsonConvert.DeserializeObject<Product>(All_Product);

                }
 
                //return View(p);
            }
            Products_With_Categories Products_with_categories = new Products_With_Categories();

            using (var client = new HttpClient())
            {
               
                client.BaseAddress = new Uri(Baseurl);

                client.DefaultRequestHeaders.Clear();
               
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

               
                HttpResponseMessage Res = await client.GetAsync("api/Home");

              
                if (Res.IsSuccessStatusCode)
                {
                   
                    var All_Product = Res.Content.ReadAsStringAsync().Result;

                 
                    Products_with_categories = JsonConvert.DeserializeObject<Products_With_Categories>(All_Product);

                }
            }
            if(variant==0)
            {
                Products_with_categories.Variant = Products_with_categories.product_variants.Where(e => e.ProductID == id).Select(e => e.VariantID).FirstOrDefault();
            }
            else
            {
                Products_with_categories.Variant = variant;
            }
            
            Products_with_categories.Product = p;
            return View(Products_with_categories);
        }
        [HttpPost]
        public async Task<IActionResult> GetSubcategoryProduct(int subid)
        {
            Products_With_Categories Products_with_categories = new Products_With_Categories();

            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri(Baseurl);

                client.DefaultRequestHeaders.Clear();

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                HttpResponseMessage Res = await client.GetAsync("api/Home");


                if (Res.IsSuccessStatusCode)
                {

                    var All_Product = Res.Content.ReadAsStringAsync().Result;


                    Products_with_categories = JsonConvert.DeserializeObject<Products_With_Categories>(All_Product);

                }
            }
            //if (variant == 0)
            //{
            //    Products_with_categories.Variant = Products_with_categories.product_variants.Where(e => e.ProductID == id).Select(e => e.VariantID).FirstOrDefault();
            //}
            //Products_with_categories.Variant = variant;
            int count = 1;
            foreach (var item in Products_with_categories.subCategories)
            {
                if (subid == item.SubCategoryID)
                {
                    item.Status = 1;
                }
                else
                {
                    item.Status = 0;
                }
            }
            int categoryid = Products_with_categories.category_Subs.Where(e => e.SubCategoryID == subid).Select(e => e.CategoryID).FirstOrDefault();
            foreach (var item in Products_with_categories.categories)
            {
                if (categoryid == item.CategoryID)
                {
                    item.Status = 1;
                }
                else
                {
                    item.Status = 0;
                }
            }

            return PartialView("/Views/catalog/Product_By_Categories.cshtml", Products_with_categories);
        }
    }
}