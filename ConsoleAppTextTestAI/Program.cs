using System;
using ConsoleAppTextTestAIML.Model;

namespace ConsoleAppTextTestAI
{
    class Program
    {
        static void Main(string[] args)
        {
            string userdata = Console.ReadLine();

            // Add input data
            var input = new ModelInput();
            input.Email = userdata;

            // Load model and predict output of sample data
            ModelOutput result = ConsumeModel.Predict(input);

            Console.WriteLine(result.Prediction);
        }
    }
}