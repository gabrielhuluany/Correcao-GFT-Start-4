using System;
using System.Collections.Generic;
using System.Linq;

class Program {
  public static void Main (string[] args) {
    bool sucesso = false;
    List<int> lista = new List<int>();
    List<int> impares = new List<int>();

    while(!sucesso) {
      Console.Write("Digite o valor inicial e o valor final do intervalo: ");
      lista = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

      if(lista[0] < 0) {
        Console.Write("Digite um valor inicial maior ou igual a 0!\n");
        sucesso = false;
      }

      if(lista[0] > lista[1]) {
        Console.Write("Digite um valor inicial menor ou igual ao valor final!\n");
        sucesso = false;
      }

      if(lista[0] >= 0 && lista[0] <= lista[1]) {
        //Console.WriteLine("[" + lista[0] + "," + lista[1] + "]\n");
        sucesso = true;
      }
    }

    for(int i = 0; i <= (lista[1] - lista[0]); i++) {
      if((lista[0] + i) % 2 != 0) {
        impares.Add((lista[0] + i));
      }
    }

    Console.WriteLine("{0}", string.Join(" ", impares));
    Console.WriteLine("\n");

    Console.WriteLine("Pressione qualquer tecla para fechar esta janela...");
    Console.ReadKey();
  }
}