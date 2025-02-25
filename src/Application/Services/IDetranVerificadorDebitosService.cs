﻿using DesignPatternSamples.Application.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatternSamples.Application.Services
{
    public interface IDetranVerificadorPontosService
    {
        Task<IEnumerable<PontosCarteira>> ConsultarPontos(Carteira carteira);
    }
}
