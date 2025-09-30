public class CartaoDebito : Cartao{

    public override void Debitar(decimal valor){

        Console.WriteLine("Chamando classe base");
        base.Debitar(valor);

        Console.WriteLine("Chamando sobrescrita...");
        Console.WriteLine($"Compra {valor:C} realizada no cartão de débito.");
    }
}