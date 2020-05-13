namespace ListWPF
{
    internal class Employee
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
        public Department Department { get; set; }

        public Employee(string name, string lastName, int age, int v, Department department)
        {
            Name = name;
            LastName = lastName;
            Age = age;         
            Department = department;
        }

        public override string ToString()
        {
            return $@"{Name} {LastName}";
        }
    }
}