
public abstract class Veiculo
    {
        protected int Velocidade;

        public abstract void Acelerar();
        public abstract void Frear();

        public void ExibirVelocidade()
        {
            Console.WriteLine($"A velocidade atual do veículo é: {Velocidade}");
        }
    }
