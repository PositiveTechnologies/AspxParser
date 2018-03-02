using System.Text.RegularExpressions;

namespace System.Web.RegularExpressions
{
    internal class TextRegexRunner9 : RegexRunner
    {
        protected override void Go()
        {
            string runtext = base.runtext;
            int runtextstart = base.runtextstart;
            int runtextbeg = base.runtextbeg;
            int runtextend = base.runtextend;
            int runtextpos = base.runtextpos;
            int[] runtrack = base.runtrack;
            int runtrackpos = base.runtrackpos;
            int[] runstack = base.runstack;
            int runstackpos = base.runstackpos;
            this.CheckTimeout();
            runtrack[--runtrackpos] = runtextpos;
            runtrack[--runtrackpos] = 0;
            this.CheckTimeout();
            runstack[--runstackpos] = runtextpos;
            runtrack[--runtrackpos] = 1;
            this.CheckTimeout();
            int num;
            if (runtextpos == base.runtextstart)
            {
                this.CheckTimeout();
                if (1 <= runtextend - runtextpos)
                {
                    runtextpos++;
                    num = 1;
                    while (true)
                    {
                        if (runtext[runtextpos - num--] == '<')
                        {
                            break;
                        }
                        if (num > 0)
                        {
                            continue;
                        }
                        goto IL_00d3;
                    }
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
                        goto IL_0202;
                    case 3:
                        this.CheckTimeout();
                        runstack[--runstackpos] = runtrack[runtrackpos++];
                        this.Uncapture();
                        continue;
                }
                break;
            }
            this.CheckTimeout();
            runtextpos = runtrack[runtrackpos++];
            goto IL_0175;
            IL_00d3:
            this.CheckTimeout();
            int num6;
            num = (num6 = runtextend - runtextpos) + 1;
            while (--num > 0)
            {
                if (runtext[runtextpos++] != '<')
                {
                    continue;
                }
                runtextpos--;
                break;
            }
            if (num6 > num)
            {
                runtrack[--runtrackpos] = num6 - num - 1;
                runtrack[--runtrackpos] = runtextpos - 1;
                runtrack[--runtrackpos] = 2;
            }
            goto IL_013f;
            IL_0175:
            this.CheckTimeout();
            base.runtextpos = runtextpos;
            return;
            IL_013f:
            this.CheckTimeout();
            num = runstack[runstackpos++];
            this.Capture(0, num, runtextpos);
            runtrack[--runtrackpos] = num;
            runtrack[--runtrackpos] = 3;
            goto IL_0175;
            IL_0202:
            this.CheckTimeout();
            runtextpos = runtrack[runtrackpos++];
            num = runtrack[runtrackpos++];
            if (num > 0)
            {
                runtrack[--runtrackpos] = num - 1;
                runtrack[--runtrackpos] = runtextpos - 1;
                runtrack[--runtrackpos] = 2;
            }
            goto IL_013f;
        }

        protected override bool FindFirstChar()
        {
            if (base.runtextpos > base.runtextstart)
            {
                base.runtextpos = base.runtextend;
                return false;
            }
            return true;
        }

        protected override void InitTrackCount()
        {
            base.runtrackcount = 4;
        }
    }
}
