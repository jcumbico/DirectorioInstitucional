using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DirectorioEntidades
{
    [Table("Persona")]
    public partial class Persona
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(10)]
        public string Nombre1 { get; set; }

        [MaxLength(10)]
        public string Nombre2 { get; set; }

        [Required]
        [MaxLength(10)]
        public string ApellidoPaterno { get; set; }

        [Required]
        [MaxLength(10)]
        public string ApellidoMaterno { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [ValidarFechaNacimiento]
        public DateTime FechaNacimiento { get; set; }

        [DataType(DataType.DateTime)]
        public Nullable<DateTime> FechaFallecimiento { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime FechaIngreso { get; set; }

        [DataType(DataType.DateTime)]
        public Nullable<DateTime> FechaSalida { get; set; }

        [DefaultValue(false )]
        public bool EstaActivo { get; set; }

        [Required]
        public Cargo CargoAsignado { get; set; }

        [NotMapped]
        [Required]
        public int CargoId { get; set; }
    }

    public class ValidarFechaNacimiento : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Persona ObjetoPersona = (Persona)validationContext.ObjectInstance;

            if (value == null)
            {
                return ValidationResult.Success;
            }
            DateTime FechaNacimiento = (DateTime)value;

            if (FechaNacimiento > ObjetoPersona.FechaFallecimiento)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("Fecha de Nacimiento no puede ser igual o mayor a la fecha de fallecimiento", new string[] { "FechaNacimiento" });
            }
        }
    }
}
