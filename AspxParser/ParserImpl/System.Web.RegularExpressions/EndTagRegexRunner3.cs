using System.Text.RegularExpressions;

namespace System.Web.RegularExpressions
{
    internal class EndTagRegexRunner3 : RegexRunner
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
                if (2 <= runtextend - runtextpos && runtext[runtextpos] == '<' && runtext[runtextpos + 1] == '/')
                {
                    runtextpos += 2;
                    this.CheckTimeout();
                    runstack[--runstackpos] = runtextpos;
                    runtrack[--runtrackpos] = 1;
                    this.CheckTimeout();
                    if (1 <= runtextend - runtextpos)
                    {
                        runtextpos++;
                        num = 1;
                        while (true)
                        {
                            if (!RegexRunner.CharInClass(runtext[runtextpos - num--], "\0\u0004\n./:;\0\u0002\u0004\u0005\u0003\u0001\u0006\t\u0013\0"))
                            {
                                break;
                            }
                            if (num > 0)
                            {
                                continue;
                            }
                            goto IL_0138;
                        }
                    }
                }
            }
            goto IL_02cc;
            IL_0138:
            this.CheckTimeout();
            int num3;
            num = (num3 = runtextend - runtextpos) + 1;
            while (--num > 0)
            {
                if (RegexRunner.CharInClass(runtext[runtextpos++], "\0\u0004\n./:;\0\u0002\u0004\u0005\u0003\u0001\u0006\t\u0013\0"))
                {
                    continue;
                }
                runtextpos--;
                break;
            }
            if (num3 > num)
            {
                runtrack[--runtrackpos] = num3 - num - 1;
                runtrack[--runtrackpos] = runtextpos - 1;
                runtrack[--runtrackpos] = 2;
            }
            goto IL_01b2;
            IL_02cc:
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
                        goto IL_034e;
                    case 3:
                        this.CheckTimeout();
                        runstack[--runstackpos] = runtrack[runtrackpos++];
                        this.Uncapture();
                        continue;
                    case 4:
                        goto IL_03c9;
                }
                break;
            }
            this.CheckTimeout();
            runtextpos = runtrack[runtrackpos++];
            goto IL_02bd;
            IL_01b2:
            this.CheckTimeout();
            num = runstack[runstackpos++];
            this.Capture(1, num, runtextpos);
            runtrack[--runtrackpos] = num;
            runtrack[--runtrackpos] = 3;
            this.CheckTimeout();
            num = (num3 = runtextend - runtextpos) + 1;
            while (--num > 0)
            {
                if (RegexRunner.CharInClass(runtext[runtextpos++], "\0\0\u0001d"))
                {
                    continue;
                }
                runtextpos--;
                break;
            }
            if (num3 > num)
            {
                runtrack[--runtrackpos] = num3 - num - 1;
                runtrack[--runtrackpos] = runtextpos - 1;
                runtrack[--runtrackpos] = 4;
            }
            goto IL_0262;
            IL_0262:
            this.CheckTimeout();
            if (runtextpos < runtextend && runtext[runtextpos++] == '>')
            {
                this.CheckTimeout();
                num = runstack[runstackpos++];
                this.Capture(0, num, runtextpos);
                runtrack[--runtrackpos] = num;
                runtrack[--runtrackpos] = 3;
                goto IL_02bd;
            }
            goto IL_02cc;
            IL_03c9:
            this.CheckTimeout();
            runtextpos = runtrack[runtrackpos++];
            num = runtrack[runtrackpos++];
            if (num > 0)
            {
                runtrack[--runtrackpos] = num - 1;
                runtrack[--runtrackpos] = runtextpos - 1;
                runtrack[--runtrackpos] = 4;
            }
            goto IL_0262;
            IL_034e:
            this.CheckTimeout();
            runtextpos = runtrack[runtrackpos++];
            num = runtrack[runtrackpos++];
            if (num > 0)
            {
                runtrack[--runtrackpos] = num - 1;
                runtrack[--runtrackpos] = runtextpos - 1;
                runtrack[--runtrackpos] = 2;
            }
            goto IL_01b2;
            IL_02bd:
            this.CheckTimeout();
            base.runtextpos = runtextpos;
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
            base.runtrackcount = 7;
        }
    }
}