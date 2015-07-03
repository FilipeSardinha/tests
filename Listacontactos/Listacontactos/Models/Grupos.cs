using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace Listacontactos.Models
{
    public class Grupos
    {
        [Key] public int ID { get; set; }
        public string Grupo { get; set; }
    }
    public class grupoDBcontext : DbContext
    {
        public DbSet<Grupos> grupo { get; set; }
    }
}