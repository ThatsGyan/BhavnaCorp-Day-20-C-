using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace Employee
{
    class Program
    {
        static void Main(string[]args)
        {
            Employee emp = new Employee();

            Console.WriteLine("Enter the name of Employee");
            emp.name = Console.ReadLine();

            Console.WriteLine("Enter Department of Employee");
            emp.department = Console.ReadLine();

            Console.WriteLine("Enter Department of Salary");
            emp.salary = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Department of Gender");
            emp.gender = Console.ReadLine();

            //connection string

            SqlConnection con = new SqlConnection("server=localhost;database = Employee;integrated security=true");

            //Command Creation

            //for string data --> ' ""+emp.name + " '
            SqlCommand cmd = new SqlCommand("insert into Employee values(' " +emp.name+"','"+emp.department+"',"+emp.salary+",'"+emp.gender+"')",con); // command for inserting values in DB table

            
            con.Open();
            cmd.ExecuteNonQuery(); //executr cmd
            con.Close(); //connection close

            Console.WriteLine("Record Inserted Sucessfully");



        }
    }
}