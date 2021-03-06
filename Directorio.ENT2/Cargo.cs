﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DirectorioEntidades
{
    [Table("Cargo")]
    public partial class Cargo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Nombre { get; set; }

        [DataType(DataType.MultilineText)]
        public string Observacion { get; set; }
    }
}
