using cloudscribe;
using System.Linq;

namespace LearningBootstrapV4_NetCore3._1.Controllers
{
    public class HomeController : Infrastructure.BaseController
    {
        public HomeController() : base()
        {

        }
        [Microsoft.AspNetCore.Mvc.HttpGet]
        public Microsoft.AspNetCore.Mvc.IActionResult Index()
        {
            return View();
        }

        [Microsoft.AspNetCore.Mvc.HttpGet]
        public Microsoft.AspNetCore.Mvc.IActionResult Learn01()
        {
            return View();
        }

        [Microsoft.AspNetCore.Mvc.HttpGet]
        public Microsoft.AspNetCore.Mvc.IActionResult Learn02()
        {
            var model = new System.Collections.Generic.List<Models.ProductModel>();
            for (int index = 1; index < 25; index++)
            {
                Models.ProductModel productModel =
                        new Models.ProductModel
                        {
                            Name = $"Product #{index}",
                            UnitPrice = 18 + index,
                            UnitsInStock = 56 + index,
                            Discontinued = (index % 2 == 0 ? true : false),
                            Status = (index % 2 == 0 ? "Fail" : "Success"),
                        };
                model.Add(productModel);
            }

            return View(model: model);
        }

        [Microsoft.AspNetCore.Mvc.HttpGet]
        public Microsoft.AspNetCore.Mvc.IActionResult Learn03()
        {
            return View();
        }

        [Microsoft.AspNetCore.Mvc.HttpGet]
        public Microsoft.AspNetCore.Mvc.IActionResult Learn04()
        {
            return View();
        }

        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Microsoft.AspNetCore.Mvc.ValidateAntiForgeryToken]
        public Microsoft.AspNetCore.Mvc.IActionResult Learn04(ViewModels.LoginViewModel viewModel)
        {
            string state = string.Empty;
            if (ModelState.IsValid)
            {
                state = $"Login for {viewModel.Username} with password {viewModel.Password} successed...";
                ViewData["status"] = state;

            }
            return View(model: viewModel);
        }

        [Microsoft.AspNetCore.Mvc.HttpGet]
        public Microsoft.AspNetCore.Mvc.IActionResult Learn05()
        {
            var model = new System.Collections.Generic.List<Models.Employee>();
            Models.Employee employee1 =
                    new Models.Employee
                    {
                        Name= "Penguins",
                        JobTitle="Fishing",
                        Resume="it is an animal who live in frozen land of pole.",
                    };
            Models.Employee employee2 =
                    new Models.Employee
                    {
                        Name = "Rahim",
                        JobTitle="Peasent",
                        Resume = "it is an animal who live in Iran.",
                    };
            Models.Employee employee3 =
                    new Models.Employee
                    {
                        Name = "koala",
                        JobTitle="resting",
                        Resume = "it is an animal who live in Australia.",
                    };
            model.AddRange(collection: new[] { employee1, employee2, employee3 });
            return View(model:model);
        }

        [Microsoft.AspNetCore.Mvc.HttpGet]
        public Microsoft.AspNetCore.Mvc.IActionResult Learn06()
        {
            ViewModels.DataViewModel data =
                new ViewModels.DataViewModel
                { 
                  Id = 1,
                  Text = "If you need to display an image or a piece of content with a caption, the <figure> elementcan be used" 
                };
            
            return View(model:data);
        }

        [Microsoft.AspNetCore.Mvc.HttpGet]
        public Microsoft.AspNetCore.Mvc.IActionResult Learn07()
        {
            return View();
        }

        [Microsoft.AspNetCore.Mvc.HttpGet]
        public Microsoft.AspNetCore.Mvc.IActionResult Learn08()
        {
            var products = Infrastructure.Utility.GetProducts(300);
            return View(model:products);
        }

        [Microsoft.AspNetCore.Mvc.HttpGet]
        public Microsoft.AspNetCore.Mvc.IActionResult Learn09(int? page )
        {
            int pageSize = 10;
            var currentPageNum = page.HasValue ? page.Value : 1;
            var offset = (pageSize * currentPageNum) - pageSize;
            var model = new ViewModels.ProductPagingViewModel();
            model.Products =
                Infrastructure.Utility.GetProducts(300)
                .Skip(offset)
                .Take(pageSize).OrderBy(p => p.Name)
                .ToList();
            model.Paging.CurrentPage = currentPageNum;
            model.Paging.ItemsPerPage = pageSize;
            model.Paging.TotalItems = Infrastructure.Utility.GetProducts(300).Count;
            return View(model: model);
        }

    }
}