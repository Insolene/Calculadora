namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual operação deseja fazer?");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiply");
            Console.WriteLine("4 - Divide");

            double operationId = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro número:");
            double firstNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            double secondNumber = double.Parse(Console.ReadLine());

            double result = 0;

            switch (operationId)
            {
                case 1:
                    {
                        result = Sum(firstNumber, secondNumber);
                        break;
                    }
                case 2:
                    {
                        result = Subtract(firstNumber, secondNumber);
                        break;
                    }
                case 3:
                    {
                        result = Multiply(firstNumber, secondNumber);
                        break;
                    }
                case 4:
                    {
                        result = Divide(firstNumber, secondNumber);
                        break;
                    }     
            }
            

        Console.WriteLine("O result é: " + result);
            Console.ReadLine(); 
        }

        public static double Sum(double firstNumber, double secondNumber)
        {
            double result = firstNumber + secondNumber;
            return result;
        }

        public static double Subtract(double firstNumber, double secondNumber)
        {
            double result = firstNumber - secondNumber;
            return result;
        }

        public static double Multiply(double firstNumber, double secondNumber)
        {
            double result = firstNumber * secondNumber;
            return result;
        }
        public static double Divide(double firstNumber, double secondNumber)
        {
            double result = firstNumber / secondNumber;
            return result;
        }
    }
}   