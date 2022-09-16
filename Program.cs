/*
string tipo = "C6PO";
robos robo;

if (tipo.Equals("C6PO"))
    robo = new C6PO();
else if (tipo.Equals("Bumblebee"))
    robo = new Bumblebee();
else if (tipo.Equals("Optimus_Prime"))
    robo = new Optimus_Prime();

//Class fabrica fará este processo, apresentar código de escolha no program.cs
*/

public enum EDirecaoAndar{
    Frente,
    Traz,
    Esquerda,
    Direita
}

public enum EGirar{
    Esquerda,
    Direita
}

public enum EModo{
    veiculo,
    robo
}

public enum ERobos{
    C6PO,
    Optimus_Prime,
    Bumblebee
}