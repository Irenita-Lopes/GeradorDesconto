namespace GeradorDesconto
{
    internal static class ProcessadorDescontos
    {
        public static void Executar()
        {
            ExibirMensagem("Gerador de Descontos");

            ExibirMensagem("Digite o valor original do produto: ");
            decimal valorOriginal = ConverterParaDecimal(LerValor());

            ExibirMensagem("Informe o tipo do desconto: ");

            decimal porcentagemDesconto = BuscarPorcentagemDesconto();

            decimal valorDesconto = CalcularDesconto(valorOriginal, porcentagemDesconto);

            decimal valorFinal = valorOriginal - valorDesconto;

            ExibirMensagem($"Valor do Desconto: R$ {valorDesconto:F2}");
            ExibirMensagem($"Valor Final após Desconto: R$ {valorFinal:F2}");
        }

        private static void ExibirMensagem(string mensagem)
        {
            Console.WriteLine(mensagem);
        }

        private static decimal ConverterParaDecimal(string? entrada)
        {
            return Convert.ToDecimal(entrada);
        }

        private static string? LerValor()
        {
            return Console.ReadLine();
        }

        private static void ExibirOpcoesDesconto()
        {
            ExibirMensagem("1 - Desconto para Professores");
            ExibirMensagem("2 - Desconto para Funcionários Públicos");
            ExibirMensagem("3 - Desconto para PCD");
            ExibirMensagem("4 - Desconto para Pessoas Trans");
        }

        private static decimal BuscarPorcentagemDesconto()
        {
            ExibirOpcoesDesconto();

            string? opcao = LerValor();

            switch (opcao)
            {
                case "1":
                    return 15; // Desconto para Professores
                case "2":
                    return 10; // Desconto para Funcionários Públicos
                case "3":
                    return 20; // Desconto para PCD
                case "4":
                    return 25; // Desconto para Pessoas Trans
                default:
                    return 0; // Sem desconto

            }
        }

        private static decimal CalcularDesconto(decimal valorOriginal, decimal porcentagemDesconto)
        {
            return (valorOriginal * porcentagemDesconto) / 100;
        }


    }
}
