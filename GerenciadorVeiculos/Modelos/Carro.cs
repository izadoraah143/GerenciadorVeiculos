using System;

namespace GerenciadorVeiculos.Modelos
{
    // Os dois pontos (:) idicam que Carro herda tudo o que tem em Veiculo
    public class Carro : Veiculo
    {
        // Informação exclusiva da classe Carro, dos carros
        public int Portas { get; set; }

        // O construtor repassa modelo e diaria para a classe mãe através do base()
        public Carro(string modelo, decimal valorDiaria, int portas) : base(modelo, valorDiaria)
        {
            Portas = portas;
        }

        // Polimorfismo: para Carro, o seguro é de 10% do valor da diária
        // m é pra idicar que é decimal 
        public override decimal CalcularSeguro()
        {
            return ValorDiaria * 0.10m;
        }
    }
}
