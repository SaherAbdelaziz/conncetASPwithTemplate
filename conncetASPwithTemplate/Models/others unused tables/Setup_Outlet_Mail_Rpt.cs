namespace conncetASPwithTemplate.Models.others_unused_tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Setup_Outlet_Mail_Rpt
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(10)]
        public string Code { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public bool? Active { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? User_ID { get; set; }

        public int? Rest_ID_Active { get; set; }

        public int? OutLet_ID_Active { get; set; }

        public DateTime? Last_Sent { get; set; }

        public int? File_Type { get; set; }

        [StringLength(150)]
        public string From_Mail { get; set; }

        [StringLength(150)]
        public string Smtp_Host { get; set; }

        public int? Smtp_Port { get; set; }

        public bool? EnableSsl { get; set; }

        [StringLength(150)]
        public string User_Name { get; set; }

        [StringLength(150)]
        public string PassWord { get; set; }

        [StringLength(150)]
        public string To_Mail { get; set; }

        public bool? Prnt_Z_Out { get; set; }

        public bool? Prnt_Pilots { get; set; }

        public bool? Prnt_Pilots_Balance { get; set; }

        public bool? Prnt_Qty_Sold { get; set; }
    }
}
