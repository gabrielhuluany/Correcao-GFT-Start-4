using System;

class Program {
  public static void Main (string[] args) {
    ContaCorrente cc = new ContaCorrente();
    ContaPoupanca cp = new ContaPoupanca();

    cc.setNumero(001);
    cc.setTitular("Gabriel");
    cc.setSaldo(100);
    Console.WriteLine("Tipo da conta: " + cc.GetType());
    Console.WriteLine("Número da conta: " + cc.getNumero());
    Console.WriteLine("Títular da conta: " + cc.getTitular());
    Console.WriteLine("Saldo da conta: R$" + cc.getSaldo());
    Console.WriteLine("Rendimento: R$" + cc.Rendimento());
    Console.WriteLine("Imposto: R$" + cc.calcularImposto() + "\n");

    cp.setNumero(002);
    cp.setTitular("Gustavo");
    cp.setSaldo(100);
    Console.WriteLine("Tipo da conta: " + cp.GetType());
    Console.WriteLine("Número da conta: " + cp.getNumero());
    Console.WriteLine("Títular da conta: " + cp.getTitular());
    Console.WriteLine("Saldo da conta: R$" + cp.getSaldo());
    Console.WriteLine("Rendimento: R$" + cp.Rendimento());
    Console.WriteLine("Imposto: R$" + cp.calcularImposto() + "\n");

    Console.WriteLine("Pressione qualquer tecla para fechar esta janela...");
    Console.ReadKey();
  }
}