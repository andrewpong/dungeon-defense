// Decompiled with JetBrains decompiler
// Type: CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using CodeStage.AntiCheat.Common;
using CodeStage.AntiCheat.Detectors;
using System;
using System.Runtime.InteropServices;
using UnityEngine.Serialization;

namespace CodeStage.AntiCheat.ObscuredTypes
{
  [Serializable]
  public struct ObscuredDecimal : IEquatable<ObscuredDecimal>, IFormattable
  {
    private static long cryptoKey = 209208;
    private long currentCryptoKey;
    [FormerlySerializedAs("hiddenValue")]
    private byte[] hiddenValueOld;
    private ACTkByte16 hiddenValue;
    private Decimal fakeValue;
    private bool inited;

    private ObscuredDecimal(ACTkByte16 value)
    {
      this.currentCryptoKey = ObscuredDecimal.cryptoKey;
      this.hiddenValue = value;
      this.hiddenValueOld = (byte[]) null;
      this.fakeValue = new Decimal(0);
      this.inited = true;
    }

    public static implicit operator ObscuredDecimal(Decimal value)
    {
      ObscuredDecimal obscuredDecimal = new ObscuredDecimal(ObscuredDecimal.InternalEncrypt(value));
      if (ObscuredCheatingDetector.IsRunning)
        obscuredDecimal.fakeValue = value;
      return obscuredDecimal;
    }

    public static implicit operator Decimal(ObscuredDecimal value)
    {
      return value.InternalDecrypt();
    }

    public static explicit operator ObscuredDecimal(ObscuredFloat f)
    {
      return (ObscuredDecimal) (Decimal) (float) f;
    }

    public static ObscuredDecimal operator ++(ObscuredDecimal input)
    {
      Decimal num = input.InternalDecrypt() + new Decimal(1);
      input.hiddenValue = ObscuredDecimal.InternalEncrypt(num, input.currentCryptoKey);
      if (ObscuredCheatingDetector.IsRunning)
        input.fakeValue = num;
      return input;
    }

    public static ObscuredDecimal operator --(ObscuredDecimal input)
    {
      Decimal num = input.InternalDecrypt() - new Decimal(1);
      input.hiddenValue = ObscuredDecimal.InternalEncrypt(num, input.currentCryptoKey);
      if (ObscuredCheatingDetector.IsRunning)
        input.fakeValue = num;
      return input;
    }

    public static void SetNewCryptoKey(long newKey)
    {
      ObscuredDecimal.cryptoKey = newKey;
    }

    public static Decimal Encrypt(Decimal value)
    {
      return ObscuredDecimal.Encrypt(value, ObscuredDecimal.cryptoKey);
    }

    public static Decimal Encrypt(Decimal value, long key)
    {
      ObscuredDecimal.DecimalLongBytesUnion decimalLongBytesUnion = new ObscuredDecimal.DecimalLongBytesUnion();
      decimalLongBytesUnion.d = value;
      decimalLongBytesUnion.l1 = decimalLongBytesUnion.l1 ^ key;
      decimalLongBytesUnion.l2 = decimalLongBytesUnion.l2 ^ key;
      return decimalLongBytesUnion.d;
    }

    private static ACTkByte16 InternalEncrypt(Decimal value)
    {
      return ObscuredDecimal.InternalEncrypt(value, 0L);
    }

    private static ACTkByte16 InternalEncrypt(Decimal value, long key)
    {
      long num = key;
      if (num == 0L)
        num = ObscuredDecimal.cryptoKey;
      ObscuredDecimal.DecimalLongBytesUnion decimalLongBytesUnion = new ObscuredDecimal.DecimalLongBytesUnion();
      decimalLongBytesUnion.d = value;
      decimalLongBytesUnion.l1 = decimalLongBytesUnion.l1 ^ num;
      decimalLongBytesUnion.l2 = decimalLongBytesUnion.l2 ^ num;
      return decimalLongBytesUnion.b16;
    }

    public static Decimal Decrypt(Decimal value)
    {
      return ObscuredDecimal.Decrypt(value, ObscuredDecimal.cryptoKey);
    }

    public static Decimal Decrypt(Decimal value, long key)
    {
      ObscuredDecimal.DecimalLongBytesUnion decimalLongBytesUnion = new ObscuredDecimal.DecimalLongBytesUnion();
      decimalLongBytesUnion.d = value;
      decimalLongBytesUnion.l1 = decimalLongBytesUnion.l1 ^ key;
      decimalLongBytesUnion.l2 = decimalLongBytesUnion.l2 ^ key;
      return decimalLongBytesUnion.d;
    }

    public void ApplyNewCryptoKey()
    {
      if (this.currentCryptoKey == ObscuredDecimal.cryptoKey)
        return;
      this.hiddenValue = ObscuredDecimal.InternalEncrypt(this.InternalDecrypt(), ObscuredDecimal.cryptoKey);
      this.currentCryptoKey = ObscuredDecimal.cryptoKey;
    }

    public void RandomizeCryptoKey()
    {
      Decimal num = this.InternalDecrypt();
      do
      {
        this.currentCryptoKey = (long) UnityEngine.Random.Range(int.MinValue, int.MaxValue);
      }
      while (this.currentCryptoKey == 0L);
      this.hiddenValue = ObscuredDecimal.InternalEncrypt(num, this.currentCryptoKey);
    }

    public Decimal GetEncrypted()
    {
      this.ApplyNewCryptoKey();
      return new ObscuredDecimal.DecimalLongBytesUnion() { b16 = this.hiddenValue }.d;
    }

    public void SetEncrypted(Decimal encrypted)
    {
      this.inited = true;
      this.hiddenValue = new ObscuredDecimal.DecimalLongBytesUnion()
      {
        d = encrypted
      }.b16;
      if (!ObscuredCheatingDetector.IsRunning)
        return;
      this.fakeValue = this.InternalDecrypt();
    }

    private Decimal InternalDecrypt()
    {
      if (!this.inited)
      {
        this.currentCryptoKey = ObscuredDecimal.cryptoKey;
        this.hiddenValue = ObscuredDecimal.InternalEncrypt(new Decimal(0));
        this.fakeValue = new Decimal(0);
        this.inited = true;
      }
      ObscuredDecimal.DecimalLongBytesUnion decimalLongBytesUnion = new ObscuredDecimal.DecimalLongBytesUnion();
      decimalLongBytesUnion.b16 = this.hiddenValue;
      decimalLongBytesUnion.l1 = decimalLongBytesUnion.l1 ^ this.currentCryptoKey;
      decimalLongBytesUnion.l2 = decimalLongBytesUnion.l2 ^ this.currentCryptoKey;
      Decimal d = decimalLongBytesUnion.d;
      if (ObscuredCheatingDetector.IsRunning && this.fakeValue != new Decimal(0) && d != this.fakeValue)
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
      if (!(obj is ObscuredDecimal))
        return false;
      return this.Equals((ObscuredDecimal) obj);
    }

    public bool Equals(ObscuredDecimal obj)
    {
      return obj.InternalDecrypt().Equals(this.InternalDecrypt());
    }

    public override int GetHashCode()
    {
      return this.InternalDecrypt().GetHashCode();
    }

    [StructLayout(LayoutKind.Explicit)]
    private struct DecimalLongBytesUnion
    {
      [FieldOffset(0)]
      public Decimal d;
      [FieldOffset(0)]
      public long l1;
      [FieldOffset(8)]
      public long l2;
      [FieldOffset(0)]
      public ACTkByte16 b16;
    }
  }
}
