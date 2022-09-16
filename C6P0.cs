public class C6PO : robos{
    public C6PO(){
    this.nome = "C6PO";
    this.Modo = EModo.robo;
    }

    public override void Transformar(){
    Console.WriteLine("{0} não tem opção de se transformar!", this.nome);
    //this.Modo = (this.Modo == EModo.veiculo ? EModo.robo : EModo.veiculo);
    }

    public override void Script(int Numero){
        this.andar(EDirecaoAndar.Frente, 20);
        this.Girar(EGirar.Esquerda, 90);
        this.andar(EDirecaoAndar.Frente, 100);
        this.Girar(EGirar.Direita, 19);
    }
}