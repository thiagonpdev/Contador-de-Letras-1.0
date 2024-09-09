namespace Contador_de_letras
{
    class Program
    {
        static void Main(string[] args)
        {
            string linha = string.Empty;

            Console.WriteLine("Digite uma palavra ou texto: ");
            string texto = Console.ReadLine()!;
            Console.WriteLine(linha);
            
            Console.WriteLine("Digite a letra que deseja contar: ");
            char letraProcurada = Console.ReadLine()![0];
            Console.WriteLine(linha);

            texto = texto.ToLower();
            letraProcurada = char.ToLower(letraProcurada);

            int quantidadeDeLetras = texto.Count(c => c == letraProcurada);

            Console.WriteLine("A letra '" + letraProcurada + "' aparece " + quantidadeDeLetras + " vezes no texto.");
        }
    }
}