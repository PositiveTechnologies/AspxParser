using System.Text.RegularExpressions;

namespace System.Web.RegularExpressions
{
    internal class AspCodeRegexRunner4 : RegexRunner
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
            if (runtextpos == base.runtextstart)
            {
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
                    if (runtextpos < runtextend && runtext[runtextpos++] == '@')
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
                int num16;
                switch (runtrack[runtrackpos++])
                {
                    default:
                        this.CheckTimeout();
                        runtextpos = runtrack[runtrackpos++];
                        goto IL_02cb;
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
                        num16 = runstack[runstackpos++];
                        runtrackpos = (int)((long)(IntPtr)(void*)base.runtrack.LongLength - (long)runstack[runstackpos++]);
                        runtrack[--runtrackpos] = num16;
                        runtrack[--runtrackpos] = 4;
                        this.CheckTimeout();
                        runstack[--runstackpos] = runtextpos;
                        runtrack[--runtrackpos] = 1;
                        this.CheckTimeout();
                        if ((num16 = runtextend - runtextpos) > 0)
                        {
                            runtrack[--runtrackpos] = num16 - 1;
                            runtrack[--runtrackpos] = runtextpos;
                            runtrack[--runtrackpos] = 5;
                        }
                        goto IL_0223;
                    case 4:
                        {
                            this.CheckTimeout();
                            int num13 = runtrack[runtrackpos++];
                            if (num13 != this.Crawlpos())
                            {
                                do
                                {
                                    this.Uncapture();
                                }
                                while (num13 != this.Crawlpos());
                            }
                            break;
                        }
                    case 5:
                        {
                            this.CheckTimeout();
                            runtextpos = runtrack[runtrackpos++];
                            int num9 = runtrack[runtrackpos++];
                            if (!RegexRunner.CharInClass(runtext[runtextpos++], "\0\u0001\0\0"))
                            {
                                break;
                            }
                            if (num9 > 0)
                            {
                                runtrack[--runtrackpos] = num9 - 1;
                                runtrack[--runtrackpos] = runtextpos;
                                runtrack[--runtrackpos] = 5;
                            }
                            goto IL_0223;
                        }
                    case 6:
                        {
                            this.CheckTimeout();
                            runstack[--runstackpos] = runtrack[runtrackpos++];
                            this.Uncapture();
                            break;
                        }
                        IL_02cb:
                        this.CheckTimeout();
                        base.runtextpos = runtextpos;
                        return;
                        IL_0223:
                        this.CheckTimeout();
                        num16 = runstack[runstackpos++];
                        this.Capture(1, num16, runtextpos);
                        runtrack[--runtrackpos] = num16;
                        runtrack[--runtrackpos] = 6;
                        this.CheckTimeout();
                        if (2 > runtextend - runtextpos)
                        {
                            break;
                        }
                        if (runtext[runtextpos] != '%')
                        {
                            break;
                        }
                        if (runtext[runtextpos + 1] != '>')
                        {
                            break;
                        }
                        runtextpos += 2;
                        this.CheckTimeout();
                        num16 = runstack[runstackpos++];
                        this.Capture(0, num16, runtextpos);
                        runtrack[--runtrackpos] = num16;
                        runtrack[--runtrackpos] = 6;
                        goto IL_02cb;
                }
            }
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