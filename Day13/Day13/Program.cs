using System;

namespace Day13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();
            string firstName = inputs[0];
            string lastName = inputs[1];
            int id = Convert.ToInt32(inputs[2]);
            int numScores = Convert.ToInt32(Console.ReadLine());
            inputs = Console.ReadLine().Split();
            int[] scores = new int[numScores];
            for (int i = 0; i < numScores; i++)
            {
                scores[i] = Convert.ToInt32(inputs[i]);
            }

            Student s = new Student(firstName, lastName, id, scores);
            s.printPerson();
            Console.WriteLine("Grade: " + s.Calculate() + "\n");
        }

        class Student : Person
        {
            private int[] testScores;

            public Student(string firstName,
                string lastName,
                int idNumber,
                int[] testScores
                )
                : base(firstName, lastName, idNumber)
            {
                this.testScores = testScores;
            }

            public char Calculate()
            {
                int total = 0;
                double average = 0;
                char grade = 'O';
                foreach(int score in testScores)
                {
                    total+= score;
                }

                average = total / testScores.Length;

                if(average >= 90)

                    grade = Convert.ToChar(GradingScale.O);
                
                else { 
                    if (average < 90)
                        grade = Convert.ToChar(GradingScale.E);
                    if (average < 80)
                        grade = Convert.ToChar(GradingScale.A);
                    if(average < 70)
                        grade = Convert.ToChar(GradingScale.P);
                    if (average < 55)
                        grade = Convert.ToChar(GradingScale.D);
                    if (average < 40)
                        grade = Convert.ToChar(GradingScale.T);
                }

                return grade;


            }

        }


        enum GradingScale
        {
            O = 'O',
            E = 'E',
            A = 'A',
            P = 'P',
            D = 'D',
            T = 'T'
        }
        class Person
        {
            string firstName;
            string lastName;
            int idNumber;

            public Person(string firstName, string lastName, int idNumber)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.idNumber = idNumber;
            }

            public void printPerson() {
                 Console.WriteLine($"Name: {this.lastName}, {this.firstName}\n" +
                    $"ID: {this.idNumber}");
            }
        }
    }
}
