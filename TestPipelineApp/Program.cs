using System;

namespace TestPipelineApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator(5, 5, Calculator.Operation.Add);
            Console.WriteLine(calculator.GetResult());
            calculator.NewOperation = Calculator.Operation.Subtract;
            Console.WriteLine(calculator.GetResult());
            calculator.NewOperation = Calculator.Operation.Multiply;
            Console.WriteLine(calculator.GetResult());
            calculator.NewOperation = Calculator.Operation.Divide;
            Console.WriteLine(calculator.GetResult());
            Console.ReadLine();
        }
    }
}
