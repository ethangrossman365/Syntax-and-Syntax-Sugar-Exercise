namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var answer = 4;
            var response = (answer < 9) ? $"{answer} is less that nine" : $"{answer} is greater than nine";
            Console.WriteLine(response);

        }
    }
}
