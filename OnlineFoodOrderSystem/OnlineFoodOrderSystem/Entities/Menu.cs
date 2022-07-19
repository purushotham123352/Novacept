using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OnlineFoodOrderSystem.Entities
{
    [Table("Menu")]
    public class Menu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Menuid { get; set; }
        [StringLength(20)]
        [Column(TypeName = "varchar")]
        public string MenuName { get; set; }
        public int Quantity { get; set; }
        [Column(TypeName ="decimal")]
        public int Price { get; set; }
        [StringLength(20)]
        [Column(TypeName = "varchar")]
        public string FoodCategory { get; set; }
    }
}
