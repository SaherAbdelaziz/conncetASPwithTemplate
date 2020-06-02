namespace conncetASPwithTemplate
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public class ModifiersGroup
    {
        public int Id { get; set; }

        [StringLength(10)]
        public string Code { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Name2 { get; set; }

        public bool? MultiPick { get; set; }

        public bool? AllawNoPick { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        public bool? Active { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? User_ID { get; set; }

        public int? MaxPick { get; set; }

        public bool? Pick_Follow_Item_Qty { get; set; }
    }
}
