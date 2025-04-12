namespace DotnetIntro // Defines a namespace called DotnetIntro
// ✅ NOTE: A **namespace** is like a container that holds related classes and code.
// It helps organize your code and avoid name conflicts.
{
    public class User // Declares a class named 'User'
                      // ✅ NOTE: A **class** is a blueprint for creating objects.
                      // It defines what properties (data) and methods (behavior) an object will have.
    {
        public string Name { get; set; } // Declares a property 'Name' of type string
        public int Age { get; set; }     // Declares a property 'Age' of type int

        // ✅ NOTE: These are **auto-implemented properties**.
        // `get` allows reading the value, and `set` allows assigning a value.

        public User() // Default constructor - no parameters
        {
            Name = "Venkat"; // Sets default name
            Age = 35;        // Sets default age
        }
        // ✅ NOTE: A **constructor** is a special method that runs when an object is created.
        // This is the **default constructor** that sets predefined values.

        public User(string name, int age) // Constructor with parameters
        {
            Name = name;
            Age = age;
        }
        // ✅ NOTE: This is a **parameterized constructor**. You can pass custom values when creating the object.

        public void Greet() // Method with no return value
        {
            Console.WriteLine($"Hello, {Name}! You are {Age} years old.");
        }
        // ✅ NOTE: This method prints a greeting to the console.
        // `$` is used for **string interpolation** (inserting variables inside strings).

        public string GreetWithReturn() // Method that returns a string
        {
            string result = $"Hello, {Name}! You are {Age} years old.";
            return result;
        }
        // ✅ NOTE: This method builds a greeting message and returns it as a string.

        public string GreetWithReturn(string name, string age) // Overloaded method with input parameters
        {
            string result = $"Hello, {name}! You are {age} years old.";
            return result;
        }
        // ✅ NOTE: This is **method overloading**. It uses parameters to return a custom greeting.
    }

    class Program // Defines the Program class - contains the entry point
    {
        static void Main(string[] args) // Main method - application starts here
        {
            // Using default constructor
            User defaultUser = new User(); // Creates a User object with default values
            defaultUser.Greet();           // Calls Greet() method to print a message

            // Using parameterized constructor
            User customUser = new User("Arjun", 30); // Creates a User object with specific values
            string greetMessage = customUser.GreetWithReturn(); // Gets greeting message
            Console.WriteLine(greetMessage); // Prints the returned message

            // Using method with parameters
            string customMessage = customUser.GreetWithReturn("Bhavana", "28"); // Calls method with arguments
            Console.WriteLine(customMessage); // Prints the returned custom greeting

            Console.WriteLine("Press any key to exit..."); // Asks user to press a key before closing
            Console.ReadKey(); // Waits for key press to keep console window open
        }
        // ✅ NOTE: `Main()` is the first method that runs in a console application.
        // `Console.WriteLine()` displays messages, and `Console.ReadKey()` waits for user input.
    }
}
