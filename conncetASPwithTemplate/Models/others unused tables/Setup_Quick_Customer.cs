namespace conncetASPwithTemplate.Models.others_unused_tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Setup_Quick_Customer
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Name_Item { get; set; }

        [StringLength(50)]
        public string Desc_Item { get; set; }

        public int? Rest_ID_Active { get; set; }

        public int? OutLet_ID_Active { get; set; }

        public DateTime? CreateDate { get; set; }

        public int? User_ID { get; set; }
    }
}
