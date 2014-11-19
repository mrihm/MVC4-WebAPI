using System;

namespace Common
{
    /// <summary>
    /// Wrapper class for the DateTime class
    /// </summary>
    public class DateTimeAdapter : IDateTime
    {
        public DateTime UtcNow 
        {
            get { return DateTime.UtcNow; }
        }
    }
}
