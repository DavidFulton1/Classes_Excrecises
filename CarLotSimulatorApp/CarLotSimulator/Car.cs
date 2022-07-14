using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    internal class Car
    {
        public Car() 
        { 
        }
        public int Year { get; set; }
        public String Make { get; set; }
        public String Model { get; set; }
        public bool IsDrivable { get; set; }
        public String EngineNoise { get; set; }
        public String HonkNoise { get; set; }
    
    
    public static void MakeEngineNoise(string EngineNoise)
        {if (EngineNoise=="cool")
            {
                Console.WriteLine("VVVVRRROOOOOOOOOOM");
            }

            else
            {
                Console.WriteLine("sad vroom");
            }
        }
    
    public static void MakeHonkNoise(string HonkNoise)
        {if (HonkNoise == "cool")
            {
                Console.WriteLine("La Cucaracha");
            }
            else
            {
                Console.WriteLine("BEEP");
            }

        }
    
    
    }








}


