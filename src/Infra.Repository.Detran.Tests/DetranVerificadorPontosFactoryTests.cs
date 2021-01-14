using DesignPatternSamples.Application.Repository;
using DesignPatternSamples.Infra.Repository.Detran;
using Microsoft.Extensions.DependencyInjection;
using System;
using Xunit;

namespace DesignPatternsSamples.Infra.Repository.Detran.Tests
{
    public class DetranVerificadorPontosFactoryTests : IClassFixture<DependencyInjectionFixtureP>
    {
        private readonly IDetranVerificadorPontosFactory _Factory;

        public DetranVerificadorPontosFactoryTests(DependencyInjectionFixtureP dependencyInjectionFixtureP)
        {
            var serviceProvider = dependencyInjectionFixtureP.ServiceProvider;
            _Factory = serviceProvider.GetService<IDetranVerificadorPontosFactory>();
        }

        [Theory(DisplayName = "Dado um UF que está devidamente registrado no Factory devemos receber a sua implementação correspondente")]
        [InlineData("SP", typeof(DetranSPVerificadorDebitosRepository))]
        public void InstanciarServicoPorUFRegistrado(string uf, Type implementacao)
        {
            var resultado = _Factory.Create(uf);

            Assert.NotNull(resultado);
            Assert.IsType(implementacao, resultado);
        }

        [Fact(DisplayName = "Dado um UF que não está registrado no Factory devemos receber NULL")]
        public void InstanciarServicoPorUFNaoRegistrado()
        {
            IDetranVerificadorPontosRepository implementacao = _Factory.Create("SP");

            Assert.Null(implementacao);
        }
    }
}
