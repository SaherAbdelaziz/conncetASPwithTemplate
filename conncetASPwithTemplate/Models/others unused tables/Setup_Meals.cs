namespace conncetASPwithTemplate.Models.others_unused_tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Setup_Meals
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(10)]
        public string Code { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Name2 { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        public bool? Active { get; set; }

        public int? Start_Time { get; set; }

        public int? End_Time { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? User_ID { get; set; }

        public int? Rest_ID_Active { get; set; }

        public int? OutLet_ID_Active { get; set; }

        public int? PriceLVL_ID { get; set; }

        public bool? Satur_day { get; set; }

        public bool? Sun_day { get; set; }

        public bool? Mon_day { get; set; }

        public bool? Tues_day { get; set; }

        public bool? Wednes_day { get; set; }

        public bool? Thurs_day { get; set; }

        public bool? Fri_day { get; set; }
    }
}
