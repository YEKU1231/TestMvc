using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TestMvc.Models
{
    public class SeachFormModels
    {
        [DisplayFormat(ConvertEmptyStringToNull =false)]
        public string Name{get; set;}

        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string Age { get; set; }

        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string Depertment { get; set; }

    }
}