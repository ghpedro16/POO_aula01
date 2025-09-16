public class CartaoDebito
{

    public CartaoDebito()
    {
        Bandeira = BandeiraCartao.Visa;
    }

    public string Numero { get; set; }
    public BandeiraCartao Bandeira { get; set; }
    public DateTime Vencimento { get; set; }
    public string Cvv { get; set; }
    public string Portador { get; set; }

    public decimal Saldo { get; set; }
    public decimal Limite { get; set; }

    public bool Debitar(decimal valor)
    {
        if (valor > Saldo)
            return false;

        Saldo -= valor;
        return true;
    }

    public bool Debitar(decimal valor, bool usarLimite)
    {
        
    }
}

public enum BandeiraCartao
{
    Visa,
    Mastercard,
    Amex,
    Elo
}

