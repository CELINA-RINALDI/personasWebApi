using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SWMedicos.Models
{
    [Table("Medicos")]
    public class Medico
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName="varchar(50)")] 
        public string Nombre { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Apellido { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Especialidad { get; set; }

        public int NroMatricula { get; set; }

        [Column(TypeName = "date")]
        public DateTime FechaNacimiento { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string  Ciudad { get; set; }

    }
}
