using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestMvc.Models;
using System.Web.Mvc;
using System.IO;
using Newtonsoft.Json;


namespace TestMvc.Dao
{
    public class EmployeeDao
    {
        public List<EmployeeViewModels> GetEmployeeList()
        {
            var list = new List<EmployeeViewModels>() {
                new EmployeeViewModels() {Name="鈴木",Age ="20",Depertment="総務" },
                new EmployeeViewModels() {Name="田中",Age ="20",Depertment="総務" }
            };

            return list;
        }
        public List<EmployeeViewModels> GetEmployeeListFromJson (){
            var viewPath = "~/Json/EmployeeData.json";

            var path = System.Web.HttpContext.Current.Server.MapPath(viewPath);

            var jsonText = File.ReadAllText(path);
            var employeeModel= JsonConvert.DeserializeObject<List<EmployeeViewModels>>(jsonText);
            
            return employeeModel;   
        }
    }
}