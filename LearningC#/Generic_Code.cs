using System;
using System.Collections.Generic;
using System.Text;

namespace LearningC_
{
    public interface ILoggable
    {
        string GetLogMessage();
    }

    public class Order : ILoggable
    {
        public int OrderId { get; set; }

        public string GetLogMessage()
        {
            return $"Order created. Id = {OrderId}";
        }
    }

    public class Customer : ILoggable
    {
        public string Name { get; set; }

        public string GetLogMessage()
        {
            return $"Customer registered. Name = {Name}";
        }
    }

    public class Logger<T> where T : ILoggable
    {
        public void Log(T item)
        {
            Console.WriteLine(item.GetLogMessage());
        }
    }

    public class Product : ILoggable
    {
        public string Name { get; set; }
        public string GetLogMessage()
        {
            return $"Product registered. Name = {Name}";
        }
    }

}
