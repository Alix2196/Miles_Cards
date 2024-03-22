using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entity
{
    [Table("vehiculos")]
    public class VehiculosEntity
    {
        [Key]
        [Column("Id_vehiculo")]
        public int Id { get; set; }

        [Column("marca")]
        public string? Marca {  get; set; }

        [Column("placa")]
        public string? Placa { get; set; }
    }
}
