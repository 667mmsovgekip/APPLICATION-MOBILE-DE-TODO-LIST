using System.ComponentModel.DataAnnotations;

namespace Projet11.Models
{
    public enum TaskPriority
    {
        [Display(Name = "Low")]
        Low,

        [Display(Name = "Medium")]
        Medium,

        [Display(Name = "High")]
        High
    }
}
