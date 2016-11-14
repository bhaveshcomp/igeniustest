using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CategoriesDemo.Models
{

    public class PetDetail
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class CustDetail
    {
        public string name { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public List<PetDetail> pets { get; set; }
    }
}