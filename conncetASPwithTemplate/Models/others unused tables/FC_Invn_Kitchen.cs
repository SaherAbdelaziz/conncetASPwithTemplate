namespace conncetASPwithTemplate.Models.others_unused_tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FC_Invn_Kitchen
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Invn_Kit_ID { get; set; }

        [StringLength(10)]
        public string Code { get; set; }

        [StringLength(150)]
        public string Name { get; set; }

        [StringLength(150)]
        public string Name2 { get; set; }

        public int? Invn_ID { get; set; }

        public bool? Active { get; set; }

        public bool? Main_kit { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? User_ID { get; set; }

        public bool? Is_OutLet { get; set; }
    }
}
