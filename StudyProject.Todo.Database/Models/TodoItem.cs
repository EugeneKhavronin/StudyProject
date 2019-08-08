using System;
using System.ComponentModel.DataAnnotations;

namespace StudyProject.Todo.Database.Models
{
    /// <summary>
    /// Модель задачи
    /// </summary>
    public class TodoItem
    {
        /// <summary>
        /// Уникальный идентификатор
        /// </summary>
        [Key]
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