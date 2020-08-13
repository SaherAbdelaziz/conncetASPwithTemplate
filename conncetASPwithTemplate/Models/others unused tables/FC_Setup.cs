namespace conncetASPwithTemplate.Models.others_unused_tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FC_Setup
    {
        public int ID { get; set; }

        public bool? Calc_Cost_AVERAGE { get; set; }

        public bool? Calc_Cost_Last_Cost { get; set; }

        public bool? Calc_Cost_FIFO { get; set; }

        public bool? Calc_Cost_LIFO { get; set; }

        public bool? Deductive_POS_Data_Negative { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? User_ID { get; set; }

        public bool? Invn_Kit { get; set; }

        public bool? Invn_Only { get; set; }

        public bool? Kit_Only { get; set; }
    }
}
