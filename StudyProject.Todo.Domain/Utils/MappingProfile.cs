using AutoMapper;
using StudyProject.Todo.Database.Models;
using StudyProject.Todo.Domain.Models;

namespace StudyProject.Todo.Domain.Utils
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<TodoItem, TodoCreateModel>();
            CreateMap<TodoItem, TodoUpdateModel>();
            CreateMap<TodoItem, TodoViewModel>();
            CreateMap<TodoViewModel, TodoItem>();
            CreateMap<TodoUpdateModel, TodoItem>();
            CreateMap<TodoCreateModel, TodoItem>();
        }
    }
}