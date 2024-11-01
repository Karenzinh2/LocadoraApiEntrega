using System.ComponentModel.DataAnnotations;

namespace LocadoraApi.Models
{
    public class Locadora
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string NOME { get; set; }
        public string Cidade { get; set; }
        public ICollection<Filme> Filme { get; set; } = new List<Filme>();

    }
}
