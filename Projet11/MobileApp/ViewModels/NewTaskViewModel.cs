using System.Threading.Tasks;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using ApplicationMobile.Models;
using ApplicationMobile.Services;

namespace ApplicationMobile.ViewModels
{
    public class NewTaskViewModel : ObservableObject
    {
        private readonly ITaskService _taskService;

        public NewTaskViewModel(ITaskService taskService)
        {
            _taskService = taskService;
            Task = new TaskModel();
        }

        public TaskModel Task { get; set; }

        private ICommand _addTaskCommand;
        public ICommand AddTaskCommand => _addTaskCommand ??= new AsyncRelayCommand(AddTask);

        private async Task AddTask()
        {
            await _taskService.AddTaskAsync(Task);
            // Réinitialiser les propriétés
            Task = new TaskModel();
        }
    }
}
