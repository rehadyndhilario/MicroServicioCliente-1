using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.dto
{
    public class ClienteResponseDto
    {
        private int id;
        private String nombre;
        private String apellido;
        private String email;
        private DateTime fechaCreacion;
        private String[] direcciones;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Email { get => email; set => email = value; }
        public DateTime FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }
        public string[] Direcciones { get => direcciones; set => direcciones = value; }
    }
}