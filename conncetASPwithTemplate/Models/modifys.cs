using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace conncetASPwithTemplate.Models
{
    public class Modifys
    {
        public int itemsToShowCount ;
        public int CategriesCount ;
        public List<string> idsStrings;
        public List<string> surcs = new List<string>() { "../../Content/mytemplate/assets/img/photos/menu-title-burgers.jpg",
            "../../Content/mytemplate/assets/img/photos/menu-title-pasta.jpg",
            "../../Content/mytemplate/assets/img/photos/menu-title-pizza.jpg" ,
            "../../Content/mytemplate/assets/img/photos/menu-title-sushi.jpg",
            "../../Content/mytemplate/assets/img/photos/menu-title-desserts.jpg",
            "../../Content/mytemplate/assets/img/photos/menu-title-drinks.jpg"
        };


        public Modifys()
        {
            idsStrings= new List<string>();
        }
    }
}