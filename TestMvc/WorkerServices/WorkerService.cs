using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestMvc.Models;
using TestMvc.Dao;

namespace TestMvc.WorkerServices
{
    public class WorkerService
    {
        private EmployeeDao employeeDao;

        public List<EmployeeViewModels> SearchEmployee() {

            var employeeDao = new EmployeeDao();

            return employeeDao.GetEmployeeList();
        }


        public List<EmployeeViewModels> SearchEmployee(SeachFormModels searchForm) {
            var employeeDao = new EmployeeDao();

            var emplyoeeList = employeeDao.GetEmployeeListFromJson();

            char[] delimiter = { ' ', ',' };

            string[] formName = searchForm.Name.Split(delimiter);
            string[] formAge = searchForm.Age.Split(delimiter);
            string[] formDpertment = searchForm.Depertment.Split(delimiter);

            var ret = emplyoeeList.Where(row => formName.Any(keyword => row.Name.Contains(keyword)))
                                  .ToList();
                      
            
            return ret;
        }

        public WorkerService()
        {
            employeeDao = new EmployeeDao();
        }
    }
}