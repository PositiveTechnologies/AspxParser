using System.Text.RegularExpressions;

namespace System.Web.RegularExpressions
{
    internal class GTRegexRunner10 : RegexRunner
    {
        protected override void Go()
        {
            string runtext = base.runtext;
            int runtextstart = base.runtextstart;
            int runtextbeg = base.runtextbeg;
            int runtextend = base.runtextend;
            int num = base.runtextpos;
            int[] runtrack = base.runtrack;
            int runtrackpos = base.runtrackpos;
            int[] runstack = base.runstack;
            int runstackpos = base.runstackpos;
            this.CheckTimeout();
            runtrack[--runtrackpos] = num;
            runtrack[--runtrackpos] = 0;
            this.CheckTimeout();
            runstack[--runstackpos] = num;
            runtrack[--runtrackpos] = 1;
            this.CheckTimeout();
            if (num < runtextend && runtext[num++] != '%')
            {
                this.CheckTimeout();
                if (num < runtextend && runtext[num++] == '>')
                {
                    this.CheckTimeout();
                    int num5 = runstack[runstackpos++];
                    this.Capture(0, num5, num);
                    runtrack[--runtrackpos] = num5;
                    runtrack[--runtrackpos] = 2;
                    goto IL_0104;
                }
            }
            while (true)
            {
                base.runtrackpos = runtrackpos;
                base.runstackpos = runstackpos;
                this.EnsureStorage();
                runtrackpos = base.runtrackpos;
                runstackpos = base.runstackpos;
                runtrack = base.runtrack;
                runstack = base.runstack;
                switch (runtrack[runtrackpos++])
                {
                    case 1:
                        this.CheckTimeout();
                        runstackpos++;
                        continue;
                    case 2:
                        this.CheckTimeout();
                        runstack[--runstackpos] = runtrack[runtrackpos++];
                        this.Uncapture();
                        continue;
                }
                break;
            }
            this.CheckTimeout();
            num = runtrack[runtrackpos++];
            goto IL_0104;
            IL_0104:
            this.CheckTimeout();
            base.runtextpos = num;
        }

        protected override bool FindFirstChar()
        {
            int num = base.runtextpos;
            string runtext = base.runtext;
            int num2 = base.runtextend - num;
            if (num2 > 0)
            {
                int result;
                while (true)
                {
                    num2--;
                    if (!RegexRunner.CharInClass(runtext[num++], "\0\u0003\0\0%&"))
                    {
                        if (num2 > 0)
                        {
                            continue;
                        }
                        result = 0;
                    }
                    else
                    {
                        num--;
                        result = 1;
                    }
                    break;
                }
                base.runtextpos = num;
                return (byte)result != 0;
            }
            return false;
        }

        protected override void InitTrackCount()
        {
            base.runtrackcount = 3;
        }
    }
}