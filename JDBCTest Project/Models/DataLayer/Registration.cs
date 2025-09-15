using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Assign_07.Models.DataLayer;

[PrimaryKey("CustomerId", "ProductCode")]
public partial class Registration
{
    [Key]
    [Column("CustomerID")]
    public int CustomerId { get; set; }

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string ProductCode { get; set; } = null!;

    public DateTime RegistrationDate { get; set; }

    [ForeignKey("CustomerId")]
    [InverseProperty("Registrations")]
    public virtual Customer Customer { get; set; } = null!;

    [ForeignKey("ProductCode")]
    [InverseProperty("Registrations")]
    public virtual Product ProductCodeNavigation { get; set; } = null!;
}
