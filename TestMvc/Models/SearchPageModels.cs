using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestMvc.Models;

namespace TestMvc.Models
{
    public class SearchPageModels
    {
        public SeachFormModels searchFormModel { get; set; }
        public List<EmployeeViewModels> employeeViewModels { get; set; }
        
        //public SearchPageModels()
        //{
        //    this.searchFormModel = new SeachFormModels();
        //    this.employeeViewModels = new EmployeeViewModels();
        //}    
    }
}