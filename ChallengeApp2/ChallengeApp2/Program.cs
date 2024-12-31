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

class User
{
    public static string GameName = "Diablo";
    public static int count = 0;
    private List<int> scores = new List<int>();

    // default private
    public User(string login, string password)
    {
        this.Login = login; 
        this.Password = password;
        User.count++;
    }

    public string Login { get; private set; }
    public string Password { get; private set; }
    public int Result
    {
        get
        {
            return this.scores.Sum();
        }
    }

    public void AddScore(int score)
    {
        scores.Add(score);
    }
}