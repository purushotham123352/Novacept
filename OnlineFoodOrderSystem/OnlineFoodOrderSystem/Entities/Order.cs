using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OnlineFoodOrderSystem.Entities
{
    [Table("Order")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }
        
        public DateTime OrderDate { get; set; }
        [Column(TypeName ="decimal")]
        public int TotalAmount { get; set; }

        public int Customerid { get; set; }
        [ForeignKey("Customerid")]
        public Customer customer { get; set; }


        [StringLength(20)]
        [Column(TypeName = "varchar")]
        public string OrderStatus { get; set; }
    }
}
