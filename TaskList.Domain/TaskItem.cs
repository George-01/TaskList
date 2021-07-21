using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskList.Domain
{
    public class TaskItem : BaseEntity
    {
        [Required]
        [StringLength(255)]
        [Display(Name = "TAsk Name")]
        public string TaskName { get; set; }

        [Display(Name = "Is Completed?")]
        public bool IsCompleted { get; set; } = false;
    }
}
