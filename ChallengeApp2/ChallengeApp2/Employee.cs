namespace ChallengeApp2
{
    public class Employee
    {
        private List<int> scores = new List<int>();

        public Employee(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public string FirstName { get; }
        public string LastName { get; }
        public int Age { get; } 

        
        public int Result
        {
            get { return scores.Sum(); }

        }

        public void AddScore(int score)
        {
            scores.Add(score);
        }
    }
}
