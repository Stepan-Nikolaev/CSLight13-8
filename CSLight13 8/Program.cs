using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLight13_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Zoo zoo = new Zoo();

            int userInput = 0;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Добро пожаловать в наш зоопарк. Куда хотите пойти?");
                zoo.DisplayZoo();
                Console.WriteLine("0. Выйти.");
                Console.WriteLine("Наберите номер того вольера, куда хотите пойти.");
                userInput = Convert.ToInt32(Console.ReadLine());

                if (userInput == 0)
                {
                    break;
                }

                zoo.CallDisplayAviary(userInput - 1);
            }
        }
    }

    class Zoo
    {
        private List<Aviary> _zoo = new List<Aviary>();
        private Random random = new Random();

        private int _countAviary;
        private int _aviaryID;

        public Zoo()
        {
            _countAviary = random.Next(4, 20);

            for (int i = 0; i < _countAviary; i++)
            {
                _aviaryID = random.Next(0, 3);

                switch (_aviaryID)
                {
                    case 0:
                        Aquarium aquarium = new Aquarium();
                        _zoo.Add(aquarium);
                        break;
                    case 1:
                        Terrarium terrarium = new Terrarium();
                        _zoo.Add(terrarium);
                        break;
                    case 2:
                        Paddock paddock = new Paddock();
                        _zoo.Add(paddock);
                        break;
                }
            }
        }

        public void DisplayZoo()
        {
            Console.WriteLine();

            for (int i = 0; i < _zoo.Count - 1; i++)
            {
                Console.WriteLine($"{i + 1}. {_zoo[i].TypeAviary}");
            }
        }

        public void CallDisplayAviary(int aviaryID)
        {
            _zoo[aviaryID].DisplayAviary();
        }
    }

    class Aviary
    {
        protected List<Animals> _animals = new List<Animals>();
        protected Random random = new Random();
        public int Capasity { get; protected set; }
        public string TypeAviary { get; protected set; }
        public int AnimalID { get; protected set; }

        public void DisplayAviary()
        {
            Console.Clear();
            Console.WriteLine("Тип вольера - " + TypeAviary);
            Console.WriteLine("Количество обитателей - " + Capasity);
            Console.WriteLine();

            for (int i = 0; i < _animals.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + _animals[i].DisplayAnimal());
            }

            Console.ReadKey();
        }
    }

    class Aquarium : Aviary
    {
        public Aquarium()
        {
            TypeAviary = "Аквариум";
            Capasity = random.Next(15, 40);
            AnimalID = random.Next(0, 3);

            for (int i = 0; i < Capasity; i++)
            {
                switch (AnimalID)
                {
                    case 0:
                        Devilfish devilfish = new Devilfish();
                        _animals.Add(devilfish);
                        break;
                    case 1:
                        Dolphin dolphin = new Dolphin();
                        _animals.Add(dolphin);
                        break;
                    case 2:
                        Shark shark = new Shark();
                        _animals.Add(shark);
                        break;
                }
            }
        }
    }

    class Terrarium : Aviary
    {
        public Terrarium()
        {
            TypeAviary = "Терррариум";
            Capasity = random.Next(15, 40);
            AnimalID = random.Next(3, 6);

            for (int i = 0; i < Capasity; i++)
            {
                switch (AnimalID)
                {
                    case 3:
                        Cobra cobra = new Cobra();
                        _animals.Add(cobra);
                        break;
                    case 4:
                        Python python = new Python();
                        _animals.Add(python);
                        break;
                    case 5:
                        Anaconda anaconda = new Anaconda();
                        _animals.Add(anaconda);
                        break;
                }
            }
        }
    }

    class Paddock : Aviary
    {
        public Paddock()
        {
            TypeAviary = "Загон";
            Capasity = random.Next(15, 40);
            AnimalID = random.Next(6, 9);

            for (int i = 0; i < Capasity; i++)
            {
                switch (AnimalID)
                {
                    case 6:
                        Lion lion = new Lion();
                        _animals.Add(lion);
                        break;
                    case 7:
                        Zebra zebra = new Zebra();
                        _animals.Add(zebra);
                        break;
                    case 8:
                        Camel camel = new Camel();
                        _animals.Add(camel);
                        break;
                }
            }
        }
    }

    class Animals
    {
        protected Random random = new Random();
        public string TypeAnimals { get; protected set; }
        public string Gender { get; protected set; }
        public string Sound { get; protected set; }

        public string DisplayAnimal()
        {
            return ($"{TypeAnimals} Звук: {Sound} Пол: {Gender}");
        }
    }

    class Devilfish : Animals
    {
        public Devilfish()
        {
            TypeAnimals = "Скат";
            Sound = "Молчание";
            Gender = (random.Next(0, 2) == 1 ? "Женский" : "Мужской");
        }
    }

    class Dolphin : Animals
    {
        public Dolphin()
        {
            TypeAnimals = "Дельфин";
            Sound = "Свист";
            Gender = (random.Next(0, 2) == 1 ? "Женский" : "Мужской");
        }
    }

    class Shark : Animals
    {
        public Shark()
        {
            TypeAnimals = "Акула";
            Sound = "Грозное молчание";
            Gender = (random.Next(0, 2) == 1 ? "Женский" : "Мужской");
        }
    }

    class Cobra : Animals
    {
        public Cobra()
        {
            TypeAnimals = "Кобра";
            Sound = "Шипение";
            Gender = (random.Next(0, 2) == 1 ? "Женский" : "Мужской");
        }
    }

    class Python : Animals
    {
        public Python()
        {
            TypeAnimals = "Питон";
            Sound = "Шипение";
            Gender = (random.Next(0, 2) == 1 ? "Женский" : "Мужской");
        }
    }

    class Anaconda : Animals
    {
        public Anaconda()
        {
            TypeAnimals = "Анаконда";
            Sound = "Шипение";
            Gender = (random.Next(0, 2) == 1 ? "Женский" : "Мужской");
        }
    }

    class Lion : Animals
    {
        public Lion()
        {
            TypeAnimals = "Лев";
            Sound = "Рык";
            Gender = (random.Next(0, 2) == 1 ? "Женский" : "Мужской");
        }
    }

    class Zebra : Animals
    {
        public Zebra()
        {
            TypeAnimals = "Зебра";
            Sound = "Ржание";
            Gender = (random.Next(0, 2) == 1 ? "Женский" : "Мужской");
        }
    }

    class Camel : Animals
    {
        public Camel()
        {
            TypeAnimals = "Верблюд";
            Sound = "Мычание";
            Gender = (random.Next(0, 2) == 1 ? "Женский" : "Мужской");
        }
    }
}
