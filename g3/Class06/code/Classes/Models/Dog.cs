using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Dog
    {
        public Dog(string name, string breed, Action currentState)
        {
            Name = name;
            Breed = breed;
            CurrentState = currentState;
            IsRunning = false;
            IsBarking = false;
            IsEating = false;
            IsHungry = false;
            IsTailing = false;
        }

        public string Name { get; set; }
        public string Breed { get; set; }
        public Action CurrentState { get; set; }
        private bool IsRunning { get; set; }
        private bool IsBarking { get; set; }
        private bool IsEating { get; set; }
        private bool IsHungry { get; set; }
        private bool IsTailing { get; set; }

        public void Eat()
        {
            if (this.ValidateAction(Action.Eat))
            {
                IsEating = true;
                Console.WriteLine("The dog is now eating");
            }
            else
            {
                Console.WriteLine("The dog is already eating or its not hungry");
            }
        }

        public void StopEating()
        {
            if (this.ValidateAction(Action.NotEat))
            {
                Console.WriteLine("The dog will now stop eating");
            }
        }

        public void Bark()
        {
            if (ValidateAction(Action.Bark))
            {
                IsBarking = true;
                Console.WriteLine("The dog is now barking");
            }
        }

        public void StopBarking()
        {
            if (this.ValidateAction(Action.NotBark))
            {
                IsBarking = false;
                Console.WriteLine("The dog will now stop barking");
            }
        }

        public void Tail()
        {
            if (ValidateAction(Action.Tail))
            {
                Console.WriteLine("The dog is now playing with its tail");
                IsTailing = true;
            }
        }

        public void StopTailing()
        {
            if (ValidateAction(Action.NotTail))
            {
                IsTailing = false;
                Console.WriteLine("The dog will now stop playing with its tail");
            }
        }

        private bool ValidateAction(Action action)
        {
            switch (action)
            {
                case Action.Eat:
                    return (IsEating == false && IsHungry == true);
                case Action.NotEat:
                    return (IsEating == true);
                case Action.Bark:
                    return (IsEating == false);
                case Action.NotBark:
                    return (IsBarking == true);
                case Action.Tail:
                    return (IsEating == false && IsBarking == false);
                case Action.NotTail:
                    return (IsTailing == true);
                default:
                    return false;
            }
        }
    }
}
