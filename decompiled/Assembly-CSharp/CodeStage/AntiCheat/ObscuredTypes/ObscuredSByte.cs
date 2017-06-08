﻿// Decompiled with JetBrains decompiler
// Type: CodeStage.AntiCheat.ObscuredTypes.ObscuredSByte
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2EE8B15F-8D58-4BD6-8905-91665367FCCE
// Assembly location: C:\Users\Andrew\Downloads\base\assets\bin\Data\Managed\Assembly-CSharp.dll

using CodeStage.AntiCheat.Detectors;
using System;

namespace CodeStage.AntiCheat.ObscuredTypes
{
  [Serializable]
  public struct ObscuredSByte : IEquatable<ObscuredSByte>, IFormattable
  {
    private static sbyte cryptoKey = 112;
    private sbyte currentCryptoKey;
    private sbyte hiddenValue;
    private sbyte fakeValue;
    private bool inited;

    private ObscuredSByte(sbyte value)
    {
      this.currentCryptoKey = ObscuredSByte.cryptoKey;
      this.hiddenValue = value;
      this.fakeValue = (sbyte) 0;
      this.inited = true;
    }

    public static implicit operator ObscuredSByte(sbyte value)
    {
      ObscuredSByte obscuredSbyte = new ObscuredSByte(ObscuredSByte.EncryptDecrypt(value));
      if (ObscuredCheatingDetector.IsRunning)
        obscuredSbyte.fakeValue = value;
      return obscuredSbyte;
    }

    public static implicit operator sbyte(ObscuredSByte value)
    {
      return value.InternalDecrypt();
    }

    public static ObscuredSByte operator ++(ObscuredSByte input)
    {
      sbyte num = (sbyte) ((int) input.InternalDecrypt() + 1);
      input.hiddenValue = ObscuredSByte.EncryptDecrypt(num, input.currentCryptoKey);
      if (ObscuredCheatingDetector.IsRunning)
        input.fakeValue = num;
      return input;
    }

    public static ObscuredSByte operator --(ObscuredSByte input)
    {
      sbyte num = (sbyte) ((int) input.InternalDecrypt() - 1);
      input.hiddenValue = ObscuredSByte.EncryptDecrypt(num, input.currentCryptoKey);
      if (ObscuredCheatingDetector.IsRunning)
        input.fakeValue = num;
      return input;
    }

    public static void SetNewCryptoKey(sbyte newKey)
    {
      ObscuredSByte.cryptoKey = newKey;
    }

    public static sbyte EncryptDecrypt(sbyte value)
    {
      return ObscuredSByte.EncryptDecrypt(value, (sbyte) 0);
    }

    public static sbyte EncryptDecrypt(sbyte value, sbyte key)
    {
      if ((int) key == 0)
        return (sbyte) ((int) value ^ (int) ObscuredSByte.cryptoKey);
      return (sbyte) ((int) value ^ (int) key);
    }

    public void ApplyNewCryptoKey()
    {
      if ((int) this.currentCryptoKey == (int) ObscuredSByte.cryptoKey)
        return;
      this.hiddenValue = ObscuredSByte.EncryptDecrypt(this.InternalDecrypt(), ObscuredSByte.cryptoKey);
      this.currentCryptoKey = ObscuredSByte.cryptoKey;
    }

    public void RandomizeCryptoKey()
    {
      sbyte num = this.InternalDecrypt();
      do
      {
        this.currentCryptoKey = (sbyte) UnityEngine.Random.Range((int) sbyte.MinValue, (int) sbyte.MaxValue);
      }
      while ((int) this.currentCryptoKey == 0);
      this.hiddenValue = ObscuredSByte.EncryptDecrypt(num, this.currentCryptoKey);
    }

    public sbyte GetEncrypted()
    {
      this.ApplyNewCryptoKey();
      return this.hiddenValue;
    }

    public void SetEncrypted(sbyte encrypted)
    {
      this.inited = true;
      this.hiddenValue = encrypted;
      if (!ObscuredCheatingDetector.IsRunning)
        return;
      this.fakeValue = this.InternalDecrypt();
    }

    private sbyte InternalDecrypt()
    {
      if (!this.inited)
      {
        this.currentCryptoKey = ObscuredSByte.cryptoKey;
        this.hiddenValue = ObscuredSByte.EncryptDecrypt((sbyte) 0);
        this.fakeValue = (sbyte) 0;
        this.inited = true;
      }
      sbyte num = ObscuredSByte.EncryptDecrypt(this.hiddenValue, this.currentCryptoKey);
      if (ObscuredCheatingDetector.IsRunning && (int) this.fakeValue != 0 && (int) num != (int) this.fakeValue)
        ObscuredCheatingDetector.Instance.OnCheatingDetected();
      return num;
    }

    public override bool Equals(object obj)
    {
      if (!(obj is ObscuredSByte))
        return false;
      return this.Equals((ObscuredSByte) obj);
    }

    public bool Equals(ObscuredSByte obj)
    {
      if ((int) this.currentCryptoKey == (int) obj.currentCryptoKey)
        return (int) this.hiddenValue == (int) obj.hiddenValue;
      return (int) ObscuredSByte.EncryptDecrypt(this.hiddenValue, this.currentCryptoKey) == (int) ObscuredSByte.EncryptDecrypt(obj.hiddenValue, obj.currentCryptoKey);
    }

    public override string ToString()
    {
      return this.InternalDecrypt().ToString();
    }

    public string ToString(string format)
    {
      return this.InternalDecrypt().ToString(format);
    }

    public override int GetHashCode()
    {
      return this.InternalDecrypt().GetHashCode();
    }

    public string ToString(IFormatProvider provider)
    {
      return this.InternalDecrypt().ToString(provider);
    }

    public string ToString(string format, IFormatProvider provider)
    {
      return this.InternalDecrypt().ToString(format, provider);
    }
  }
}
