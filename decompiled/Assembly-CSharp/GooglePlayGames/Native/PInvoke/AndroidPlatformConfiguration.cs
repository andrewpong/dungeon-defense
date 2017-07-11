// Decompiled with JetBrains decompiler
// Type: GooglePlayGames.Native.PInvoke.AndroidPlatformConfiguration
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using AOT;
using GooglePlayGames.OurUtils;
using System;
using System.Runtime.InteropServices;

namespace GooglePlayGames.Native.PInvoke
{
  internal sealed class AndroidPlatformConfiguration : PlatformConfiguration
  {
    private AndroidPlatformConfiguration(IntPtr selfPointer)
      : base(selfPointer)
    {
    }

    internal void SetActivity(IntPtr activity)
    {
      GooglePlayGames.Native.Cwrapper.AndroidPlatformConfiguration.AndroidPlatformConfiguration_SetActivity(this.SelfPtr(), activity);
    }

    internal void SetOptionalIntentHandlerForUI(Action<IntPtr> intentHandler)
    {
      Misc.CheckNotNull<Action<IntPtr>>(intentHandler);
      HandleRef self = this.SelfPtr();
      // ISSUE: reference to a compiler-generated field
      if (AndroidPlatformConfiguration.\u003C\u003Ef__mg\u0024cache0 == null)
      {
        // ISSUE: reference to a compiler-generated field
        AndroidPlatformConfiguration.\u003C\u003Ef__mg\u0024cache0 = new GooglePlayGames.Native.Cwrapper.AndroidPlatformConfiguration.IntentHandler(AndroidPlatformConfiguration.InternalIntentHandler);
      }
      // ISSUE: reference to a compiler-generated field
      GooglePlayGames.Native.Cwrapper.AndroidPlatformConfiguration.IntentHandler fMgCache0 = AndroidPlatformConfiguration.\u003C\u003Ef__mg\u0024cache0;
      IntPtr intPtr = Callbacks.ToIntPtr((Delegate) intentHandler);
      GooglePlayGames.Native.Cwrapper.AndroidPlatformConfiguration.AndroidPlatformConfiguration_SetOptionalIntentHandlerForUI(self, fMgCache0, intPtr);
    }

    protected override void CallDispose(HandleRef selfPointer)
    {
      GooglePlayGames.Native.Cwrapper.AndroidPlatformConfiguration.AndroidPlatformConfiguration_Dispose(selfPointer);
    }

    [MonoPInvokeCallback(typeof (AndroidPlatformConfiguration.IntentHandlerInternal))]
    private static void InternalIntentHandler(IntPtr intent, IntPtr userData)
    {
      Callbacks.PerformInternalCallback("AndroidPlatformConfiguration#InternalIntentHandler", Callbacks.Type.Permanent, intent, userData);
    }

    internal static AndroidPlatformConfiguration Create()
    {
      return new AndroidPlatformConfiguration(GooglePlayGames.Native.Cwrapper.AndroidPlatformConfiguration.AndroidPlatformConfiguration_Construct());
    }

    private delegate void IntentHandlerInternal(IntPtr intent, IntPtr userData);
  }
}
