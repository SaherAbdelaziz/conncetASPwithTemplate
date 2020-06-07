using conncetASPwithTemplate.Models;

namespace conncetASPwithTemplate.Dtos
{
    public class ItemDto
    {
        public int Id { get; set; }
        
        public string Code { get; set; }
        
        public string Name { get; set; }
        
        public string Name2 { get; set; }

        public int? SubCategryId { get; set; }

        public bool? IsModifier { get; set; }


        public double? StaticPrice { get; set; }

    }
}




