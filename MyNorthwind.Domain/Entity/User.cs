using MyNorthwind.Domain.ValueObjects;

namespace MyNorthwind.Domain.Entity
{
    public class User
    {
        public int Id { get; set; }

        public AdAccount AdAccount { get; set; }
    }
}
