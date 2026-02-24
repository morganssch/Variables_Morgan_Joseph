using System.Runtime.ConstrainedExecution;

namespace Variables_Morgan_Joseph
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int favoriteNumber; //mkaing an int called favorite number
            bool isJumping = false, isRunning = false;  //making the booleans
            float jumpForce; //making a float called jumpForce
            favoriteNumber = 67; //assigning a value to my favorite number
            jumpForce = 2f; //putting a value on the float
            const double finalGrade = 98.6; //saying final grade

            //Printing everything
            Console.WriteLine($"My favorite number is {favoriteNumber}");
            Console.WriteLine($"Is the character jumping? {isJumping}");
            Console.WriteLine($"Is the character running? {isRunning}");
            Console.WriteLine($"Current jump force: {jumpForce}");
            Console.WriteLine($"Final grade: {finalGrade}");

        }
    }
}
