using System;

namespace ItCompany
{
    public abstract class Entity : IEntity
    {
        public int Id { get; set; }

        public Entity()
        {
            Console.WriteLine($"Entity: { GetType().Name} has been created\n");
            Id = SetId();
        }

        public abstract void DisplayName();

        protected virtual int SetId()
        {
            return Guid.NewGuid().GetHashCode();
        }
    }
}
