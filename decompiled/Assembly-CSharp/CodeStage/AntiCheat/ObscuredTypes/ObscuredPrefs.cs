﻿// Decompiled with JetBrains decompiler
// Type: CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using CodeStage.AntiCheat.Utils;
using System;
using System.Text;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
  public static class ObscuredPrefs
  {
    private static string cryptoKey = "e806f6";
    private const byte VERSION = 2;
    private const string RAW_NOT_FOUND = "{not_found}";
    private const string DATA_SEPARATOR = "|";
    private static bool foreignSavesReported;
    private static string deviceId;
    private static uint deviceIdHash;
    public static Action onAlterationDetected;
    public static bool preservePlayerPrefs;
    public static Action onPossibleForeignSavesDetected;
    public static ObscuredPrefs.DeviceLockLevel lockToDevice;
    public static bool readForeignSaves;
    public static bool emergencyMode;
    private const char DEPRECATED_RAW_SEPARATOR = ':';
    private static string deprecatedDeviceId;

    public static string CryptoKey
    {
      get
      {
        return ObscuredPrefs.cryptoKey;
      }
      set
      {
        ObscuredPrefs.cryptoKey = value;
      }
    }

    public static string DeviceId
    {
      get
      {
        if (string.IsNullOrEmpty(ObscuredPrefs.deviceId))
          ObscuredPrefs.deviceId = ObscuredPrefs.GetDeviceId();
        return ObscuredPrefs.deviceId;
      }
      set
      {
        ObscuredPrefs.deviceId = value;
      }
    }

    [Obsolete("This property is obsolete, please use DeviceId instead.")]
    internal static string DeviceID
    {
      get
      {
        return ObscuredPrefs.DeviceId;
      }
      set
      {
        ObscuredPrefs.DeviceId = value;
      }
    }

    private static uint DeviceIdHash
    {
      get
      {
        if ((int) ObscuredPrefs.deviceIdHash == 0)
          ObscuredPrefs.deviceIdHash = ObscuredPrefs.CalculateChecksum(ObscuredPrefs.DeviceId);
        return ObscuredPrefs.deviceIdHash;
      }
    }

    private static string DeprecatedDeviceId
    {
      get
      {
        if (string.IsNullOrEmpty(ObscuredPrefs.deprecatedDeviceId))
          ObscuredPrefs.deprecatedDeviceId = ObscuredPrefs.DeprecatedCalculateChecksum(ObscuredPrefs.DeviceId);
        return ObscuredPrefs.deprecatedDeviceId;
      }
    }

    public static void ForceLockToDeviceInit()
    {
      if (string.IsNullOrEmpty(ObscuredPrefs.deviceId))
      {
        ObscuredPrefs.deviceId = ObscuredPrefs.GetDeviceId();
        ObscuredPrefs.deviceIdHash = ObscuredPrefs.CalculateChecksum(ObscuredPrefs.deviceId);
      }
      else
        Debug.LogWarning((object) "[ACTk] ObscuredPrefs.ForceLockToDeviceInit() is called, but device ID is already obtained!");
    }

    [Obsolete("This method is obsolete, use property CryptoKey instead")]
    internal static void SetNewCryptoKey(string newKey)
    {
      ObscuredPrefs.CryptoKey = newKey;
    }

    public static void SetInt(string key, int value)
    {
      PlayerPrefs.SetString(ObscuredPrefs.EncryptKey(key), ObscuredPrefs.EncryptIntValue(key, value));
    }

    public static int GetInt(string key)
    {
      return ObscuredPrefs.GetInt(key, 0);
    }

    public static int GetInt(string key, int defaultValue)
    {
      string str = ObscuredPrefs.EncryptKey(key);
      if (!PlayerPrefs.HasKey(str) && PlayerPrefs.HasKey(key))
      {
        int num = PlayerPrefs.GetInt(key, defaultValue);
        if (!ObscuredPrefs.preservePlayerPrefs)
        {
          ObscuredPrefs.SetInt(key, num);
          PlayerPrefs.DeleteKey(key);
        }
        return num;
      }
      string encryptedPrefsString = ObscuredPrefs.GetEncryptedPrefsString(key, str);
      if (encryptedPrefsString == "{not_found}")
        return defaultValue;
      return ObscuredPrefs.DecryptIntValue(key, encryptedPrefsString, defaultValue);
    }

    internal static string EncryptIntValue(string key, int value)
    {
      byte[] bytes = BitConverter.GetBytes(value);
      return ObscuredPrefs.EncryptData(key, bytes, ObscuredPrefs.DataType.Int);
    }

    internal static int DecryptIntValue(string key, string encryptedInput, int defaultValue)
    {
      if (encryptedInput.IndexOf(':') > -1)
      {
        string s = ObscuredPrefs.DeprecatedDecryptValue(encryptedInput);
        if (s == string.Empty)
          return defaultValue;
        int result;
        int.TryParse(s, out result);
        ObscuredPrefs.SetInt(key, result);
        return result;
      }
      byte[] numArray = ObscuredPrefs.DecryptData(key, encryptedInput);
      if (numArray == null)
        return defaultValue;
      return BitConverter.ToInt32(numArray, 0);
    }

    public static void SetUInt(string key, uint value)
    {
      PlayerPrefs.SetString(ObscuredPrefs.EncryptKey(key), ObscuredPrefs.EncryptUIntValue(key, value));
    }

    public static uint GetUInt(string key)
    {
      return ObscuredPrefs.GetUInt(key, 0U);
    }

    public static uint GetUInt(string key, uint defaultValue)
    {
      string encryptedPrefsString = ObscuredPrefs.GetEncryptedPrefsString(key, ObscuredPrefs.EncryptKey(key));
      if (encryptedPrefsString == "{not_found}")
        return defaultValue;
      return ObscuredPrefs.DecryptUIntValue(key, encryptedPrefsString, defaultValue);
    }

    private static string EncryptUIntValue(string key, uint value)
    {
      byte[] bytes = BitConverter.GetBytes(value);
      return ObscuredPrefs.EncryptData(key, bytes, ObscuredPrefs.DataType.UInt);
    }

    private static uint DecryptUIntValue(string key, string encryptedInput, uint defaultValue)
    {
      if (encryptedInput.IndexOf(':') > -1)
      {
        string s = ObscuredPrefs.DeprecatedDecryptValue(encryptedInput);
        if (s == string.Empty)
          return defaultValue;
        uint result;
        uint.TryParse(s, out result);
        ObscuredPrefs.SetUInt(key, result);
        return result;
      }
      byte[] numArray = ObscuredPrefs.DecryptData(key, encryptedInput);
      if (numArray == null)
        return defaultValue;
      return BitConverter.ToUInt32(numArray, 0);
    }

    public static void SetString(string key, string value)
    {
      PlayerPrefs.SetString(ObscuredPrefs.EncryptKey(key), ObscuredPrefs.EncryptStringValue(key, value));
    }

    public static string GetString(string key)
    {
      return ObscuredPrefs.GetString(key, string.Empty);
    }

    public static string GetString(string key, string defaultValue)
    {
      string str1 = ObscuredPrefs.EncryptKey(key);
      if (!PlayerPrefs.HasKey(str1) && PlayerPrefs.HasKey(key))
      {
        string str2 = PlayerPrefs.GetString(key, defaultValue);
        if (!ObscuredPrefs.preservePlayerPrefs)
        {
          ObscuredPrefs.SetString(key, str2);
          PlayerPrefs.DeleteKey(key);
        }
        return str2;
      }
      string encryptedPrefsString = ObscuredPrefs.GetEncryptedPrefsString(key, str1);
      if (encryptedPrefsString == "{not_found}")
        return defaultValue;
      return ObscuredPrefs.DecryptStringValue(key, encryptedPrefsString, defaultValue);
    }

    internal static string EncryptStringValue(string key, string value)
    {
      byte[] bytes = Encoding.UTF8.GetBytes(value);
      return ObscuredPrefs.EncryptData(key, bytes, ObscuredPrefs.DataType.String);
    }

    internal static string DecryptStringValue(string key, string encryptedInput, string defaultValue)
    {
      if (encryptedInput.IndexOf(':') > -1)
      {
        string str = ObscuredPrefs.DeprecatedDecryptValue(encryptedInput);
        if (str == string.Empty)
          return defaultValue;
        ObscuredPrefs.SetString(key, str);
        return str;
      }
      byte[] bytes = ObscuredPrefs.DecryptData(key, encryptedInput);
      if (bytes == null)
        return defaultValue;
      return Encoding.UTF8.GetString(bytes, 0, bytes.Length);
    }

    public static void SetFloat(string key, float value)
    {
      PlayerPrefs.SetString(ObscuredPrefs.EncryptKey(key), ObscuredPrefs.EncryptFloatValue(key, value));
    }

    public static float GetFloat(string key)
    {
      return ObscuredPrefs.GetFloat(key, 0.0f);
    }

    public static float GetFloat(string key, float defaultValue)
    {
      string str = ObscuredPrefs.EncryptKey(key);
      if (!PlayerPrefs.HasKey(str) && PlayerPrefs.HasKey(key))
      {
        float num = PlayerPrefs.GetFloat(key, defaultValue);
        if (!ObscuredPrefs.preservePlayerPrefs)
        {
          ObscuredPrefs.SetFloat(key, num);
          PlayerPrefs.DeleteKey(key);
        }
        return num;
      }
      string encryptedPrefsString = ObscuredPrefs.GetEncryptedPrefsString(key, str);
      if (encryptedPrefsString == "{not_found}")
        return defaultValue;
      return ObscuredPrefs.DecryptFloatValue(key, encryptedPrefsString, defaultValue);
    }

    internal static string EncryptFloatValue(string key, float value)
    {
      byte[] bytes = BitConverter.GetBytes(value);
      return ObscuredPrefs.EncryptData(key, bytes, ObscuredPrefs.DataType.Float);
    }

    internal static float DecryptFloatValue(string key, string encryptedInput, float defaultValue)
    {
      if (encryptedInput.IndexOf(':') > -1)
      {
        string s = ObscuredPrefs.DeprecatedDecryptValue(encryptedInput);
        if (s == string.Empty)
          return defaultValue;
        float result;
        float.TryParse(s, out result);
        ObscuredPrefs.SetFloat(key, result);
        return result;
      }
      byte[] numArray = ObscuredPrefs.DecryptData(key, encryptedInput);
      if (numArray == null)
        return defaultValue;
      return BitConverter.ToSingle(numArray, 0);
    }

    public static void SetDouble(string key, double value)
    {
      PlayerPrefs.SetString(ObscuredPrefs.EncryptKey(key), ObscuredPrefs.EncryptDoubleValue(key, value));
    }

    public static double GetDouble(string key)
    {
      return ObscuredPrefs.GetDouble(key, 0.0);
    }

    public static double GetDouble(string key, double defaultValue)
    {
      string encryptedPrefsString = ObscuredPrefs.GetEncryptedPrefsString(key, ObscuredPrefs.EncryptKey(key));
      if (encryptedPrefsString == "{not_found}")
        return defaultValue;
      return ObscuredPrefs.DecryptDoubleValue(key, encryptedPrefsString, defaultValue);
    }

    private static string EncryptDoubleValue(string key, double value)
    {
      byte[] bytes = BitConverter.GetBytes(value);
      return ObscuredPrefs.EncryptData(key, bytes, ObscuredPrefs.DataType.Double);
    }

    private static double DecryptDoubleValue(string key, string encryptedInput, double defaultValue)
    {
      if (encryptedInput.IndexOf(':') > -1)
      {
        string s = ObscuredPrefs.DeprecatedDecryptValue(encryptedInput);
        if (s == string.Empty)
          return defaultValue;
        double result;
        double.TryParse(s, out result);
        ObscuredPrefs.SetDouble(key, result);
        return result;
      }
      byte[] numArray = ObscuredPrefs.DecryptData(key, encryptedInput);
      if (numArray == null)
        return defaultValue;
      return BitConverter.ToDouble(numArray, 0);
    }

    public static void SetLong(string key, long value)
    {
      PlayerPrefs.SetString(ObscuredPrefs.EncryptKey(key), ObscuredPrefs.EncryptLongValue(key, value));
    }

    public static long GetLong(string key)
    {
      return ObscuredPrefs.GetLong(key, 0L);
    }

    public static long GetLong(string key, long defaultValue)
    {
      string encryptedPrefsString = ObscuredPrefs.GetEncryptedPrefsString(key, ObscuredPrefs.EncryptKey(key));
      if (encryptedPrefsString == "{not_found}")
        return defaultValue;
      return ObscuredPrefs.DecryptLongValue(key, encryptedPrefsString, defaultValue);
    }

    private static string EncryptLongValue(string key, long value)
    {
      byte[] bytes = BitConverter.GetBytes(value);
      return ObscuredPrefs.EncryptData(key, bytes, ObscuredPrefs.DataType.Long);
    }

    private static long DecryptLongValue(string key, string encryptedInput, long defaultValue)
    {
      if (encryptedInput.IndexOf(':') > -1)
      {
        string s = ObscuredPrefs.DeprecatedDecryptValue(encryptedInput);
        if (s == string.Empty)
          return defaultValue;
        long result;
        long.TryParse(s, out result);
        ObscuredPrefs.SetLong(key, result);
        return result;
      }
      byte[] numArray = ObscuredPrefs.DecryptData(key, encryptedInput);
      if (numArray == null)
        return defaultValue;
      return BitConverter.ToInt64(numArray, 0);
    }

    public static void SetBool(string key, bool value)
    {
      PlayerPrefs.SetString(ObscuredPrefs.EncryptKey(key), ObscuredPrefs.EncryptBoolValue(key, value));
    }

    public static bool GetBool(string key)
    {
      return ObscuredPrefs.GetBool(key, false);
    }

    public static bool GetBool(string key, bool defaultValue)
    {
      string encryptedPrefsString = ObscuredPrefs.GetEncryptedPrefsString(key, ObscuredPrefs.EncryptKey(key));
      if (encryptedPrefsString == "{not_found}")
        return defaultValue;
      return ObscuredPrefs.DecryptBoolValue(key, encryptedPrefsString, defaultValue);
    }

    private static string EncryptBoolValue(string key, bool value)
    {
      byte[] bytes = BitConverter.GetBytes(value);
      return ObscuredPrefs.EncryptData(key, bytes, ObscuredPrefs.DataType.Bool);
    }

    private static bool DecryptBoolValue(string key, string encryptedInput, bool defaultValue)
    {
      if (encryptedInput.IndexOf(':') > -1)
      {
        string s = ObscuredPrefs.DeprecatedDecryptValue(encryptedInput);
        if (s == string.Empty)
          return defaultValue;
        int result;
        int.TryParse(s, out result);
        ObscuredPrefs.SetBool(key, result == 1);
        return result == 1;
      }
      byte[] numArray = ObscuredPrefs.DecryptData(key, encryptedInput);
      if (numArray == null)
        return defaultValue;
      return BitConverter.ToBoolean(numArray, 0);
    }

    public static void SetByteArray(string key, byte[] value)
    {
      PlayerPrefs.SetString(ObscuredPrefs.EncryptKey(key), ObscuredPrefs.EncryptByteArrayValue(key, value));
    }

    public static byte[] GetByteArray(string key)
    {
      return ObscuredPrefs.GetByteArray(key, (byte) 0, 0);
    }

    public static byte[] GetByteArray(string key, byte defaultValue, int defaultLength)
    {
      string encryptedPrefsString = ObscuredPrefs.GetEncryptedPrefsString(key, ObscuredPrefs.EncryptKey(key));
      if (encryptedPrefsString == "{not_found}")
        return ObscuredPrefs.ConstructByteArray(defaultValue, defaultLength);
      return ObscuredPrefs.DecryptByteArrayValue(key, encryptedPrefsString, defaultValue, defaultLength);
    }

    private static string EncryptByteArrayValue(string key, byte[] value)
    {
      return ObscuredPrefs.EncryptData(key, value, ObscuredPrefs.DataType.ByteArray);
    }

    private static byte[] DecryptByteArrayValue(string key, string encryptedInput, byte defaultValue, int defaultLength)
    {
      if (encryptedInput.IndexOf(':') <= -1)
        return ObscuredPrefs.DecryptData(key, encryptedInput) ?? ObscuredPrefs.ConstructByteArray(defaultValue, defaultLength);
      string s = ObscuredPrefs.DeprecatedDecryptValue(encryptedInput);
      if (s == string.Empty)
        return ObscuredPrefs.ConstructByteArray(defaultValue, defaultLength);
      byte[] bytes = Encoding.UTF8.GetBytes(s);
      ObscuredPrefs.SetByteArray(key, bytes);
      return bytes;
    }

    private static byte[] ConstructByteArray(byte value, int length)
    {
      byte[] numArray = new byte[length];
      for (int index = 0; index < length; ++index)
        numArray[index] = value;
      return numArray;
    }

    public static void SetVector2(string key, Vector2 value)
    {
      PlayerPrefs.SetString(ObscuredPrefs.EncryptKey(key), ObscuredPrefs.EncryptVector2Value(key, value));
    }

    public static Vector2 GetVector2(string key)
    {
      return ObscuredPrefs.GetVector2(key, Vector2.zero);
    }

    public static Vector2 GetVector2(string key, Vector2 defaultValue)
    {
      string encryptedPrefsString = ObscuredPrefs.GetEncryptedPrefsString(key, ObscuredPrefs.EncryptKey(key));
      if (encryptedPrefsString == "{not_found}")
        return defaultValue;
      return ObscuredPrefs.DecryptVector2Value(key, encryptedPrefsString, defaultValue);
    }

    private static string EncryptVector2Value(string key, Vector2 value)
    {
      byte[] cleanBytes = new byte[8];
      Buffer.BlockCopy((Array) BitConverter.GetBytes(value.x), 0, (Array) cleanBytes, 0, 4);
      Buffer.BlockCopy((Array) BitConverter.GetBytes(value.y), 0, (Array) cleanBytes, 4, 4);
      return ObscuredPrefs.EncryptData(key, cleanBytes, ObscuredPrefs.DataType.Vector2);
    }

    private static Vector2 DecryptVector2Value(string key, string encryptedInput, Vector2 defaultValue)
    {
      if (encryptedInput.IndexOf(':') > -1)
      {
        string str = ObscuredPrefs.DeprecatedDecryptValue(encryptedInput);
        if (str == string.Empty)
          return defaultValue;
        string[] strArray = str.Split("|"[0]);
        float result1;
        float.TryParse(strArray[0], out result1);
        float result2;
        float.TryParse(strArray[1], out result2);
        Vector2 vector2 = new Vector2(result1, result2);
        ObscuredPrefs.SetVector2(key, vector2);
        return vector2;
      }
      byte[] numArray = ObscuredPrefs.DecryptData(key, encryptedInput);
      if (numArray == null)
        return defaultValue;
      Vector2 vector2_1;
      vector2_1.x = BitConverter.ToSingle(numArray, 0);
      vector2_1.y = BitConverter.ToSingle(numArray, 4);
      return vector2_1;
    }

    public static void SetVector3(string key, Vector3 value)
    {
      PlayerPrefs.SetString(ObscuredPrefs.EncryptKey(key), ObscuredPrefs.EncryptVector3Value(key, value));
    }

    public static Vector3 GetVector3(string key)
    {
      return ObscuredPrefs.GetVector3(key, Vector3.zero);
    }

    public static Vector3 GetVector3(string key, Vector3 defaultValue)
    {
      string encryptedPrefsString = ObscuredPrefs.GetEncryptedPrefsString(key, ObscuredPrefs.EncryptKey(key));
      if (encryptedPrefsString == "{not_found}")
        return defaultValue;
      return ObscuredPrefs.DecryptVector3Value(key, encryptedPrefsString, defaultValue);
    }

    private static string EncryptVector3Value(string key, Vector3 value)
    {
      byte[] cleanBytes = new byte[12];
      Buffer.BlockCopy((Array) BitConverter.GetBytes(value.x), 0, (Array) cleanBytes, 0, 4);
      Buffer.BlockCopy((Array) BitConverter.GetBytes(value.y), 0, (Array) cleanBytes, 4, 4);
      Buffer.BlockCopy((Array) BitConverter.GetBytes(value.z), 0, (Array) cleanBytes, 8, 4);
      return ObscuredPrefs.EncryptData(key, cleanBytes, ObscuredPrefs.DataType.Vector3);
    }

    private static Vector3 DecryptVector3Value(string key, string encryptedInput, Vector3 defaultValue)
    {
      if (encryptedInput.IndexOf(':') > -1)
      {
        string str = ObscuredPrefs.DeprecatedDecryptValue(encryptedInput);
        if (str == string.Empty)
          return defaultValue;
        string[] strArray = str.Split("|"[0]);
        float result1;
        float.TryParse(strArray[0], out result1);
        float result2;
        float.TryParse(strArray[1], out result2);
        float result3;
        float.TryParse(strArray[2], out result3);
        Vector3 vector3 = new Vector3(result1, result2, result3);
        ObscuredPrefs.SetVector3(key, vector3);
        return vector3;
      }
      byte[] numArray = ObscuredPrefs.DecryptData(key, encryptedInput);
      if (numArray == null)
        return defaultValue;
      Vector3 vector3_1;
      vector3_1.x = BitConverter.ToSingle(numArray, 0);
      vector3_1.y = BitConverter.ToSingle(numArray, 4);
      vector3_1.z = BitConverter.ToSingle(numArray, 8);
      return vector3_1;
    }

    public static void SetQuaternion(string key, Quaternion value)
    {
      PlayerPrefs.SetString(ObscuredPrefs.EncryptKey(key), ObscuredPrefs.EncryptQuaternionValue(key, value));
    }

    public static Quaternion GetQuaternion(string key)
    {
      return ObscuredPrefs.GetQuaternion(key, Quaternion.identity);
    }

    public static Quaternion GetQuaternion(string key, Quaternion defaultValue)
    {
      string encryptedPrefsString = ObscuredPrefs.GetEncryptedPrefsString(key, ObscuredPrefs.EncryptKey(key));
      if (encryptedPrefsString == "{not_found}")
        return defaultValue;
      return ObscuredPrefs.DecryptQuaternionValue(key, encryptedPrefsString, defaultValue);
    }

    private static string EncryptQuaternionValue(string key, Quaternion value)
    {
      byte[] cleanBytes = new byte[16];
      Buffer.BlockCopy((Array) BitConverter.GetBytes(value.x), 0, (Array) cleanBytes, 0, 4);
      Buffer.BlockCopy((Array) BitConverter.GetBytes(value.y), 0, (Array) cleanBytes, 4, 4);
      Buffer.BlockCopy((Array) BitConverter.GetBytes(value.z), 0, (Array) cleanBytes, 8, 4);
      Buffer.BlockCopy((Array) BitConverter.GetBytes(value.w), 0, (Array) cleanBytes, 12, 4);
      return ObscuredPrefs.EncryptData(key, cleanBytes, ObscuredPrefs.DataType.Quaternion);
    }

    private static Quaternion DecryptQuaternionValue(string key, string encryptedInput, Quaternion defaultValue)
    {
      if (encryptedInput.IndexOf(':') > -1)
      {
        string str = ObscuredPrefs.DeprecatedDecryptValue(encryptedInput);
        if (str == string.Empty)
          return defaultValue;
        string[] strArray = str.Split("|"[0]);
        float result1;
        float.TryParse(strArray[0], out result1);
        float result2;
        float.TryParse(strArray[1], out result2);
        float result3;
        float.TryParse(strArray[2], out result3);
        float result4;
        float.TryParse(strArray[3], out result4);
        Quaternion quaternion = new Quaternion(result1, result2, result3, result4);
        ObscuredPrefs.SetQuaternion(key, quaternion);
        return quaternion;
      }
      byte[] numArray = ObscuredPrefs.DecryptData(key, encryptedInput);
      if (numArray == null)
        return defaultValue;
      Quaternion quaternion1;
      quaternion1.x = BitConverter.ToSingle(numArray, 0);
      quaternion1.y = BitConverter.ToSingle(numArray, 4);
      quaternion1.z = BitConverter.ToSingle(numArray, 8);
      quaternion1.w = BitConverter.ToSingle(numArray, 12);
      return quaternion1;
    }

    public static void SetColor(string key, Color32 value)
    {
      uint num = (uint) ((int) value.a << 24 | (int) value.r << 16 | (int) value.g << 8) | (uint) value.b;
      PlayerPrefs.SetString(ObscuredPrefs.EncryptKey(key), ObscuredPrefs.EncryptColorValue(key, num));
    }

    public static Color32 GetColor(string key)
    {
      return ObscuredPrefs.GetColor(key, new Color32((byte) 0, (byte) 0, (byte) 0, (byte) 1));
    }

    public static Color32 GetColor(string key, Color32 defaultValue)
    {
      string encryptedPrefsString = ObscuredPrefs.GetEncryptedPrefsString(key, ObscuredPrefs.EncryptKey(key));
      if (encryptedPrefsString == "{not_found}")
        return defaultValue;
      uint num = ObscuredPrefs.DecryptUIntValue(key, encryptedPrefsString, 16777216U);
      byte a = (byte) (num >> 24);
      return new Color32((byte) (num >> 16), (byte) (num >> 8), (byte) (num >> 0), a);
    }

    private static string EncryptColorValue(string key, uint value)
    {
      byte[] bytes = BitConverter.GetBytes(value);
      return ObscuredPrefs.EncryptData(key, bytes, ObscuredPrefs.DataType.Color);
    }

    public static void SetRect(string key, Rect value)
    {
      PlayerPrefs.SetString(ObscuredPrefs.EncryptKey(key), ObscuredPrefs.EncryptRectValue(key, value));
    }

    public static Rect GetRect(string key)
    {
      return ObscuredPrefs.GetRect(key, new Rect(0.0f, 0.0f, 0.0f, 0.0f));
    }

    public static Rect GetRect(string key, Rect defaultValue)
    {
      string encryptedPrefsString = ObscuredPrefs.GetEncryptedPrefsString(key, ObscuredPrefs.EncryptKey(key));
      if (encryptedPrefsString == "{not_found}")
        return defaultValue;
      return ObscuredPrefs.DecryptRectValue(key, encryptedPrefsString, defaultValue);
    }

    private static string EncryptRectValue(string key, Rect value)
    {
      byte[] cleanBytes = new byte[16];
      Buffer.BlockCopy((Array) BitConverter.GetBytes(value.x), 0, (Array) cleanBytes, 0, 4);
      Buffer.BlockCopy((Array) BitConverter.GetBytes(value.y), 0, (Array) cleanBytes, 4, 4);
      Buffer.BlockCopy((Array) BitConverter.GetBytes(value.width), 0, (Array) cleanBytes, 8, 4);
      Buffer.BlockCopy((Array) BitConverter.GetBytes(value.height), 0, (Array) cleanBytes, 12, 4);
      return ObscuredPrefs.EncryptData(key, cleanBytes, ObscuredPrefs.DataType.Rect);
    }

    private static Rect DecryptRectValue(string key, string encryptedInput, Rect defaultValue)
    {
      if (encryptedInput.IndexOf(':') > -1)
      {
        string str = ObscuredPrefs.DeprecatedDecryptValue(encryptedInput);
        if (str == string.Empty)
          return defaultValue;
        string[] strArray = str.Split("|"[0]);
        float result1;
        float.TryParse(strArray[0], out result1);
        float result2;
        float.TryParse(strArray[1], out result2);
        float result3;
        float.TryParse(strArray[2], out result3);
        float result4;
        float.TryParse(strArray[3], out result4);
        Rect rect = new Rect(result1, result2, result3, result4);
        ObscuredPrefs.SetRect(key, rect);
        return rect;
      }
      byte[] numArray = ObscuredPrefs.DecryptData(key, encryptedInput);
      if (numArray == null)
        return defaultValue;
      return new Rect()
      {
        x = BitConverter.ToSingle(numArray, 0),
        y = BitConverter.ToSingle(numArray, 4),
        width = BitConverter.ToSingle(numArray, 8),
        height = BitConverter.ToSingle(numArray, 12)
      };
    }

    public static void SetRawValue(string key, string encryptedValue)
    {
      PlayerPrefs.SetString(ObscuredPrefs.EncryptKey(key), encryptedValue);
    }

    public static string GetRawValue(string key)
    {
      return PlayerPrefs.GetString(ObscuredPrefs.EncryptKey(key));
    }

    internal static ObscuredPrefs.DataType GetRawValueType(string value)
    {
      ObscuredPrefs.DataType dataType1 = ObscuredPrefs.DataType.Unknown;
      byte[] numArray;
      try
      {
        numArray = Convert.FromBase64String(value);
      }
      catch (Exception ex)
      {
        return dataType1;
      }
      if (numArray.Length < 7)
        return dataType1;
      int length = numArray.Length;
      ObscuredPrefs.DataType dataType2 = (ObscuredPrefs.DataType) numArray[length - 7];
      if ((int) numArray[length - 6] > 10)
        dataType2 = ObscuredPrefs.DataType.Unknown;
      return dataType2;
    }

    internal static string EncryptKey(string key)
    {
      key = ObscuredString.EncryptDecrypt(key, ObscuredPrefs.cryptoKey);
      key = Convert.ToBase64String(Encoding.UTF8.GetBytes(key));
      return key;
    }

    public static bool HasKey(string key)
    {
      if (!PlayerPrefs.HasKey(key))
        return PlayerPrefs.HasKey(ObscuredPrefs.EncryptKey(key));
      return true;
    }

    public static void DeleteKey(string key)
    {
      PlayerPrefs.DeleteKey(ObscuredPrefs.EncryptKey(key));
      if (ObscuredPrefs.preservePlayerPrefs)
        return;
      PlayerPrefs.DeleteKey(key);
    }

    public static void DeleteAll()
    {
      PlayerPrefs.DeleteAll();
    }

    public static void Save()
    {
      PlayerPrefs.Save();
    }

    private static string GetEncryptedPrefsString(string key, string encryptedKey)
    {
      string str = PlayerPrefs.GetString(encryptedKey, "{not_found}");
      if (str == "{not_found}" && PlayerPrefs.HasKey(key))
        Debug.LogWarning((object) ("[ACTk] Are you trying to read regular PlayerPrefs data using ObscuredPrefs (key = " + key + ")?"));
      return str;
    }

    private static string EncryptData(string key, byte[] cleanBytes, ObscuredPrefs.DataType type)
    {
      int length1 = cleanBytes.Length;
      byte[] numArray1 = ObscuredPrefs.EncryptDecryptBytes(cleanBytes, length1, key + ObscuredPrefs.cryptoKey);
      uint hash = xxHash.CalculateHash(cleanBytes, length1, 0U);
      byte[] numArray2 = new byte[4]
      {
        (byte) (hash & (uint) byte.MaxValue),
        (byte) (hash >> 8 & (uint) byte.MaxValue),
        (byte) (hash >> 16 & (uint) byte.MaxValue),
        (byte) (hash >> 24 & (uint) byte.MaxValue)
      };
      byte[] numArray3 = (byte[]) null;
      int length2;
      if (ObscuredPrefs.lockToDevice != ObscuredPrefs.DeviceLockLevel.None)
      {
        length2 = length1 + 11;
        uint deviceIdHash = ObscuredPrefs.DeviceIdHash;
        numArray3 = new byte[4]
        {
          (byte) (deviceIdHash & (uint) byte.MaxValue),
          (byte) (deviceIdHash >> 8 & (uint) byte.MaxValue),
          (byte) (deviceIdHash >> 16 & (uint) byte.MaxValue),
          (byte) (deviceIdHash >> 24 & (uint) byte.MaxValue)
        };
      }
      else
        length2 = length1 + 7;
      byte[] inArray = new byte[length2];
      Buffer.BlockCopy((Array) numArray1, 0, (Array) inArray, 0, length1);
      if (numArray3 != null)
        Buffer.BlockCopy((Array) numArray3, 0, (Array) inArray, length1, 4);
      inArray[length2 - 7] = (byte) type;
      inArray[length2 - 6] = (byte) 2;
      inArray[length2 - 5] = (byte) ObscuredPrefs.lockToDevice;
      Buffer.BlockCopy((Array) numArray2, 0, (Array) inArray, length2 - 4, 4);
      return Convert.ToBase64String(inArray);
    }

    internal static byte[] DecryptData(string key, string encryptedInput)
    {
      byte[] numArray1;
      try
      {
        numArray1 = Convert.FromBase64String(encryptedInput);
      }
      catch (Exception ex)
      {
        ObscuredPrefs.SavesTampered();
        return (byte[]) null;
      }
      if (numArray1.Length <= 0)
      {
        ObscuredPrefs.SavesTampered();
        return (byte[]) null;
      }
      int length1 = numArray1.Length;
      if ((int) numArray1[length1 - 6] != 2)
      {
        ObscuredPrefs.SavesTampered();
        return (byte[]) null;
      }
      ObscuredPrefs.DeviceLockLevel deviceLockLevel = (ObscuredPrefs.DeviceLockLevel) numArray1[length1 - 5];
      byte[] numArray2 = new byte[4];
      Buffer.BlockCopy((Array) numArray1, length1 - 4, (Array) numArray2, 0, 4);
      uint num1 = (uint) ((int) numArray2[0] | (int) numArray2[1] << 8 | (int) numArray2[2] << 16 | (int) numArray2[3] << 24);
      uint num2 = 0;
      int length2;
      if (deviceLockLevel != ObscuredPrefs.DeviceLockLevel.None)
      {
        length2 = length1 - 11;
        if (ObscuredPrefs.lockToDevice != ObscuredPrefs.DeviceLockLevel.None)
        {
          byte[] numArray3 = new byte[4];
          Buffer.BlockCopy((Array) numArray1, length2, (Array) numArray3, 0, 4);
          num2 = (uint) ((int) numArray3[0] | (int) numArray3[1] << 8 | (int) numArray3[2] << 16 | (int) numArray3[3] << 24);
        }
      }
      else
        length2 = length1 - 7;
      byte[] bytes = new byte[length2];
      Buffer.BlockCopy((Array) numArray1, 0, (Array) bytes, 0, length2);
      byte[] buf = ObscuredPrefs.EncryptDecryptBytes(bytes, length2, key + ObscuredPrefs.cryptoKey);
      if ((int) xxHash.CalculateHash(buf, length2, 0U) != (int) num1)
      {
        ObscuredPrefs.SavesTampered();
        return (byte[]) null;
      }
      if (ObscuredPrefs.lockToDevice == ObscuredPrefs.DeviceLockLevel.Strict && (int) num2 == 0 && (!ObscuredPrefs.emergencyMode && !ObscuredPrefs.readForeignSaves))
        return (byte[]) null;
      if ((int) num2 != 0 && !ObscuredPrefs.emergencyMode)
      {
        uint deviceIdHash = ObscuredPrefs.DeviceIdHash;
        if ((int) num2 != (int) deviceIdHash)
        {
          ObscuredPrefs.PossibleForeignSavesDetected();
          if (!ObscuredPrefs.readForeignSaves)
            return (byte[]) null;
        }
      }
      return buf;
    }

    private static uint CalculateChecksum(string input)
    {
      byte[] bytes = Encoding.UTF8.GetBytes(input + ObscuredPrefs.cryptoKey);
      return xxHash.CalculateHash(bytes, bytes.Length, 0U);
    }

    private static void SavesTampered()
    {
      if (ObscuredPrefs.onAlterationDetected == null)
        return;
      ObscuredPrefs.onAlterationDetected();
      ObscuredPrefs.onAlterationDetected = (Action) null;
    }

    private static void PossibleForeignSavesDetected()
    {
      if (ObscuredPrefs.onPossibleForeignSavesDetected == null || ObscuredPrefs.foreignSavesReported)
        return;
      ObscuredPrefs.foreignSavesReported = true;
      ObscuredPrefs.onPossibleForeignSavesDetected();
    }

    private static string GetDeviceId()
    {
      string str = string.Empty;
      if (string.IsNullOrEmpty(str))
        str = SystemInfo.deviceUniqueIdentifier;
      return str;
    }

    private static byte[] EncryptDecryptBytes(byte[] bytes, int dataLength, string key)
    {
      int length = key.Length;
      byte[] numArray = new byte[dataLength];
      for (int index = 0; index < dataLength; ++index)
        numArray[index] = (byte) ((uint) bytes[index] ^ (uint) key[index % length]);
      return numArray;
    }

    private static string DeprecatedDecryptValue(string value)
    {
      string[] strArray = value.Split(':');
      if (strArray.Length < 2)
      {
        ObscuredPrefs.SavesTampered();
        return string.Empty;
      }
      string str1 = strArray[0];
      string str2 = strArray[1];
      byte[] bytes;
      try
      {
        bytes = Convert.FromBase64String(str1);
      }
      catch
      {
        ObscuredPrefs.SavesTampered();
        return string.Empty;
      }
      string str3 = ObscuredString.EncryptDecrypt(Encoding.UTF8.GetString(bytes, 0, bytes.Length), ObscuredPrefs.cryptoKey);
      if (strArray.Length == 3)
      {
        if (str2 != ObscuredPrefs.DeprecatedCalculateChecksum(str1 + ObscuredPrefs.DeprecatedDeviceId))
          ObscuredPrefs.SavesTampered();
      }
      else if (strArray.Length == 2)
      {
        if (str2 != ObscuredPrefs.DeprecatedCalculateChecksum(str1))
          ObscuredPrefs.SavesTampered();
      }
      else
        ObscuredPrefs.SavesTampered();
      if (ObscuredPrefs.lockToDevice != ObscuredPrefs.DeviceLockLevel.None && !ObscuredPrefs.emergencyMode)
      {
        if (strArray.Length >= 3)
        {
          if (strArray[2] != ObscuredPrefs.DeprecatedDeviceId)
          {
            if (!ObscuredPrefs.readForeignSaves)
              str3 = string.Empty;
            ObscuredPrefs.PossibleForeignSavesDetected();
          }
        }
        else if (ObscuredPrefs.lockToDevice == ObscuredPrefs.DeviceLockLevel.Strict)
        {
          if (!ObscuredPrefs.readForeignSaves)
            str3 = string.Empty;
          ObscuredPrefs.PossibleForeignSavesDetected();
        }
        else if (str2 != ObscuredPrefs.DeprecatedCalculateChecksum(str1))
        {
          if (!ObscuredPrefs.readForeignSaves)
            str3 = string.Empty;
          ObscuredPrefs.PossibleForeignSavesDetected();
        }
      }
      return str3;
    }

    private static string DeprecatedCalculateChecksum(string input)
    {
      int num1 = 0;
      byte[] bytes = Encoding.UTF8.GetBytes(input + ObscuredPrefs.cryptoKey);
      int length = bytes.Length;
      int num2 = ObscuredPrefs.cryptoKey.Length ^ 64;
      for (int index = 0; index < length; ++index)
      {
        byte num3 = bytes[index];
        num1 += (int) num3 + (int) num3 * (index + num2) % 3;
      }
      return num1.ToString("X2");
    }

    internal enum DataType : byte
    {
      Unknown = 0,
      Int = 5,
      UInt = 10,
      String = 15,
      Float = 20,
      Double = 25,
      Long = 30,
      Bool = 35,
      ByteArray = 40,
      Vector2 = 45,
      Vector3 = 50,
      Quaternion = 55,
      Color = 60,
      Rect = 65,
    }

    public enum DeviceLockLevel : byte
    {
      None,
      Soft,
      Strict,
    }
  }
}
