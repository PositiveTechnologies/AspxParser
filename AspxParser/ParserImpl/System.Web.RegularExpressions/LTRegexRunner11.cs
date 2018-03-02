using System.Text.RegularExpressions;

namespace System.Web.RegularExpressions
{
    internal class LTRegexRunner11 : RegexRunner
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
            if (num < runtextend && runtext[num++] == '<')
            {
                this.CheckTimeout();
                if (num < runtextend && runtext[num++] != '%')
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
            string runtext = base.runtext;
            int runtextend = base.runtextend;
            int num = base.runtextpos + 0;
            while (true)
            {
                if (num >= runtextend)
                {
                    break;
                }
                int num2;
                if ((num2 = runtext[num]) != 60)
                {
                    int num3;
                    if ((num2 -= 60) != 0)
                    {
                        num3 = 1;
                    }
                    else
                    {
                        switch (num2)
                        {
                        }
                        num3 = 0;
                    }
                    num = num3 + num;
                    continue;
                }
                num2 = (base.runtextpos = num);
                return true;
            }
            base.runtextpos = base.runtextend;
            return false;
        }

        protected override void InitTrackCount()
        {
            base.runtrackcount = 3;
        }
    }
}