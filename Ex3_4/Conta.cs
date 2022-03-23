using System;

public abstract class Conta : Imposto {
    protected int numero { get; set; }
    protected String titular { get; set; }
    protected double saldo { get; set; }

    public Conta() {

    }

    public abstract double Rendimento();
    public abstract double calcularImposto();

}