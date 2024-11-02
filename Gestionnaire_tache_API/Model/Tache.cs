using System.ComponentModel.DataAnnotations;

namespace Gestionnaire_tache_API.Model
{
    public class Tache
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Liaison 
        public int ColumnId { get; set; }
        public Column Column { get; set; } // Navigation property pour lier la colonne

    }
    public enum TaskPriority
    {
        Low,
        Medium,
        High
    }
    public enum TaskStatus
    {
        ToDo,
        InProgress,
        Done
    }
}
