namespace Gestionnaire_tache_API.Model
{
    public class Task
    {
        public int TaskId { get; set; }

        public string Title { get; set; }

        // Description détaillée de la tâche
        public string? Description { get; set; }



        // État d'achèvement (optionnel si tu souhaites avoir un contrôle de progression)
        public bool IsCompleted { get; set; }

        // Date de création de la tâche
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
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
