using System;

namespace log4net
{
    internal interface ILog
    {
        void Error(Exception e);
        void Info(string v);
    }
}