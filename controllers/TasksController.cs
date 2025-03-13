// Controllers/TasksController.cs
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TasksController : ControllerBase
    {
        private readonly ITaskService _taskService;

        public TasksController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        // GET: api/tasks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TaskItem>>> GetTasks()
        {
            var tasks = await _taskService.GetAllAsync();
            return Ok(tasks);
        }

        // GET: api/tasks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TaskItem>> GetTask(int id)
        {
            var task = await _taskService.GetByIdAsync(id);
            if (task == null) return NotFound();
            return Ok(task);
        }

        // POST: api/tasks
        [HttpPost]
        public async Task<ActionResult<TaskItem>> CreateTask(TaskItem task)
        {
            var created = await _taskService.CreateAsync(task);
            return CreatedAtAction(nameof(GetTask), new { id = created.Id }, created);
        }

        // PUT: api/tasks/5
        [HttpPut("{id}")]
        public async Task<ActionResult<TaskItem>> UpdateTask(int id, TaskItem updated)
        {
            var result = await _taskService.UpdateAsync(id, updated);
            if (result == null) return NotFound();
            return Ok(result);
        }

        // PATCH: api/tasks/5/status
        [HttpPatch("{id}/status")]
        public async Task<ActionResult<TaskItem>> UpdateTaskStatus(int id, [FromBody] bool completed)
        {
            var result = await _taskService.UpdateStatusAsync(id, completed);
            if (result == null) return NotFound();
            return Ok(result);
        }

        // DELETE: api/tasks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTask(int id)
        {
            var success = await _taskService.DeleteAsync(id);
            if (!success) return NotFound();
            return NoContent();
        }
    }
}
