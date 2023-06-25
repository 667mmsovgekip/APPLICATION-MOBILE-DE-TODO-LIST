using System;
using System.Collections.Generic;
using System.Linq;

namespace Projet11.Models
{
    public class FakeTaskManager : ITaskManager
    {
        private List<TaskEntity> _tasks;

        public FakeTaskManager()
        {
            _tasks = new List<TaskEntity>();
        }

        public TaskEntity AddNewTask(TaskEntity task)
        {
            task.Id = Guid.NewGuid();
            _tasks.Add(task);
            return task;
        }

        public bool DeleteTask(Guid id)
        {
            var task = _tasks.FirstOrDefault(t => t.Id == id);
            if (task != null)
            {
                _tasks.Remove(task);
                return true;
            }
            return false;
        }

        public TaskEntity? UpdateStatus(Guid id, TaskStatus newStatus)
        {
            var task = _tasks.FirstOrDefault(t => t.Id == id);
            if (task != null)
            {
                task.Status = newStatus;
                return task;
            }
            return null;
        }

        public TaskEntity? UpdatePriority(Guid id, TaskPriority newPriority)
        {
            var task = _tasks.FirstOrDefault(t => t.Id == id);
            if (task != null)
            {
                task.Priority = newPriority;
                return task;
            }
            return null;
        }

        public TaskEntity? UpdateDueDate(Guid id, DateTime newDueDate)
        {
            var task = _tasks.FirstOrDefault(t => t.Id == id);
            if (task != null)
            {
                task.DueDate = newDueDate;
                return task;
            }
            return null;
        }
    }
}
