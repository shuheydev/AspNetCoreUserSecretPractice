﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreUserSecretPractice
{
    public class Models
    {
        public class Student
        {
            public int StudentId { get; set; }
            public string Name { get; set; }
            [Required]
            public int CourseId { get; set; }
            public Course Course { get; set; }//ナビゲーションプロパティ
        }

        public class Course
        {
            public int CourseId { get; set; }
            public string CourseName { get; set; }
            public ICollection<Student> Students { get; set; }//ナビゲーションプロパティ
        }
    }
}
