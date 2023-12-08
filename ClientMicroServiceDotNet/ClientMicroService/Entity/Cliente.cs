using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Entity.Entity
{
    [Table("Cliente")]
    public class Cliente : EntityBase
    {        
        private String nombre;
        private String apellido;
        private String email;
        private DateTime fechaCreacion;
        private String[] direcciones;
       
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Email { get => email; set => email = value; }
        public DateTime FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }
        public string[] Direcciones { get => direcciones; set => direcciones = value; }
    }
}