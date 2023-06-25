using System;
using System.Collections.Generic;

namespace Projet11.Models
{
    public interface ITaskManager
    {
        TaskEntity AddNewTask(TaskEntity task);
        bool DeleteTask(Guid id);
        TaskEntity? UpdateStatus(Guid id, TaskStatus newStatus);
        TaskEntity? UpdatePriority(Guid id, TaskPriority newPriority);
        TaskEntity? UpdateDueDate(Guid id, DateTime newDueDate);
    }
}
