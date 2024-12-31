using ChallengeApp2;

User user1 = new User("Adam", "356647477");
User user2 = new User("Monika", "465437848");
User user3 = new User("Zuzia", "47367367");
User user4 = new User("Damian", "duddfcfs");

string login = user1.Login;
string password = user1.Password;
user1.AddScore(5);
user1.AddScore(2);
user1.AddScore(1);

int result = user1.Result;
Console.WriteLine(result);
Console.WriteLine(User.GameName);
var pi = Math.PI;
Console.WriteLine(pi);
Console.WriteLine(User.count); 
