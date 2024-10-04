/*
 * Napisz w Program.cs kod, w którym:
 * - zdeklarujesz zmienną z imieniem
 * - zdeklarujesz zmienną z płcią (dobierz odpowiednią)
 * - zdeklarujesz z mienną z wiekiem
 *  
 * A następnie napisz kilka instrukcji warunkowych,
 * które przeanalizują te dane w następujący sposób:
 *  
 * (1): jeśli mamy do czynienia z kobietą i ma ona poniżej 30 lat, to zwróć komunikat:
 *      "Kobieta poniżej 30 lat"
 * (2): jesli mamy do czynienia z osobą o imiemiu Ewa i ma ona równo 30 lat, to zwróć komunikat:
 *      "Ewa, lat 30"
 * (3): jeśli mamy do czynienia z mężczyzną i ma poniżej 18 lat zwróć komunikat:
 *      "Niepenołetni mężczyzna"
 * (4): jeśli dane nie spełniają żadnego z wzarunków program nie zwraca nic
 *  
 * UWAGA:
 * Twój program zawsze powinien zwracać TYLKO JEDEN KOMUNIKAT lub w przypadku (4) nic!
 */

string name = "Ewa";
bool male = false;
int age = 30;

if (male == false && age < 30)
{
    Console.WriteLine("Kobieta, poniżej 30 lat");
}
else if(name == "Ewa" && age == 30)
{
    Console.WriteLine("Ewa, lat 30");
}
else if (male == true && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna"); 
}
