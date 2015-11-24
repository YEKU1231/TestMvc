using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web;
using TestMvc.Models;
namespace TestMvc.Extensitons
{
    public class SearchPageBinder:IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            SearchPageModels result;

            result = new SearchPageModels()
            {
                searchFormModel = new SeachFormModels(),
                employeeViewModels = new List<EmployeeViewModels>()
            };


            result.searchFormModel.Name = GetValue(bindingContext, "Name");
            result.employeeViewModels.Id = GetValue(bindingContext, "Id");

            return result;
        }
        
        public string GetValue(ModelBindingContext context,string type)
        {
            var result = string.Empty;

            var value = context.ValueProvider.GetValue(
                 string.Format("searchFormModel.{1}", context.ModelName, type));

            result = (string)value.ConvertTo(typeof(string));

            return result;
        }
    }
}