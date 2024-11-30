namespace Gestionnaire_tache_API.Dtos
{
    public class ColumnDto
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public int Order { get; set; }
        public  List<TacheDto> Taches { get; set; }
    }
}
