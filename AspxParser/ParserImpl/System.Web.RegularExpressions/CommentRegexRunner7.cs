using System.Text.RegularExpressions;

namespace System.Web.RegularExpressions
{
    internal class CommentRegexRunner7 : RegexRunner
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
            if (runtextpos == base.runtextstart)
            {
                this.CheckTimeout();
                if (4 <= runtextend - runtextpos && runtext[runtextpos] == '<' && runtext[runtextpos + 1] == '%' && runtext[runtextpos + 2] == '-' && runtext[runtextpos + 3] == '-')
                {
                    runtextpos += 4;
                    this.CheckTimeout();
                    runstack[--runstackpos] = -1;
                    runtrack[--runtrackpos] = 1;
                    this.CheckTimeout();
                    goto IL_025b;
                }
            }
            goto IL_0358;
            IL_0349:
            this.CheckTimeout();
            base.runtextpos = runtextpos;
            return;
            IL_0225:
            this.CheckTimeout();
            int num2 = runstack[runstackpos++];
            this.Capture(1, num2, runtextpos);
            runtrack[--runtrackpos] = num2;
            runtrack[--runtrackpos] = 3;
            goto IL_025b;
            IL_0358:
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
                        goto IL_03de;
                    case 3:
                        this.CheckTimeout();
                        runstack[--runstackpos] = runtrack[runtrackpos++];
                        this.Uncapture();
                        continue;
                    case 4:
                        goto IL_0459;
                    case 5:
                        this.CheckTimeout();
                        runstack[runstackpos] = runtrack[runtrackpos++];
                        continue;
                }
                break;
                IL_0459:
                this.CheckTimeout();
                runtextpos = runtrack[runtrackpos++];
                runstack[--runstackpos] = runtextpos;
                runtrack[--runtrackpos] = 5;
                if (runtrackpos > 40 && runstackpos > 30)
                {
                    this.CheckTimeout();
                    runstack[--runstackpos] = runtextpos;
                    runtrack[--runtrackpos] = 1;
                    this.CheckTimeout();
                    runstack[--runstackpos] = runtextpos;
                    runtrack[--runtrackpos] = 1;
                    this.CheckTimeout();
                    int num7;
                    num2 = (num7 = runtextend - runtextpos) + 1;
                    while (--num2 > 0)
                    {
                        if (runtext[runtextpos++] != '-')
                        {
                            continue;
                        }
                        runtextpos--;
                        break;
                    }
                    if (num7 > num2)
                    {
                        runtrack[--runtrackpos] = num7 - num2 - 1;
                        runtrack[--runtrackpos] = runtextpos - 1;
                        runtrack[--runtrackpos] = 2;
                    }
                    goto IL_01ca;
                }
                runtrack[--runtrackpos] = 6;
                continue;
                IL_03de:
                this.CheckTimeout();
                runtextpos = runtrack[runtrackpos++];
                num2 = runtrack[runtrackpos++];
                if (num2 > 0)
                {
                    runtrack[--runtrackpos] = num2 - 1;
                    runtrack[--runtrackpos] = runtextpos - 1;
                    runtrack[--runtrackpos] = 2;
                }
                goto IL_01ca;
                IL_01ca:
                this.CheckTimeout();
                num2 = runstack[runstackpos++];
                this.Capture(2, num2, runtextpos);
                runtrack[--runtrackpos] = num2;
                runtrack[--runtrackpos] = 3;
                this.CheckTimeout();
                if (runtextpos < runtextend && runtext[runtextpos++] == '-')
                {
                    goto IL_0225;
                }
            }
            this.CheckTimeout();
            runtextpos = runtrack[runtrackpos++];
            goto IL_0349;
            IL_025b:
            this.CheckTimeout();
            int num15 = num2 = runstack[runstackpos++];
            if (num2 != -1)
            {
                runtrack[--runtrackpos] = num2;
            }
            else
            {
                runtrack[--runtrackpos] = runtextpos;
            }
            if (num15 != runtextpos)
            {
                runtrack[--runtrackpos] = runtextpos;
                runtrack[--runtrackpos] = 4;
            }
            else
            {
                runstack[--runstackpos] = num2;
                runtrack[--runtrackpos] = 5;
            }
            this.CheckTimeout();
            if (3 <= runtextend - runtextpos && runtext[runtextpos] == '-' && runtext[runtextpos + 1] == '%' && runtext[runtextpos + 2] == '>')
            {
                runtextpos += 3;
                this.CheckTimeout();
                num2 = runstack[runstackpos++];
                this.Capture(0, num2, runtextpos);
                runtrack[--runtrackpos] = num2;
                runtrack[--runtrackpos] = 3;
                goto IL_0349;
            }
            goto IL_0358;
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
            base.runtrackcount = 10;
        }
    }
}