namespace conncetASPwithTemplate.Models.others_unused_tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Setup_Call_Center
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Rest_ID_Active { get; set; }

        public int? Port { get; set; }

        [StringLength(50)]
        public string IP_Address { get; set; }

        public bool? Active { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? User_ID { get; set; }
    }
}
