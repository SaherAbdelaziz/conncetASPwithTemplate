using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using AdminPanel.Models;

namespace AdminPanel.ViewModels
{
    public class ProfileViewModel
    {
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [StringLength(100)]
        public string Phone { get; set; }

        public string Email { get; set; }

        [Required]
        [Display(Name = "Address")]
        public string Address { get; set; }


        [Required]
        [Display(Name = "Address2")]
        public string Address2 { get; set; }

        [Display(Name = "Street")]
        public string Street { get; set; }

        [Display(Name = "Building")]
        public string Building { get; set; }

        [Display(Name = "Floor")]
        public string Floor { get; set; }

        [Display(Name = "Apartment")]
        public string Apartment { get; set; }

        [Display(Name = "Special Mark")]
        public string SpecialMark { get; set; }

        [Required]
        public int Area { get; set; }

        [Display(Name = "Area")]
        public IEnumerable<HD_Areas> Areas { get; set; }

        [Required]
        public int Outlet { get; set; }

        [Display(Name = "OutLet")]
        public IEnumerable<OutLet> Outlets { get; set; }



        public ProfileViewModel()
        {
            
        }


        public ProfileViewModel(ApplicationUser user)
        {
            Id = user.Id;
            Name = user.Name;
            Phone = user.Phone;
            Email = user.Email;
            Address = user.Adress;
            Address2 = user.Adress2;

            Street = user.Street;
            Building = user.Building;
            Floor = user.Floor;
            Apartment = user.Apartment;
            SpecialMark = user.SpecialMark;

            Area = user.AreaId;
            Outlet = user.OutletId;

        }

    }
}