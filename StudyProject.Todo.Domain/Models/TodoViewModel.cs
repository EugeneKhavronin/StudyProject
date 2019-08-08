using System;

namespace StudyProject.Todo.Domain.Models
{
    /// <summary>
    /// Модель просмотра задачи
    /// </summary>
    public class TodoViewModel
    {
        /// <summary />
        public TodoViewModel()
        {
        }
        
        /// <summary>
        /// Уникальный идентификатор
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