using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CheckBox_DropDownList_MVC_Core.Models
{
    public class FruitModel
    {
        [Key]
        public int FruitId { get; set; }
        public string FruitName { get; set; }
    }
}
