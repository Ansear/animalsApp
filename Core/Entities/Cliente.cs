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
        
    }