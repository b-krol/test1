using test1.klasy;

internal class Program
{
    private static void Main(string[] args)
    {
        string str1 = "Ala ma kota";
        str1 = Szyfrowanie.zaszyfrujGADERYPOLUKI(str1);
        Console.WriteLine(str1);

        string str2 = "kot";
        str2 = Szyfrowanie.zaszyfrujGADERYPOLUKI(str2);
        Console.WriteLine(str2);

        str1 = Szyfrowanie.odszyfrujGADERYPOLUKI(str1);
        str2 = Szyfrowanie.odszyfrujGADERYPOLUKI(str2);
        Console.WriteLine(str1);
        Console.WriteLine(str2);


        Console.WriteLine();
        Console.WriteLine();


        Student student1 = new Student("Ala", "Kot", 2020);
        Student student2 = new Student("Bruno", "Pies", 2019);
        Student student3 = new Student("Alex", "Lew", 2019);

        Console.WriteLine(student1.ToString());
        Console.WriteLine(student2.ToString());
        student1.zmienLogin(student2.pokazLogin(), student1.pokazLogin());
        student1.zmienHaslo(student2.pokazHaslo(), student1.pokazHaslo());
        Console.WriteLine(student1.Equals(student2));

        Wydzial wydzial1 = new Wydzial(new List<Student>() { student1, student2, student3 });


        Console.WriteLine();
        Console.WriteLine();


        //zad 4
        student1.zmienLogin("abc", student1.pokazLogin());
        student1.zmienHaslo("cba", student1.pokazHaslo());
        student2.zmienLogin("abc", student2.pokazLogin());
        student2.zmienHaslo("cba", student2.pokazHaslo());
        Console.WriteLine(student1.ToString());
        Console.WriteLine(student2.ToString());

        Console.WriteLine();

        wydzial1.sprawdzIPoprawDaneLog(0);
        foreach (Student student in wydzial1.students)
        {
            Console.WriteLine(student.ToString());
        }

        Console.WriteLine();

        wydzial1.students.Sort();
        foreach (Student student in wydzial1.students)
        {
            Console.WriteLine(student.ToString());
        }
    }
}