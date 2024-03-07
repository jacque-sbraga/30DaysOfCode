namespace Day05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.In.ReadLine());
            for (int i = 0; i < T; i++)
            {
                int age = int.Parse(Console.In.ReadLine());
                Person p = new Person(age);
                p.amIOld();
                for (int j = 0; j < 3; j++)
                {
                    p.yearPasses();
                }
                p.amIOld();
                Console.WriteLine();
            }
        }
    }


    class Person
    {
        private int _age;

        public Person(int initialAge)
        {
            this.Age = initialAge;
        }

        public int Age {
            get { return _age; }
            set
            {
                if(value < 0)
                {
                    Console.WriteLine("Age is not valid, setting age to 0.");
                    this._age = 0;
                } else
                {
                    this._age = value;
                }
            }
        }

        public int yearPasses()
        {
            this._age++;
            return this._age;
        }

        public void amIOld()
        {
            if(this._age < 13)
            {
                 Console.WriteLine("You are young.");
            }
            else
            {
                 if(this._age < 18)
                {
                     Console.WriteLine("You are a teenager.");
                }
                 else
                {
                    Console.WriteLine( "You are old.");
                }
            }
        }
    }
}
