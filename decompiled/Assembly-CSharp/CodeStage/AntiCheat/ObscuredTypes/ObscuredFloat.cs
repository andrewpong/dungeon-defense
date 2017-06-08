// Decompiled with JetBrains decompiler
// Type: CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using CodeStage.AntiCheat.Common;
using CodeStage.AntiCheat.Detectors;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace CodeStage.AntiCheat.ObscuredTypes
{
  [Serializable]
  public struct ObscuredFloat : IEquatable<ObscuredFloat>, IFormattable
  {
    private static int cryptoKey = 230887;
    [SerializeField]
    private int currentCryptoKey;
    [SerializeField]
    private ACTkByte4 hiddenValue;
    [SerializeField]
    [FormerlySerializedAs("hiddenValue")]
    private byte[] hiddenValueOld;
    [SerializeField]
    private float fakeValue;
    [SerializeField]
    private bool inited;

    private ObscuredFloat(ACTkByte4 value)
    {
      this.currentCryptoKey = ObscuredFloat.cryptoKey;
      this.hiddenValue = value;
      this.hiddenValueOld = (byte[]) null;
      this.fakeValue = 0.0f;
      this.inited = true;
    }

    public static implicit operator ObscuredFloat(float value)
    {
      ObscuredFloat obscuredFloat = new ObscuredFloat(ObscuredFloat.InternalEncrypt(value));
      if (ObscuredCheatingDetector.IsRunning)
        obscuredFloat.fakeValue = value;
      return obscuredFloat;
    }

    public static implicit operator float(ObscuredFloat value)
    {
      return value.InternalDecrypt();
    }

    public static ObscuredFloat operator ++(ObscuredFloat input)
    {
      float num = input.InternalDecrypt() + 1f;
      input.hiddenValue = ObscuredFloat.InternalEncrypt(num, input.currentCryptoKey);
      if (ObscuredCheatingDetector.IsRunning)
        input.fakeValue = num;
      return input;
    }

    public static ObscuredFloat operator --(ObscuredFloat input)
    {
      float num = input.InternalDecrypt() - 1f;
      input.hiddenValue = ObscuredFloat.InternalEncrypt(num, input.currentCryptoKey);
      if (ObscuredCheatingDetector.IsRunning)
        input.fakeValue = num;
      return input;
    }

    public static void SetNewCryptoKey(int newKey)
    {
      ObscuredFloat.cryptoKey = newKey;
    }

    public static int Encrypt(float value)
    {
      return ObscuredFloat.Encrypt(value, ObscuredFloat.cryptoKey);
    }

    public static int Encrypt(float value, int key)
    {
      ObscuredFloat.FloatIntBytesUnion floatIntBytesUnion = new ObscuredFloat.FloatIntBytesUnion();
      floatIntBytesUnion.f = value;
      floatIntBytesUnion.i = floatIntBytesUnion.i ^ key;
      return floatIntBytesUnion.i;
    }

    private static ACTkByte4 InternalEncrypt(float value)
    {
      return ObscuredFloat.InternalEncrypt(value, 0);
    }

    private static ACTkByte4 InternalEncrypt(float value, int key)
    {
      int num = key;
      if (num == 0)
        num = ObscuredFloat.cryptoKey;
      ObscuredFloat.FloatIntBytesUnion floatIntBytesUnion = new ObscuredFloat.FloatIntBytesUnion();
      floatIntBytesUnion.f = value;
      floatIntBytesUnion.i = floatIntBytesUnion.i ^ num;
      return floatIntBytesUnion.b4;
    }

    public static float Decrypt(int value)
    {
      return ObscuredFloat.Decrypt(value, ObscuredFloat.cryptoKey);
    }

    public static float Decrypt(int value, int key)
    {
      return new ObscuredFloat.FloatIntBytesUnion() { i = (value ^ key) }.f;
    }

    public void ApplyNewCryptoKey()
    {
      if (this.currentCryptoKey == ObscuredFloat.cryptoKey)
        return;
      this.hiddenValue = ObscuredFloat.InternalEncrypt(this.InternalDecrypt(), ObscuredFloat.cryptoKey);
      this.currentCryptoKey = ObscuredFloat.cryptoKey;
    }

    public void RandomizeCryptoKey()
    {
      float num = this.InternalDecrypt();
      do
      {
        this.currentCryptoKey = UnityEngine.Random.Range(int.MinValue, int.MaxValue);
      }
      while (this.currentCryptoKey == 0);
      this.hiddenValue = ObscuredFloat.InternalEncrypt(num, this.currentCryptoKey);
    }

    public int GetEncrypted()
    {
      this.ApplyNewCryptoKey();
      return new ObscuredFloat.FloatIntBytesUnion() { b4 = this.hiddenValue }.i;
    }

    public void SetEncrypted(int encrypted)
    {
      this.inited = true;
      this.hiddenValue = new ObscuredFloat.FloatIntBytesUnion()
      {
        i = encrypted
      }.b4;
      if (!ObscuredCheatingDetector.IsRunning)
        return;
      this.fakeValue = this.InternalDecrypt();
    }

    private float InternalDecrypt()
    {
      if (!this.inited)
      {
        this.currentCryptoKey = ObscuredFloat.cryptoKey;
        this.hiddenValue = ObscuredFloat.InternalEncrypt(0.0f);
        this.fakeValue = 0.0f;
        this.inited = true;
      }
      ObscuredFloat.FloatIntBytesUnion floatIntBytesUnion = new ObscuredFloat.FloatIntBytesUnion();
      floatIntBytesUnion.b4 = this.hiddenValue;
      floatIntBytesUnion.i = floatIntBytesUnion.i ^ this.currentCryptoKey;
      float f = floatIntBytesUnion.f;
      if (ObscuredCheatingDetector.IsRunning && (double) this.fakeValue != 0.0 && (double) Math.Abs(f - this.fakeValue) > (double) ObscuredCheatingDetector.Instance.floatEpsilon)
        ObscuredCheatingDetector.Instance.OnCheatingDetected();
      return f;
    }

    public override bool Equals(object obj)
    {
      if (!(obj is ObscuredFloat))
        return false;
      return this.Equals((ObscuredFloat) obj);
    }

    public bool Equals(ObscuredFloat obj)
    {
      return ((double) obj.InternalDecrypt()).Equals((double) this.InternalDecrypt());
    }

    public override int GetHashCode()
    {
      return this.InternalDecrypt().GetHashCode();
    }

    public override string ToString()
    {
      return this.InternalDecrypt().ToString();
    }

    public string ToString(string format)
    {
      return this.InternalDecrypt().ToString(format);
    }

    public string ToString(IFormatProvider provider)
    {
      return this.InternalDecrypt().ToString(provider);
    }

    public string ToString(string format, IFormatProvider provider)
    {
      return this.InternalDecrypt().ToString(format, provider);
    }

    [StructLayout(LayoutKind.Explicit)]
    private struct FloatIntBytesUnion
    {
      [FieldOffset(0)]
      public float f;
      [FieldOffset(0)]
      public int i;
      [FieldOffset(0)]
      public ACTkByte4 b4;
    }
  }
}
