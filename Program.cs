namespace Aula10_CalculadoraSimples;

public class Program
{
    public static void Main()
    {
        bool continuar = true;
        {
            // Inicialização do programa
            Console.WriteLine("======================== Calculadora Simples ==============================");
            Console.WriteLine("Digite o primeiro número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            // Selecionar a operação
            Console.WriteLine("Escolha qual operação: ");
            Console.WriteLine("1 - Adição (+) ");
            Console.WriteLine("2 - Subtração (-) ");
            Console.WriteLine("3 - Multiplicação (x) ");
            Console.WriteLine("4 - Divisão (/) ");
            Console.WriteLine("Digite o número da operação: ");
            int operacao = Convert.ToInt32(Console.ReadLine());
            double result = 0;

            // Condições 

            if (operacao == 1)
            {
                result = num1 + num2;
            }
            else if (operacao == 2)
            {
                result = (num1 - num2);
            }
            else if (operacao == 3)
            {
                result = num1 * num2;
            }
            else if (operacao == 4)
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Não é possível dividir por 0");
                }

            }
            else
            {
                Console.WriteLine("Operação Inválida");
            }

            Console.WriteLine("\nResultado: " + result);
        }

        Console.WriteLine("\nDeseja realizar outra operação? (s/n) ");
        string response = Console.ReadLine();
        if (response != "s")
        {
            continuar = false;
        }

        Console.WriteLine("Fim do programa");
        
    }
}