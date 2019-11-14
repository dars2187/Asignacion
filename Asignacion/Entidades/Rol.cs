﻿using System.ComponentModel.DataAnnotations;

namespace Asignacion.Entidades
{
    public class Rol
    {
        public int idrol { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "El nombre no debe de tener más de {0} caracteres, ni menos de {2} caracteres.", MinimumLength = 3)]
        public string descripcion { get; set; }
    }
}
