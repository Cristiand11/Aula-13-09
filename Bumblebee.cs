public class Bumblebee : robos{

    public Bumblebee(){
        this.nome = "Bumblebee";
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
                    this.Girar(EGirar.Direita, 1);
                    this.andar(EDirecaoAndar.Esquerda, 2);
                    this.andar(EDirecaoAndar.Frente, 1);
                break;

            case 2:
                if (this.Modo == EModo.veiculo)
                    this.Transformar();
                    this.andar(EDirecaoAndar.Frente, 15);
                    this.andar(EDirecaoAndar.Direita, 4);
                    this.Girar(EGirar.Direita, 180);
                    this.andar(EDirecaoAndar.Frente, 2);
                break;

            case 3:
                if (this.Modo == EModo.veiculo)
                    this.Transformar();
                    Console.WriteLine("{0} fez alguns passos de samba.", this.nome);
                break;
        }
    }
}