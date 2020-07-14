using System;

namespace BaseNumericaCMD
{
    class Program
    {
        static void Main(string[] args)
        {
            int repeat = 1; //Se o processo deve ser repetido do zero ou finalizado.
            Console.WriteLine("~~CALCULADORA COM BASES NUMÉRICAS~~");
            Console.WriteLine("(Este software só trabalha com as bases 2, 8, 10 e 16.");
            Console.WriteLine("");

            while (repeat == 1) {

                int op = 0; //Operaçao que define a funçao.
                string snum1 = "0";
                int num1 = 0;
                int basenum1 = 0;
                string snum2 = "0";
                int basenum2 = 0;
                int basenumr = 0;

                Console.WriteLine("Oque deseja fazer?");
                Console.WriteLine("1. Converter Base.");
                Console.WriteLine("2. Somar.");
                Console.WriteLine("3. Subtrair.");
                Console.WriteLine("4. Multiplicar.");
                Console.WriteLine("5. Dividir.");

                op = Convert.ToInt32(Console.ReadLine());
                if (op < 1 | op > 5)
                {
                    Console.WriteLine("Escolha um valor de 1 a 5.");
                }
                if (op == 1) //Conversor de bases.
                {
                    Console.WriteLine("Digite o número que gostaria de converter.");
                    snum1 = Console.ReadLine();
                    Console.WriteLine("Em qual base esse número está?");
                    basenum1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite a base para que gostaria que ele fosse convertido.");
                    int segundabase = Convert.ToInt32(Console.ReadLine());

                    num1 = Convert.ToInt32(snum1, basenum1);
                    if (segundabase == 10)
                    {
                        Console.WriteLine("Resultado da conversão: " + num1);
                    } else
                    {
                        snum1 = Convert.ToString(num1, segundabase);
                        Console.WriteLine("Resultado da conversão: " + snum1);
                    }
                    Console.WriteLine("Deseja fazer outra operação?");
                    Console.WriteLine("1. Sim.");
                    Console.WriteLine("0. Não.");
                    repeat = Convert.ToInt32(Console.ReadLine());
                }

                if (op == 2) //Somar
                {
                    Console.WriteLine("~~SOMA~~");
                    Console.WriteLine("Digite o primeiro número:");
                    snum1 = Console.ReadLine();
                    Console.WriteLine("Digite a base deste número:");
                    basenum1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite o segundo número:");
                    snum2 = Console.ReadLine();
                    Console.WriteLine("Digite a base do segundo número:");
                    basenum2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite a base do resultado: ");
                    basenumr = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("");
                    Console.WriteLine(snum1+"("+basenum1+")"+" + "+snum2+"("+basenum2+")"+" = ");

                    int r = Convert.ToInt32(snum1, basenum1) + Convert.ToInt32(snum2, basenum2);
                    string sr = Convert.ToString(r, basenumr);
                    Console.WriteLine(sr+"("+basenumr+")");
                    Console.WriteLine("");

                    Console.WriteLine("Deseja fazer outra operação?");
                    Console.WriteLine("1. Sim.");
                    Console.WriteLine("0. Não.");
                    repeat = Convert.ToInt32(Console.ReadLine());
                }
                if (op == 3) //Subtrair
                {
                    Console.WriteLine("~~SUBTRAÇÃO~~");
                    Console.WriteLine("Digite o primeiro número:");
                    snum1 = Console.ReadLine();
                    Console.WriteLine("Digite a base deste número:");
                    basenum1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite o segundo número:");
                    snum2 = Console.ReadLine();
                    Console.WriteLine("Digite a base do segundo número:");
                    basenum2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite a base do resultado: ");
                    basenumr = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("");
                    Console.WriteLine(snum1 + "(" + basenum1 + ")" + " - " + snum2 + "(" + basenum2 + ")" + " = ");

                    int r = Convert.ToInt32(snum1, basenum1) - Convert.ToInt32(snum2, basenum2);
                    string sr = Convert.ToString(r, basenumr);
                    Console.WriteLine(sr + "(" + basenumr + ")");
                    Console.WriteLine("");

                    Console.WriteLine("Deseja fazer outra operação?");
                    Console.WriteLine("1. Sim.");
                    Console.WriteLine("0. Não.");
                    repeat = Convert.ToInt32(Console.ReadLine());
                }
                if (op == 4) //Multiplicar
                {
                    Console.WriteLine("~~MULTIPLICAÇÃO~~");
                    Console.WriteLine("Digite o primeiro número:");
                    snum1 = Console.ReadLine();
                    Console.WriteLine("Digite a base deste número:");
                    basenum1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite o segundo número:");
                    snum2 = Console.ReadLine();
                    Console.WriteLine("Digite a base do segundo número:");
                    basenum2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite a base do resultado: ");
                    basenumr = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("");
                    Console.WriteLine(snum1 + "(" + basenum1 + ")" + " x " + snum2 + "(" + basenum2 + ")" + " = ");

                    int r = Convert.ToInt32(snum1, basenum1) * Convert.ToInt32(snum2, basenum2);
                    string sr = Convert.ToString(r, basenumr);
                    Console.WriteLine(sr + "(" + basenumr + ")");
                    Console.WriteLine("");

                    Console.WriteLine("Deseja fazer outra operação?");
                    Console.WriteLine("1. Sim.");
                    Console.WriteLine("0. Não.");
                    repeat = Convert.ToInt32(Console.ReadLine());
                }
                if (op == 5) //Dividr
                {
                    Console.WriteLine("~~DIVISÃO~~");
                    Console.WriteLine("Digite o primeiro número:");
                    snum1 = Console.ReadLine();
                    Console.WriteLine("Digite a base deste número:");
                    basenum1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite o segundo número:");
                    snum2 = Console.ReadLine();
                    Console.WriteLine("Digite a base do segundo número:");
                    basenum2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite a base do resultado: ");
                    basenumr = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("");
                    Console.WriteLine(snum1 + "(" + basenum1 + ")" + " / " + snum2 + "(" + basenum2 + ")" + " = ");

                    int r = Convert.ToInt32(snum1, basenum1) / Convert.ToInt32(snum2, basenum2);
                    string sr = Convert.ToString(r, basenumr);
                    Console.WriteLine(sr + "(" + basenumr + ")");
                    Console.WriteLine("");

                    Console.WriteLine("Deseja fazer outra operação?");
                    Console.WriteLine("1. Sim.");
                    Console.WriteLine("0. Não.");
                    repeat = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Obrigado por usar o conversor!");
        }
    }
}
