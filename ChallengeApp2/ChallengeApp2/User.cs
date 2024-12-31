namespace ChallengeApp2
{
    public class User
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
}
