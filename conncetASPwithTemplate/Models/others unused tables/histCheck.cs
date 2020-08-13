namespace conncetASPwithTemplate.Models.others_unused_tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class histCheck
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        public int CheckSerail { get; set; }

        [StringLength(50)]
        public string CheckTitel { get; set; }

        [StringLength(50)]
        public string CheckType { get; set; }

        public int? Covers { get; set; }

        [StringLength(50)]
        public string MyTable { get; set; }

        [StringLength(50)]
        public string MyStatus { get; set; }

        public bool? Splited { get; set; }

        public long? RefranceTo { get; set; }

        public DateTime? myDateTime { get; set; }

        public DateTime? OpenIn { get; set; }

        public DateTime? ClosedIn { get; set; }

        public long? Cust_ID { get; set; }

        public int? Server_ID { get; set; }

        public int? Casher_ID { get; set; }

        public int? Admin_ID { get; set; }

        public int? OutLet_ID { get; set; }

        public int? Rest_ID_Active { get; set; }

        public int? WS { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? Num_Fired { get; set; }

        public int? User_ID { get; set; }

        public bool? Voided { get; set; }

        public DateTime? Voided_Time { get; set; }

        public int? Voided_Reason { get; set; }

        public int? Order_No { get; set; }

        public bool? ReOpen { get; set; }

        public int? Table_ID { get; set; }

        public int? Num_Print { get; set; }

        public int? Lvl_Split { get; set; }

        public int? ChangeAfterSplit { get; set; }

        public bool? Combined { get; set; }

        public long? Combined_To { get; set; }

        public int? ChangeAfterCombine { get; set; }

        public bool? Received { get; set; }

        public DateTime? Received_Time { get; set; }

        public int? Point_ID { get; set; }

        public int? Meal_ID { get; set; }

        public int? Voided_By { get; set; }

        public long? Catering_ID { get; set; }

        public bool? Pick_Up { get; set; }

        public DateTime? Pick_Up_Time { get; set; }

        public bool? Officer { get; set; }

        public int? Officer_ID { get; set; }

        [StringLength(100)]
        public string Void_Reason_Comment { get; set; }

        public bool? Call_Center { get; set; }

        public bool? PrePaid_Card { get; set; }

        [StringLength(20)]
        public string PrePaid_Serial { get; set; }
    }
}
