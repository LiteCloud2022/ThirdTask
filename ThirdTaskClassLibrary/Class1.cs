namespace ThirdTaskClassLibrary
{
    public class Zoo
    {
        private Animal[] _animalList;

        public Zoo (int numberOfAnimals)
        {
            _animalList = new Animal[numberOfAnimals];
            Random random = new Random();
            for (int n = 0; n < numberOfAnimals; n++)
            {
                int nameLenght = random.Next(3, 10);
                char[] nameChar = new char[nameLenght];
                for (int m = 0; m < nameChar.Length; m++) { nameChar[m] = (char)random.Next(97, 123);}
                string nameString = "";
                foreach (char c in nameChar) { nameString += c; }
                _animalList[n] = new Animal(random.Next(2,9), random.Next(1,3), nameString);
            }
        }

        public void StartZooExcurtion()
        {
            for (int n = 0; n < _animalList.Length;  n++)
            {
                Console.WriteLine($"This is {_animalList[n]._name}, and its number is {n+1}.");
            }
            bool IsExcutionIsOver = false;
            Console.Write("Would you like to know more about our animals? ");
            while (true)
            {
                string continueExcurtion = Console.ReadLine().ToLower();
                if (continueExcurtion == "yes")
                {
                    this.ObserveAnimal();
                }
                else if (continueExcurtion == "no")
                {
                    Console.WriteLine("If you don't have questions excurtion is over.");
                    break; 
                }
                else
                {
                    Console.Write("Sorry, but I don't understand your answer.\nSo, would you like to know more information about our animals? ");
                }
            }
        }

        private void ObserveAnimal()
        {
            try
            {
                Console.Write("Please, tell me number of animal you want to study closer: ");
                int numberOfAnimalToStudy = Int32.Parse(Console.ReadLine());
                Console.WriteLine($"This is {_animalList[numberOfAnimalToStudy - 1]._name}, and its number is {numberOfAnimalToStudy - 1} it has {numberOfAnimalToStudy - 1} legs and {numberOfAnimalToStudy - 1} heads.");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Sorry, but we don't have an animal with what number.");
            }
            finally
            {
                Console.Write("Would you like to know more about any other our animal? ");
            }
        }
    }

    public class Animal
    {
        public int _legs { get; private set; }
        public int _heads { get; private set; }
        public string _name { get; private set; }
        public Animal (int legs, int heads, string name)
        {
            _legs = legs;
            _heads = heads;
            _name = name;
        }
    }
}