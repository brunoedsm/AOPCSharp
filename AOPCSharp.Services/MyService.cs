using AOPCSharp.Services.Interfaces;
using System;

namespace AOPCSharp.Services
{
    public class MyService : IMyService
    {
        public int Execute(int param)
        {
            var j = 0;
            for (var i = 0; i < param; i++)
            {
                j += i;
            }

            return j;
        }
    }
}
