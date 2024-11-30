using Gestionnaire_tache_API.Model;

namespace Gestionnaire_tache_API.Dtos
{
    public class TacheDto
    {
        public string Title { get; set; }
        public string? Description { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime CreatedAt { get; set; } 

        // Liaison 
        public int ColumnId { get; set; }
    }
}
