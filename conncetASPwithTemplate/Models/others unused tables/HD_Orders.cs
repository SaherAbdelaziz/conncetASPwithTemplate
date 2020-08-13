namespace conncetASPwithTemplate.Models.others_unused_tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HD_Orders
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        public int? Serial { get; set; }

        public long? Check_ID { get; set; }

        public long? Cust_ID { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        [StringLength(50)]
        public string Type_Order { get; set; }

        public int? Pilot_ID { get; set; }

        public DateTime? Attach_Time { get; set; }

        public long? Order_Pilot_ID { get; set; }

        public bool? Voided { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? User_ID { get; set; }

        public int? OutLet_ID { get; set; }

        public int? Rest_ID_Active { get; set; }

        public int? WS { get; set; }

        [StringLength(50)]
        public string Order_Phone { get; set; }
    }
}
