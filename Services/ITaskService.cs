﻿// Services/ITaskService.cs
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public interface ITaskService
    {
        Task<IEnumerable<TaskItem>> GetAllAsync();
        Task<TaskItem?> GetByIdAsync(int id);
        Task<TaskItem> CreateAsync(TaskItem task);
        Task<TaskItem?> UpdateAsync(int id, TaskItem task);
        Task<bool> DeleteAsync(int id);
        Task<TaskItem?> UpdateStatusAsync(int id, bool completed);
    }
}