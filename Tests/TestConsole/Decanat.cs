﻿namespace TestConsole
{
   internal class Decanat : Storage<Student>
    {
        private int _MaxId = 1;

        public override void Add(Student item)
        {
            item.Id = _MaxId++;
            base.Add(item);
        }
    }
}