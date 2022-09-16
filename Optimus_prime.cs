public class Optimus_Prime : robos{
    
    public Optimus_Prime(){
        this.nome = "Optimus_Prime";
        this.Modo = EModo.veiculo;
    }

    public override void Transformar(){
        this.Modo = (this.Modo == EModo.veiculo ? EModo.robo : EModo.veiculo);

        Console.WriteLine("{0} em modo {1}", this.nome, this.Modo.ToString());
    }

    public override void Script(int Numero){
        switch (Numero){
            case 1:
                if (this.Modo == EModo.veiculo)
                    this.Transformar();
                    this.Girar(EGirar.Esquerda, 25);
                    this.andar(EDirecaoAndar.Esquerda, 2);
                    this.andar(EDirecaoAndar.Frente, 10);
                break;
        }
    }
}