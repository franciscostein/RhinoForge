using MongoDB.Bson;

namespace RhinoForge.Core.Entities.Bases
{
    public abstract class EntityBase
    {
        public ObjectId Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsActive { get; set; }
    }
}