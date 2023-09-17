﻿namespace LX.TestSpace.Client.Entities
{
    public class TestResult
    {
        public int Id { get; set; }
        public List<QuestionSnapshot> QuestionSnapshots { get; set; } = new();
        public string? UserId { get; set; }
        public User? User { get; set; }
        public TestSnapshot TestSnapshot { get; set; }
        public DateTime StartedAt { get; set; }
        public DateTime FinishedAt { get; set; }
        public double TestScore { get; set; }
        public int? TestId { get; set; }
        public Test? Test { get; set; }
        public string TextExecutionTime()
        {
            TimeSpan executionTime = FinishedAt - StartedAt;
            return executionTime.ToString(@"hh\:mm\:ss");
        }
    }
}
