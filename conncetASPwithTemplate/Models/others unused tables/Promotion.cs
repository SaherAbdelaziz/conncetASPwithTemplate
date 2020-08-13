namespace conncetASPwithTemplate.Models.others_unused_tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Promotion")]
    public partial class Promotion
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        [StringLength(50)]
        public string Promo_Type { get; set; }

        public int? Discount_ID { get; set; }

        [StringLength(50)]
        public string Check_No { get; set; }

        public DateTime? Start_Date { get; set; }

        public DateTime? End_Date { get; set; }

        [StringLength(250)]
        public string Notes { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? User_ID { get; set; }

        public int? Rest_ID_Active { get; set; }

        public int? QtyBO { get; set; }

        public int? GiftQty { get; set; }

        public bool? ByTime { get; set; }

        public int? Start_Time { get; set; }

        public int? End_Time { get; set; }

        public bool? Satur_day { get; set; }

        public bool? Sun_day { get; set; }

        public bool? Mon_day { get; set; }

        public bool? Tues_day { get; set; }

        public bool? Wednes_day { get; set; }

        public bool? Thurs_day { get; set; }

        public bool? Fri_day { get; set; }

        public bool? DinIn { get; set; }

        public bool? HD { get; set; }

        public bool? FastFood { get; set; }

        public bool? DriveThru { get; set; }
    }
}
