using System.Text.RegularExpressions;

namespace System.Web.RegularExpressions
{
    internal class DatabindExprRegexRunner6 : RegexRunner
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
                if (3 <= runtextend - num && runtext[num] == '<' && runtext[num + 1] == '%' && runtext[num + 2] == '#')
                {
                    num += 3;
                    this.CheckTimeout();
                    runstack[--runstackpos] = -1;
                    runstack[--runstackpos] = 0;
                    runtrack[--runtrackpos] = 2;
                    this.CheckTimeout();
                    goto IL_0194;
                }
            }
            goto IL_040b;
            IL_011b:
            this.CheckTimeout();
            runstack[--runstackpos] = num;
            runtrack[--runtrackpos] = 1;
            this.CheckTimeout();
            int num4;
            if (num < runtextend && runtext[num++] == ':')
            {
                this.CheckTimeout();
                num4 = runstack[runstackpos++];
                this.Capture(1, num4, num);
                runtrack[--runtrackpos] = num4;
                runtrack[--runtrackpos] = 3;
                goto IL_0194;
            }
            goto IL_040b;
            IL_04f2:
            num = runstack[runstackpos++];
            runtrack[--runtrackpos] = num4;
            runtrack[--runtrackpos] = 6;
            goto IL_022e;
            IL_02f0:
            this.CheckTimeout();
            num4 = runstack[runstackpos++];
            int num8;
            int num9 = num8 = runstack[runstackpos++];
            runtrack[--runtrackpos] = num8;
            if ((num9 != num || num4 < 0) && num4 < 1)
            {
                runstack[--runstackpos] = num;
                runstack[--runstackpos] = num4 + 1;
                runtrack[--runtrackpos] = 8;
                if (runtrackpos > 56 && runstackpos > 42)
                {
                    goto IL_0263;
                }
                runtrack[--runtrackpos] = 9;
                goto IL_040b;
            }
            runtrack[--runtrackpos] = num4;
            runtrack[--runtrackpos] = 6;
            goto IL_038a;
            IL_0194:
            this.CheckTimeout();
            num4 = runstack[runstackpos++];
            int num12 = num8 = runstack[runstackpos++];
            runtrack[--runtrackpos] = num8;
            if ((num12 != num || num4 < 0) && num4 < 1)
            {
                runstack[--runstackpos] = num;
                runstack[--runstackpos] = num4 + 1;
                runtrack[--runtrackpos] = 4;
                if (runtrackpos > 56 && runstackpos > 42)
                {
                    goto IL_011b;
                }
                runtrack[--runtrackpos] = 5;
                goto IL_040b;
            }
            runtrack[--runtrackpos] = num4;
            runtrack[--runtrackpos] = 6;
            goto IL_022e;
            IL_0263:
            this.CheckTimeout();
            runstack[--runstackpos] = num;
            runtrack[--runtrackpos] = 1;
            this.CheckTimeout();
            if ((num4 = runtextend - num) > 0)
            {
                runtrack[--runtrackpos] = num4 - 1;
                runtrack[--runtrackpos] = num;
                runtrack[--runtrackpos] = 7;
            }
            goto IL_02ba;
            IL_040b:
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
                    case 5:
                        break;
                    case 9:
                        goto IL_0263;
                    default:
                        goto IL_0478;
                    case 1:
                        this.CheckTimeout();
                        runstackpos++;
                        continue;
                    case 2:
                        this.CheckTimeout();
                        runstackpos += 2;
                        continue;
                    case 3:
                        this.CheckTimeout();
                        runstack[--runstackpos] = runtrack[runtrackpos++];
                        this.Uncapture();
                        continue;
                    case 4:
                        goto IL_04d8;
                    case 6:
                        this.CheckTimeout();
                        num4 = runtrack[runtrackpos++];
                        runstack[--runstackpos] = runtrack[runtrackpos++];
                        runstack[--runstackpos] = num4;
                        continue;
                    case 7:
                        goto IL_0572;
                    case 8:
                        goto IL_05e3;
                }
                break;
                IL_05e3:
                this.CheckTimeout();
                if ((num4 = runstack[runstackpos++] - 1) >= 0)
                {
                    goto IL_05fd;
                }
                runstack[runstackpos] = runtrack[runtrackpos++];
                runstack[--runstackpos] = num4;
                continue;
                IL_04d8:
                this.CheckTimeout();
                if ((num4 = runstack[runstackpos++] - 1) >= 0)
                {
                    goto IL_04f2;
                }
                runstack[runstackpos] = runtrack[runtrackpos++];
                runstack[--runstackpos] = num4;
                continue;
                IL_0572:
                this.CheckTimeout();
                num = runtrack[runtrackpos++];
                num8 = runtrack[runtrackpos++];
                if (!RegexRunner.CharInClass(runtext[num++], "\0\u0001\0\0"))
                {
                    continue;
                }
                goto IL_05ae;
            }
            goto IL_011b;
            IL_0478:
            this.CheckTimeout();
            num = runtrack[runtrackpos++];
            goto IL_03fc;
            IL_05fd:
            num = runstack[runstackpos++];
            runtrack[--runtrackpos] = num4;
            runtrack[--runtrackpos] = 6;
            goto IL_038a;
            IL_02ba:
            this.CheckTimeout();
            num4 = runstack[runstackpos++];
            this.Capture(2, num4, num);
            runtrack[--runtrackpos] = num4;
            runtrack[--runtrackpos] = 3;
            goto IL_02f0;
            IL_038a:
            this.CheckTimeout();
            if (2 <= runtextend - num && runtext[num] == '%' && runtext[num + 1] == '>')
            {
                num += 2;
                this.CheckTimeout();
                num4 = runstack[runstackpos++];
                this.Capture(0, num4, num);
                runtrack[--runtrackpos] = num4;
                runtrack[--runtrackpos] = 3;
                goto IL_03fc;
            }
            goto IL_040b;
            IL_05ae:
            if (num8 > 0)
            {
                runtrack[--runtrackpos] = num8 - 1;
                runtrack[--runtrackpos] = num;
                runtrack[--runtrackpos] = 7;
            }
            goto IL_02ba;
            IL_022e:
            this.CheckTimeout();
            runstack[--runstackpos] = -1;
            runstack[--runstackpos] = 0;
            runtrack[--runtrackpos] = 2;
            this.CheckTimeout();
            goto IL_02f0;
            IL_03fc:
            this.CheckTimeout();
            base.runtextpos = num;
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
            base.runtrackcount = 14;
        }
    }
}