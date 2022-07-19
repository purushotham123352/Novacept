using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OnlineFoodOrderSystem.Entities
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Customerid { get; set; }
        [StringLength(20)]
        [Column(TypeName = "varchar")]
        public string FirstName { get; set; }
        [StringLength(20)]
        [Column(TypeName = "varchar")]
        public string lastName { get; set; }
        [StringLength(20)]
        [Column(TypeName = "varchar")]
        public string Email { get; set; }
        [Column(TypeName = "Bigint")]
        public long Mobile { get; set; }
        [StringLength(20)]
        [Column(TypeName = "varchar")]
        public string Password { get; set; }
        [StringLength(20)]
        [Column(TypeName = "varchar")]
        public string Status { get; set; }
    }
}
