using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToyLibrarySolution.Server.Model
{
    /// <summary>
    /// The Customer Model.
    /// </summary>

    [Table("customers")]
    public class Customers
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("first_name")]
        [MaxLength(50)]
        public string? FirstName { get; set; }

        [Column("country")]
        [MaxLength(50)]
        public string? Country { get; set; }

        [Column("score")]
        public int? Score { get; set; }
    }
}
