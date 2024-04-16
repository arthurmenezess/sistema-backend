namespace ProgramacaoDoZero.Models
{
    public class Veiculos // FORMA
    {
        
        //COSNTRUTOR 
        public Veiculos()
        
        {
            TanqueCombustivel = 40;
        } 

        // ATRIBUTOS OU PROPRIEDADES
        public string Cor { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public int TanqueCombustivel { get; set; }

        // MÉTODOS
        public virtual void Acelerar()
        {
            InjetarCombustivel(3);
        }
        public void Freiar()
        {

        }

        private void InjetarCombustivel(int quantidadeCombustivel)
        {
            TanqueCombustivel = TanqueCombustivel - quantidadeCombustivel;
        }
    }
}
