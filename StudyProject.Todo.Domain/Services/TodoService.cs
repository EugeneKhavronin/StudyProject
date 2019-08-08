using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StudyProject.Todo.Database;
using StudyProject.Todo.Database.Models;
using StudyProject.Todo.Domain.Interfaces;
using StudyProject.Todo.Domain.Models;

namespace StudyProject.Todo.Domain.Services
{
    /// <inheritdoc />
    public class TodoService : ITodoService
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;

        /// <summary />
        public TodoService(DatabaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        /// <inheritdoc />
        public async Task<IEnumerable<TodoViewModel>> GetAll()
        {
            var todoItems = await _context.TodoItems.ToListAsync();
            return _mapper.Map<List<TodoItem>, List<TodoViewModel>>(todoItems);
        }

        /// <inheritdoc />
        public async Task<TodoViewModel> Get(Guid todoGuid)
        {
            var todoItem = await _context.TodoItems.FirstOrDefaultAsync(a=>a.Guid==todoGuid);
            return _mapper.Map<TodoViewModel>(todoItem);
        }

        /// <inheritdoc />
        public async Task<Guid> Create(TodoCreateModel todoItem)
        {
            var createModel = _mapper.Map<TodoItem>(todoItem);
            _context.TodoItems.Add(createModel);
            await _context.SaveChangesAsync();
            return createModel.Guid;
        }

        /// <inheritdoc />
        public async Task<Guid> Update(TodoUpdateModel todoEditItem)
        {
            var todoItem = await _context.TodoItems.FirstOrDefaultAsync(a=>a.Guid==todoEditItem.Guid);
            todoItem.Name = todoEditItem.Name;
            todoItem.IsComplete = todoEditItem.IsComplete;
            _context.TodoItems.Update(todoItem);
            await _context.SaveChangesAsync();
            return todoItem.Guid;
        }

        /// <inheritdoc />
        public async Task Delete(Guid todoGuid)
        {
            var todoItem = await _context.TodoItems.FirstOrDefaultAsync(a=>a.Guid==todoGuid);
            _context.TodoItems.Remove(todoItem);
            await _context.SaveChangesAsync();
        }
    }
}