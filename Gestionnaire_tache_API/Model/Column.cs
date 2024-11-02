namespace Gestionnaire_tache_API.Model
{
    public class Column
    {
        // Identifiant unique de la colonne
        public int ColumnId { get; set; }

        // Nom de la colonne (ex : "À faire", "En cours", "Terminé")
        public string Name { get; set; }

        // Description ou détails supplémentaires (optionnel)
        public string Description { get; set; }

        // Position de la colonne dans le Kanban (pour gérer l'ordre)
        public int Order { get; set; }

        // Liste des tâches dans cette colonne
        public List<Task> Tasks { get; set; } = new List<Task>();
    }
}
