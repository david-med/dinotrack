﻿using System.ComponentModel.DataAnnotations;

namespace Dinotrack.shared.Entities
{
    public class Category
    {
        public int Id { get; set; }

        [Display(Name = "Marca")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Name { get; set; } = null!;
    }
}

