using MainLib.Entities;
using System;
using System.Text.Json;

namespace ExperimentConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var testJson = File.ReadAllText(@"C:\Users\lukas.josai\Downloads\sample_resume.json.txt");

            var resume = JsonSerializer.Deserialize<Resume>(testJson);

            //TODO: Make serialisation and deserialisation with schema verification into a test
            File.WriteAllText(@"C:\Users\lukas.josai\Downloads\sample_resume_resaved.json", JsonSerializer.Serialize(resume));

            Console.WriteLine(testJson);
        }
    }
}