using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LocadoraApi.Models
{
    public class Locacao
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime DataInicio { get; set; }
        public DateTime? DataFim { get; set; }

        [ForeignKey("FilmeId")]
        public Guid FilmeId { get; set; }
        [ForeignKey("ClienteId")]
        public Guid ClienteId { get; set; }

        public Filme? Filme { get; set; }
        public Cliente? Cliente { get; set; }
    }
}
