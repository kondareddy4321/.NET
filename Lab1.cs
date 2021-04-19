using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    public class Employee 
    {
        public int id;
        public String name;
        public float salary;
        public void insert(int i, String  n, float s)
        {
            id = i;
            name = n;
            salary = s;

        }
        public void display()
        {
            Console.WriteLine(id + " " + name + " " + salary);
        }
    }
    class TestEmployee 
    {
        public static void Main (String[] args)
        {
            Employee e1 = new Employee();
            Employee e2 = new Employee();
            e1.insert(111, "Mahi", 2000);
            e2.insert(112, "Anu", 3000);
            e1.display();
            e2.display();
            Console.ReadKey();
        }
    }
}
