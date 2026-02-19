using System.Runtime.ConstrainedExecution;

namespace Variables_Morgan_Joseph
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int favoriteNumber = 7; //delcare favorite number
            bool isJumping = false; //making a bool
            bool isRunnig= false;  //making the other bool
            float jumpForce = 2f; //declaring the speed
            double finalGrade = 98.6; //saying final grade

            //Printing everything
            Console.WriteLine($"My favorite number is {favoriteNumber}");
            Console.WriteLine($"Is the character jumping? {isJumping}");
            Console.WriteLine($"Is the character running? {isRunnig}");
            Console.WriteLine($"Current jump force: {jumpForce}");
            Console.WriteLine($"Final grade: {finalGrade}");

        }
    }
}
