namespace DotnetIntro // Defines a namespace called DotnetIntro
// ✅ NOTE: A **namespace** is like a container that holds related classes and code.
// It helps organize your code and avoid name conflicts.
{
    

    class Program // Defines the Program class - contains the entry point
    {
        static void Main(string[] args) // Main method - application starts here
        {
            // Using default constructor
            User defaultUser = new User(); // Creates a User object with default values
            defaultUser.Greet();           // Calls Greet() method to print a message

            // Using parameterized constructor
            User customUser = new User("Krishna", 30); // Creates a User object with specific values
            string greetMessage = customUser.GreetWithReturn(); // Gets greeting message
            Console.WriteLine(greetMessage); // Prints the returned message

            // Using method with parameters
            string customMessage = customUser.GreetWithReturn("Saharsa", "28"); // Calls method with arguments
            Console.WriteLine(customMessage); // Prints the returned custom greeting

            Console.WriteLine("Press any key to exit..."); // Asks user to press a key before closing
            Console.ReadKey(); // Waits for key press to keep console window open
        }
        // ✅ NOTE: `Main()` is the first method that runs in a console application.
        // `Console.WriteLine()` displays messages, and `Console.ReadKey()` waits for user input.
        int a = Convert.ToInt32(Console.ReadLine());
    }
}
