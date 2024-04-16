using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramacaoDoZero.Controllers
{
    [Route("api/aula8")]
    [ApiController]
    public class Aula8Controller : ControllerBase
    {
        [Route("olaMundo")] // isso é um endpoint e nome da rota
        [HttpGet]
        public string OlaMundo()
        {
            var mensagem = "Olá mundo via API";
            return mensagem;
        }

        [Route("olaMundoPersonalizado")] //nome da rota
        [HttpGet]

        public string OlaMundoPersonalizado(string nome) // nome da funcao e recebe como parametro o nome
        {
            var mensagem = "Olá " + nome + ", eu sou uma API";

            return mensagem;
        }

        [Route("somar")]
        [HttpGet]
        public string Somar(int valor1, int valor2)
        {
            var soma = valor1 + valor2;

            var mensagem = "A soma é " + soma;

            return mensagem;
        }

        [Route("media")]
        [HttpGet]
        public string Media(decimal valor1, decimal valor2)
        {
            var soma = valor1 + valor2;
            var media = soma / 2;
            var mensagem = "A média dos dois números é " + media;
            return mensagem;
        }

        [Route("terreno")]
        [HttpGet]
        public string Terreno(decimal largura, decimal comprimento, decimal valorM2)
        {
            var area = largura * comprimento;
            var precoTerreno = area * valorM2;
            var mensagem = "O valor do M2 do terreno é R$" + precoTerreno + ". E a area dele é " + area + "m2.";
            return mensagem;
        }

        [Route("troco")]
        [HttpGet]
        public string Troco(decimal precoUn, int quantidade, decimal valorDado)
        {
            var valorCompra = precoUn * quantidade;
            var troco = valorDado - valorCompra;
            var mensagem = "A compra foi de R$" + valorCompra + ". E o troco é de R$" + troco;
            return mensagem;
        }

        [Route("pagamento")]
        [HttpGet]
        public string Pagamento(string nomeFuncionario, decimal valorHora, decimal qtdeTrabalhada)
        {
            var salario = valorHora * qtdeTrabalhada;
            var mensagem = "O funcionário " + nomeFuncionario + " trabalhou " + qtdeTrabalhada + " horas e vai receber R$" + salario;
            return mensagem;
        }

        [Route("consumo")]
        [HttpGet]
        public string Consumo(decimal distanciaPercorrida, decimal combustivelGasto)
        {
            var consumo = distanciaPercorrida / combustivelGasto;
            var mensagem = "O consumo do veículo foi de " + consumo + "km/l";
            return mensagem;
        }

    }



}
