using System;

public class ContaPoupanca : Conta {
    

    public ContaPoupanca() {
        
    }

    public void setNumero(int valor) {
        this.numero = valor;
    }

    public int getNumero() {
        return numero;
    }

    public void setTitular(String valor) {
        this.titular = valor;
    }

    public String getTitular() {
        return titular;
    }

    public void setSaldo(double valor) {
        this.saldo = valor;
    }

    public double getSaldo() {
        return saldo;
    }

    public override double Rendimento() {
        return saldo * 0.05;
    }

    public override double calcularImposto() {
        return (saldo * 0.05) * 0.10;
    }
}