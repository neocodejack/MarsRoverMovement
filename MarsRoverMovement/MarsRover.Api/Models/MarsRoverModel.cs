using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MarsRover.Api.Models
{
    public class MarsRoverContext : DbContext
    {
        public MarsRoverContext(DbContextOptions<MarsRoverContext> options)
                : base(options)
        { }

        public DbSet<MarsRoverMovement> MarsRoverMovements { get; set; }
    }

    public class MarsRoverMovement
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public double Left { get; set; }
        public double Right { get; set; }
        public double Top { get; set; }
    }
}
