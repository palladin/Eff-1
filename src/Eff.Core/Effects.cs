﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Eff.Core
{
    public class DateTimeNowEffect : IEffect<DateTime>
    {
        private readonly string memberName;
        private readonly string sourceFilePath;
        private readonly int sourceLineNumber;

        public DateTimeNowEffect(string memberName, string sourceFilePath, int sourceLineNumber)
        {
            this.memberName = memberName;
            this.sourceFilePath = sourceFilePath;
            this.sourceLineNumber = sourceLineNumber;
        }

        public bool IsCompleted => throw new NotImplementedException();

        public string CallerMemberName => memberName;

        public string CallerFilePath => sourceFilePath;

        public int CallerLineNumber => sourceLineNumber;

        public DateTime GetResult()
        {
            throw new NotImplementedException();
        }

        public void OnCompleted(Action continuation)
        {
            throw new NotImplementedException();
        }

        public void UnsafeOnCompleted(Action continuation)
        {
            throw new NotImplementedException();
        }

        public IEffect<DateTime> GetAwaiter()
        {
            return this;
        }
    }

    public static class Effect
    {
        public static DateTimeNowEffect DateTimeNow([CallerMemberName] string memberName = "",
                                                    [CallerFilePath] string sourceFilePath = "",
                                                    [CallerLineNumber] int sourceLineNumber = 0)
        {
            return new DateTimeNowEffect(memberName, sourceFilePath, sourceLineNumber);
        }
    }
    
}
