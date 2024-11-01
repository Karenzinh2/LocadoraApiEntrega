using System.ComponentModel.DataAnnotations;

namespace LocadoraApi.Models
{
    public class Cliente
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string NOME { get; set; }
        public string CPF {  get; set; }
        public string EMAIL { get; set; }
        public string TELEFONE { get; set; }
        public ICollection<Locacao> Locacoes { get; set; } = new List<Locacao>();
    }
}
