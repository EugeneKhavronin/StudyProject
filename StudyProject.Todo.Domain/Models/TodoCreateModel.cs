using System;

namespace StudyProject.Todo.Domain.Models
{
    /// <summary>
    /// Модель создания задачи
    /// </summary>
    public class TodoCreateModel
    {
        /// <summary />
        public TodoCreateModel()
        {
        }

        /// <summary>
        /// Уникальный идентификатор
        /// </summary>
        private Guid Guid { get; set; }

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