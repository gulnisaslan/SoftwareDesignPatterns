using System;
using System.Collections;
using System.Collections.Generic;

namespace Composites
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee gulnisa = new Employee { Name = "Gülnisa Aslan" };
            Employee engin = new Employee { Name = "Engin Demiroğ" };
            Employee ercan = new Employee { Name = "Ercan Aslan" };
            Employee merve = new Employee { Name = "Merve" };

            gulnisa.AddSubordinates(engin);
            gulnisa.AddSubordinates(ercan);
            engin.AddSubordinates(merve);
            Console.WriteLine(gulnisa.Name);
            foreach (Employee person in gulnisa)
            {
            Console.WriteLine("  {0}",person.Name);
                foreach (Employee employee in person)
                {
                    Console.WriteLine("       {0}",employee.Name);
                }
            }

        }
    }

    //classes

    class Employee : IPerson, IEnumerable<IPerson>
    {

        List<IPerson> _subordinates = new List<IPerson>();
        public void AddSubordinates(IPerson person)
        {
            _subordinates.Add(person);
        }

        public void RemoveSubordinates(IPerson person)
        {
            _subordinates.Remove(person);
        }

        public IPerson GetSubordinate(int index)
        {
            return _subordinates[index];
        }

        public IEnumerator<IPerson> GetEnumerator()
        {
            foreach (var subordinate in _subordinates)
            {
                yield return subordinate;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public string Name { get; set; }
    

    }


    //interfaces

    interface IPerson
    {
        string Name { get; set; }
    }


    //abstract classes
}

