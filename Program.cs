using System;

namespace AnimalInheritance
{
    //base class
        class Animal
    {
        private string name; // only accessible within this class
        protected string type; //accessible from derived classes
        public string color;  // accessible from any class

        public void setName(string name)
        {
            this.name = name;
        }
        public virtual string getName() 
        { 
            return this.name; 
        }
        public void setType(string type) 
        { 
            this.type = type; 
        }
        public virtual string getType() 
        { 
            return this.type;
        }
        public virtual void displayData()
        {
            Console.WriteLine($"\nHorse Information: ");
            Console.WriteLine($"Name: {getName()}");
            Console.WriteLine($"Type: {getType()}");
            Console.WriteLine($"Color: {color}");
        }
    }
    class Horse : Animal
    {
        public int age;
        protected string sex;
        private int _value;
        public void setSex(string sex)
        {
            this.sex = sex;
        }
        public string getSex()
        {
            return sex;
        }
        public void setValue(int value)
        {
            _value = value;
        }
        public int getValue()
        {
            return _value;
        }
        public override string getName()
        {
            return base.getName();
        }
        public override string getType()
        {
            return base.getType();
        }
        public override void displayData()
        {
            Console.WriteLine($"\nHorse Information: ");
            Console.WriteLine($"Name: {getName()}");
            Console.WriteLine($"Type: {getType()}");
            Console.WriteLine($"Color: {color}");            
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Sex: {getSex()}");
            Console.WriteLine($"Value: ${getValue()}");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal fred = new Animal();
            fred.color = "Brown";
            fred.setName("Fred");
            fred.setType("Pig");
            fred.displayData();


            Horse sally = new Horse();
            sally.color = "White";
            sally.setName("sally");
            sally.setType("Horse");
            sally.age = 7;            
            sally.setSex("Female");
            sally.setValue(90000);
            sally.displayData();

        }
    }
}
