using System.Text.RegularExpressions;

namespace System.Web.RegularExpressions
{
    internal class TagRegexRunner1 : RegexRunner
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
            int num3;
            if (num == base.runtextstart)
            {
                this.CheckTimeout();
                if (num < runtextend && runtext[num++] == '<')
                {
                    this.CheckTimeout();
                    runstack[--runstackpos] = num;
                    runtrack[--runtrackpos] = 1;
                    this.CheckTimeout();
                    if (1 <= runtextend - num)
                    {
                        num++;
                        num3 = 1;
                        while (true)
                        {
                            if (!RegexRunner.CharInClass(runtext[num - num3--], "\0\u0004\n./:;\0\u0002\u0004\u0005\u0003\u0001\u0006\t\u0013\0"))
                            {
                                break;
                            }
                            if (num3 > 0)
                            {
                                continue;
                            }
                            goto IL_0121;
                        }
                    }
                }
            }
            goto IL_1098;
            IL_0a9c:
            num += 2;
            this.CheckTimeout();
            num3 = runstack[runstackpos++];
            this.Capture(5, num3, num);
            runtrack[--runtrackpos] = num3;
            runtrack[--runtrackpos] = 3;
            this.CheckTimeout();
            goto IL_0d81;
            IL_01fa:
            this.CheckTimeout();
            runstack[--runstackpos] = num;
            runtrack[--runtrackpos] = 1;
            this.CheckTimeout();
            if (1 <= runtextend - num)
            {
                num++;
                num3 = 1;
                while (true)
                {
                    if (!RegexRunner.CharInClass(runtext[num - num3--], "\0\0\u0001d"))
                    {
                        break;
                    }
                    if (num3 > 0)
                    {
                        continue;
                    }
                    goto IL_025f;
                }
            }
            goto IL_1098;
            IL_12c0:
            this.CheckTimeout();
            num = runtrack[runtrackpos++];
            num3 = runtrack[runtrackpos++];
            if (num3 > 0)
            {
                runtrack[--runtrackpos] = num3 - 1;
                runtrack[--runtrackpos] = num - 1;
                runtrack[--runtrackpos] = 7;
            }
            goto IL_048a;
            IL_02d9:
            this.CheckTimeout();
            runstack[--runstackpos] = num;
            runtrack[--runtrackpos] = 1;
            this.CheckTimeout();
            int num10;
            if (num < runtextend && RegexRunner.CharInClass(runtext[num++], "\0\0\n\0\u0002\u0004\u0005\u0003\u0001\u0006\t\u0013\0"))
            {
                this.CheckTimeout();
                num3 = (num10 = runtextend - num) + 1;
                while (--num3 > 0)
                {
                    if (RegexRunner.CharInClass(runtext[num++], "\0\u0004\n-.:;\0\u0002\u0004\u0005\u0003\u0001\u0006\t\u0013\0"))
                    {
                        continue;
                    }
                    num--;
                    break;
                }
                if (num10 > num3)
                {
                    runtrack[--runtrackpos] = num10 - num3 - 1;
                    runtrack[--runtrackpos] = num - 1;
                    runtrack[--runtrackpos] = 5;
                }
                goto IL_039e;
            }
            goto IL_1098;
            IL_048a:
            this.CheckTimeout();
            if (num < runtextend && runtext[num++] == '=')
            {
                this.CheckTimeout();
                num3 = (num10 = runtextend - num) + 1;
                while (--num3 > 0)
                {
                    if (RegexRunner.CharInClass(runtext[num++], "\0\0\u0001d"))
                    {
                        continue;
                    }
                    num--;
                    break;
                }
                if (num10 > num3)
                {
                    runtrack[--runtrackpos] = num10 - num3 - 1;
                    runtrack[--runtrackpos] = num - 1;
                    runtrack[--runtrackpos] = 8;
                }
                goto IL_0529;
            }
            goto IL_1098;
            IL_1253:
            this.CheckTimeout();
            num = runtrack[runtrackpos++];
            num3 = runtrack[runtrackpos++];
            if (num3 > 0)
            {
                runtrack[--runtrackpos] = num3 - 1;
                runtrack[--runtrackpos] = num - 1;
                runtrack[--runtrackpos] = 5;
            }
            goto IL_039e;
            IL_0121:
            this.CheckTimeout();
            num3 = (num10 = runtextend - num) + 1;
            while (--num3 > 0)
            {
                if (RegexRunner.CharInClass(runtext[num++], "\0\u0004\n./:;\0\u0002\u0004\u0005\u0003\u0001\u0006\t\u0013\0"))
                {
                    continue;
                }
                num--;
                break;
            }
            if (num10 > num3)
            {
                runtrack[--runtrackpos] = num10 - num3 - 1;
                runtrack[--runtrackpos] = num - 1;
                runtrack[--runtrackpos] = 2;
            }
            goto IL_019b;
            IL_0f15:
            this.CheckTimeout();
            runstack[--runstackpos] = num;
            runtrack[--runtrackpos] = 1;
            this.CheckTimeout();
            if (num < runtextend && runtext[num++] == '/')
            {
                this.CheckTimeout();
                num3 = runstack[runstackpos++];
                this.Capture(6, num3, num);
                runtrack[--runtrackpos] = num3;
                runtrack[--runtrackpos] = 3;
                goto IL_0f8e;
            }
            goto IL_1098;
            IL_136c:
            this.CheckTimeout();
            num = runtrack[runtrackpos++];
            num3 = runtrack[runtrackpos++];
            if (num3 > 0)
            {
                runtrack[--runtrackpos] = num3 - 1;
                runtrack[--runtrackpos] = num - 1;
                runtrack[--runtrackpos] = 9;
            }
            goto IL_05d8;
            IL_11fd:
            this.CheckTimeout();
            num = runtrack[runtrackpos++];
            num3 = runtrack[runtrackpos++];
            if (num3 > 0)
            {
                runtrack[--runtrackpos] = num3 - 1;
                runtrack[--runtrackpos] = num - 1;
                runtrack[--runtrackpos] = 4;
            }
            goto IL_02d9;
            IL_025f:
            this.CheckTimeout();
            num3 = (num10 = runtextend - num) + 1;
            while (--num3 > 0)
            {
                if (RegexRunner.CharInClass(runtext[num++], "\0\0\u0001d"))
                {
                    continue;
                }
                num--;
                break;
            }
            if (num10 > num3)
            {
                runtrack[--runtrackpos] = num10 - num3 - 1;
                runtrack[--runtrackpos] = num - 1;
                runtrack[--runtrackpos] = 4;
            }
            goto IL_02d9;
            IL_0ee0:
            this.CheckTimeout();
            runstack[--runstackpos] = -1;
            runstack[--runstackpos] = 0;
            runtrack[--runtrackpos] = 27;
            this.CheckTimeout();
            goto IL_0f8e;
            IL_1098:
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
                    case 24:
                        break;
                    case 29:
                        goto IL_0f15;
                    default:
                        goto IL_1159;
                    case 1:
                        this.CheckTimeout();
                        runstackpos++;
                        continue;
                    case 2:
                        goto IL_1182;
                    case 3:
                        this.CheckTimeout();
                        runstack[--runstackpos] = runtrack[runtrackpos++];
                        this.Uncapture();
                        continue;
                    case 4:
                        goto IL_11fd;
                    case 5:
                        goto IL_1253;
                    case 6:
                        this.CheckTimeout();
                        num = runtrack[runtrackpos++];
                        this.CheckTimeout();
                        runtrack[--runtrackpos] = num;
                        runtrack[--runtrackpos] = 10;
                        this.CheckTimeout();
                        num3 = (num10 = runtextend - num) + 1;
                        while (--num3 > 0)
                        {
                            if (RegexRunner.CharInClass(runtext[num++], "\0\0\u0001d"))
                            {
                                continue;
                            }
                            num--;
                            break;
                        }
                        if (num10 > num3)
                        {
                            runtrack[--runtrackpos] = num10 - num3 - 1;
                            runtrack[--runtrackpos] = num - 1;
                            runtrack[--runtrackpos] = 11;
                        }
                        goto IL_06d6;
                    case 7:
                        goto IL_12c0;
                    case 8:
                        goto IL_1316;
                    case 9:
                        goto IL_136c;
                    case 10:
                        this.CheckTimeout();
                        num = runtrack[runtrackpos++];
                        this.CheckTimeout();
                        runtrack[--runtrackpos] = num;
                        runtrack[--runtrackpos] = 14;
                        this.CheckTimeout();
                        num3 = (num10 = runtextend - num) + 1;
                        while (--num3 > 0)
                        {
                            if (RegexRunner.CharInClass(runtext[num++], "\0\0\u0001d"))
                            {
                                continue;
                            }
                            num--;
                            break;
                        }
                        if (num10 > num3)
                        {
                            runtrack[--runtrackpos] = num10 - num3 - 1;
                            runtrack[--runtrackpos] = num - 1;
                            runtrack[--runtrackpos] = 15;
                        }
                        goto IL_0922;
                    case 11:
                        this.CheckTimeout();
                        num = runtrack[runtrackpos++];
                        num3 = runtrack[runtrackpos++];
                        if (num3 > 0)
                        {
                            runtrack[--runtrackpos] = num3 - 1;
                            runtrack[--runtrackpos] = num - 1;
                            runtrack[--runtrackpos] = 11;
                        }
                        goto IL_06d6;
                    case 12:
                        this.CheckTimeout();
                        num = runtrack[runtrackpos++];
                        num3 = runtrack[runtrackpos++];
                        if (num3 > 0)
                        {
                            runtrack[--runtrackpos] = num3 - 1;
                            runtrack[--runtrackpos] = num - 1;
                            runtrack[--runtrackpos] = 12;
                        }
                        goto IL_0775;
                    case 13:
                        this.CheckTimeout();
                        num = runtrack[runtrackpos++];
                        num3 = runtrack[runtrackpos++];
                        if (num3 > 0)
                        {
                            runtrack[--runtrackpos] = num3 - 1;
                            runtrack[--runtrackpos] = num - 1;
                            runtrack[--runtrackpos] = 13;
                        }
                        goto IL_0824;
                    case 14:
                        this.CheckTimeout();
                        num = runtrack[runtrackpos++];
                        this.CheckTimeout();
                        runtrack[--runtrackpos] = num;
                        runtrack[--runtrackpos] = 18;
                        this.CheckTimeout();
                        num3 = (num10 = runtextend - num) + 1;
                        while (--num3 > 0)
                        {
                            if (RegexRunner.CharInClass(runtext[num++], "\0\0\u0001d"))
                            {
                                continue;
                            }
                            num--;
                            break;
                        }
                        if (num10 > num3)
                        {
                            runtrack[--runtrackpos] = num10 - num3 - 1;
                            runtrack[--runtrackpos] = num - 1;
                            runtrack[--runtrackpos] = 19;
                        }
                        goto IL_0b7c;
                    case 15:
                        this.CheckTimeout();
                        num = runtrack[runtrackpos++];
                        num3 = runtrack[runtrackpos++];
                        if (num3 > 0)
                        {
                            runtrack[--runtrackpos] = num3 - 1;
                            runtrack[--runtrackpos] = num - 1;
                            runtrack[--runtrackpos] = 15;
                        }
                        goto IL_0922;
                    case 16:
                        this.CheckTimeout();
                        num = runtrack[runtrackpos++];
                        num3 = runtrack[runtrackpos++];
                        if (num3 > 0)
                        {
                            runtrack[--runtrackpos] = num3 - 1;
                            runtrack[--runtrackpos] = num - 1;
                            runtrack[--runtrackpos] = 16;
                        }
                        goto IL_09c1;
                    case 17:
                        this.CheckTimeout();
                        num = runtrack[runtrackpos++];
                        num10 = runtrack[runtrackpos++];
                        if (!RegexRunner.CharInClass(runtext[num++], "\0\u0001\0\0"))
                        {
                            continue;
                        }
                        if (num10 > 0)
                        {
                            runtrack[--runtrackpos] = num10 - 1;
                            runtrack[--runtrackpos] = num;
                            runtrack[--runtrackpos] = 17;
                        }
                        goto IL_0a67;
                    case 18:
                        this.CheckTimeout();
                        num = runtrack[runtrackpos++];
                        this.CheckTimeout();
                        runstack[--runstackpos] = num;
                        runtrack[--runtrackpos] = 1;
                        this.CheckTimeout();
                        if ((num3 = runtextend - num) > 0)
                        {
                            runtrack[--runtrackpos] = num3 - 1;
                            runtrack[--runtrackpos] = num;
                            runtrack[--runtrackpos] = 22;
                        }
                        goto IL_0d4b;
                    case 19:
                        this.CheckTimeout();
                        num = runtrack[runtrackpos++];
                        num3 = runtrack[runtrackpos++];
                        if (num3 > 0)
                        {
                            runtrack[--runtrackpos] = num3 - 1;
                            runtrack[--runtrackpos] = num - 1;
                            runtrack[--runtrackpos] = 19;
                        }
                        goto IL_0b7c;
                    case 20:
                        this.CheckTimeout();
                        num = runtrack[runtrackpos++];
                        num3 = runtrack[runtrackpos++];
                        if (num3 > 0)
                        {
                            runtrack[--runtrackpos] = num3 - 1;
                            runtrack[--runtrackpos] = num - 1;
                            runtrack[--runtrackpos] = 20;
                        }
                        goto IL_0c1b;
                    case 21:
                        this.CheckTimeout();
                        num = runtrack[runtrackpos++];
                        num3 = runtrack[runtrackpos++];
                        if (num3 > 0)
                        {
                            runtrack[--runtrackpos] = num3 - 1;
                            runtrack[--runtrackpos] = num - 1;
                            runtrack[--runtrackpos] = 21;
                        }
                        goto IL_0cb3;
                    case 22:
                        this.CheckTimeout();
                        num = runtrack[runtrackpos++];
                        num10 = runtrack[runtrackpos++];
                        if (!RegexRunner.CharInClass(runtext[num++], "\0\0\u0001d"))
                        {
                            continue;
                        }
                        if (num10 > 0)
                        {
                            runtrack[--runtrackpos] = num10 - 1;
                            runtrack[--runtrackpos] = num;
                            runtrack[--runtrackpos] = 22;
                        }
                        goto IL_0d4b;
                    case 23:
                        goto IL_1799;
                    case 25:
                        this.CheckTimeout();
                        runstack[--runstackpos] = runtrack[runtrackpos++];
                        continue;
                    case 26:
                        goto IL_17e6;
                    case 27:
                        this.CheckTimeout();
                        runstackpos += 2;
                        continue;
                    case 28:
                        goto IL_184e;
                    case 30:
                        {
                            this.CheckTimeout();
                            num3 = runtrack[runtrackpos++];
                            runstack[--runstackpos] = runtrack[runtrackpos++];
                            runstack[--runstackpos] = num3;
                            continue;
                        }
                        IL_09c1:
                        this.CheckTimeout();
                        runstack[--runstackpos] = num;
                        runtrack[--runtrackpos] = 1;
                        this.CheckTimeout();
                        if (3 <= runtextend - num && runtext[num] == '<' && runtext[num + 1] == '%' && runtext[num + 2] == '#')
                        {
                            num += 3;
                            this.CheckTimeout();
                            if ((num3 = runtextend - num) > 0)
                            {
                                runtrack[--runtrackpos] = num3 - 1;
                                runtrack[--runtrackpos] = num;
                                runtrack[--runtrackpos] = 17;
                            }
                            goto IL_0a67;
                        }
                        continue;
                        IL_0775:
                        this.CheckTimeout();
                        if (num < runtextend && runtext[num++] == '\'')
                        {
                            this.CheckTimeout();
                            runstack[--runstackpos] = num;
                            runtrack[--runtrackpos] = 1;
                            this.CheckTimeout();
                            num3 = (num10 = runtextend - num) + 1;
                            while (--num3 > 0)
                            {
                                if (runtext[num++] != '\'')
                                {
                                    continue;
                                }
                                num--;
                                break;
                            }
                            if (num10 > num3)
                            {
                                runtrack[--runtrackpos] = num10 - num3 - 1;
                                runtrack[--runtrackpos] = num - 1;
                                runtrack[--runtrackpos] = 13;
                            }
                            goto IL_0824;
                        }
                        continue;
                        IL_0c1b:
                        this.CheckTimeout();
                        runstack[--runstackpos] = num;
                        runtrack[--runtrackpos] = 1;
                        this.CheckTimeout();
                        num3 = (num10 = runtextend - num) + 1;
                        while (--num3 > 0)
                        {
                            if (RegexRunner.CharInClass(runtext[num++], "\u0001\b\u0001\"#'(/0=?d"))
                            {
                                continue;
                            }
                            num--;
                            break;
                        }
                        if (num10 > num3)
                        {
                            runtrack[--runtrackpos] = num10 - num3 - 1;
                            runtrack[--runtrackpos] = num - 1;
                            runtrack[--runtrackpos] = 21;
                        }
                        goto IL_0cb3;
                        IL_0922:
                        this.CheckTimeout();
                        if (num < runtextend && runtext[num++] == '=')
                        {
                            this.CheckTimeout();
                            num3 = (num10 = runtextend - num) + 1;
                            while (--num3 > 0)
                            {
                                if (RegexRunner.CharInClass(runtext[num++], "\0\0\u0001d"))
                                {
                                    continue;
                                }
                                num--;
                                break;
                            }
                            if (num10 > num3)
                            {
                                runtrack[--runtrackpos] = num10 - num3 - 1;
                                runtrack[--runtrackpos] = num - 1;
                                runtrack[--runtrackpos] = 16;
                            }
                            goto IL_09c1;
                        }
                        continue;
                        IL_0d4b:
                        this.CheckTimeout();
                        num3 = runstack[runstackpos++];
                        this.Capture(5, num3, num);
                        runtrack[--runtrackpos] = num3;
                        runtrack[--runtrackpos] = 3;
                        goto IL_0d81;
                        IL_06d6:
                        this.CheckTimeout();
                        if (num < runtextend && runtext[num++] == '=')
                        {
                            this.CheckTimeout();
                            num3 = (num10 = runtextend - num) + 1;
                            while (--num3 > 0)
                            {
                                if (RegexRunner.CharInClass(runtext[num++], "\0\0\u0001d"))
                                {
                                    continue;
                                }
                                num--;
                                break;
                            }
                            if (num10 > num3)
                            {
                                runtrack[--runtrackpos] = num10 - num3 - 1;
                                runtrack[--runtrackpos] = num - 1;
                                runtrack[--runtrackpos] = 12;
                            }
                            goto IL_0775;
                        }
                        continue;
                        IL_0cb3:
                        this.CheckTimeout();
                        num3 = runstack[runstackpos++];
                        this.Capture(5, num3, num);
                        runtrack[--runtrackpos] = num3;
                        runtrack[--runtrackpos] = 3;
                        this.CheckTimeout();
                        goto IL_0d81;
                        IL_0824:
                        this.CheckTimeout();
                        num3 = runstack[runstackpos++];
                        this.Capture(5, num3, num);
                        runtrack[--runtrackpos] = num3;
                        runtrack[--runtrackpos] = 3;
                        this.CheckTimeout();
                        if (num < runtextend)
                        {
                            goto IL_0869;
                        }
                        continue;
                        IL_0a67:
                        this.CheckTimeout();
                        if (2 <= runtextend - num)
                        {
                            goto IL_0a79;
                        }
                        continue;
                        IL_0b7c:
                        this.CheckTimeout();
                        if (num < runtextend && runtext[num++] == '=')
                        {
                            this.CheckTimeout();
                            num3 = (num10 = runtextend - num) + 1;
                            while (--num3 > 0)
                            {
                                if (RegexRunner.CharInClass(runtext[num++], "\0\0\u0001d"))
                                {
                                    continue;
                                }
                                num--;
                                break;
                            }
                            if (num10 > num3)
                            {
                                runtrack[--runtrackpos] = num10 - num3 - 1;
                                runtrack[--runtrackpos] = num - 1;
                                runtrack[--runtrackpos] = 20;
                            }
                            goto IL_0c1b;
                        }
                        continue;
                }
                break;
                IL_184e:
                this.CheckTimeout();
                if ((num3 = runstack[runstackpos++] - 1) >= 0)
                {
                    goto IL_1868;
                }
                runstack[runstackpos] = runtrack[runtrackpos++];
                runstack[--runstackpos] = num3;
                continue;
                IL_0869:
                if (runtext[num++] == '\'')
                {
                    goto IL_087f;
                }
                continue;
                IL_0a79:
                if (runtext[num] == '%' && runtext[num + 1] == '>')
                {
                    goto IL_0a9c;
                }
            }
            goto IL_01fa;
            IL_0e66:
            this.CheckTimeout();
            num3 = (num10 = runtextend - num) + 1;
            while (--num3 > 0)
            {
                if (RegexRunner.CharInClass(runtext[num++], "\0\0\u0001d"))
                {
                    continue;
                }
                num--;
                break;
            }
            if (num10 > num3)
            {
                runtrack[--runtrackpos] = num10 - num3 - 1;
                runtrack[--runtrackpos] = num - 1;
                runtrack[--runtrackpos] = 26;
            }
            goto IL_0ee0;
            IL_1316:
            this.CheckTimeout();
            num = runtrack[runtrackpos++];
            num3 = runtrack[runtrackpos++];
            if (num3 > 0)
            {
                runtrack[--runtrackpos] = num3 - 1;
                runtrack[--runtrackpos] = num - 1;
                runtrack[--runtrackpos] = 8;
            }
            goto IL_0529;
            IL_1868:
            num = runstack[runstackpos++];
            runtrack[--runtrackpos] = num3;
            runtrack[--runtrackpos] = 30;
            goto IL_102e;
            IL_0d81:
            this.CheckTimeout();
            num3 = runstack[runstackpos++];
            this.Capture(2, num3, num);
            runtrack[--runtrackpos] = num3;
            runtrack[--runtrackpos] = 3;
            this.CheckTimeout();
            num3 = runstack[runstackpos++];
            this.Capture(1, num3, num);
            runtrack[--runtrackpos] = num3;
            runtrack[--runtrackpos] = 3;
            goto IL_0ded;
            IL_1182:
            this.CheckTimeout();
            num = runtrack[runtrackpos++];
            num3 = runtrack[runtrackpos++];
            if (num3 > 0)
            {
                runtrack[--runtrackpos] = num3 - 1;
                runtrack[--runtrackpos] = num - 1;
                runtrack[--runtrackpos] = 2;
            }
            goto IL_019b;
            IL_17e6:
            this.CheckTimeout();
            num = runtrack[runtrackpos++];
            num3 = runtrack[runtrackpos++];
            if (num3 > 0)
            {
                runtrack[--runtrackpos] = num3 - 1;
                runtrack[--runtrackpos] = num - 1;
                runtrack[--runtrackpos] = 26;
            }
            goto IL_0ee0;
            IL_1089:
            this.CheckTimeout();
            base.runtextpos = num;
            return;
            IL_087f:
            this.CheckTimeout();
            goto IL_0d81;
            IL_1799:
            this.CheckTimeout();
            num = runtrack[runtrackpos++];
            int num100 = runstack[runstackpos++];
            runtrack[--runtrackpos] = 25;
            goto IL_0e66;
            IL_039e:
            this.CheckTimeout();
            num3 = runstack[runstackpos++];
            this.Capture(4, num3, num);
            runtrack[--runtrackpos] = num3;
            runtrack[--runtrackpos] = 3;
            this.CheckTimeout();
            runstack[--runstackpos] = num;
            runtrack[--runtrackpos] = 1;
            this.CheckTimeout();
            runtrack[--runtrackpos] = num;
            runtrack[--runtrackpos] = 6;
            this.CheckTimeout();
            num3 = (num10 = runtextend - num) + 1;
            while (--num3 > 0)
            {
                if (RegexRunner.CharInClass(runtext[num++], "\0\0\u0001d"))
                {
                    continue;
                }
                num--;
                break;
            }
            if (num10 > num3)
            {
                runtrack[--runtrackpos] = num10 - num3 - 1;
                runtrack[--runtrackpos] = num - 1;
                runtrack[--runtrackpos] = 7;
            }
            goto IL_048a;
            IL_05d8:
            this.CheckTimeout();
            num3 = runstack[runstackpos++];
            this.Capture(5, num3, num);
            runtrack[--runtrackpos] = num3;
            runtrack[--runtrackpos] = 3;
            this.CheckTimeout();
            if (num < runtextend && runtext[num++] == '"')
            {
                this.CheckTimeout();
                goto IL_0d81;
            }
            goto IL_1098;
            IL_019b:
            this.CheckTimeout();
            num3 = runstack[runstackpos++];
            this.Capture(3, num3, num);
            runtrack[--runtrackpos] = num3;
            runtrack[--runtrackpos] = 3;
            this.CheckTimeout();
            runstack[--runstackpos] = -1;
            runtrack[--runtrackpos] = 1;
            this.CheckTimeout();
            goto IL_0ded;
            IL_0ded:
            this.CheckTimeout();
            int num91 = num3 = runstack[runstackpos++];
            runtrack[--runtrackpos] = num3;
            if (num91 != num)
            {
                runtrack[--runtrackpos] = num;
                runstack[--runstackpos] = num;
                runtrack[--runtrackpos] = 23;
                if (runtrackpos > 212 && runstackpos > 159)
                {
                    goto IL_01fa;
                }
                runtrack[--runtrackpos] = 24;
                goto IL_1098;
            }
            runtrack[--runtrackpos] = 25;
            goto IL_0e66;
            IL_0529:
            this.CheckTimeout();
            if (num < runtextend && runtext[num++] == '"')
            {
                this.CheckTimeout();
                runstack[--runstackpos] = num;
                runtrack[--runtrackpos] = 1;
                this.CheckTimeout();
                num3 = (num10 = runtextend - num) + 1;
                while (--num3 > 0)
                {
                    if (runtext[num++] != '"')
                    {
                        continue;
                    }
                    num--;
                    break;
                }
                if (num10 > num3)
                {
                    runtrack[--runtrackpos] = num10 - num3 - 1;
                    runtrack[--runtrackpos] = num - 1;
                    runtrack[--runtrackpos] = 9;
                }
                goto IL_05d8;
            }
            goto IL_1098;
            IL_1159:
            this.CheckTimeout();
            num = runtrack[runtrackpos++];
            goto IL_1089;
            IL_0f8e:
            this.CheckTimeout();
            num3 = runstack[runstackpos++];
            int num97 = num10 = runstack[runstackpos++];
            runtrack[--runtrackpos] = num10;
            if ((num97 != num || num3 < 0) && num3 < 1)
            {
                runstack[--runstackpos] = num;
                runstack[--runstackpos] = num3 + 1;
                runtrack[--runtrackpos] = 28;
                if (runtrackpos > 212 && runstackpos > 159)
                {
                    goto IL_0f15;
                }
                runtrack[--runtrackpos] = 29;
                goto IL_1098;
            }
            runtrack[--runtrackpos] = num3;
            runtrack[--runtrackpos] = 30;
            goto IL_102e;
            IL_102e:
            this.CheckTimeout();
            if (num < runtextend && runtext[num++] == '>')
            {
                this.CheckTimeout();
                num3 = runstack[runstackpos++];
                this.Capture(0, num3, num);
                runtrack[--runtrackpos] = num3;
                runtrack[--runtrackpos] = 3;
                goto IL_1089;
            }
            goto IL_1098;
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
            base.runtrackcount = 53;
        }
    }
}