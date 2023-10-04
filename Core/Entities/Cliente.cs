using System.ComponentModel.DataAnnotations;

namespace Core.Entities;
    public class Cliente : BaseEntity
    {

        [Required]
        public int Apellidos { get; set;}
        [Required]
        public int Nombre { get; set;}
        [Required]
        public int Email { get; set;}
        public ClienteDireccion ClienteDireccion { get; set; }
        public ICollection<ClienteTelefono> ClientesTelefonos { get; set; }
        public ICollection<Mascota> Mascotas { get; set; }
        public ICollection<Cita> Citas { get; set; }
    }