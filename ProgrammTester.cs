using System;
using Programmieren_cs2;
using Container;

class ProgrammTester {
    public static void Main(string[] args) {
        Person person1 = new  Person();
        person1.name = "Max";
        person1.alter = 20;
        Frau frau1 = new Frau();
        Mann mann1 = new Mann();
        Person[] instanzenArray = new Person[3];
        instanzenArray[0] = person1;
        instanzenArray[1] = frau1;
        instanzenArray[2] = mann1;
        MyContainer container = new MyContainer();
        container.Add(instanzenArray);
        container.GetAt(0);

        foreach(Person instanz in instanzenArray) {
            Console.WriteLine(instanz.GetAnrede());
        }
    }
}