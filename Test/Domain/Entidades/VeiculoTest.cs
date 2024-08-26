using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MinimalApi.Dominio.Entidades;
using MinimalApi.Dominio.Servicos;
using MinimalApi.Infraestrutura.Db;

namespace Test.Domain.Entidades;

public class VeiculoTest()
{
    public void VeiculoTestGetSet()
    {
        // Arrange
        var veiculo = new Veiculo();

        // Action
        veiculo.Id = 1;
        veiculo.Nome = "Fiat";
        veiculo.Marca = "Uno";
        veiculo.Ano = 2010;

        // Assert
        Assert.AreEqual(1, veiculo.Id);
        Assert.AreEqual("Fiat", veiculo.Nome);
        Assert.AreEqual("Uno", veiculo.Marca);
        Assert.AreEqual(2010, veiculo.Ano);
    }
}
