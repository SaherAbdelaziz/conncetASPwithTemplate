namespace conncetASPwithTemplate.Models.others_unused_tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class histHD_Orders_Pilot
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        public int? Serial { get; set; }

        public int? Checks_Count { get; set; }

        public int? Pilot_ID { get; set; }

        [StringLength(50)]
        public string Pilot_Status { get; set; }

        public DateTime? Go_Time { get; set; }

        public DateTime? Back_Time { get; set; }

        public bool? Cash_In { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? User_ID { get; set; }

        public int? OutLet_ID { get; set; }

        public int? Rest_ID_Active { get; set; }

        public int? WS { get; set; }

        public int? Pilot_Log_ID { get; set; }
    }
}
