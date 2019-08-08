using System;

namespace StudyProject.Todo.Domain.Models
{
    /// <summary>
    /// Модель изменения задачи
    /// </summary>
    public class TodoUpdateModel
    {
        /// <summary />
        public TodoUpdateModel()
        {
        }

        /// <summary>
        /// Уникальный идентификатор задачи
        /// </summary>
        public Guid Guid { get; set; }
        
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