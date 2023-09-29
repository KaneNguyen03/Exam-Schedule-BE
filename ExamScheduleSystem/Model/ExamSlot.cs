﻿namespace ExamScheduleSystem.Model
{
    public class ExamSlot
    {
        public string ExamSlotId { get; set; }
        public string ExamSlotName { get; set;}
        public string ProctoringId { get; set; }

        public DateTime Date { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }

        public ICollection<ExamSchedule> ExamSchedules { get; set; }
        public Proctoring Proctoring { get; set; }
    }
}
