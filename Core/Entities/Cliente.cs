using System.ComponentModel.DataAnnotations;

namespace Core.Entities;
    public class Cliente : BaseEntity
    {

        [Required]
        public string Apellidos { get; set;}
        [Required]
        public string Nombre { get; set;}
        [Required]
        public string Email { get; set;}
        public ClienteDireccion ClienteDireccion { get; set; }
        public ICollection<ClienteTelefono> ClientesTelefonos { get; set; }
        public ICollection<Mascota> Mascotas { get; set; }
        public ICollection<Cita> Citas { get; set; }
    }