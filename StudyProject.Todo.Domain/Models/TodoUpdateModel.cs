namespace StudyProject.Todo.Domain.Models
{
    public class TodoUpdateModel
    {
        /// <summary>
        /// Название задачи
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Статус
        /// </summary>
        public bool IsComplete { get; set; }
    }
}