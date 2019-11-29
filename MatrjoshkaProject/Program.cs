using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrjoshkaProject
{
    class Program
    {

        class Matrjoshka //CLASS
        {

            //OMADUSED
            public static int Count = 0;
            string name;
            string color;
            int size;
            string image;

            public Matrjoshka(string _name, string _color, int _size, string _image) //KONSTRUKTOR
            {
                name = _name;
                color = _color;
                Size = _size;
                image = _image;
                Count++;





            }

            public string Name
            {
                get { return name; }
            }
            public string Color
            {
                get { return color; }
            }
            


            public int Size
            {
                get { return size; }
                set
                {
                    if (value > 0 && value <= 10)
                    {
                        size = value;
                    }
                    else
                    {
                        size = 1;
                    }
                }
            }

            public Matrjoshka OpenMatrjoshka(string name, string color, string image) //MEETOD-mida teeb
            {
                Matrjoshka temporaryMatrjoshka = new Matrjoshka(name, color, size - 2, image);
                return temporaryMatrjoshka; //Ajutine värk
            }

            public string Image
            {
                get { return image; }
            }
            static void Main(string[] args)
            {
                //Salvestad matrjoshkad "KARPI" ehk Listi sisse!

                List<Matrjoshka> boxOfMatrjoshkas = new List<Matrjoshka>();

                //Salvestatud eraldi muutuja sisse. boxOfMatrjoshkas siis muutuja????
                Matrjoshka matrjoshka1 = new Matrjoshka("Matrjoshka1", "green", 10, "image1");
                boxOfMatrjoshkas.Add(matrjoshka1);

                //Open Matrjoshkas
                Matrjoshka matrjoshka2 = matrjoshka1.OpenMatrjoshka("Matrjoshka2", "yellow", "image2");
                boxOfMatrjoshkas.Add(matrjoshka2);

                Matrjoshka matrjoshka3 = matrjoshka2.OpenMatrjoshka("Matrjoshka3", "purple", "image3");
                boxOfMatrjoshkas.Add(matrjoshka3);


                Matrjoshka matrjoshka4 = matrjoshka3.OpenMatrjoshka("Matrjoshka4", "red", "image4");
                boxOfMatrjoshkas.Add(matrjoshka4);

                Matrjoshka matrjoshka5 = matrjoshka4.OpenMatrjoshka("Matrjoshka5", "blue", "image5");
                boxOfMatrjoshkas.Add(matrjoshka5);

                //KUVAMINE LISTIST
                foreach (Matrjoshka matrjoshka in boxOfMatrjoshkas)
                {
                    Console.WriteLine($"A {matrjoshka.Color} {matrjoshka.Name} size {matrjoshka.Size} is in the box");
                }
                Console.WriteLine($"There are {Matrjoshka.Count} matrjoshkas in the box");


                //KÜSID KASUTAJALT, MIS VÄRVI MATRJOSHKAT KASUTAJA SOOVIB LEIDA JA SIIS KUSTUTAD SELLE LISTIST.
                Console.WriteLine("What color matrjoshka you want to find?");
                string userColor = Console.ReadLine();

                //ForLoop
                
                for (int i = 0; i<boxOfMatrjoshkas.Count; i++ )
                { 
                    //Leia värv
                    if(boxOfMatrjoshkas[i].Color == userColor)
                    {
                        Console.WriteLine($"You have taken {boxOfMatrjoshkas[i].Name} from the box");
                        boxOfMatrjoshkas.Remove(boxOfMatrjoshkas[i]); //Eemalda värv/matrjoshka listist
                        Matrjoshka.Count--;
                        break;
                    }
                }

                Console.WriteLine();

                //Kuva värske list uuesti, kus seda eemaldatud asja pole
                foreach(Matrjoshka matrjoshka in boxOfMatrjoshkas)
                {
                    Console.WriteLine($"Name: {matrjoshka.Name}, color {matrjoshka.Color} is left in the box");
                }

                Console.WriteLine($"There are {Matrjoshka.Count} matrjoshkas left in the box");

                Console.ReadLine();
            }
        }
    }
}