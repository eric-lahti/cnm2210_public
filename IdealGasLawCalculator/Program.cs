// See https://aka.ms/new-console-template for more information
using System;
using System.IO;

namespace GasLaws
{
    class IdealGasLawCalculator
    {
        static void Main(string[] args)
        {
            string filePath = "Files/MolecularWeightsGasesAndVapors.csv";

            List<Gasses> gasses = GetGasses(filePath);
            int TotalGasses = gasses.Count;

            Console.WriteLine(TotalGasses.ToString() + " Gasses");

            /*
            foreach(Gasses gas in gasses)
            {
                Console.WriteLine("Name: {0}, weight: {1}", gas.GasName, gas.Weight);
            }
            */

            DisplayGasNames(gasses);

            double gasWeight = GetWeight("Butadiene", gasses);
            Console.WriteLine("Butadiene weighs: " + gasWeight.ToString());
            double PressureInPascals = GetPascals(10.0, gasWeight);
            Console.WriteLine("Pressure in Pascals: " + PressureInPascals.ToString());

        }

        static List<Gasses> GetGasses(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            List<Gasses> gasses = new List<Gasses>();
            foreach(string line in lines)
            {
                if(line == lines[0])
                {
                    continue;
                }
                string[] lineSplit = line.Split(',');
                Gasses gas = new Gasses();
                gas.GasName = lineSplit[0];
                gas.Weight = double.Parse(lineSplit[1]);
                gasses.Add(gas);
            }
            return gasses;
        }

        static void DisplayGasNames(List<Gasses> gasses)
        {
            int count = gasses.Count;
            int perColumn = count / 3;
            for (int x = 0; x <= perColumn; x++)
            {
                int ColA = x;
                int ColB = x + perColumn;
                int ColC = x + (perColumn * 2);
                int padVal = 30;
                if(ColC < count)
                {
                    Console.WriteLine($"{gasses[ColA].GasName.PadRight(padVal)} | {gasses[ColB].GasName.PadRight(padVal)} | {gasses[ColC].GasName.PadRight(padVal)}");
                }
                else
                {
                    Console.WriteLine($"{gasses[ColA].GasName.PadRight(padVal)} | {gasses[ColB].GasName.PadRight(padVal)}");
                }
            }
        }

        static double GetWeight(string GasName, List<Gasses> gasses)
        {
            var result = gasses.Find(item => item.GasName == GasName);
            return result.Weight;
        }

        static double GetKelvin(double Celsius)
        {
            return Celsius + 273.15;
        }

        static double GetVolume(double Meters)
        {
            return Meters * Meters * Meters;
        }

        static double GetMoles(double MassGas, double MolWeightOfGas)
        {
            return MassGas / MolWeightOfGas;
        }

        static double GetPascals(double MassGas, double MolWeightOfGas)
        {
            //P = nRT/V
            //P = pressure in Pascals
            //n = moles
            //R = ideal constant (8.314)
            //V = Volume
            //T = Temp in Kelvin

            double moles = GetMoles(MassGas, MolWeightOfGas);
            double R = 8.314;
            double volume = GetVolume(6);
            double temperature = GetKelvin(32);

            double PressureInPascals = (moles * R * temperature) / volume;
            return PressureInPascals;

        }
    }

    public class Gasses
    {
        public string GasName{get;set;}
        public double Weight{get;set;}
    }
}
