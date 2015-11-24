using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestMvc.Models;
using TestMvc.WorkerServices;

namespace TestMvc.Controllers
{
    public class SearchPageController : Controller
    {
        private WorkerService workerService;

        public SearchPageController()
        {
            this.workerService = new WorkerService();
        }

        // GET: SearchPage
        public ActionResult Index()
        {
            var pageVm = new SearchPageModels();

            var employeeVm = workerService.SearchEmployee();
                        
            pageVm.employeeViewModels = employeeVm;
             
            return View(pageVm);
        }

        // GET : SearchPage/Search
        public ActionResult Search(SearchPageModels searchPageModels)
        {            
            searchPageModels.employeeViewModels = workerService.SearchEmployee(searchPageModels.searchFormModel);

            return View("Index",searchPageModels);
        }
    }
}