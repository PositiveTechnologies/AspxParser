using System.Text.RegularExpressions;

namespace System.Web.RegularExpressions
{
    internal class DirectiveRegexRunner2 : RegexRunner
    {
        protected unsafe override void Go()
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
            int num2;
            if (num == base.runtextstart)
            {
                this.CheckTimeout();
                if (2 <= runtextend - num && runtext[num] == '<' && runtext[num + 1] == '%')
                {
                    num += 2;
                    this.CheckTimeout();
                    num3 = (num2 = runtextend - num) + 1;
                    while (--num3 > 0)
                    {
                        if (RegexRunner.CharInClass(runtext[num++], "\0\0\u0001d"))
                        {
                            continue;
                        }
                        num--;
                        break;
                    }
                    if (num2 > num3)
                    {
                        runtrack[--runtrackpos] = num2 - num3 - 1;
                        runtrack[--runtrackpos] = num - 1;
                        runtrack[--runtrackpos] = 2;
                    }
                    goto IL_014d;
                }
            }
            goto IL_0e58;
            IL_0f05:
            this.CheckTimeout();
            num = runtrack[runtrackpos++];
            goto IL_0e49;
            IL_1177:
            this.CheckTimeout();
            num = runtrack[runtrackpos++];
            num3 = runtrack[runtrackpos++];
            if (num3 > 0)
            {
                runtrack[--runtrackpos] = num3 - 1;
                runtrack[--runtrackpos] = num - 1;
                runtrack[--runtrackpos] = 12;
            }
            goto IL_066e;
            IL_0dd7:
            this.CheckTimeout();
            if (2 <= runtextend - num && runtext[num] == '%' && runtext[num + 1] == '>')
            {
                num += 2;
                this.CheckTimeout();
                num3 = runstack[runstackpos++];
                this.Capture(0, num3, num);
                runtrack[--runtrackpos] = num3;
                runtrack[--runtrackpos] = 8;
                goto IL_0e49;
            }
            goto IL_0e58;
            IL_066e:
            this.CheckTimeout();
            num3 = runstack[runstackpos++];
            this.Capture(5, num3, num);
            runtrack[--runtrackpos] = num3;
            runtrack[--runtrackpos] = 8;
            this.CheckTimeout();
            if (num < runtextend && runtext[num++] == '"')
            {
                this.CheckTimeout();
                goto IL_0cb9;
            }
            goto IL_0e58;
            IL_0d25:
            this.CheckTimeout();
            int num12 = num3 = runstack[runstackpos++];
            runtrack[--runtrackpos] = num3;
            if (num12 != num)
            {
                runtrack[--runtrackpos] = num;
                runstack[--runstackpos] = num;
                runtrack[--runtrackpos] = 22;
                if (runtrackpos > 204 && runstackpos > 153)
                {
                    goto IL_019b;
                }
                runtrack[--runtrackpos] = 23;
                goto IL_0e58;
            }
            runtrack[--runtrackpos] = 24;
            goto IL_0d9e;
            IL_0d9e:
            this.CheckTimeout();
            if ((num3 = runtextend - num) > 0)
            {
                runtrack[--runtrackpos] = num3 - 1;
                runtrack[--runtrackpos] = num;
                runtrack[--runtrackpos] = 25;
            }
            goto IL_0dd7;
            IL_0fda:
            this.CheckTimeout();
            num = runtrack[runtrackpos++];
            num3 = runtrack[runtrackpos++];
            if (num3 > 0)
            {
                runtrack[--runtrackpos] = num3 - 1;
                runtrack[--runtrackpos] = num - 1;
                runtrack[--runtrackpos] = 4;
            }
            goto IL_02f8;
            IL_0233:
            this.CheckTimeout();
            runstack[--runstackpos] = num;
            runtrack[--runtrackpos] = 1;
            this.CheckTimeout();
            if (num < runtextend && RegexRunner.CharInClass(runtext[num++], "\0\0\n\0\u0002\u0004\u0005\u0003\u0001\u0006\t\u0013\0"))
            {
                this.CheckTimeout();
                num3 = (num2 = runtextend - num) + 1;
                while (--num3 > 0)
                {
                    if (RegexRunner.CharInClass(runtext[num++], "\0\u0002\n:;\0\u0002\u0004\u0005\u0003\u0001\u0006\t\u0013\0"))
                    {
                        continue;
                    }
                    num--;
                    break;
                }
                if (num2 > num3)
                {
                    runtrack[--runtrackpos] = num2 - num3 - 1;
                    runtrack[--runtrackpos] = num - 1;
                    runtrack[--runtrackpos] = 4;
                }
                goto IL_02f8;
            }
            goto IL_0e58;
            IL_019b:
            this.CheckTimeout();
            runstack[--runstackpos] = num;
            runtrack[--runtrackpos] = 1;
            this.CheckTimeout();
            num3 = (num2 = runtextend - num) + 1;
            while (--num3 > 0)
            {
                if (RegexRunner.CharInClass(runtext[num++], "\0\0\u0001d"))
                {
                    continue;
                }
                num--;
                break;
            }
            if (num2 > num3)
            {
                runtrack[--runtrackpos] = num2 - num3 - 1;
                runtrack[--runtrackpos] = num - 1;
                runtrack[--runtrackpos] = 3;
            }
            goto IL_0233;
            IL_0e58:
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
                    case 23:
                        break;
                    default:
                        goto IL_0f05;
                    case 1:
                        this.CheckTimeout();
                        runstackpos++;
                        continue;
                    case 2:
                        goto IL_0f2e;
                    case 3:
                        goto IL_0f84;
                    case 4:
                        goto IL_0fda;
                    case 5:
                        this.CheckTimeout();
                        runstackpos += 2;
                        continue;
                    case 6:
                        this.CheckTimeout();
                        runstack[--runstackpos] = runtrack[runtrackpos++];
                        continue;
                    case 7:
                        {
                            this.CheckTimeout();
                            int num42 = runtrack[runtrackpos++];
                            if (num42 != this.Crawlpos())
                            {
                                do
                                {
                                    this.Uncapture();
                                }
                                while (num42 != this.Crawlpos());
                            }
                            continue;
                        }
                    case 8:
                        this.CheckTimeout();
                        runstack[--runstackpos] = runtrack[runtrackpos++];
                        this.Uncapture();
                        continue;
                    case 9:
                        this.CheckTimeout();
                        num = runtrack[runtrackpos++];
                        this.CheckTimeout();
                        runtrack[--runtrackpos] = num;
                        runtrack[--runtrackpos] = 13;
                        this.CheckTimeout();
                        num3 = (num2 = runtextend - num) + 1;
                        while (--num3 > 0)
                        {
                            if (RegexRunner.CharInClass(runtext[num++], "\0\0\u0001d"))
                            {
                                continue;
                            }
                            num--;
                            break;
                        }
                        if (num2 > num3)
                        {
                            runtrack[--runtrackpos] = num2 - num3 - 1;
                            runtrack[--runtrackpos] = num - 1;
                            runtrack[--runtrackpos] = 14;
                        }
                        goto IL_076c;
                    case 10:
                        goto IL_10cb;
                    case 11:
                        goto IL_1121;
                    case 12:
                        goto IL_1177;
                    case 13:
                        this.CheckTimeout();
                        num = runtrack[runtrackpos++];
                        this.CheckTimeout();
                        runtrack[--runtrackpos] = num;
                        runtrack[--runtrackpos] = 17;
                        this.CheckTimeout();
                        num3 = (num2 = runtextend - num) + 1;
                        while (--num3 > 0)
                        {
                            if (RegexRunner.CharInClass(runtext[num++], "\0\0\u0001d"))
                            {
                                continue;
                            }
                            num--;
                            break;
                        }
                        if (num2 > num3)
                        {
                            runtrack[--runtrackpos] = num2 - num3 - 1;
                            runtrack[--runtrackpos] = num - 1;
                            runtrack[--runtrackpos] = 18;
                        }
                        goto IL_0a0c;
                    case 14:
                        this.CheckTimeout();
                        num = runtrack[runtrackpos++];
                        num3 = runtrack[runtrackpos++];
                        if (num3 > 0)
                        {
                            runtrack[--runtrackpos] = num3 - 1;
                            runtrack[--runtrackpos] = num - 1;
                            runtrack[--runtrackpos] = 14;
                        }
                        goto IL_076c;
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
                        goto IL_085f;
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
                        goto IL_090e;
                    case 17:
                        this.CheckTimeout();
                        num = runtrack[runtrackpos++];
                        this.CheckTimeout();
                        runstack[--runstackpos] = num;
                        runtrack[--runtrackpos] = 1;
                        this.CheckTimeout();
                        num3 = runstack[runstackpos++];
                        this.Capture(4, num3, num);
                        runtrack[--runtrackpos] = num3;
                        runtrack[--runtrackpos] = 8;
                        this.CheckTimeout();
                        runstack[--runstackpos] = num;
                        runtrack[--runtrackpos] = 1;
                        this.CheckTimeout();
                        if ((num3 = runtextend - num) > 0)
                        {
                            runtrack[--runtrackpos] = num3 - 1;
                            runtrack[--runtrackpos] = num;
                            runtrack[--runtrackpos] = 21;
                        }
                        goto IL_0c83;
                    case 18:
                        this.CheckTimeout();
                        num = runtrack[runtrackpos++];
                        num3 = runtrack[runtrackpos++];
                        if (num3 > 0)
                        {
                            runtrack[--runtrackpos] = num3 - 1;
                            runtrack[--runtrackpos] = num - 1;
                            runtrack[--runtrackpos] = 18;
                        }
                        goto IL_0a0c;
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
                        goto IL_0aff;
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
                        goto IL_0b97;
                    case 21:
                        this.CheckTimeout();
                        num = runtrack[runtrackpos++];
                        num2 = runtrack[runtrackpos++];
                        if (!RegexRunner.CharInClass(runtext[num++], "\0\0\u0001d"))
                        {
                            continue;
                        }
                        if (num2 > 0)
                        {
                            runtrack[--runtrackpos] = num2 - 1;
                            runtrack[--runtrackpos] = num;
                            runtrack[--runtrackpos] = 21;
                        }
                        goto IL_0c83;
                    case 22:
                        goto IL_1470;
                    case 24:
                        this.CheckTimeout();
                        runstack[--runstackpos] = runtrack[runtrackpos++];
                        continue;
                    case 25:
                        goto IL_14bd;
                        IL_0a0c:
                        this.CheckTimeout();
                        runstack[--runstackpos] = num;
                        runtrack[--runtrackpos] = 1;
                        this.CheckTimeout();
                        if (num < runtextend && runtext[num++] == '=')
                        {
                            this.CheckTimeout();
                            num3 = runstack[runstackpos++];
                            this.Capture(4, num3, num);
                            runtrack[--runtrackpos] = num3;
                            runtrack[--runtrackpos] = 8;
                            this.CheckTimeout();
                            num3 = (num2 = runtextend - num) + 1;
                            while (--num3 > 0)
                            {
                                if (RegexRunner.CharInClass(runtext[num++], "\0\0\u0001d"))
                                {
                                    continue;
                                }
                                num--;
                                break;
                            }
                            if (num2 > num3)
                            {
                                runtrack[--runtrackpos] = num2 - num3 - 1;
                                runtrack[--runtrackpos] = num - 1;
                                runtrack[--runtrackpos] = 19;
                            }
                            goto IL_0aff;
                        }
                        continue;
                        IL_090e:
                        this.CheckTimeout();
                        num3 = runstack[runstackpos++];
                        this.Capture(5, num3, num);
                        runtrack[--runtrackpos] = num3;
                        runtrack[--runtrackpos] = 8;
                        this.CheckTimeout();
                        if (num < runtextend)
                        {
                            goto IL_0953;
                        }
                        continue;
                        IL_085f:
                        this.CheckTimeout();
                        if (num < runtextend && runtext[num++] == '\'')
                        {
                            this.CheckTimeout();
                            runstack[--runstackpos] = num;
                            runtrack[--runtrackpos] = 1;
                            this.CheckTimeout();
                            num3 = (num2 = runtextend - num) + 1;
                            while (--num3 > 0)
                            {
                                if (runtext[num++] != '\'')
                                {
                                    continue;
                                }
                                num--;
                                break;
                            }
                            if (num2 > num3)
                            {
                                runtrack[--runtrackpos] = num2 - num3 - 1;
                                runtrack[--runtrackpos] = num - 1;
                                runtrack[--runtrackpos] = 16;
                            }
                            goto IL_090e;
                        }
                        continue;
                        IL_076c:
                        this.CheckTimeout();
                        runstack[--runstackpos] = num;
                        runtrack[--runtrackpos] = 1;
                        this.CheckTimeout();
                        if (num < runtextend && runtext[num++] == '=')
                        {
                            this.CheckTimeout();
                            num3 = runstack[runstackpos++];
                            this.Capture(4, num3, num);
                            runtrack[--runtrackpos] = num3;
                            runtrack[--runtrackpos] = 8;
                            this.CheckTimeout();
                            num3 = (num2 = runtextend - num) + 1;
                            while (--num3 > 0)
                            {
                                if (RegexRunner.CharInClass(runtext[num++], "\0\0\u0001d"))
                                {
                                    continue;
                                }
                                num--;
                                break;
                            }
                            if (num2 > num3)
                            {
                                runtrack[--runtrackpos] = num2 - num3 - 1;
                                runtrack[--runtrackpos] = num - 1;
                                runtrack[--runtrackpos] = 15;
                            }
                            goto IL_085f;
                        }
                        continue;
                        IL_0c83:
                        this.CheckTimeout();
                        num3 = runstack[runstackpos++];
                        this.Capture(5, num3, num);
                        runtrack[--runtrackpos] = num3;
                        runtrack[--runtrackpos] = 8;
                        goto IL_0cb9;
                        IL_0aff:
                        this.CheckTimeout();
                        runstack[--runstackpos] = num;
                        runtrack[--runtrackpos] = 1;
                        this.CheckTimeout();
                        num3 = (num2 = runtextend - num) + 1;
                        while (--num3 > 0)
                        {
                            if (RegexRunner.CharInClass(runtext[num++], "\u0001\b\u0001\"#%&'(>?d"))
                            {
                                continue;
                            }
                            num--;
                            break;
                        }
                        if (num2 > num3)
                        {
                            runtrack[--runtrackpos] = num2 - num3 - 1;
                            runtrack[--runtrackpos] = num - 1;
                            runtrack[--runtrackpos] = 20;
                        }
                        goto IL_0b97;
                        IL_0b97:
                        this.CheckTimeout();
                        num3 = runstack[runstackpos++];
                        this.Capture(5, num3, num);
                        runtrack[--runtrackpos] = num3;
                        runtrack[--runtrackpos] = 8;
                        this.CheckTimeout();
                        goto IL_0cb9;
                }
                break;
                IL_14bd:
                this.CheckTimeout();
                num = runtrack[runtrackpos++];
                num2 = runtrack[runtrackpos++];
                if (!RegexRunner.CharInClass(runtext[num++], "\0\0\u0001d"))
                {
                    continue;
                }
                goto IL_14f9;
                IL_0953:
                if (runtext[num++] == '\'')
                {
                    goto IL_0969;
                }
            }
            goto IL_019b;
            IL_0cb9:
            this.CheckTimeout();
            num3 = runstack[runstackpos++];
            this.Capture(2, num3, num);
            runtrack[--runtrackpos] = num3;
            runtrack[--runtrackpos] = 8;
            this.CheckTimeout();
            num3 = runstack[runstackpos++];
            this.Capture(1, num3, num);
            runtrack[--runtrackpos] = num3;
            runtrack[--runtrackpos] = 8;
            goto IL_0d25;
            IL_14f9:
            if (num2 > 0)
            {
                runtrack[--runtrackpos] = num2 - 1;
                runtrack[--runtrackpos] = num;
                runtrack[--runtrackpos] = 25;
            }
            goto IL_0dd7;
            IL_02f8:
            this.CheckTimeout();
            runstack[--runstackpos] = (int)((long)(IntPtr)(void*)base.runtrack.LongLength - (long)runtrackpos);
            runstack[--runstackpos] = this.Crawlpos();
            runtrack[--runtrackpos] = 5;
            this.CheckTimeout();
            runstack[--runstackpos] = num;
            runtrack[--runtrackpos] = 1;
            this.CheckTimeout();
            if (num < runtextend && RegexRunner.CharInClass(runtext[num++], "\u0001\0\n\0\u0002\u0004\u0005\u0003\u0001\u0006\t\u0013\0"))
            {
                this.CheckTimeout();
                num = (runtrack[--runtrackpos] = runstack[runstackpos++]);
                runtrack[--runtrackpos] = 6;
                this.CheckTimeout();
                num3 = runstack[runstackpos++];
                runtrackpos = (int)((long)(IntPtr)(void*)base.runtrack.LongLength - (long)runstack[runstackpos++]);
                runtrack[--runtrackpos] = num3;
                runtrack[--runtrackpos] = 7;
                this.CheckTimeout();
                num3 = runstack[runstackpos++];
                this.Capture(3, num3, num);
                runtrack[--runtrackpos] = num3;
                runtrack[--runtrackpos] = 8;
                this.CheckTimeout();
                runstack[--runstackpos] = num;
                runtrack[--runtrackpos] = 1;
                this.CheckTimeout();
                runtrack[--runtrackpos] = num;
                runtrack[--runtrackpos] = 9;
                this.CheckTimeout();
                num3 = (num2 = runtextend - num) + 1;
                while (--num3 > 0)
                {
                    if (RegexRunner.CharInClass(runtext[num++], "\0\0\u0001d"))
                    {
                        continue;
                    }
                    num--;
                    break;
                }
                if (num2 > num3)
                {
                    runtrack[--runtrackpos] = num2 - num3 - 1;
                    runtrack[--runtrackpos] = num - 1;
                    runtrack[--runtrackpos] = 10;
                }
                goto IL_04cc;
            }
            goto IL_0e58;
            IL_05bf:
            this.CheckTimeout();
            if (num < runtextend && runtext[num++] == '"')
            {
                this.CheckTimeout();
                runstack[--runstackpos] = num;
                runtrack[--runtrackpos] = 1;
                this.CheckTimeout();
                num3 = (num2 = runtextend - num) + 1;
                while (--num3 > 0)
                {
                    if (runtext[num++] != '"')
                    {
                        continue;
                    }
                    num--;
                    break;
                }
                if (num2 > num3)
                {
                    runtrack[--runtrackpos] = num2 - num3 - 1;
                    runtrack[--runtrackpos] = num - 1;
                    runtrack[--runtrackpos] = 12;
                }
                goto IL_066e;
            }
            goto IL_0e58;
            IL_1470:
            this.CheckTimeout();
            num = runtrack[runtrackpos++];
            int num85 = runstack[runstackpos++];
            runtrack[--runtrackpos] = 24;
            goto IL_0d9e;
            IL_0e49:
            this.CheckTimeout();
            base.runtextpos = num;
            return;
            IL_0f84:
            this.CheckTimeout();
            num = runtrack[runtrackpos++];
            num3 = runtrack[runtrackpos++];
            if (num3 > 0)
            {
                runtrack[--runtrackpos] = num3 - 1;
                runtrack[--runtrackpos] = num - 1;
                runtrack[--runtrackpos] = 3;
            }
            goto IL_0233;
            IL_0f2e:
            this.CheckTimeout();
            num = runtrack[runtrackpos++];
            num3 = runtrack[runtrackpos++];
            if (num3 > 0)
            {
                runtrack[--runtrackpos] = num3 - 1;
                runtrack[--runtrackpos] = num - 1;
                runtrack[--runtrackpos] = 2;
            }
            goto IL_014d;
            IL_0969:
            this.CheckTimeout();
            goto IL_0cb9;
            IL_10cb:
            this.CheckTimeout();
            num = runtrack[runtrackpos++];
            num3 = runtrack[runtrackpos++];
            if (num3 > 0)
            {
                runtrack[--runtrackpos] = num3 - 1;
                runtrack[--runtrackpos] = num - 1;
                runtrack[--runtrackpos] = 10;
            }
            goto IL_04cc;
            IL_014d:
            this.CheckTimeout();
            if (num < runtextend && runtext[num++] == '@')
            {
                this.CheckTimeout();
                runstack[--runstackpos] = -1;
                runtrack[--runtrackpos] = 1;
                this.CheckTimeout();
                goto IL_0d25;
            }
            goto IL_0e58;
            IL_1121:
            this.CheckTimeout();
            num = runtrack[runtrackpos++];
            num3 = runtrack[runtrackpos++];
            if (num3 > 0)
            {
                runtrack[--runtrackpos] = num3 - 1;
                runtrack[--runtrackpos] = num - 1;
                runtrack[--runtrackpos] = 11;
            }
            goto IL_05bf;
            IL_04cc:
            this.CheckTimeout();
            runstack[--runstackpos] = num;
            runtrack[--runtrackpos] = 1;
            this.CheckTimeout();
            if (num < runtextend && runtext[num++] == '=')
            {
                this.CheckTimeout();
                num3 = runstack[runstackpos++];
                this.Capture(4, num3, num);
                runtrack[--runtrackpos] = num3;
                runtrack[--runtrackpos] = 8;
                this.CheckTimeout();
                num3 = (num2 = runtextend - num) + 1;
                while (--num3 > 0)
                {
                    if (RegexRunner.CharInClass(runtext[num++], "\0\0\u0001d"))
                    {
                        continue;
                    }
                    num--;
                    break;
                }
                if (num2 > num3)
                {
                    runtrack[--runtrackpos] = num2 - num3 - 1;
                    runtrack[--runtrackpos] = num - 1;
                    runtrack[--runtrackpos] = 11;
                }
                goto IL_05bf;
            }
            goto IL_0e58;
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
            base.runtrackcount = 51;
        }
    }
}