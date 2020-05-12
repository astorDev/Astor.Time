using System;
using System.Runtime.CompilerServices;

namespace Astor.Time
{
    public static class Clock
    {
        private static DateTime? time;
        
        public static DateTime Time
        {
            get => time ?? DateTime.Now;
            set => time = value;
        }
    }
}