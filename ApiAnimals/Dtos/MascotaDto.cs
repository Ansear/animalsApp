using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiAnimals.Dtos;
    public class MascotaDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public RazaDto Raza { get; set; }
        public ClienteDto Cliente { get; set; }
    }