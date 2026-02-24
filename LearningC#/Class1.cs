namespace LearningC_
{
    class A { public int X; }
    class Person
    {
        public Person(string name) { }
        public Person() { }
        public static T Identity<T>(T value) where T : new()
        {
            return new T();
        }
    }
    public class Tests
    {
        public string Name{ get; set; }
        private string[] _players = new string[5];
        public static T Identity<T>(T value)
        {
           return value;
        }

        public string this[int index]
        {
            get { return _players[index]; }
            set { _players[index] = value; }
        }

    }
    public class Class1
    {
        static void Main()
        {
            int? age = null;

            if (age.HasValue)
                age = 3;

            Tests test = new Tests();
            test.Name = "John Doe";
            Console.WriteLine(test.Name);

            test[0] = "Player1";
            test[1] = "Player2";
            Console.WriteLine(test[0]);
            Console.WriteLine(test[1]);
            Console.WriteLine(test[2]);

            var i = Tests.Identity<int>(42);
            Console.WriteLine(i);

            Person p = Person.Identity<Person>(new Person("Alice"));
            List<string> list1 = new List<string>();
            list1.Add("Hello");
            list1.Add("World");


            List<object> list2 = new List<object>();
            list2.Add("Hello2");
            list2.Add(42);

            string s1 = "eyal";
            string s2 = "eyal";
            var result = ReferenceEquals(s1, s2);

            string part1 = "eya";
            string part2 = "l";
            string s3 = part1 + part2;

            result = object.ReferenceEquals(s1, s2);

            string s5 = "";
            string s6 = string.Empty;

            result = ReferenceEquals(s5, s6);

            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }

            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }

            list2 = list1.Cast<object>().ToList();

           

            A a1 = new A { X = 5 };
            A a2 = new A { X = 5 };

            result = ReferenceEquals(a1, a2);
            A a3 = a1;
            result = ReferenceEquals(a1, a3);
            a1.X = 10;
            result = ReferenceEquals(a1, a3);
        }
    }
}
