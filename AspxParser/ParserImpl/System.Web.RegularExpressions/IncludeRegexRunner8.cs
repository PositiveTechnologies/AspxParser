using System.Globalization;
using System.Text.RegularExpressions;

namespace System.Web.RegularExpressions
{
    internal class IncludeRegexRunner8 : RegexRunner
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
            int num2;
            if (runtextpos == base.runtextstart)
            {
                this.CheckTimeout();
                if (4 <= runtextend - runtextpos && runtext[runtextpos] == '<' && runtext[runtextpos + 1] == '!' && runtext[runtextpos + 2] == '-' && runtext[runtextpos + 3] == '-')
                {
                    runtextpos += 4;
                    this.CheckTimeout();
                    num2 = (num = runtextend - runtextpos) + 1;
                    while (--num2 > 0)
                    {
                        if (RegexRunner.CharInClass(runtext[runtextpos++], "\0\0\u0001d"))
                        {
                            continue;
                        }
                        runtextpos--;
                        break;
                    }
                    if (num > num2)
                    {
                        runtrack[--runtrackpos] = num - num2 - 1;
                        runtrack[--runtrackpos] = runtextpos - 1;
                        runtrack[--runtrackpos] = 2;
                    }
                    goto IL_0173;
                }
            }
            goto IL_07c0;
            IL_09db:
            this.CheckTimeout();
            runtextpos = runtrack[runtrackpos++];
            num2 = runtrack[runtrackpos++];
            if (num2 > 0)
            {
                runtrack[--runtrackpos] = num2 - 1;
                runtrack[--runtrackpos] = runtextpos - 1;
                runtrack[--runtrackpos] = 7;
            }
            goto IL_0521;
            IL_07b1:
            this.CheckTimeout();
            base.runtextpos = runtextpos;
            return;
            IL_0985:
            this.CheckTimeout();
            runtextpos = runtrack[runtrackpos++];
            num2 = runtrack[runtrackpos++];
            if (num2 > 0)
            {
                runtrack[--runtrackpos] = num2 - 1;
                runtrack[--runtrackpos] = runtextpos - 1;
                runtrack[--runtrackpos] = 6;
            }
            goto IL_0482;
            IL_085e:
            this.CheckTimeout();
            runtextpos = runtrack[runtrackpos++];
            num2 = runtrack[runtrackpos++];
            if (num2 > 0)
            {
                runtrack[--runtrackpos] = num2 - 1;
                runtrack[--runtrackpos] = runtextpos - 1;
                runtrack[--runtrackpos] = 2;
            }
            goto IL_0173;
            IL_05a3:
            this.CheckTimeout();
            runstack[--runstackpos] = runtextpos;
            runtrack[--runtrackpos] = 1;
            this.CheckTimeout();
            if ((num2 = runtextend - runtextpos) > 0)
            {
                runtrack[--runtrackpos] = num2 - 1;
                runtrack[--runtrackpos] = runtextpos;
                runtrack[--runtrackpos] = 9;
            }
            goto IL_05fa;
            IL_090a:
            this.CheckTimeout();
            runtextpos = runtrack[runtrackpos++];
            num2 = runtrack[runtrackpos++];
            if (num2 > 0)
            {
                runtrack[--runtrackpos] = num2 - 1;
                runtrack[--runtrackpos] = runtextpos - 1;
                runtrack[--runtrackpos] = 4;
            }
            goto IL_03d2;
            IL_06b2:
            this.CheckTimeout();
            num2 = (num = runtextend - runtextpos) + 1;
            while (--num2 > 0)
            {
                if (RegexRunner.CharInClass(runtext[runtextpos++], "\0\0\u0001d"))
                {
                    continue;
                }
                runtextpos--;
                break;
            }
            if (num > num2)
            {
                runtrack[--runtrackpos] = num - num2 - 1;
                runtrack[--runtrackpos] = runtextpos - 1;
                runtrack[--runtrackpos] = 11;
            }
            goto IL_072c;
            IL_03d2:
            this.CheckTimeout();
            num2 = runstack[runstackpos++];
            this.Capture(1, num2, runtextpos);
            runtrack[--runtrackpos] = num2;
            runtrack[--runtrackpos] = 5;
            this.CheckTimeout();
            num2 = (num = runtextend - runtextpos) + 1;
            while (--num2 > 0)
            {
                if (RegexRunner.CharInClass(runtext[runtextpos++], "\0\0\u0001d"))
                {
                    continue;
                }
                runtextpos--;
                break;
            }
            if (num > num2)
            {
                runtrack[--runtrackpos] = num - num2 - 1;
                runtrack[--runtrackpos] = runtextpos - 1;
                runtrack[--runtrackpos] = 6;
            }
            goto IL_0482;
            IL_0521:
            this.CheckTimeout();
            int num15 = runtextend - runtextpos;
            if (num15 >= 1)
            {
                num15 = 1;
            }
            num = num15;
            num2 = num15 + 1;
            while (--num2 > 0)
            {
                if (RegexRunner.CharInClass(runtext[runtextpos++], "\0\u0004\0\"#'("))
                {
                    continue;
                }
                runtextpos--;
                break;
            }
            if (num > num2)
            {
                runtrack[--runtrackpos] = num - num2 - 1;
                runtrack[--runtrackpos] = runtextpos - 1;
                runtrack[--runtrackpos] = 8;
            }
            goto IL_05a3;
            IL_08b4:
            this.CheckTimeout();
            runtextpos = runtrack[runtrackpos++];
            num2 = runtrack[runtrackpos++];
            if (num2 > 0)
            {
                runtrack[--runtrackpos] = num2 - 1;
                runtrack[--runtrackpos] = runtextpos - 1;
                runtrack[--runtrackpos] = 3;
            }
            goto IL_02f3;
            IL_05fa:
            this.CheckTimeout();
            num2 = runstack[runstackpos++];
            this.Capture(2, num2, runtextpos);
            runtrack[--runtrackpos] = num2;
            runtrack[--runtrackpos] = 5;
            this.CheckTimeout();
            int num20 = runtextend - runtextpos;
            if (num20 >= 1)
            {
                num20 = 1;
            }
            num = num20;
            num2 = num20 + 1;
            while (--num2 > 0)
            {
                if (RegexRunner.CharInClass(runtext[runtextpos++], "\0\u0004\0\"#'("))
                {
                    continue;
                }
                runtextpos--;
                break;
            }
            if (num > num2)
            {
                runtrack[--runtrackpos] = num - num2 - 1;
                runtrack[--runtrackpos] = runtextpos - 1;
                runtrack[--runtrackpos] = 10;
            }
            goto IL_06b2;
            IL_07c0:
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
                        goto IL_085e;
                    case 3:
                        goto IL_08b4;
                    case 4:
                        goto IL_090a;
                    case 5:
                        this.CheckTimeout();
                        runstack[--runstackpos] = runtrack[runtrackpos++];
                        this.Uncapture();
                        continue;
                    case 6:
                        goto IL_0985;
                    case 7:
                        goto IL_09db;
                    case 8:
                        goto IL_0a31;
                    case 9:
                        goto IL_0a87;
                    case 10:
                        goto IL_0af8;
                    case 11:
                        goto IL_0b4e;
                }
                break;
                IL_0a87:
                this.CheckTimeout();
                runtextpos = runtrack[runtrackpos++];
                num = runtrack[runtrackpos++];
                if (!RegexRunner.CharInClass(runtext[runtextpos++], "\u0001\u0004\0\"#'("))
                {
                    continue;
                }
                goto IL_0ac3;
            }
            this.CheckTimeout();
            runtextpos = runtrack[runtrackpos++];
            goto IL_07b1;
            IL_0b4e:
            this.CheckTimeout();
            runtextpos = runtrack[runtrackpos++];
            num2 = runtrack[runtrackpos++];
            if (num2 > 0)
            {
                runtrack[--runtrackpos] = num2 - 1;
                runtrack[--runtrackpos] = runtextpos - 1;
                runtrack[--runtrackpos] = 11;
            }
            goto IL_072c;
            IL_0173:
            this.CheckTimeout();
            if (runtextpos < runtextend && runtext[runtextpos++] == '#')
            {
                this.CheckTimeout();
                if (7 <= runtextend - runtextpos && char.ToLower(runtext[runtextpos], CultureInfo.CurrentCulture) == 'i' && char.ToLower(runtext[runtextpos + 1], CultureInfo.CurrentCulture) == 'n' && char.ToLower(runtext[runtextpos + 2], CultureInfo.CurrentCulture) == 'c' && char.ToLower(runtext[runtextpos + 3], CultureInfo.CurrentCulture) == 'l' && char.ToLower(runtext[runtextpos + 4], CultureInfo.CurrentCulture) == 'u' && char.ToLower(runtext[runtextpos + 5], CultureInfo.CurrentCulture) == 'd' && char.ToLower(runtext[runtextpos + 6], CultureInfo.CurrentCulture) == 'e')
                {
                    runtextpos += 7;
                    this.CheckTimeout();
                    num2 = (num = runtextend - runtextpos) + 1;
                    while (--num2 > 0)
                    {
                        if (RegexRunner.CharInClass(runtext[runtextpos++], "\0\0\u0001d"))
                        {
                            continue;
                        }
                        runtextpos--;
                        break;
                    }
                    if (num > num2)
                    {
                        runtrack[--runtrackpos] = num - num2 - 1;
                        runtrack[--runtrackpos] = runtextpos - 1;
                        runtrack[--runtrackpos] = 3;
                    }
                    goto IL_02f3;
                }
            }
            goto IL_07c0;
            IL_0af8:
            this.CheckTimeout();
            runtextpos = runtrack[runtrackpos++];
            num2 = runtrack[runtrackpos++];
            if (num2 > 0)
            {
                runtrack[--runtrackpos] = num2 - 1;
                runtrack[--runtrackpos] = runtextpos - 1;
                runtrack[--runtrackpos] = 10;
            }
            goto IL_06b2;
            IL_0358:
            this.CheckTimeout();
            num2 = (num = runtextend - runtextpos) + 1;
            while (--num2 > 0)
            {
                if (RegexRunner.CharInClass(runtext[runtextpos++], "\0\0\n\0\u0002\u0004\u0005\u0003\u0001\u0006\t\u0013\0"))
                {
                    continue;
                }
                runtextpos--;
                break;
            }
            if (num > num2)
            {
                runtrack[--runtrackpos] = num - num2 - 1;
                runtrack[--runtrackpos] = runtextpos - 1;
                runtrack[--runtrackpos] = 4;
            }
            goto IL_03d2;
            IL_0482:
            this.CheckTimeout();
            if (runtextpos < runtextend && runtext[runtextpos++] == '=')
            {
                this.CheckTimeout();
                num2 = (num = runtextend - runtextpos) + 1;
                while (--num2 > 0)
                {
                    if (RegexRunner.CharInClass(runtext[runtextpos++], "\0\0\u0001d"))
                    {
                        continue;
                    }
                    runtextpos--;
                    break;
                }
                if (num > num2)
                {
                    runtrack[--runtrackpos] = num - num2 - 1;
                    runtrack[--runtrackpos] = runtextpos - 1;
                    runtrack[--runtrackpos] = 7;
                }
                goto IL_0521;
            }
            goto IL_07c0;
            IL_0ac3:
            if (num > 0)
            {
                runtrack[--runtrackpos] = num - 1;
                runtrack[--runtrackpos] = runtextpos;
                runtrack[--runtrackpos] = 9;
            }
            goto IL_05fa;
            IL_072c:
            this.CheckTimeout();
            if (3 <= runtextend - runtextpos && runtext[runtextpos] == '-' && runtext[runtextpos + 1] == '-' && runtext[runtextpos + 2] == '>')
            {
                runtextpos += 3;
                this.CheckTimeout();
                num2 = runstack[runstackpos++];
                this.Capture(0, num2, runtextpos);
                runtrack[--runtrackpos] = num2;
                runtrack[--runtrackpos] = 5;
                goto IL_07b1;
            }
            goto IL_07c0;
            IL_0a31:
            this.CheckTimeout();
            runtextpos = runtrack[runtrackpos++];
            num2 = runtrack[runtrackpos++];
            if (num2 > 0)
            {
                runtrack[--runtrackpos] = num2 - 1;
                runtrack[--runtrackpos] = runtextpos - 1;
                runtrack[--runtrackpos] = 8;
            }
            goto IL_05a3;
            IL_02f3:
            this.CheckTimeout();
            runstack[--runstackpos] = runtextpos;
            runtrack[--runtrackpos] = 1;
            this.CheckTimeout();
            if (1 <= runtextend - runtextpos)
            {
                runtextpos++;
                num2 = 1;
                while (true)
                {
                    if (!RegexRunner.CharInClass(runtext[runtextpos - num2--], "\0\0\n\0\u0002\u0004\u0005\u0003\u0001\u0006\t\u0013\0"))
                    {
                        break;
                    }
                    if (num2 > 0)
                    {
                        continue;
                    }
                    goto IL_0358;
                }
            }
            goto IL_07c0;
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
            base.runtrackcount = 16;
        }
    }
}