using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudyProject.Todo.Domain.Interfaces;
using StudyProject.Todo.Domain.Models;

namespace StudyProject.Todo.API.Controllers
{
    /// <summary>
    /// Контролер задач
    /// </summary>
    [Route("api/todo")]
    [Authorize]
    public class TodoController
    {
        private readonly ITodoService _todoService;
        
        /// <summary/>
        public TodoController(ITodoService todoService)
        {
            _todoService = todoService;
        }

        /// <summary>
        /// Получение задачи
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IEnumerable<TodoViewModel>> GetTodoItems()
        {
            return await _todoService.GetAll();
        }

        /// <summary>
        /// Получение задач
        /// </summary>
        /// <param name="guid">Уникальный идентификатор</param>
        /// <returns></returns>
        [HttpGet("{guid}")]
        public async Task<TodoViewModel> GetTodoItem([FromRoute]Guid guid)
        {
            return await _todoService.Get(guid);
        }

        /// <summary>
        /// Добавление задачи
        /// </summary>
        /// <param name="todoItem">Модель задачи</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<Guid> CreateTodoItem([FromBody]TodoCreateModel todoItem)
        {
            return await _todoService.Create(todoItem);
        }

        /// <summary>
        /// Изменение задачи
        /// </summary>
        /// <param name="todoItem">Модель задачи</param>
        /// <returns></returns>
        [HttpPut]
        public async Task<Guid> PutTodoItem([FromBody]TodoUpdateModel todoItem)
        {
            return await _todoService.Update(todoItem);
        }
        
        /// <summary>
        /// Удаление задачи
        /// </summary>
        /// <param name="guid">Уникальный идентификатор</param>
        /// <returns></returns>
        [HttpDelete("{guid}")]
        public async Task DeleteTodoItem([FromRoute]Guid guid)
        {
            await _todoService.Delete(guid);
        }
    }
}