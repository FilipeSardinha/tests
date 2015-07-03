using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace Listacontactos.Models
{
    public class numeros
    {
        [Key] public string Nome { get; set; }
        public string Apelido { get; set; }
        public string Tipo { get; set; }
        public int Numero { get; set; }
    }

    public class numeroDBcontext : DbContext
    {
        public DbSet<numeros> numero { get; set; }
    }
}