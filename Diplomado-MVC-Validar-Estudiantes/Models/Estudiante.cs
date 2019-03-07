using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace Diplomado_MVC_Validar_Estudiantes.Models
{
    public class Estudiante
    {
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [MinLength(3, ErrorMessage = "El nombre del estudiante debe tener al menos 3 caracteres")]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "El apellido es obligatorio")]
        [MinLength(3, ErrorMessage = "El apellido del estudiante debe tener al menos 3 caracteres")]
        public string Apellidos { get; set; }

        [Range(14, 65, ErrorMessage = "La edad del estudiante debe estar entre 14 y 65 años")]
        public int Edad { get; set; }

        [EmailAddress(ErrorMessage = "Debe ingresar un mail valido")]
        public string Email { get; set; }

        [RegularExpression("[MmFf]", ErrorMessage = "Solo puede ingresar M=masculino y F=femenino")]
        public string Genero { get; set; }

        [RegularExpression("[CcSsUuDd]", ErrorMessage = "Solo puede ingresar C=casado, S=soltero, U=union libre y D=divorciado")]
        public string EstadoCivil { get; set; }

    }
}