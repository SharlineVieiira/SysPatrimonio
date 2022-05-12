using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SysPatrimonio.Models
{
    [Table("patrimonio", Schema = "public")]
    public class DbPatrimonio
    {
        [Key]
        public int id { get; set; }
        public string? numeetiqueta { get; set; }
        public string? nomepatrimonio { get; set; }
        public string? descricaopatrimonio { get; set; }
        public string? valorpatrimonio { get; set; }
        public int idcategoria { get; set; }
        public int idlocal { get; set; }
        public int iddepartamento { get; set; }
        public string? marcamodelo { get; set; }
        public DateTime dataaquisicao { get; set; }
        public DateTime databaixa { get; set; }
        public string? numnf { get; set; }
        public string? numserie { get; set; }
        public string? situacao { get; set; }
        public int idfornecedor { get; set; }
        public DateTime datagarantia { get; set; }   
    }
}
