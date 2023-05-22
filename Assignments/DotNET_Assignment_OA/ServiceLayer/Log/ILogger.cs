using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.Log
{
    public interface ILogger
    {
        void LogDetails(string message);
    }
}
