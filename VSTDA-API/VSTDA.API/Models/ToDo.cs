using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VSTDA.Models
{
    public class ToDo
    {
        // Primary Key
        [Key]
        public int ToDoEntryId { get; set; }
        // Additional Columns
        public String ToDoItem { get; set; }
        public int Priority { get; set; }


    }
}