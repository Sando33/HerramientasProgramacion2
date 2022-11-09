using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace api_autores.Entitys { 
    public class Autor
    {
        //Definimos la clave primaria
        [Key]
        public int codigoautor { get; set; }
        //Definimos los valores no nulos
        [Required]
        //Definimos el tamaño del campo
        [StringLength(
            maximumLength: 100,
            ErrorMessage = "Se tiene que ingresar un Nombre"
            )]
        public string nombre { get; set; }
        [Required]
        public bool estado { get; set; }

        public List<Libro> libro { get; set; }

    }
}

