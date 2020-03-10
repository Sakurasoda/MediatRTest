using System;
using System.Data;
using TestMediatR.Interface;

namespace TestMediatR.Logic
{
    public class MemoLogic : IMemoLogic
    {
        public DateTime GetNow()
        {
            return DateTime.Now;
        }
    }
}