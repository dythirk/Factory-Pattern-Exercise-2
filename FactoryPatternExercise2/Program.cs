namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What database do you want to use (list, SQL, Mongo)?");
            var choice = Console.ReadLine();

            var database = DataAccessFactory.GetDataAccesType(choice);

            database.LoadData();
            database.SaveData();

        }
    }
}
