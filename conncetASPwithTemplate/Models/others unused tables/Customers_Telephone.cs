namespace conncetASPwithTemplate.Models.others_unused_tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Customers_Telephone
    {
        public int ID { get; set; }

        public long Cust_ID { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }
    }
}
