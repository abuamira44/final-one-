using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1feysalcali66
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }


       

// Create an interface called IQuittable
public interface IQuittable
        {
            // Define a void method called Quit()
            void Quit();
        }

        // Create an Employee class that inherits from IQuittable
        public class Employee : IQuittable
        {
            // Properties of the Employee class
            public string FirstName { get; set; }
            public string LastName { get; set; }

            // Constructor to initialize properties
            public Employee(string firstName, string lastName)
            {
                FirstName = firstName;
                LastName = lastName;
            }

            // Implement the Quit() method from the IQuittable interface
            public void Quit()
            {
                Console.WriteLine($"{FirstName} {LastName} has quit the job.");
            }
        }

        
        
            static void Main()
            {
                // Instantiate an Employee object
                Employee employee = new Employee("John", "Doe");

                // Use polymorphism to create an object of type IQuittable
                IQuittable quittableEmployee = employee;

                // Call the Quit() method on the IQuittable object
                quittableEmployee.Quit();
            }
        }

    }


