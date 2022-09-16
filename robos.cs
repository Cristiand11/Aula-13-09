public abstract class robos{

    protected String nome { get; set; }
    protected EModo Modo { get; set; }

    public void andar(EDirecaoAndar Direcao, int passos){
    Console.WriteLine("O robo {0} está andando para {1} {2} passo(s)",
     this.nome, Direcao.ToString(), passos);
    }

    public void Girar(EGirar Movimento, int grau){
    Console.WriteLine("O robo {0} está girando para {1} {2}º",
     this.nome, Movimento.ToString(), grau);
    }

    public abstract void Transformar();
    public abstract void Script(int Numero);
}