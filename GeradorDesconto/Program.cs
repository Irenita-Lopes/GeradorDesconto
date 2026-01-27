class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Gerador de Descontos");
        
  
        Console.Write("Digite o valor original do produto: ");
        decimal valorOriginal = Convert.ToDecimal(Console.ReadLine());
        
        Console.Write("Digite a porcentagem de desconto (ex: 10 para 10%): ");
        decimal porcentagemDesconto = Convert.ToDecimal(Console.ReadLine());
        
        decimal valorDesconto = (valorOriginal * porcentagemDesconto) / 100;
        
        decimal valorFinal = valorOriginal - valorDesconto;
        
        Console.WriteLine($"Valor do Desconto: R$ {valorDesconto:F2}");
        Console.WriteLine($"Valor Final após Desconto: R$ {valorFinal:F2}");
    }
}