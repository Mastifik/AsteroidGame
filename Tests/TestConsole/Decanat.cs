namespace TestConsole
{
   internal class Decanat : EntityStorage<Student>
    {
        
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