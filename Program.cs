namespace Homework7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car MyCar = new Car("Toyota", "Corolla", 2005, 50000.0f);

            Console.WriteLine("Drive() Method");
            MyCar.Drive(123.35f);
            Console.WriteLine(MyCar.WriteOutInfo("mileage"));

            Console.WriteLine("\n");
            Console.WriteLine("DisplayCarInfo() Method");
            MyCar.DisplayCarInfo();

            Console.WriteLine("\n");
            Console.WriteLine(MyCar);
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }

    public class Car
    {
        private string Name { get; set; } //Pořád si nejsem jistý, kdy je dobrá praxe používat private-public,
        private string Model { get; set; } //ale říkal jsem si, že kdybych měl někde v databázi uvedené auté, 
        private int Year { get; set; } //tak bych ho nechtěl jen tak změnit. Zvlášť mileage kvůli scamům.
        private float Mileage { get; set; }

        public Car(string name, string model, int year, float mileage)
        {
            Name = name;
            Model = model;
            Year = year;
            Mileage = mileage;
        }

        public void Drive(float kiloMeters)
        {
            if (kiloMeters < 0)
            {
                throw new ArgumentException("Kilometers driven cannot be negative.");
            }
            this.Mileage = this.Mileage + kiloMeters;
        }
        public string WriteOutInfo(string input)
        {
            if (input == "name" || input == "Name" || input == "NAME")
            {
                return this.Name;
            }
            else if (input == "model" || input == "Model" || input == "MODEL")
            {
                return this.Model;
            }
            else if (input == "year" || input == "Year" || input == "YEAR")
            {
                return this.Year.ToString();
            }
            else if (input == "mileage" || input == "Mileage" || input == "MILEAGE")
            {
                return this.Mileage.ToString();
            }
            else
            {
                return "EXCEPTION: InputUnknown";
            }

        }
        public override string ToString() //Chtěl jsem i jednu metodu, která by přímo vracela string a ne jen vypisovala
        {
            return "Name: " + this.Name +
                            "\nModel: " + this.Model +
                            "\nYear: " + this.Year +
                            "\nMileage: " + this.Mileage;
        }
        public void DisplayCarInfo()
        {
            Console.WriteLine("Brand: " + this.Name + ", Model: " + this.Model + ", Year: " + this.Year + ", Mileage: " + this.Mileage + " km.");
        }


    }
}
