// Decompiled with JetBrains decompiler
// Type: KeyChainCrypto
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using System;
using System.Security.Cryptography;
using System.Text;

public class KeyChainCrypto
{
  private static void GetKeys(string secret, out byte[] key, out byte[] iv)
  {
    byte[] bytes = Encoding.UTF8.GetBytes(secret);
    key = new byte[8];
    iv = new byte[8];
    for (int index = 0; index < key.Length; ++index)
      key[index] = bytes.Length > index ? bytes[index] : bytes[bytes.Length - 1];
    for (int index = 0; index < iv.Length; ++index)
      iv[index] = bytes.Length - 1 - index >= 0 ? bytes[bytes.Length - 1 - index] : bytes[0];
  }

  public static string Crypt(string text, string secret)
  {
    byte[] key;
    byte[] iv;
    KeyChainCrypto.GetKeys(secret, out key, out iv);
    ICryptoTransform encryptor = DES.Create().CreateEncryptor(key, iv);
    byte[] bytes = Encoding.Unicode.GetBytes(text);
    return Convert.ToBase64String(encryptor.TransformFinalBlock(bytes, 0, bytes.Length));
  }

  public static string Decrypt(string text, string secret)
  {
    byte[] key;
    byte[] iv;
    KeyChainCrypto.GetKeys(secret, out key, out iv);
    ICryptoTransform decryptor = DES.Create().CreateDecryptor(key, iv);
    byte[] inputBuffer = Convert.FromBase64String(text);
    return Encoding.Unicode.GetString(decryptor.TransformFinalBlock(inputBuffer, 0, inputBuffer.Length));
  }
}
