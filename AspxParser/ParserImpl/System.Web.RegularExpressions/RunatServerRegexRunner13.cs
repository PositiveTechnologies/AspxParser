using System.Globalization;
using System.Text.RegularExpressions;

namespace System.Web.RegularExpressions
{
    internal class RunatServerRegexRunner13 : RegexRunner
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
            int num2;
            if (5 <= runtextend - runtextpos && char.ToLower(runtext[runtextpos], CultureInfo.InvariantCulture) == 'r' && char.ToLower(runtext[runtextpos + 1], CultureInfo.InvariantCulture) == 'u' && char.ToLower(runtext[runtextpos + 2], CultureInfo.InvariantCulture) == 'n' && char.ToLower(runtext[runtextpos + 3], CultureInfo.InvariantCulture) == 'a' && char.ToLower(runtext[runtextpos + 4], CultureInfo.InvariantCulture) == 't')
            {
                runtextpos += 5;
                this.CheckTimeout();
                int num;
                num2 = (num = runtextend - runtextpos) + 1;
                while (--num2 > 0)
                {
                    if (RegexRunner.CharInClass(char.ToLower(runtext[runtextpos++], CultureInfo.InvariantCulture), "\u0001\0\n\0\u0002\u0004\u0005\u0003\u0001\u0006\t\u0013\0"))
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
                goto IL_01af;
            }
            goto IL_02b8;
            IL_01af:
            this.CheckTimeout();
            if (6 <= runtextend - runtextpos && char.ToLower(runtext[runtextpos], CultureInfo.InvariantCulture) == 's' && char.ToLower(runtext[runtextpos + 1], CultureInfo.InvariantCulture) == 'e' && char.ToLower(runtext[runtextpos + 2], CultureInfo.InvariantCulture) == 'r' && char.ToLower(runtext[runtextpos + 3], CultureInfo.InvariantCulture) == 'v' && char.ToLower(runtext[runtextpos + 4], CultureInfo.InvariantCulture) == 'e' && char.ToLower(runtext[runtextpos + 5], CultureInfo.InvariantCulture) == 'r')
            {
                runtextpos += 6;
                this.CheckTimeout();
                num2 = runstack[runstackpos++];
                this.Capture(0, num2, runtextpos);
                runtrack[--runtrackpos] = num2;
                runtrack[--runtrackpos] = 3;
                goto IL_02a9;
            }
            goto IL_02b8;
            IL_02b8:
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
                        goto IL_0336;
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
            goto IL_02a9;
            IL_02a9:
            this.CheckTimeout();
            base.runtextpos = runtextpos;
            return;
            IL_0336:
            this.CheckTimeout();
            runtextpos = runtrack[runtrackpos++];
            num2 = runtrack[runtrackpos++];
            if (num2 > 0)
            {
                runtrack[--runtrackpos] = num2 - 1;
                runtrack[--runtrackpos] = runtextpos - 1;
                runtrack[--runtrackpos] = 2;
            }
            goto IL_01af;
        }

        protected override bool FindFirstChar()
        {
            string runtext = base.runtext;
            int runtextend = base.runtextend;
            int num = base.runtextpos + 4;
            while (true)
            {
                if (num >= runtextend)
                {
                    break;
                }
                int num3;
                int num2;
                if ((num2 = char.ToLower(runtext[num], CultureInfo.InvariantCulture)) != 116)
                {
                    if ((uint)(num2 -= 97) > 20u)
                    {
                        num3 = 5;
                    }
                    else
                    {
                        switch (num2)
                        {
                            default:
                                num3 = 1;
                                break;
                            case 1:
                                num3 = 5;
                                break;
                            case 2:
                                num3 = 5;
                                break;
                            case 3:
                                num3 = 5;
                                break;
                            case 4:
                                num3 = 5;
                                break;
                            case 5:
                                num3 = 5;
                                break;
                            case 6:
                                num3 = 5;
                                break;
                            case 7:
                                num3 = 5;
                                break;
                            case 8:
                                num3 = 5;
                                break;
                            case 9:
                                num3 = 5;
                                break;
                            case 10:
                                num3 = 5;
                                break;
                            case 11:
                                num3 = 5;
                                break;
                            case 12:
                                num3 = 5;
                                break;
                            case 13:
                                num3 = 2;
                                break;
                            case 14:
                                num3 = 5;
                                break;
                            case 15:
                                num3 = 5;
                                break;
                            case 16:
                                num3 = 5;
                                break;
                            case 17:
                                num3 = 4;
                                break;
                            case 18:
                                num3 = 5;
                                break;
                            case 19:
                                num3 = 0;
                                break;
                            case 20:
                                num3 = 3;
                                break;
                        }
                    }
                    goto IL_001f;
                }
                num2 = num;
                if (char.ToLower(runtext[--num2], CultureInfo.InvariantCulture) != 'a')
                {
                    num3 = 1;
                    goto IL_001f;
                }
                if (char.ToLower(runtext[--num2], CultureInfo.InvariantCulture) != 'n')
                {
                    num3 = 1;
                    goto IL_001f;
                }
                if (char.ToLower(runtext[--num2], CultureInfo.InvariantCulture) != 'u')
                {
                    num3 = 1;
                    goto IL_001f;
                }
                if (char.ToLower(runtext[--num2], CultureInfo.InvariantCulture) != 'r')
                {
                    num3 = 1;
                    goto IL_001f;
                }
                base.runtextpos = num2;
                return true;
                IL_001f:
                num = num3 + num;
            }
            base.runtextpos = base.runtextend;
            return false;
        }

        protected override void InitTrackCount()
        {
            base.runtrackcount = 4;
        }
    }
}