// Decompiled with JetBrains decompiler
// Type: CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble
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
  public struct ObscuredDouble : IEquatable<ObscuredDouble>, IFormattable
  {
    private static long cryptoKey = 210987;
    [SerializeField]
    private long currentCryptoKey;
    [SerializeField]
    private ACTkByte8 hiddenValue;
    [SerializeField]
    [FormerlySerializedAs("hiddenValue")]
    private byte[] hiddenValueOld;
    [SerializeField]
    private double fakeValue;
    [SerializeField]
    private bool inited;

    private ObscuredDouble(ACTkByte8 value)
    {
      this.currentCryptoKey = ObscuredDouble.cryptoKey;
      this.hiddenValue = value;
      this.hiddenValueOld = (byte[]) null;
      this.fakeValue = 0.0;
      this.inited = true;
    }

    public static implicit operator ObscuredDouble(double value)
    {
      ObscuredDouble obscuredDouble = new ObscuredDouble(ObscuredDouble.InternalEncrypt(value));
      if (ObscuredCheatingDetector.IsRunning)
        obscuredDouble.fakeValue = value;
      return obscuredDouble;
    }

    public static implicit operator double(ObscuredDouble value)
    {
      return value.InternalDecrypt();
    }

    public static ObscuredDouble operator ++(ObscuredDouble input)
    {
      double num = input.InternalDecrypt() + 1.0;
      input.hiddenValue = ObscuredDouble.InternalEncrypt(num, input.currentCryptoKey);
      if (ObscuredCheatingDetector.IsRunning)
        input.fakeValue = num;
      return input;
    }

    public static ObscuredDouble operator --(ObscuredDouble input)
    {
      double num = input.InternalDecrypt() - 1.0;
      input.hiddenValue = ObscuredDouble.InternalEncrypt(num, input.currentCryptoKey);
      if (ObscuredCheatingDetector.IsRunning)
        input.fakeValue = num;
      return input;
    }

    public static void SetNewCryptoKey(long newKey)
    {
      ObscuredDouble.cryptoKey = newKey;
    }

    public static long Encrypt(double value)
    {
      return ObscuredDouble.Encrypt(value, ObscuredDouble.cryptoKey);
    }

    public static long Encrypt(double value, long key)
    {
      ObscuredDouble.DoubleLongBytesUnion doubleLongBytesUnion = new ObscuredDouble.DoubleLongBytesUnion();
      doubleLongBytesUnion.d = value;
      doubleLongBytesUnion.l = doubleLongBytesUnion.l ^ key;
      return doubleLongBytesUnion.l;
    }

    private static ACTkByte8 InternalEncrypt(double value)
    {
      return ObscuredDouble.InternalEncrypt(value, 0L);
    }

    private static ACTkByte8 InternalEncrypt(double value, long key)
    {
      long num = key;
      if (num == 0L)
        num = ObscuredDouble.cryptoKey;
      ObscuredDouble.DoubleLongBytesUnion doubleLongBytesUnion = new ObscuredDouble.DoubleLongBytesUnion();
      doubleLongBytesUnion.d = value;
      doubleLongBytesUnion.l = doubleLongBytesUnion.l ^ num;
      return doubleLongBytesUnion.b8;
    }

    public static double Decrypt(long value)
    {
      return ObscuredDouble.Decrypt(value, ObscuredDouble.cryptoKey);
    }

    public static double Decrypt(long value, long key)
    {
      return new ObscuredDouble.DoubleLongBytesUnion() { l = (value ^ key) }.d;
    }

    public void ApplyNewCryptoKey()
    {
      if (this.currentCryptoKey == ObscuredDouble.cryptoKey)
        return;
      this.hiddenValue = ObscuredDouble.InternalEncrypt(this.InternalDecrypt(), ObscuredDouble.cryptoKey);
      this.currentCryptoKey = ObscuredDouble.cryptoKey;
    }

    public void RandomizeCryptoKey()
    {
      double num = this.InternalDecrypt();
      do
      {
        this.currentCryptoKey = (long) UnityEngine.Random.Range(int.MinValue, int.MaxValue);
      }
      while (this.currentCryptoKey == 0L);
      this.hiddenValue = ObscuredDouble.InternalEncrypt(num, this.currentCryptoKey);
    }

    public long GetEncrypted()
    {
      this.ApplyNewCryptoKey();
      return new ObscuredDouble.DoubleLongBytesUnion() { b8 = this.hiddenValue }.l;
    }

    public void SetEncrypted(long encrypted)
    {
      this.inited = true;
      this.hiddenValue = new ObscuredDouble.DoubleLongBytesUnion()
      {
        l = encrypted
      }.b8;
      if (!ObscuredCheatingDetector.IsRunning)
        return;
      this.fakeValue = this.InternalDecrypt();
    }

    private double InternalDecrypt()
    {
      if (!this.inited)
      {
        this.currentCryptoKey = ObscuredDouble.cryptoKey;
        this.hiddenValue = ObscuredDouble.InternalEncrypt(0.0);
        this.fakeValue = 0.0;
        this.inited = true;
      }
      ObscuredDouble.DoubleLongBytesUnion doubleLongBytesUnion = new ObscuredDouble.DoubleLongBytesUnion();
      doubleLongBytesUnion.b8 = this.hiddenValue;
      doubleLongBytesUnion.l = doubleLongBytesUnion.l ^ this.currentCryptoKey;
      double d = doubleLongBytesUnion.d;
      if (ObscuredCheatingDetector.IsRunning && this.fakeValue != 0.0 && Math.Abs(d - this.fakeValue) > 1E-06)
        ObscuredCheatingDetector.Instance.OnCheatingDetected();
      return d;
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

    public override bool Equals(object obj)
    {
      if (!(obj is ObscuredDouble))
        return false;
      return this.Equals((ObscuredDouble) obj);
    }

    public bool Equals(ObscuredDouble obj)
    {
      return obj.InternalDecrypt().Equals(this.InternalDecrypt());
    }

    public override int GetHashCode()
    {
      return this.InternalDecrypt().GetHashCode();
    }

    [StructLayout(LayoutKind.Explicit)]
    private struct DoubleLongBytesUnion
    {
      [FieldOffset(0)]
      public double d;
      [FieldOffset(0)]
      public long l;
      [FieldOffset(0)]
      public ACTkByte8 b8;
    }
  }
}
