using System.ComponentModel;

namespace Locacoes.Models
{
    public class VeiculoLocado
    {
        public int Id { get; set; } // Adiciona a propriedade Id
        public int VeiculoId { get; set; }
        public Veiculo? Veiculo { get; set; }
        public int LocacaoId { get; set; }
        public Locacao? Locacao { get; set; }
        public DateOnly DataDevolucao { get; set; }
        public long KilometragemInicial { get; set; }
        public long KilometragemFinal { get; set; }
        public decimal ValorDiaria { get; set; }
    }
}
