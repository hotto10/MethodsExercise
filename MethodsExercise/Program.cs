namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var myName = Console.ReadLine();
            Console.WriteLine("What is your middle name?");
            var myMiddleName = Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
            var myColor = Console.ReadLine();
            Console.WriteLine ("What is your favorite hobby?");
            var myHobby = Console.ReadLine();
            MyMethod(myName, myMiddleName, myColor, myHobby);
        }

        static void MyMethod(string myName, string myMiddleName, string myColor, string myHobby)
        {
            var myStory = ($"This is a short sweet story about {myName}. ");
            myStory = myStory + ($"They always wanted to be addressed as {myMiddleName} instead of their first name. ");
            myStory = myStory + ($"Most of the time they got made fun of for liking {myColor} and for liking {myHobby}. ");
            Console.WriteLine(myStory);
        }
            
    }

}
