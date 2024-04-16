using Microsoft.AspNetCore.Mvc;
using ProgramacaoDoZero.Models;

namespace ProgramacaoDoZero.Controllers
{
    [Route("api/aula11")]
    [ApiController]
    public class Aula11Controller : ControllerBase
    {
        [Route("obterVeiculo")] //endpoint
        [HttpGet] // get = obter
        public Veiculos obterVeiculo() //metodo
        {
            var meuVeiculo = new Veiculos(); // criou uma instancia da classe veiculos e monta um objeto meuVeiculo

            meuVeiculo.Cor = "Amarelo"; // atribui as caracteristicas do veiculo
            meuVeiculo.Marca = "Ford";
            meuVeiculo.Modelo = "Fusion";
            meuVeiculo.Placa = "CCZ-2564";

            meuVeiculo.Acelerar();
            meuVeiculo.Acelerar();
            meuVeiculo.Acelerar();

            return meuVeiculo; // retorna as caracteristicas
        }

        [Route("obterCarro")]
        [HttpGet]
        public Carro obterCarro()
        {
            var meuCarro = new Carro();

            meuCarro.Marca = "Honda";
            meuCarro.Modelo = "Fit";
            meuCarro.Placa = "CSX-2774";
            meuCarro.Cor = "Vermelho";

            meuCarro.Acelerar();
            meuCarro.Acelerar();

            return meuCarro;
        }

        [Route("obterMoto")]
        [HttpGet]
        public Moto obterMoto()
        {
            var minhaMoto = new Moto();

            minhaMoto.Marca = "Yamaha";
            minhaMoto.Modelo = "Fazer 250";
            minhaMoto.Cor = "Azul";
            minhaMoto.Placa = "EED-2485";

            minhaMoto.Acelerar();
            minhaMoto.Acelerar();
            minhaMoto.Acelerar();

            return minhaMoto;
        }
    }

}
