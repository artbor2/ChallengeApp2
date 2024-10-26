int[] grades = new int[3];

string[] daysOfWeek = new string[7];
daysOfWeek[0] = "Poniedziałek";
daysOfWeek[1] = "Wtorek";
daysOfWeek[2] = "Środa";
daysOfWeek[3] = "Czwartek";
daysOfWeek[4] = "Piatek";
daysOfWeek[5] = "Sobota";
daysOfWeek[6] = "Niedziela";
Console.WriteLine(daysOfWeek[2]);

string[] daysOfWeek2 = {
    "Poniedziałek", "Wtorek", "Środa",
    "Czwartek", "Piątek","Sobota",
    "Niedziela"
};
Console.WriteLine(daysOfWeek2[0]);
Console.WriteLine();

/*
 * Index was outside the bounds of the array 
 * 
 * Console.WriteLine(daysOfWeek2[-1]);
 * Console.WriteLine(daysOfWeek2[10]);
 */


for (int i = 0; i < 10; i = i + 1)
{
    Console.Write(i + " ");
}
Console.WriteLine();


for (int i = 0; i < 10; i++)
{
    Console.Write(i + " ");
}
Console.WriteLine('\n');



for(int i = 0; i < daysOfWeek.Length; i++)
{
    Console.WriteLine(daysOfWeek[i]);
}

