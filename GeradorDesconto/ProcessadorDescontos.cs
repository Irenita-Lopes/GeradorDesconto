namespace GeradorDesconto
{
    internal static class ProcessadorDescontos
    {
        public static void Executar()
        {
            ExibirMensagem("Gerador de Descontos");
            
            ExibirMensagem("Digite o valor original do produto: ");
            decimal valorOriginal = LerValor();
            
            ExibirMensagem("Digite a porcentagem de desconto (ex: 10 para 10%): ");
   
            decimal porcentagemDesconto = LerValor();
            
            decimal valorDesconto = CalcularDesconto(valorOriginal, porcentagemDesconto);
            
            decimal valorFinal = valorOriginal - valorDesconto;
            
            ExibirMensagem($"Valor do Desconto: R$ {valorDesconto:F2}");
            ExibirMensagem($"Valor Final após Desconto: R$ {valorFinal:F2}");
        }
       
        private static decimal LerValor()
        {
            return Convert.ToDecimal(Console.ReadLine());
        }

        private static void ExibirMensagem(string mensagem)
        {
            Console.WriteLine(mensagem);
        }

        private static decimal CalcularDesconto(decimal valorOriginal, decimal porcentagemDesconto)
        {
            return (valorOriginal * porcentagemDesconto) / 100;
        }
    }
}
