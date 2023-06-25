using System;
using Microsoft.AspNetCore.Mvc;
using Projet11.Models;

namespace Projet11.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TasksController : ControllerBase
    {
        private readonly ITaskManager _taskManager;

        public TasksController(ITaskManager taskManager)
        {
            _taskManager = taskManager;
        }

        [HttpPost]
        public IActionResult AddNewTask(TaskEntity task)
        {
            var newTask = _taskManager.AddNewTask(task);
            return Ok(newTask);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTask(Guid id)
        {
            var result = _taskManager.DeleteTask(id);
            if (result)
            {
                return Ok();
            }
            return NotFound();
        }

        [HttpPut("{id}/status")]
        public IActionResult UpdateStatus(Guid id, TaskStatus newStatus)
        {
            var updatedTask = _taskManager.UpdateStatus(id, newStatus);
            if (updatedTask != null)
            {
                return Ok(updatedTask);
            }
            return NotFound();
        }

        [HttpPut("{id}/priority")]
        public IActionResult UpdatePriority(Guid id, TaskPriority newPriority)
        {
            var updatedTask = _taskManager.UpdatePriority(id, newPriority);
            if (updatedTask != null)
            {
                return Ok(updatedTask);
            }
            return NotFound();
        }

        [HttpPut("{id}/duedate")]
        public IActionResult UpdateDueDate(Guid id, DateTime newDueDate)
        {
            var updatedTask = _taskManager.UpdateDueDate(id, newDueDate);
            if (updatedTask != null)
            {
                return Ok(updatedTask);
            }
            return NotFound();
        }
    }
}
