using System;

namespace DesignPatternSamples.Application.DTO
{
    [Serializable]
    public class PontosCarteira
    {
        public DateTime DataOcorrencia { get; set; }
        public int Pontos { get; set; }
        public int CodigoInfracao { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
    }
}