using System;

namespace TestConsole
{
    internal class Player
    {
        private string _Name;
        private DateTime _Birthday;

        public string GetName() 
        {
            return _Name;
        }

        public void SetName(string Name) 
        {
            _Name = Name;
        }

        public string Name
        {
            get
            {
                return _Name;
            }

            set
            {
                _Name = value;
            }
        }


        public string Surename { get; set; }


        public Player() 
        {
            Surename = "123";
        }

        public Player(string Name) 
        {
            this.Name = Name;
            _Birthday = DateTime.Now;
        }

        public Player(string Name, DateTime Birthday)
            :this(Name)
        {
            this._Birthday = Birthday;

        }
    }
}
