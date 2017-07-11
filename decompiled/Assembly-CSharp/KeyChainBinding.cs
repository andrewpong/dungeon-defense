// Decompiled with JetBrains decompiler
// Type: KeyChainBinding
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using System.IO;
using UnityEngine;

public class KeyChainBinding
{
  private const char seperatorChar = '|';
  private const string logPrefix = "KeyChainBinding -> {0}";
  private const string setLog = "Set keychain values";
  private const string getLog = "Retrieved applicationKey={0} applicationData={1}";
  private const string deleteLog = "Cleared keychain values";

  private static string mSavePath
  {
    get
    {
      return Path.Combine(Application.persistentDataPath, "keyChainStore.dat");
    }
  }

  private static string mUniqueIdentifier { get; set; }

  public static void GetKeyChainData(out string applicationKey, out string data)
  {
    if (string.IsNullOrEmpty(KeyChainBinding.mUniqueIdentifier))
      KeyChainBinding.mUniqueIdentifier = SystemInfo.deviceUniqueIdentifier;
    string empty = string.Empty;
    if (File.Exists(KeyChainBinding.mSavePath))
    {
      string[] strArray = KeyChainCrypto.Decrypt(File.ReadAllText(KeyChainBinding.mSavePath), KeyChainBinding.mUniqueIdentifier).Split('|');
      applicationKey = strArray[0];
      data = strArray[1];
    }
    else
    {
      applicationKey = string.Empty;
      data = string.Empty;
    }
    KeyChainBinding.LogFormat("Retrieved applicationKey={0} applicationData={1}", (object) applicationKey, (object) data);
  }

  public static void SetKeyChainData(string applicationKey, string data)
  {
    if (string.IsNullOrEmpty(KeyChainBinding.mUniqueIdentifier))
      KeyChainBinding.mUniqueIdentifier = SystemInfo.deviceUniqueIdentifier;
    File.WriteAllText(KeyChainBinding.mSavePath, KeyChainCrypto.Crypt(string.Format("{0}{1}{2}", (object) applicationKey, (object) '|', (object) data), KeyChainBinding.mUniqueIdentifier));
    KeyChainBinding.Log("Set keychain values");
  }

  public static void DeleteKeyChainData()
  {
    if (File.Exists(KeyChainBinding.mSavePath))
      File.Delete(KeyChainBinding.mSavePath);
    KeyChainBinding.Log("Cleared keychain values");
  }

  private static void Log(string log)
  {
  }

  private static void LogFormat(string format, params object[] parms)
  {
  }
}
