using System;

public class Pessoa {
  protected String nome { get; set; }
  protected String endereco { get; set; }
  protected String telefone { get; set; }
  
  public Pessoa() {
    
  }

  public void setNome(String valor) {
      this.nome = valor;
  }

  public String getNome() {
      return nome;
  }

  public void setEndereco(String valor) {
      this.endereco = valor;
  }

  public String getEndereco() {
      return endereco;
  }

  public void setTelefone(String valor) {
      this.telefone = valor;
  }

  public String getTelefone() {
      return telefone;
  }
}