// Decompiled with JetBrains decompiler
// Type: Thinksquirrel.CShake.CameraShakeBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using System;
using UnityEngine;

namespace Thinksquirrel.CShake
{
  [AddComponentMenu("")]
  public abstract class CameraShakeBase : MonoBehaviour
  {
    public static void Log(object message, string prefix, string type)
    {
      Debug.Log((object) string.Format("[{0}] ({1}): {2}", (object) prefix, (object) type, message));
    }

    public static void LogWarning(object message, string prefix, string type)
    {
      Debug.LogWarning((object) string.Format("[{0}] ({1}): {2}", (object) prefix, (object) type, message));
    }

    public static void LogError(object message, string prefix, string type)
    {
      Debug.LogError((object) string.Format("[{0}] ({1}): {2}", (object) prefix, (object) type, message));
    }

    public static void LogException(Exception ex)
    {
      Debug.LogException(ex);
    }

    public static void Log(object message, string prefix, string type, UnityEngine.Object context)
    {
      Debug.Log((object) string.Format("[{0}] ({1}): {2}", (object) prefix, (object) type, message), context);
    }

    public static void LogWarning(object message, string prefix, string type, UnityEngine.Object context)
    {
      Debug.LogWarning((object) string.Format("[{0}] ({1}): {2}", (object) prefix, (object) type, message), context);
    }

    public static void LogError(object message, string prefix, string type, UnityEngine.Object context)
    {
      Debug.LogError((object) string.Format("[{0}] ({1}): {2}", (object) prefix, (object) type, message), context);
    }

    public static void LogException(Exception ex, UnityEngine.Object context)
    {
      Debug.LogException(ex, context);
    }
  }
}
