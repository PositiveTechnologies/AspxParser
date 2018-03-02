using System.Text.RegularExpressions;

namespace System.Web.RegularExpressions
{
    internal class AspEncodedExprRegexRunner24 : RegexRunner
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
            if (num == base.runtextstart)
            {
                this.CheckTimeout();
                if (3 <= runtextend - num && runtext[num] == '<' && runtext[num + 1] == '%' && runtext[num + 2] == ':')
                {
                    num += 3;
                    this.CheckTimeout();
                    runstack[--runstackpos] = -1;
                    runstack[--runstackpos] = 0;
                    runtrack[--runtrackpos] = 2;
                    this.CheckTimeout();
                    goto IL_01a8;
                }
            }
            goto IL_02c3;
            IL_01a8:
            this.CheckTimeout();
            int num3 = runstack[runstackpos++];
            int num5;
            int num6 = num5 = runstack[runstackpos++];
            runtrack[--runtrackpos] = num5;
            if ((num6 != num || num3 < 0) && num3 < 1)
            {
                runstack[--runstackpos] = num;
                runstack[--runstackpos] = num3 + 1;
                runtrack[--runtrackpos] = 5;
                if (runtrackpos > 36 && runstackpos > 27)
                {
                    goto IL_011b;
                }
                runtrack[--runtrackpos] = 6;
                goto IL_02c3;
            }
            runtrack[--runtrackpos] = num3;
            runtrack[--runtrackpos] = 7;
            goto IL_0242;
            IL_0328:
            this.CheckTimeout();
            num = runtrack[runtrackpos++];
            goto IL_02b4;
            IL_011b:
            this.CheckTimeout();
            runstack[--runstackpos] = num;
            runtrack[--runtrackpos] = 1;
            this.CheckTimeout();
            if ((num3 = runtextend - num) > 0)
            {
                runtrack[--runtrackpos] = num3 - 1;
                runtrack[--runtrackpos] = num;
                runtrack[--runtrackpos] = 3;
            }
            goto IL_0172;
            IL_039f:
            if (num5 > 0)
            {
                runtrack[--runtrackpos] = num5 - 1;
                runtrack[--runtrackpos] = num;
                runtrack[--runtrackpos] = 3;
            }
            goto IL_0172;
            IL_0172:
            this.CheckTimeout();
            num3 = runstack[runstackpos++];
            this.Capture(1, num3, num);
            runtrack[--runtrackpos] = num3;
            runtrack[--runtrackpos] = 4;
            goto IL_01a8;
            IL_02c3:
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
                    case 6:
                        break;
                    default:
                        goto IL_0328;
                    case 1:
                        this.CheckTimeout();
                        runstackpos++;
                        continue;
                    case 2:
                        this.CheckTimeout();
                        runstackpos += 2;
                        continue;
                    case 3:
                        goto IL_0363;
                    case 4:
                        this.CheckTimeout();
                        runstack[--runstackpos] = runtrack[runtrackpos++];
                        this.Uncapture();
                        continue;
                    case 5:
                        goto IL_03f9;
                    case 7:
                        this.CheckTimeout();
                        num3 = runtrack[runtrackpos++];
                        runstack[--runstackpos] = runtrack[runtrackpos++];
                        runstack[--runstackpos] = num3;
                        continue;
                }
                break;
                IL_03f9:
                this.CheckTimeout();
                if ((num3 = runstack[runstackpos++] - 1) >= 0)
                {
                    goto IL_0413;
                }
                runstack[runstackpos] = runtrack[runtrackpos++];
                runstack[--runstackpos] = num3;
                continue;
                IL_0363:
                this.CheckTimeout();
                num = runtrack[runtrackpos++];
                num5 = runtrack[runtrackpos++];
                if (!RegexRunner.CharInClass(runtext[num++], "\0\u0001\0\0"))
                {
                    continue;
                }
                goto IL_039f;
            }
            goto IL_011b;
            IL_02b4:
            this.CheckTimeout();
            base.runtextpos = num;
            return;
            IL_0242:
            this.CheckTimeout();
            if (2 <= runtextend - num && runtext[num] == '%' && runtext[num + 1] == '>')
            {
                num += 2;
                this.CheckTimeout();
                num3 = runstack[runstackpos++];
                this.Capture(0, num3, num);
                runtrack[--runtrackpos] = num3;
                runtrack[--runtrackpos] = 4;
                goto IL_02b4;
            }
            goto IL_02c3;
            IL_0413:
            num = runstack[runstackpos++];
            runtrack[--runtrackpos] = num3;
            runtrack[--runtrackpos] = 7;
            goto IL_0242;
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
            base.runtrackcount = 9;
        }
    }
}