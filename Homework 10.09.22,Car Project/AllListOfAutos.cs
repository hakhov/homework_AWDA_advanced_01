
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop
{
    public class AllListOfAutos : StandartAuto
    {
        protected List<StandartAuto> Audi = new List<StandartAuto>();
        protected List<StandartAuto> BMW = new List<StandartAuto>();
        protected List<StandartAuto> Honda = new List<StandartAuto>();


        public void SetData()
        {
            Audi.Add(new StandartAuto { ModelColor = "Black", ModelMark = "Audi", OwnName = "Q5", ModelPower = "350 horsepower", ModelPrice = "43000", CountofAvailables = "56", ID = "45 TFSI" });
            Audi.Add(new StandartAuto { ModelColor = "Red", ModelMark = "Audi", OwnName = "Q5", ModelPower = "350 horsepower", ModelPrice = "43000", CountofAvailables = "44", ID = "45 TFKM" });
            Audi.Add(new StandartAuto { ModelColor = "Green", ModelMark = "Audi", OwnName = "Q5", ModelPower = "350 horsepower", ModelPrice = "43000", CountofAvailables = "31", ID = "45 TFSI" });
            Audi.Add(new StandartAuto { ModelColor = "Blue", ModelMark = "Audi", OwnName = "SQ7", ModelPower = "610 horsepower", ModelPrice = "89000", CountofAvailables = "11", ID = "45 TFSI" });
            Audi.Add(new StandartAuto { ModelColor = "Pink", ModelMark = "Audi", OwnName = "SQ7", ModelPower = "610 horsepower", ModelPrice = "89000", CountofAvailables = "30", ID = "45 TFSI" });
            Audi.Add(new StandartAuto { ModelColor = "Yellow", ModelMark = "Audi", OwnName = "SQ7", ModelPower = "610 horsepower", ModelPrice = "89000", CountofAvailables = "114", ID = "46 TFSI" });
            Audi.Add(new StandartAuto { ModelColor = "Dark Blue", ModelMark = "Audi", OwnName = "Q7", ModelPower = "500 horsepower", ModelPrice = "89000", CountofAvailables = "59", ID = "47 TFSI" });
            Audi.Add(new StandartAuto { ModelColor = "Dark Green", ModelMark = "Audi", OwnName = "Q7", ModelPower = "500 horsepower", ModelPrice = "89000", CountofAvailables = "62", ID = "51 TFSI" });
            Audi.Add(new StandartAuto { ModelColor = "Dark Silver", ModelMark = "Audi", OwnName = "Q7", ModelPower = "500 horsepower", ModelPrice = "89000", CountofAvailables = "22", ID = "56 TFSI" });


            BMW.Add(new StandartAuto { ModelColor = "Black", ModelMark = "BMW", OwnName = "i4", ModelPower = "340 horsepower", ModelPrice = "53400", CountofAvailables = "74", ID = "35  EDR" });
            BMW.Add(new StandartAuto { ModelColor = "Green", ModelMark = "BMW", OwnName = "i4", ModelPower = "340 horsepower", ModelPrice = "53400", CountofAvailables = "58", ID = "35  EDK" });
            BMW.Add(new StandartAuto { ModelColor = "White", ModelMark = "BMW", OwnName = "i4", ModelPower = "340 horsepower", ModelPrice = "53400", CountofAvailables = "81", ID = "35  EDM" });
            BMW.Add(new StandartAuto { ModelColor = "Pink", ModelMark = "BMW", OwnName = "i7", ModelPower = "536 horsepower", ModelPrice = "108300", CountofAvailables = "26", ID = "50 SDL" });
            BMW.Add(new StandartAuto { ModelColor = "Red", ModelMark = "BMW", OwnName = "i7", ModelPower = "536 horsepower", ModelPrice = "108300", CountofAvailables = "31", ID = "51 SDL" });
            BMW.Add(new StandartAuto { ModelColor = "Purple", ModelMark = "BMW", OwnName = "i7", ModelPower = "536 horsepower", ModelPrice = "108300", CountofAvailables = "39", ID = "53 SDL" });

            Honda.Add(new StandartAuto { ModelColor = "Purple", ModelMark = "Honda", OwnName = "Pilot", ModelPower = "280 horsepower", ModelPrice = "38000", CountofAvailables = "39", ID = "53 SDL" });
            Honda.Add(new StandartAuto { ModelColor = "White", ModelMark = "Honda", OwnName = "Pilot", ModelPower = "280 horsepower", ModelPrice = "38000", CountofAvailables = "41", ID = "53 SDL" });
            Honda.Add(new StandartAuto { ModelColor = "Silver", ModelMark = "Honda", OwnName = "Pilot", ModelPower = "280 horsepower", ModelPrice = "138000", CountofAvailables = "49", ID = "53 SDL" });
            Honda.Add(new StandartAuto { ModelColor = "Black", ModelMark = "Honda", OwnName = "HR_V", ModelPower = "158 horsepower", ModelPrice = "23600", CountofAvailables = "139", ID = "53 SDL" });
            Honda.Add(new StandartAuto { ModelColor = "Blue", ModelMark = "Honda", OwnName = "HR_v", ModelPower = "158 horsepower", ModelPrice = "23600", CountofAvailables = "30", ID = "53 SDL" });
        }


        private string MarkChoice;
        private string PriceChoice;
        private string End;

        //public void EnterYourRequest()
        //{
        //    Console.WriteLine("Welcome,please enter your favorite mark of car and max admittable price for you");
        //    Console.WriteLine("Marks available in our shop are BMW,Audi,Honda");
        //    Console.WriteLine("We will present you all available models");
        //    Console.Write("your favorie mark is:");
        //    MarkChoice = Console.ReadLine();
        //    Console.Write("your max price is:");
        //    PriceChoice=Console.ReadLine();
        //}

        //public void ShowTheAnswer()
        //{
        //    Console.WriteLine("models requesting your requirements are");
        //    foreach(StandartAuto item in Audi)
        //    {
        //        if(MarkChoice==item.ModelMark && int.Parse(item.ModelPrice) <= int.Parse(PriceChoice))
        //        {
        //            Console.WriteLine($"ModelColor = {item.ModelColor}, ModelMark = {item.ModelMark}, OwnName = {item.OwnName}, ModelPower = {item.ModelPower}, ModelPrice = {item.ModelPrice}, CountofAvailables = {item.CountofAvailables}, ID = {item.ID} ");
        //        }
        //    }
        //    foreach (StandartAuto item in BMW)
        //    {
        //        if (MarkChoice == item.ModelMark && int.Parse(item.ModelPrice) <= int.Parse(PriceChoice))
        //        {
        //            Console.WriteLine($"ModelColor = {item.ModelColor}, ModelMark = {item.ModelMark}, OwnName = {item.OwnName}, ModelPower = {item.ModelPower}, ModelPrice = {item.ModelPrice}, CountofAvailables = {item.CountofAvailables}, ID = {item.ID} ");
        //        }
        //    }
        //    foreach (StandartAuto item in Honda)
        //    {
        //        if (MarkChoice == item.ModelMark && int.Parse(item.ModelPrice) <= int.Parse(PriceChoice))
        //        {
        //            Console.WriteLine($"ModelColor = {item.ModelColor}, ModelMark = {item.ModelMark}, OwnName = {item.OwnName}, ModelPower = {item.ModelPower}, ModelPrice = {item.ModelPrice}, CountofAvailables = {item.CountofAvailables}, ID = {item.ID} ");
        //        }
        //    }
        //}

        public void EnterRequestAndShowingData()
        {
            do
            {
                Console.WriteLine("Welcome,please enter your favorite mark of car and max admittable price for you");
                Console.WriteLine("Marks available in our shop are BMW,Audi,Honda");
                Console.WriteLine("We will present you all available models");
                Console.Write("your favorie mark is:");
                MarkChoice = Console.ReadLine();
                Console.Write("your max price is:");
                PriceChoice = Console.ReadLine();

                Console.WriteLine("models requesting your requirements are");
                foreach (StandartAuto item in Audi)
                {
                    if (MarkChoice == item.ModelMark && int.Parse(item.ModelPrice) <= int.Parse(PriceChoice))
                    {
                        Console.WriteLine($"ModelColor = {item.ModelColor}, ModelMark = {item.ModelMark}, OwnName = {item.OwnName}, ModelPower = {item.ModelPower}, ModelPrice = {item.ModelPrice}, CountofAvailables = {item.CountofAvailables}, ID = {item.ID} ");
                    }
                }
                foreach (StandartAuto item in BMW)
                {
                    if (MarkChoice == item.ModelMark && int.Parse(item.ModelPrice) <= int.Parse(PriceChoice))
                    {
                        Console.WriteLine($"ModelColor = {item.ModelColor}, ModelMark = {item.ModelMark}, OwnName = {item.OwnName}, ModelPower = {item.ModelPower}, ModelPrice = {item.ModelPrice}, CountofAvailables = {item.CountofAvailables}, ID = {item.ID} ");
                    }
                }
                foreach (StandartAuto item in Honda)
                {
                    if (MarkChoice == item.ModelMark && int.Parse(item.ModelPrice) <= int.Parse(PriceChoice))
                    {
                        Console.WriteLine($"ModelColor = {item.ModelColor}, ModelMark = {item.ModelMark}, OwnName = {item.OwnName}, ModelPower = {item.ModelPower}, ModelPrice = {item.ModelPrice}, CountofAvailables = {item.CountofAvailables}, ID = {item.ID} ");
                    }
                }

                Console.WriteLine("if you make your choice ,enter close,else type something and we will show you other models");
                End = Console.ReadLine();
            }
            while (End != "close");
        }
    }
}
