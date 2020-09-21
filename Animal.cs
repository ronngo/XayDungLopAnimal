namespace XayDungLopAnimal
{
     class Animal
    {
        public string Name {get; set;}

        public string Sound {get; set;}
        
        public AnimalInfo animalInfo = new AnimalInfo();
        public Animal(){}

        public Animal( string name, string sound)
        {
              Name = name;
              Sound = sound;
        }

         public void SetAnimalInfo(int id, string owner)
        {
            animalInfo.ID = id;
            animalInfo.Owner = owner;
        }

        public void GetInfo()
        {
            System.Console.WriteLine($"{Name} co tieng keu la {Sound} và id = {animalInfo.ID} và chu so hu la {animalInfo.Owner}");
        }
    }

    class AnimalInfo
    {
        public int ID { get; set; } = 0;
        public string Owner { get; set; } = "Thu Hoang";
    }
}
    