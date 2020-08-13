namespace conncetASPwithTemplate.Models.others_unused_tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserDefnation")]
    public partial class UserDefnation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Code { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(200)]
        public string Password { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        public int? UserClass_ID { get; set; }

        [StringLength(50)]
        public string MyLanguage { get; set; }

        [StringLength(50)]
        public string tital { get; set; }

        [StringLength(200)]
        public string FullName { get; set; }

        [StringLength(250)]
        public string Adress { get; set; }

        [StringLength(50)]
        public string jop { get; set; }

        [StringLength(150)]
        public string Phone { get; set; }

        [StringLength(150)]
        public string Mobile { get; set; }

        [StringLength(150)]
        public string Email { get; set; }

        [StringLength(200)]
        public string PassCode { get; set; }

        public bool? Active { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? User_ID { get; set; }

        public int? Rest_ID_Active { get; set; }

        public bool? IsWaiter { get; set; }

        [StringLength(10)]
        public string Ref_Code { get; set; }
    }
}
