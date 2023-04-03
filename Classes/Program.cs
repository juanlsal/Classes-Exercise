namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool? Value = null;
            while (Value == null)
            {
                Console.WriteLine("Whtas the make?");
                var make = Console.ReadLine();
                Console.WriteLine("Whats the model?");
                var model = Console.ReadLine();
                Console.WriteLine("Whats the year?");
                var year = Convert.ToInt32(Console.ReadLine());
                Car toyota = new Car(make, model, year);
                toyota.Phrase();
                Console.WriteLine("want to register another one?");
                var answer = Console.ReadLine();
                switch (answer)
                {
                    case "yes":
                        continue;
                    default:
                        Value = true; break;
                }
            }
       
        }
    }
}
