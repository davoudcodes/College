﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace College.Models
{
    public class Seminar
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [AllowHtml]
        public string Description { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public Department Department { get; set; }

        [Required]
        [Display(Name = "Department")]
        public byte DepartmentId { get; set; }
    }
}