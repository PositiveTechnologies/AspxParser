using System.Text.RegularExpressions;

namespace System.Web.RegularExpressions
{
    internal class AspExprRegexRunner5 : RegexRunner
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
            int num2;
            if (num == base.runtextstart)
            {
                this.CheckTimeout();
                if (2 <= runtextend - num && runtext[num] == '<' && runtext[num + 1] == '%')
                {
                    num += 2;
                    this.CheckTimeout();
                    if ((num2 = runtextend - num) > 0)
                    {
                        runtrack[--runtrackpos] = num2 - 1;
                        runtrack[--runtrackpos] = num;
                        runtrack[--runtrackpos] = 2;
                    }
                    goto IL_010c;
                }
            }
            goto IL_030e;
            IL_028d:
            this.CheckTimeout();
            if (2 <= runtextend - num && runtext[num] == '%' && runtext[num + 1] == '>')
            {
                num += 2;
                this.CheckTimeout();
                num2 = runstack[runstackpos++];
                this.Capture(0, num2, num);
                runtrack[--runtrackpos] = num2;
                runtrack[--runtrackpos] = 5;
                goto IL_02ff;
            }
            goto IL_030e;
            IL_045f:
            int num4;
            if (num4 > 0)
            {
                runtrack[--runtrackpos] = num4 - 1;
                runtrack[--runtrackpos] = num;
                runtrack[--runtrackpos] = 4;
            }
            goto IL_01bd;
            IL_03dc:
            if (num4 > 0)
            {
                runtrack[--runtrackpos] = num4 - 1;
                runtrack[--runtrackpos] = num;
                runtrack[--runtrackpos] = 2;
            }
            goto IL_010c;
            IL_01f3:
            this.CheckTimeout();
            num2 = runstack[runstackpos++];
            int num7 = num4 = runstack[runstackpos++];
            runtrack[--runtrackpos] = num4;
            if ((num7 != num || num2 < 0) && num2 < 1)
            {
                runstack[--runstackpos] = num;
                runstack[--runstackpos] = num2 + 1;
                runtrack[--runtrackpos] = 6;
                if (runtrackpos > 40 && runstackpos > 30)
                {
                    goto IL_0166;
                }
                runtrack[--runtrackpos] = 7;
                goto IL_030e;
            }
            runtrack[--runtrackpos] = num2;
            runtrack[--runtrackpos] = 8;
            goto IL_028d;
            IL_010c:
            this.CheckTimeout();
            if (num < runtextend && runtext[num++] == '=')
            {
                this.CheckTimeout();
                runstack[--runstackpos] = -1;
                runstack[--runstackpos] = 0;
                runtrack[--runtrackpos] = 3;
                this.CheckTimeout();
                goto IL_01f3;
            }
            goto IL_030e;
            IL_030e:
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
                    case 7:
                        break;
                    default:
                        goto IL_0377;
                    case 1:
                        this.CheckTimeout();
                        runstackpos++;
                        continue;
                    case 2:
                        goto IL_03a0;
                    case 3:
                        this.CheckTimeout();
                        runstackpos += 2;
                        continue;
                    case 4:
                        goto IL_0423;
                    case 5:
                        this.CheckTimeout();
                        runstack[--runstackpos] = runtrack[runtrackpos++];
                        this.Uncapture();
                        continue;
                    case 6:
                        goto IL_04b9;
                    case 8:
                        this.CheckTimeout();
                        num2 = runtrack[runtrackpos++];
                        runstack[--runstackpos] = runtrack[runtrackpos++];
                        runstack[--runstackpos] = num2;
                        continue;
                }
                break;
                IL_04b9:
                this.CheckTimeout();
                if ((num2 = runstack[runstackpos++] - 1) >= 0)
                {
                    goto IL_04d3;
                }
                runstack[runstackpos] = runtrack[runtrackpos++];
                runstack[--runstackpos] = num2;
                continue;
                IL_03a0:
                this.CheckTimeout();
                num = runtrack[runtrackpos++];
                num4 = runtrack[runtrackpos++];
                if (!RegexRunner.CharInClass(runtext[num++], "\0\0\u0001d"))
                {
                    continue;
                }
                goto IL_03dc;
                IL_0423:
                this.CheckTimeout();
                num = runtrack[runtrackpos++];
                num4 = runtrack[runtrackpos++];
                if (!RegexRunner.CharInClass(runtext[num++], "\0\u0001\0\0"))
                {
                    continue;
                }
                goto IL_045f;
            }
            goto IL_0166;
            IL_02ff:
            this.CheckTimeout();
            base.runtextpos = num;
            return;
            IL_01bd:
            this.CheckTimeout();
            num2 = runstack[runstackpos++];
            this.Capture(1, num2, num);
            runtrack[--runtrackpos] = num2;
            runtrack[--runtrackpos] = 5;
            goto IL_01f3;
            IL_04d3:
            num = runstack[runstackpos++];
            runtrack[--runtrackpos] = num2;
            runtrack[--runtrackpos] = 8;
            goto IL_028d;
            IL_0166:
            this.CheckTimeout();
            runstack[--runstackpos] = num;
            runtrack[--runtrackpos] = 1;
            this.CheckTimeout();
            if ((num2 = runtextend - num) > 0)
            {
                runtrack[--runtrackpos] = num2 - 1;
                runtrack[--runtrackpos] = num;
                runtrack[--runtrackpos] = 4;
            }
            goto IL_01bd;
            IL_0377:
            this.CheckTimeout();
            num = runtrack[runtrackpos++];
            goto IL_02ff;
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