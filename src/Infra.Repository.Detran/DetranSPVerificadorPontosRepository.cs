using DesignPatternSamples.Application.DTO;
using DesignPatternSamples.Application.Repository;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatternSamples.Infra.Repository.Detran
{
    public class DetranSPVerificadorPontosRepository : IDetranVerificadorPontosRepository
    {
        private readonly ILogger _Logger;

        public DetranSPVerificadorPontosRepository(ILogger<DetranSPVerificadorPontosRepository> logger)
        {
            _Logger = logger;
        }

        public Task<IEnumerable<DebitoVeiculo>> ConsultarPontos(Carteira carteira)
        {
            _Logger.LogDebug($"Consultando pontos na CNH número {carteira.numero}.");
            return Task.FromResult<IEnumerable<PontosCarteira>>(new List<Pontos>() { new PontosCarteira() });
        }
    }
}
