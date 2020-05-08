﻿using System.IO;


namespace TestConsole
{
    internal class Decanat : EntityStorage<Student>
    {
        public override void SaveToFile(string FileName)
        {
            using (var file_writer = File.CreateText(FileName))
                foreach (var student in _Items)
                {
                    file_writer.Write(string.Join(",", student.SurName, student.Name, student.Patronimyc,
                        string.Join(";", student.Ratings)));
                }
        }

        public override void LoadFromFile(string FileName)
        {
            base.LoadFromFile(FileName);

            using(var file_reader = File.OpenText(FileName))
                while (!file_reader.EndOfStream)
                {
                    var str = file_reader.ReadLine();

                    if (string.IsNullOrWhiteSpace(str))
                        continue;

                    var components = str.Split(',');

                    var student = new Student
                    {
                        SurName = components[0],
                        Name = components[1],
                        Patronimyc = components[2]
                    };

                    var ratings = components[3].Split(';');
                    foreach (var rating in ratings)
                        student.Ratings.Add(int.Parse(rating));

                    Add(student);
                }
        }
    }

    internal abstract class EntityStorage<TEntity> : Storage<TEntity> where TEntity : class, IEntity, new()
    {
        private int _Maxid = 1;

        public override void Add(TEntity item)
        {
            item.Id = _Maxid++;
            base.Add(item);

        }
    }
}