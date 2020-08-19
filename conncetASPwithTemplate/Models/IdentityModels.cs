using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using conncetASPwithTemplate.Models.others_unused_tables;
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
            userIdentity.AddClaim(new Claim("Email", this.Email ));
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

        public static string GetUserEmail(this IIdentity identity)
        {
            var claimIdent = identity as ClaimsIdentity;
            return claimIdent != null
                   && claimIdent.HasClaim(c => c.Type == "Email")
                ? claimIdent.FindFirst("Email").Value
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
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Web_Preset> WebPresets { get; set; }
        public DbSet<Web_Menu_Item> WebMenuItems { get; set; }
        public DbSet<Order> Orders { get; set; }
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



        public virtual DbSet<AvailableTable> AvailableTables { get; set; }
        // unused tables 
        public virtual DbSet<Adjustment> Adjustments { get; set; }
        public virtual DbSet<Aging> Agings { get; set; }
        public virtual DbSet<AR_Checks> AR_Checks { get; set; }
        public virtual DbSet<AR_Checks_Pay> AR_Checks_Pay { get; set; }
        public virtual DbSet<AR_Customers> AR_Customers { get; set; }
        public virtual DbSet<Assign_Drawer> Assign_Drawer { get; set; }
        public virtual DbSet<Cash_Drawer> Cash_Drawer { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Change_Server> Change_Server { get; set; }
        public virtual DbSet<ChecksCompleted> ChecksCompleteds { get; set; }
        public virtual DbSet<ChecksItemsCompleted> ChecksItemsCompleteds { get; set; }
        public virtual DbSet<ChecksItemsSerial> ChecksItemsSerials { get; set; }
        public virtual DbSet<ChecksItemsSettle> ChecksItemsSettles { get; set; }
        public virtual DbSet<Complementary_Reasons> Complementary_Reasons { get; set; }
        public virtual DbSet<Convert_Points> Convert_Points { get; set; }
        public virtual DbSet<Currency_Rate> Currency_Rate { get; set; }
        public virtual DbSet<Customer_Points> Customer_Points { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Customers_Telephone> Customers_Telephone { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Design_DiningRooms> Design_DiningRooms { get; set; }
        public virtual DbSet<Design_DiningRooms_Tables> Design_DiningRooms_Tables { get; set; }
        public virtual DbSet<DiningRoom> DiningRooms { get; set; }
        public virtual DbSet<Disable_Table> Disable_Table { get; set; }
        public virtual DbSet<Discount_Reasons> Discount_Reasons { get; set; }
        public virtual DbSet<Discount> Discounts { get; set; }
        public virtual DbSet<DiscountsCatrgory> DiscountsCatrgories { get; set; }
        public virtual DbSet<dtproperty> dtproperties { get; set; }
        public virtual DbSet<End_Shift_User> End_Shift_User { get; set; }
        public virtual DbSet<FC_Adjust_Items> FC_Adjust_Items { get; set; }
        public virtual DbSet<FC_Adjust_Reason> FC_Adjust_Reason { get; set; }
        public virtual DbSet<FC_Adjustment> FC_Adjustment { get; set; }
        public virtual DbSet<FC_Bulk_Items> FC_Bulk_Items { get; set; }
        public virtual DbSet<FC_Bulk_Items_Child> FC_Bulk_Items_Child { get; set; }
        public virtual DbSet<FC_Categories> FC_Categories { get; set; }
        public virtual DbSet<FC_Convert_Units> FC_Convert_Units { get; set; }
        public virtual DbSet<FC_Inventory> FC_Inventory { get; set; }
        public virtual DbSet<FC_Invn_kit_Sheet> FC_Invn_kit_Sheet { get; set; }
        public virtual DbSet<FC_Invn_kit_Sheet_Items> FC_Invn_kit_Sheet_Items { get; set; }
        public virtual DbSet<FC_Invn_kit_Variance> FC_Invn_kit_Variance { get; set; }
        public virtual DbSet<FC_Invn_kit_Variance_Items> FC_Invn_kit_Variance_Items { get; set; }
        public virtual DbSet<FC_Invn_Kitchen> FC_Invn_Kitchen { get; set; }
        public virtual DbSet<FC_Item_Cost> FC_Item_Cost { get; set; }
        public virtual DbSet<FC_Item_Invn_Qty> FC_Item_Invn_Qty { get; set; }
        public virtual DbSet<FC_Items> FC_Items { get; set; }
        public virtual DbSet<FC_Items_For_Invn_Kit> FC_Items_For_Invn_Kit { get; set; }
        public virtual DbSet<FC_ItemsChild> FC_ItemsChild { get; set; }
        public virtual DbSet<FC_Kitchen_Outlets> FC_Kitchen_Outlets { get; set; }
        public virtual DbSet<FC_Process_BI> FC_Process_BI { get; set; }
        public virtual DbSet<FC_Process_BI_Child> FC_Process_BI_Child { get; set; }
        public virtual DbSet<FC_Produce_Rcp_Child> FC_Produce_Rcp_Child { get; set; }
        public virtual DbSet<FC_Produce_Recipe> FC_Produce_Recipe { get; set; }
        public virtual DbSet<FC_ReceivdData> FC_ReceivdData { get; set; }
        public virtual DbSet<FC_Recipe_Items> FC_Recipe_Items { get; set; }
        public virtual DbSet<FC_Recipes> FC_Recipes { get; set; }
        public virtual DbSet<FC_Setup> FC_Setup { get; set; }
        public virtual DbSet<FC_SubCategories> FC_SubCategories { get; set; }
        public virtual DbSet<FC_Transfer> FC_Transfer { get; set; }
        public virtual DbSet<FC_Transfer_Items> FC_Transfer_Items { get; set; }
        public virtual DbSet<FC_Units> FC_Units { get; set; }
        public virtual DbSet<FC_Vendor> FC_Vendor { get; set; }
        public virtual DbSet<FC_Vou_Items> FC_Vou_Items { get; set; }
        public virtual DbSet<FC_Voucher> FC_Voucher { get; set; }
        public virtual DbSet<HD_Company> HD_Company { get; set; }
        public virtual DbSet<HD_Orders> HD_Orders { get; set; }
        public virtual DbSet<HD_Orders_Pilot> HD_Orders_Pilot { get; set; }
        public virtual DbSet<histCheck> histChecks { get; set; }
        public virtual DbSet<histChecksCompleted> histChecksCompleteds { get; set; }
        public virtual DbSet<histChecksItem> histChecksItems { get; set; }
        public virtual DbSet<histChecksItemsCompleted> histChecksItemsCompleteds { get; set; }
        public virtual DbSet<histChecksItemsSerial> histChecksItemsSerials { get; set; }
        public virtual DbSet<histChecksItemsSettle> histChecksItemsSettles { get; set; }
        public virtual DbSet<histChecksItemsSettlesSummary> histChecksItemsSettlesSummaries { get; set; }
        public virtual DbSet<histChecksTaxAdjTip> histChecksTaxAdjTips { get; set; }
        public virtual DbSet<histHD_Orders> histHD_Orders { get; set; }
        public virtual DbSet<histHD_Orders_Pilot> histHD_Orders_Pilot { get; set; }
        public virtual DbSet<Inv_Adjust_Items> Inv_Adjust_Items { get; set; }
        public virtual DbSet<Inv_Adjust_Reason> Inv_Adjust_Reason { get; set; }
        public virtual DbSet<Inv_Adjustment> Inv_Adjustment { get; set; }
        public virtual DbSet<Inv_Categories> Inv_Categories { get; set; }
        public virtual DbSet<Inventory_Items_Track> Inventory_Items_Track { get; set; }
        public virtual DbSet<InventoryDefination> InventoryDefinations { get; set; }
        public virtual DbSet<InventoryItem> InventoryItems { get; set; }
        public virtual DbSet<Item_OutLets> Item_OutLets { get; set; }
        public virtual DbSet<Items_Inventory> Items_Inventory { get; set; }
        public virtual DbSet<ItemsAssimbly> ItemsAssimblies { get; set; }
        public virtual DbSet<ItemsChild> ItemsChilds { get; set; }
        public virtual DbSet<ItemsItInv> ItemsItInvs { get; set; }
        public virtual DbSet<ItemsMonitor> ItemsMonitors { get; set; }
        public virtual DbSet<ItemsPrice> ItemsPrices { get; set; }
        public virtual DbSet<ItemsPrinter> ItemsPrinters { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Log_Pilots> Log_Pilots { get; set; }
        public virtual DbSet<LogInSy> LogInSys { get; set; }
        public virtual DbSet<Main_OutLet> Main_OutLet { get; set; }
        public virtual DbSet<MiniRecipe> MiniRecipes { get; set; }
        public virtual DbSet<ModifiesItem> ModifiesItems { get; set; }
        public virtual DbSet<Monitor> Monitors { get; set; }
        public virtual DbSet<Move_Items> Move_Items { get; set; }
        public virtual DbSet<Out_Status_Reasons> Out_Status_Reasons { get; set; }
        public virtual DbSet<OutLet_Adjustment> OutLet_Adjustment { get; set; }
        public virtual DbSet<OutLet_Discount> OutLet_Discount { get; set; }
        public virtual DbSet<OutLet_Officer> OutLet_Officer { get; set; }
        public virtual DbSet<OutLet_Pilot> OutLet_Pilot { get; set; }
        public virtual DbSet<OutLet_Promotion> OutLet_Promotion { get; set; }
        public virtual DbSet<OutLet_Setup> OutLet_Setup { get; set; }
        public virtual DbSet<OutLet_Tax> OutLet_Tax { get; set; }
        public virtual DbSet<OutletSetup> OutletSetups { get; set; }
        public virtual DbSet<PaidOut_Tranactions> PaidOut_Tranactions { get; set; }
        public virtual DbSet<PaidOut_Void_Reasons> PaidOut_Void_Reasons { get; set; }
        public virtual DbSet<PaidOutReason> PaidOutReasons { get; set; }
        public virtual DbSet<Payment_Void_Reasons> Payment_Void_Reasons { get; set; }
        public virtual DbSet<PaymentMethode> PaymentMethodes { get; set; }
        public virtual DbSet<Phone_Keys> Phone_Keys { get; set; }
        public virtual DbSet<Pilot> Pilots { get; set; }
        public virtual DbSet<Point_Items> Point_Items { get; set; }
        public virtual DbSet<Point> Points { get; set; }
        public virtual DbSet<Pre_Paid_Adjust> Pre_Paid_Adjust { get; set; }
        public virtual DbSet<Pre_Paid_Card> Pre_Paid_Card { get; set; }
        public virtual DbSet<Pre_Paid_Card_Group> Pre_Paid_Card_Group { get; set; }
        public virtual DbSet<Pre_Paid_Groups> Pre_Paid_Groups { get; set; }
        public virtual DbSet<PrePaid_Adjust_Serial> PrePaid_Adjust_Serial { get; set; }
        public virtual DbSet<PrePaid_Group_Items> PrePaid_Group_Items { get; set; }
        public virtual DbSet<Preset> Presets { get; set; }
        public virtual DbSet<Price_Levels> Price_Levels { get; set; }
        public virtual DbSet<Print_Fast_Rpt> Print_Fast_Rpt { get; set; }
        public virtual DbSet<Print_Invoice> Print_Invoice { get; set; }
        public virtual DbSet<Printer> Printers { get; set; }
        public virtual DbSet<Promotion> Promotions { get; set; }
        public virtual DbSet<Promotion_Gift_Items> Promotion_Gift_Items { get; set; }
        public virtual DbSet<Promotion_Items> Promotion_Items { get; set; }
        public virtual DbSet<Recipe> Recipes { get; set; }
        public virtual DbSet<RecipeItem> RecipeItems { get; set; }
        public virtual DbSet<Restaurant_Setup> Restaurant_Setup { get; set; }
        public virtual DbSet<Restaurant> Restaurants { get; set; }
        public virtual DbSet<Setup_Call_Center> Setup_Call_Center { get; set; }
        public virtual DbSet<Setup_EndDay> Setup_EndDay { get; set; }
        public virtual DbSet<Setup_Meals> Setup_Meals { get; set; }
        public virtual DbSet<Setup_Outlet_Mail_Rpt> Setup_Outlet_Mail_Rpt { get; set; }
        public virtual DbSet<Setup_Periods> Setup_Periods { get; set; }
        public virtual DbSet<Setup_Quick_Customer> Setup_Quick_Customer { get; set; }
        public virtual DbSet<Shelf> Shelfs { get; set; }
        public virtual DbSet<StockedItemCategory> StockedItemCategories { get; set; }
        public virtual DbSet<StockedItemsSubCategory> StockedItemsSubCategories { get; set; }
        public virtual DbSet<SystemDate> SystemDates { get; set; }
        public virtual DbSet<TablesGuest> TablesGuests { get; set; }
        public virtual DbSet<Tax> Taxes { get; set; }
        public virtual DbSet<Temp_Button> Temp_Button { get; set; }
        public virtual DbSet<Unit> Units { get; set; }
        public virtual DbSet<Update_Item_Price> Update_Item_Price { get; set; }
        public virtual DbSet<User_OutLets> User_OutLets { get; set; }
        public virtual DbSet<UserClass> UserClasses { get; set; }
        public virtual DbSet<UserDefnation> UserDefnations { get; set; }
        public virtual DbSet<UsersPrivilege> UsersPrivileges { get; set; }
        public virtual DbSet<VendorItem> VendorItems { get; set; }
        public virtual DbSet<Vendor> Vendors { get; set; }
        public virtual DbSet<VersionDB> VersionDBs { get; set; }
        public virtual DbSet<VoidReason> VoidReasons { get; set; }
        public virtual DbSet<VoucherItem> VoucherItems { get; set; }
        public virtual DbSet<Cat_Checks> Cat_Checks { get; set; }
        public virtual DbSet<Cat_ChecksItems> Cat_ChecksItems { get; set; }
        public virtual DbSet<Cat_histChecks> Cat_histChecks { get; set; }
        public virtual DbSet<Cat_histChecksItems> Cat_histChecksItems { get; set; }
        public virtual DbSet<Catering> Caterings { get; set; }
        public virtual DbSet<CL> CLs { get; set; }
        public virtual DbSet<histAR_Table> histAR_Table { get; set; }
        public virtual DbSet<Officer> Officers { get; set; }
        public virtual DbSet<OutletSetupMeal> OutletSetupMeals { get; set; }
        public virtual DbSet<Tmp_Checks> Tmp_Checks { get; set; }
        public virtual DbSet<Tmp_ChecksItems> Tmp_ChecksItems { get; set; }
        public virtual DbSet<Voucher> Vouchers { get; set; }

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