using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace TestMvc.Models
{
    public class EmployeeViewModels
    {
        public string Id { get; set; }
        [DisplayName("名前")]
        public string Name { get; set; }
        [DisplayName("年齢")]
        public string Age { get; set; }
        [DisplayName("所属")]
        public string Depertment{ get; set; }
    }
}