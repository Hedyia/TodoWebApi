﻿namespace TodoApp
{
    using System;
    public class Todo
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsDone { get; set; }
        public DateTime UpdatedAT { get; set; }
    }
}
