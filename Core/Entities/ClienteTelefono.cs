using System.ComponentModel.DataAnnotations;

namespace Core.Entities;
    public class ClienteTelefono : BaseEntity
    {
        [Required]
        public int IdCliente { get; set; }
        public Cliente Clientes { get; set; }
        [Required]
        public string Numero { get; set; }
    }