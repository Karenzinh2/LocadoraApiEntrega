using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LocadoraApi.Models
{
    public class Filme
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Editora { get; set; }
        public string Categoria { get; set; }
        public string Autor {  get; set; }
        public decimal Preco { get; set; }

        [ForeignKey("LocadoraId")]
        public Guid LocadoraId { get; set; }
        public Locadora? Locadora { get; set; }

    }
}
