using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Cliente.Models
{
    public class Clientes
    {
        public int id { get; set; }
        [Required]
        [Display (Name = "Primer Nombre")]
        public string primerNombre { get; set; }
        [Display(Name ="Segundo nombre")]
        public string segundoNombre{ get; set; }
        [Display (Name ="Direccion")]
        public string direccion { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name ="Numero de Telefono")]
        
        public int telefono { get; set; }
        
        [Required]
        [DataType(DataType.EmailAddress)]
        [Display (Name ="Correo electronico")]
        public string correo { get; set; }
        
    }

    public class ClienteDBContext : DbContext {
        public DbSet<Clientes> cliente { get; set; }
    }


}