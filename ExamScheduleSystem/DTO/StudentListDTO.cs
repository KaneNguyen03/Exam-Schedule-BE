﻿using ExamScheduleSystem.Model;

namespace ExamScheduleSystem.DTO
{
    public class StudentListDTO
    {
        public string StudentListId { get; set; }
        public string CourseId { get; set; }
        public List<StudentDTO> listStudent { get; set; }
        public string Status { get; set; }
    }
}
