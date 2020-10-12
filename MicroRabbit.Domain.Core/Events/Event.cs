﻿using System;
namespace MicroRabbit.Domain.Core.Events
{
    public class Event
    {
        public DateTime Timestamp { get; protected set; }
        protected Event()
        {
            Timestamp = DateTime.Now;
        }
    }
}
