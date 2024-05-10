using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars_9A_24
{
    internal class Car
    {
		private string mark;
		private string model;
		private int regNum;
		private int yearOfMaking;

		public int YearOfMaking
		{
			get { return yearOfMaking; }
			set { yearOfMaking = value; }
		}

		public int RegNum
		{
			get { return regNum; }
			set { regNum = value; }
		}


		public string Model
		{
			get { return model; }
			set { model = value; }
		}

		public string Mark
		{
			get { return mark; }
			set { mark = value; }
		}

		public void Moving()
		{
            Console.WriteLine($"{this.Mark} {this.Model}: \"Brym – brum -brum\"");
        }
		public void IsEcoCar()
		{
			if (this.YearOfMaking > 2001)
			{
                Console.WriteLine("Im eco car");
            }
			else
			{
				Console.WriteLine("Im NOT eco car");
			}
		}
		public void IntroduceYourself()
		{
            Console.WriteLine($"{this.Mark}, {this.Model}, {this.RegNum}, {this.YearOfMaking}");
        }
		public static void CarRace(List<Car> cars)
		{
            Console.WriteLine("----CAR RACE------");
            Console.WriteLine("----Statistics for all contenders: ");
            for (int i = 0; i < cars.Count; i++)
			{
				Console.WriteLine($"Car {i} stats");
				cars[i].IntroduceYourself();
            }
            Console.WriteLine("-----Actions and others for all the contenders");
            for (int i = 0; i < cars.Count; i++)
			{
                Console.WriteLine($"Car {i} actions and others");
				Console.Write("Moving: ");
				cars[i].Moving();
                Console.Write("Is it eco? ");
				cars[i].IsEcoCar();
            }
		}
        public Car(string mark, string model, int regNum, int year)
        {
            this.Mark = mark;
			this.Model = model;
			this.RegNum = regNum;
			this.YearOfMaking = year;
        }
    }
}
