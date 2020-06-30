using System;
namespace FindSurf.Domain.Entities
{
    public abstract class Entity : IEquatable<Entity>
    {
        public Entity()
        {
            Id = Guid.NewGuid();
            Register = DateTime.Now;
        }

        public Guid Id { get; private set; }

        public DateTime Register { get; set; }
        public bool Equals(Entity other)
        {
            return Id == other.Id;
        }
    }
}
