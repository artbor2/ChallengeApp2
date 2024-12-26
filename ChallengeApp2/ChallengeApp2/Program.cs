User user1 = new User();
User user2 = new User("Monika");
User user3 = new User("Zuzia", "47367367");
User user4 = new User("Damian", "duddfcfs", "Damian");

class User
{
    // default private
    private string login;
    private string password;
    private string name;

    public User()
    {
        this.login = "_";
        this.password = "_";
        this.name = "_";

    }

    public User(string login)
    {
        this.login = login;
        this.password = "_";
        this.name = "_";
    }

    public User(string login, string password)
    {
        this.login = login;
        this.password = password;
        this.name = "_";
    }

    public User(string login, string password, string name) : this(login, password)
    {
        this.name = name;
    }
}