using System;
using System.ComponentModel.DataAnnotations;

namespace Git.Pracice_4.Logic.Models
{
    public class Info
    {
        public String ID { get; set; }

        [Required(ErrorMessage = "{0} es requerido.")]
        [StringLength(50, MinimumLength = 1,
        ErrorMessage = "El nombre debe tener como minimo 1 caracter y maximo 50 caracteres")]
        public String Name { get; set; }
        

        [Range(0, Int32.MaxValue, ErrorMessage = "Ingrese un numero positivo")]
        public int AvailableSlots { get; set; }
        
    }
}
