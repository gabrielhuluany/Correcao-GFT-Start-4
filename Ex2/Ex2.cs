using System;

class Program {
  public static void Main (string[] args) {
    Pessoa p = new Pessoa();

    p.setNome("Gabriel");
    p.setEndereco("Rua GFT, 404");
    p.setTelefone("(00) 90000-0000");
    Console.WriteLine("Nome: " + p.getNome());
    Console.WriteLine("Endereço: " + p.getEndereco());
    Console.WriteLine("Telefone: " + p.getTelefone() + "\n");

    Console.WriteLine("Pressione qualquer tecla para fechar esta janela...");
    Console.ReadKey();
  }
}