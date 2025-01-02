using ChallengeApp2;

/// 1. Stwórz klasę Employee, w której przechowasz imię, nazwisko,
/// wiek oraz punkty pracownika w postacoi liczb całkowitych.
/// 
/// 2. Stwórz 3 pracowników i każdemu przydziel po 5 ocen
/// z zakresu od 1 do 10.
/// 
/// 3. Napisz program, który wyszuka pracownika z najwyższą liczbą
/// ocen a następnie wyswietli jego dane oraz wynik
///

Employee emp1 = new Employee("Jan", "Abacki", 20);
Employee emp2 = new Employee("Adam", "Babacki", 30);
Employee emp3 = new Employee("Jan", "Cabacki", 40);
List<Employee> employees = new List<Employee>() { emp1, emp2, emp3 };

emp1.AddScore(5);
emp1.AddScore(6);
emp1.AddScore(5);
emp1.AddScore(8);
emp1.AddScore(9);

emp2.AddScore(5);
emp2.AddScore(6);
emp2.AddScore(4);
emp2.AddScore(3);
emp2.AddScore(4);

emp3.AddScore(2);
emp3.AddScore(9);
emp3.AddScore(5);
emp3.AddScore(10);
emp3.AddScore(9);

Employee biggestScore = employees.First();

foreach(Employee emp in employees)
{
    if (emp.Result > biggestScore.Result)
    {
        biggestScore = emp;    }
}

Console.WriteLine("first name: " + biggestScore.FirstName);
Console.WriteLine("lastname: " + biggestScore.LastName);
Console.WriteLine("age: " + biggestScore.Age);
Console.WriteLine("Score: " + biggestScore.Result);
