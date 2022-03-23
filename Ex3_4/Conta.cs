using System;

public abstract class Conta : Imposto {
    protected int numero;
    protected String titular;
    protected double saldo;

    public Conta() {

    }

    public abstract double Rendimento();
    public abstract double calcularImposto();
}