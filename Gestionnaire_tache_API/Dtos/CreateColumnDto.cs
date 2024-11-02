namespace Gestionnaire_tache_API.Dtos
{
    public class CreateColumnDto
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public int Order { get; set; }
    }
}
