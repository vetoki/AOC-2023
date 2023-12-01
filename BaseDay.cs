namespace AOC_2023
{
    public class BaseDay
    {
        protected string[] _input;

        public BaseDay(int dayNumber)
        {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;

            Console.WriteLine(path);

            string day = "Day" + dayNumber.ToString();

            _input = File.ReadAllLines(path + "/" + day + "/" + day + "Input.txt");
        }
    }
}
