namespace conncetASPwithTemplate.Models.others_unused_tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FC_ReceivdData
    {
        [Key]
        public int ID_Auto { get; set; }

        public long? Check_ID { get; set; }

        public int? Check_Serial { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? MyDate { get; set; }

        [StringLength(50)]
        public string Cross_Code { get; set; }

        public double? Qty { get; set; }

        public bool? Posted { get; set; }

        public DateTime? DatePost { get; set; }

        public int? OutLet_ID { get; set; }
    }
}
