List<string> daysOfWeek = new List<string>();
daysOfWeek.Add("Poniedziałek");
daysOfWeek.Add("Wtorek");
daysOfWeek.Add("Środa");
daysOfWeek.Add("Czwartek");
daysOfWeek.Add("Piatek");
daysOfWeek.Add("Sobota");
daysOfWeek.Add("Niedziela");

for(int i = 0; i < daysOfWeek.Count; i++)
{
    Console.WriteLine(daysOfWeek[i]);
}
Console.WriteLine();

foreach (var day in daysOfWeek)
{
    Console.WriteLine(day);
}

