using System;

namespace Common
{
    public interface IDateTime
    {
        DateTime UtcNow { get; }
    }
}
