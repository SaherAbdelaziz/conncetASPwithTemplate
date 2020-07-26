using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace conncetASPwithTemplate.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {

        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [StringLength(100)]
        public string Phone { get; set; }
        public string Adress { get; set; }
        public string Adress2 { get; set; }
        public HD_Areas Area { get; set; }
        public OutLet Outlet { get; set; }

        public string Street { get; set; }
        public string Building { get; set; }
        public string Floor { get; set; }
        public string Apartment { get; set; }
        public string SpecialMark { get; set; }
        [Required]
        public int AreaId { get; set; }
        [Required]
        public int OutletId { get; set; }


        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            userIdentity.AddClaim(new Claim("Name", this.Name));
            userIdentity.AddClaim(new Claim("Phone", this.Phone ));
            userIdentity.AddClaim(new Claim("OutletId", this.OutletId.ToString()));
            userIdentity.AddClaim(new Claim("AreaId", this.AreaId.ToString()));

            return userIdentity;
        }
        
    }

    public static class IdentityHelper
    {

        public static string GetUserFirstName(this IIdentity identity)
        {
            var claimIdent = identity as ClaimsIdentity;
            return claimIdent != null
                   && claimIdent.HasClaim(c => c.Type == "Name")
                ? claimIdent.FindFirst("Name").Value
                : string.Empty;
        }

        public static string GetUserPhone(this IIdentity identity)
        {
            var claimIdent = identity as ClaimsIdentity;
            return claimIdent != null
                   && claimIdent.HasClaim(c => c.Type == "Phone")
                ? claimIdent.FindFirst("Phone").Value
                : string.Empty;
        }

        public static int GetUserOutletId(this IIdentity identity)
                {
                    var claimIdent = identity as ClaimsIdentity;
                    return claimIdent != null
                           && claimIdent.HasClaim(c => c.Type == "OutletId") 
                        ? Int32.Parse(claimIdent.FindFirstValue("OutletId"))
                        : 0;
                }
        
        public static int GetUserAreaId(this IIdentity identity)
                {
            var claimIdent = identity as ClaimsIdentity;
            return claimIdent != null
                   && claimIdent.HasClaim(c => c.Type == "AreaId")
                    ? Int32.Parse(claimIdent.FindFirstValue("AreaId"))
                    : 0;
               }


    }


    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }


        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<EldahanItems> EldahanItems { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<MyCartItem> MyCartItems { get; set; }
        public DbSet<WebPreset> WebPresets { get; set; }
        public DbSet<Web_Preset> EldahanPresets { get; set; }
        public DbSet<Web_Menu_Item> WebMenuItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderedItem> OrderedItems { get; set; }
        public DbSet<SelectedModifiers> SelectedModifiers { get; set; }
        public DbSet<EldahanItems2> EldahanItems2 { get; set; }

        public virtual DbSet<HD_Areas> HdAreas { get; set; }
        public virtual DbSet<HD_Areas_Services> HdAreasServices { get; set; }
        public virtual DbSet<ItemsModifier> ItemsModifiers { get; set; }
        public virtual DbSet<Modifier> Modifiers { get; set; }
        public virtual DbSet<ModifiersGroup> ModifiersGroups { get; set; }
        public virtual DbSet<OutLet> OutLets { get; set; }


        public DbSet<Check> Checks { get; set; }
        public DbSet<ChecksItem> ChecksItems { get; set; }
        public DbSet<ChecksItemsSettlesSummary> ChecksItemsSettlesSummaries { get; set; }
        public DbSet<ChecksTaxAdjTip> ChecksTaxAdjTips { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Order>()
            //    .HasMany(c => c.CartItems )
            //    .WithRequired(c=>c.Order)
            //    .WillCascadeOnDelete(false);
        }
    }
}