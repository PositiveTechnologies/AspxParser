using System.Text.RegularExpressions;

namespace System.Web.RegularExpressions
{
    internal class ServerTagsRegexRunner12 : RegexRunner
    {
        protected unsafe override void Go()
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
            if (2 <= runtextend - runtextpos && runtext[runtextpos] == '<' && runtext[runtextpos + 1] == '%')
            {
                runtextpos += 2;
                this.CheckTimeout();
                runstack[--runstackpos] = (int)((long)(IntPtr)(void*)base.runtrack.LongLength - (long)runtrackpos);
                runstack[--runstackpos] = this.Crawlpos();
                runtrack[--runtrackpos] = 2;
                this.CheckTimeout();
                runtrack[--runtrackpos] = runtextpos;
                runtrack[--runtrackpos] = 3;
                this.CheckTimeout();
                if (runtextpos < runtextend && RegexRunner.CharInClass(runtext[runtextpos++], "\0\u0002\0#%"))
                {
                    this.CheckTimeout();
                    int num3 = runstack[runstackpos++];
                    runtrackpos = (int)((long)(IntPtr)(void*)base.runtrack.LongLength - (long)runstack[runstackpos++]);
                    if (num3 != this.Crawlpos())
                    {
                        do
                        {
                            this.Uncapture();
                        }
                        while (num3 != this.Crawlpos());
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
                int num17;
                int num9;
                switch (runtrack[runtrackpos++])
                {
                    default:
                        this.CheckTimeout();
                        runtextpos = runtrack[runtrackpos++];
                        goto IL_03e7;
                    case 1:
                        this.CheckTimeout();
                        runstackpos++;
                        break;
                    case 2:
                        this.CheckTimeout();
                        runstackpos += 2;
                        break;
                    case 3:
                        this.CheckTimeout();
                        runtextpos = runtrack[runtrackpos++];
                        this.CheckTimeout();
                        num9 = runstack[runstackpos++];
                        runtrackpos = (int)((long)(IntPtr)(void*)base.runtrack.LongLength - (long)runstack[runstackpos++]);
                        runtrack[--runtrackpos] = num9;
                        runtrack[--runtrackpos] = 4;
                        this.CheckTimeout();
                        runstack[--runstackpos] = -1;
                        runtrack[--runtrackpos] = 1;
                        this.CheckTimeout();
                        goto IL_0323;
                    case 4:
                        {
                            this.CheckTimeout();
                            int num12 = runtrack[runtrackpos++];
                            if (num12 != this.Crawlpos())
                            {
                                do
                                {
                                    this.Uncapture();
                                }
                                while (num12 != this.Crawlpos());
                            }
                            break;
                        }
                    case 5:
                        this.CheckTimeout();
                        runtextpos = runtrack[runtrackpos++];
                        num9 = runtrack[runtrackpos++];
                        if (num9 > 0)
                        {
                            runtrack[--runtrackpos] = num9 - 1;
                            runtrack[--runtrackpos] = runtextpos - 1;
                            runtrack[--runtrackpos] = 5;
                        }
                        goto IL_0292;
                    case 6:
                        this.CheckTimeout();
                        runstack[--runstackpos] = runtrack[runtrackpos++];
                        this.Uncapture();
                        break;
                    case 7:
                        this.CheckTimeout();
                        runtextpos = runtrack[runtrackpos++];
                        runstack[--runstackpos] = runtextpos;
                        runtrack[--runtrackpos] = 8;
                        if (runtrackpos > 56 && runstackpos > 42)
                        {
                            this.CheckTimeout();
                            runstack[--runstackpos] = runtextpos;
                            runtrack[--runtrackpos] = 1;
                            this.CheckTimeout();
                            runstack[--runstackpos] = runtextpos;
                            runtrack[--runtrackpos] = 1;
                            this.CheckTimeout();
                            int num8;
                            num9 = (num8 = runtextend - runtextpos) + 1;
                            while (--num9 > 0)
                            {
                                if (runtext[runtextpos++] != '%')
                                {
                                    continue;
                                }
                                runtextpos--;
                                break;
                            }
                            if (num8 > num9)
                            {
                                runtrack[--runtrackpos] = num8 - num9 - 1;
                                runtrack[--runtrackpos] = runtextpos - 1;
                                runtrack[--runtrackpos] = 5;
                            }
                            goto IL_0292;
                        }
                        runtrack[--runtrackpos] = 9;
                        break;
                    case 8:
                        {
                            this.CheckTimeout();
                            runstack[runstackpos] = runtrack[runtrackpos++];
                            break;
                        }
                        IL_0323:
                        this.CheckTimeout();
                        num17 = (num9 = runstack[runstackpos++]);
                        if (num9 != -1)
                        {
                            runtrack[--runtrackpos] = num9;
                        }
                        else
                        {
                            runtrack[--runtrackpos] = runtextpos;
                        }
                        if (num17 != runtextpos)
                        {
                            runtrack[--runtrackpos] = runtextpos;
                            runtrack[--runtrackpos] = 7;
                        }
                        else
                        {
                            runstack[--runstackpos] = num9;
                            runtrack[--runtrackpos] = 8;
                        }
                        this.CheckTimeout();
                        if (runtextpos >= runtextend)
                        {
                            break;
                        }
                        if (runtext[runtextpos++] != '>')
                        {
                            break;
                        }
                        this.CheckTimeout();
                        num9 = runstack[runstackpos++];
                        this.Capture(0, num9, runtextpos);
                        runtrack[--runtrackpos] = num9;
                        runtrack[--runtrackpos] = 6;
                        goto IL_03e7;
                        IL_03e7:
                        this.CheckTimeout();
                        base.runtextpos = runtextpos;
                        return;
                        IL_0292:
                        this.CheckTimeout();
                        num9 = runstack[runstackpos++];
                        this.Capture(2, num9, runtextpos);
                        runtrack[--runtrackpos] = num9;
                        runtrack[--runtrackpos] = 6;
                        this.CheckTimeout();
                        if (runtextpos >= runtextend)
                        {
                            break;
                        }
                        if (runtext[runtextpos++] != '%')
                        {
                            break;
                        }
                        this.CheckTimeout();
                        num9 = runstack[runstackpos++];
                        this.Capture(1, num9, runtextpos);
                        runtrack[--runtrackpos] = num9;
                        runtrack[--runtrackpos] = 6;
                        goto IL_0323;
                }
            }
        }

        protected override bool FindFirstChar()
        {
            string runtext = base.runtext;
            int runtextend = base.runtextend;
            int num = base.runtextpos + 1;
            while (true)
            {
                if (num >= runtextend)
                {
                    break;
                }
                int num3;
                int num2;
                if ((num2 = runtext[num]) != 37)
                {
                    if ((uint)(num2 -= 37) > 23u)
                    {
                        num3 = 2;
                    }
                    else
                    {
                        switch (num2)
                        {
                            default:
                                num3 = 0;
                                break;
                            case 1:
                                num3 = 2;
                                break;
                            case 2:
                                num3 = 2;
                                break;
                            case 3:
                                num3 = 2;
                                break;
                            case 4:
                                num3 = 2;
                                break;
                            case 5:
                                num3 = 2;
                                break;
                            case 6:
                                num3 = 2;
                                break;
                            case 7:
                                num3 = 2;
                                break;
                            case 8:
                                num3 = 2;
                                break;
                            case 9:
                                num3 = 2;
                                break;
                            case 10:
                                num3 = 2;
                                break;
                            case 11:
                                num3 = 2;
                                break;
                            case 12:
                                num3 = 2;
                                break;
                            case 13:
                                num3 = 2;
                                break;
                            case 14:
                                num3 = 2;
                                break;
                            case 15:
                                num3 = 2;
                                break;
                            case 16:
                                num3 = 2;
                                break;
                            case 17:
                                num3 = 2;
                                break;
                            case 18:
                                num3 = 2;
                                break;
                            case 19:
                                num3 = 2;
                                break;
                            case 20:
                                num3 = 2;
                                break;
                            case 21:
                                num3 = 2;
                                break;
                            case 22:
                                num3 = 2;
                                break;
                            case 23:
                                num3 = 1;
                                break;
                        }
                    }
                    goto IL_001f;
                }
                num2 = num;
                if (runtext[--num2] != '<')
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
            base.runtrackcount = 14;
        }
    }
}