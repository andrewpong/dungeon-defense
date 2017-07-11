// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.OurUtils.Logger
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using System;

namespace GooglePlayGames.OurUtils
{
  public class Logger
  {
    private static bool warningLogEnabled = true;
    private static bool debugLogEnabled;

    public static bool DebugLogEnabled
    {
      get
      {
        return Logger.debugLogEnabled;
      }
      set
      {
        Logger.debugLogEnabled = value;
      }
    }

    public static bool WarningLogEnabled
    {
      get
      {
        return Logger.warningLogEnabled;
      }
      set
      {
        Logger.warningLogEnabled = value;
      }
    }

    public static void d(string msg)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Logger.\u003Cd\u003Ec__AnonStorey0 dCAnonStorey0 = new Logger.\u003Cd\u003Ec__AnonStorey0();
      // ISSUE: reference to a compiler-generated field
      dCAnonStorey0.msg = msg;
      if (!Logger.debugLogEnabled)
        return;
      // ISSUE: reference to a compiler-generated method
      PlayGamesHelperObject.RunOnGameThread(new Action(dCAnonStorey0.\u003C\u003Em__0));
    }

    public static void w(string msg)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Logger.\u003Cw\u003Ec__AnonStorey1 wCAnonStorey1 = new Logger.\u003Cw\u003Ec__AnonStorey1();
      // ISSUE: reference to a compiler-generated field
      wCAnonStorey1.msg = msg;
      if (!Logger.warningLogEnabled)
        return;
      // ISSUE: reference to a compiler-generated method
      PlayGamesHelperObject.RunOnGameThread(new Action(wCAnonStorey1.\u003C\u003Em__0));
    }

    public static void e(string msg)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Logger.\u003Ce\u003Ec__AnonStorey2 eCAnonStorey2 = new Logger.\u003Ce\u003Ec__AnonStorey2();
      // ISSUE: reference to a compiler-generated field
      eCAnonStorey2.msg = msg;
      if (!Logger.warningLogEnabled)
        return;
      // ISSUE: reference to a compiler-generated method
      PlayGamesHelperObject.RunOnGameThread(new Action(eCAnonStorey2.\u003C\u003Em__0));
    }

    public static string describe(byte[] b)
    {
      if (b == null)
        return "(null)";
      return "byte[" + (object) b.Length + "]";
    }

    private static string ToLogMessage(string prefix, string logType, string msg)
    {
      return string.Format("{0} [Play Games Plugin DLL] {1} {2}: {3}", (object) prefix, (object) DateTime.Now.ToString("MM/dd/yy H:mm:ss zzz"), (object) logType, (object) msg);
    }
  }
}
