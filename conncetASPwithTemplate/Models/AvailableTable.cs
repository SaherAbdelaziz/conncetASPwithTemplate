using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace conncetASPwithTemplate.Models
{
    public class AvailableTable
    {
        public int ID { get; set; }

        public int? WS { get; set; }

        [Required]
        [StringLength(50)]
        public string ComputerIP { get; set; }

        [Required]
        [StringLength(50)]
        public string ComputerName { get; set; }

        [StringLength(50)]
        public string TableLock { get; set; }

        public DateTime? DateLock { get; set; }

        [StringLength(50)]
        public string IDRow { get; set; }

        [StringLength(50)]
        public string FormLock { get; set; }

        [StringLength(50)]
        public string State { get; set; }

        public AvailableTable(string userId, string name, string idRow)
        {
            ComputerIP = userId;
            ComputerName = name;
            IDRow = idRow;
        }
    }
}
