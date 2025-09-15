using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Assign_07.Models.DataLayer;

public partial class Incident
{
    [Key]
    [Column("IncidentID")]
    public int IncidentId { get; set; }

    [Column("CustomerID")]
    public int CustomerId { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ProductCode { get; set; } = null!;

    [Column("TechID")]
    public int? TechId { get; set; }

    public DateTime DateOpened { get; set; }

    public DateTime? DateClosed { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Title { get; set; } = null!;

    [StringLength(2000)]
    [Unicode(false)]
    public string Description { get; set; } = null!;

    [ForeignKey("CustomerId")]
    [InverseProperty("Incidents")]
    public virtual Customer Customer { get; set; } = null!;

    [ForeignKey("ProductCode")]
    [InverseProperty("Incidents")]
    public virtual Product ProductCodeNavigation { get; set; } = null!;

    [ForeignKey("TechId")]
    [InverseProperty("Incidents")]
    public virtual Technician? Tech { get; set; }
}
