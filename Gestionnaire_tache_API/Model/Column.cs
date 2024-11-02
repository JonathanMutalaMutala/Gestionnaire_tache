namespace Gestionnaire_tache_API.Model
{
    public class Column
    {
        public int ColumnId { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public int Order { get; set; }
        public List<Tache> Tasks { get; set; } = new List<Tache>();
    }
}
