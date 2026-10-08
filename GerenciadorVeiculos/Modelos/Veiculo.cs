using System;

namespace GerenciadorVeiculos.Modelos
{
    // a classe Veiculo é abstrata pois serve de molde para carro e moto
    public abstract class Veiculo
    {
        // Propriedades: guardam informações do veículo
        public int ID { get; set; } 
        public string Modelo { get; set; }
        public decimal ValorDiaria { get; set; }

        // Método Construtor: inicializa, constroi a classe. Usado para preencher os dados ao criar o veiculo na memória

        // protected: porque não pode ser acessado fora da classe
        // veiculo: porque é o primeiro metodo quie vai buscar quando inicializar a classe
        // quando a variável começa com minúsculo, esta sendo recebia de algum lugar. Quando começa com maiúsculo, está sendo criada dentro da classe
        protected Veiculo(string modelo, decimal valorDiaria)
        {
            Modelo = modelo;
            ValorDiaria = valorDiaria;
        }

        // Método abstrato: toda classe filha é obrigada a ter esse cálculo
        public abstract decimal CalcularSeguro();
    }
}
