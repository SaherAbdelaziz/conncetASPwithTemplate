namespace conncetASPwithTemplate.Models.others_unused_tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Pre_Paid_Card
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Item_ID { get; set; }

        public bool? Set_Expiry_Period { get; set; }

        public int? Expiry_Period_By_Days { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? User_ID { get; set; }

        public int? Rest_ID_Active { get; set; }
    }
}
