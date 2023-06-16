using System.ComponentModel.DataAnnotations;

namespace Projet11.Models
{
    public enum TaskStatus
    {
        [Display(Name = "Scheduled")]
        Scheduled,

        [Display(Name = "Started")]
        Started,

        [Display(Name = "Done")]
        Done
    }
}
