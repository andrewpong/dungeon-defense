// Decompiled with JetBrains decompiler
// Type: CodeStage.AntiCheat.Utils.xxHash
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

namespace CodeStage.AntiCheat.Utils
{
  internal class xxHash
  {
    private const uint PRIME32_1 = 2654435761;
    private const uint PRIME32_2 = 2246822519;
    private const uint PRIME32_3 = 3266489917;
    private const uint PRIME32_4 = 668265263;
    private const uint PRIME32_5 = 374761393;

    public static uint CalculateHash(byte[] buf, int len, uint seed)
    {
      int index1 = 0;
      uint num1;
      if (len >= 16)
      {
        int num2 = len - 16;
        uint num3 = (uint) ((int) seed - 1640531535 - 2048144777);
        uint num4 = seed + 2246822519U;
        uint num5 = seed;
        uint num6 = seed - 2654435761U;
        do
        {
          byte[] numArray1 = buf;
          int index2 = index1;
          int num7 = 1;
          int num8 = index2 + num7;
          int num9 = (int) numArray1[index2];
          byte[] numArray2 = buf;
          int index3 = num8;
          int num10 = 1;
          int num11 = index3 + num10;
          int num12 = (int) numArray2[index3] << 8;
          int num13 = num9 | num12;
          byte[] numArray3 = buf;
          int index4 = num11;
          int num14 = 1;
          int num15 = index4 + num14;
          int num16 = (int) numArray3[index4] << 16;
          int num17 = num13 | num16;
          byte[] numArray4 = buf;
          int index5 = num15;
          int num18 = 1;
          int num19 = index5 + num18;
          int num20 = (int) numArray4[index5] << 24;
          uint num21 = (uint) (num17 | num20);
          uint num22 = num3 + num21 * 2246822519U;
          num3 = (num22 << 13 | num22 >> 19) * 2654435761U;
          byte[] numArray5 = buf;
          int index6 = num19;
          int num23 = 1;
          int num24 = index6 + num23;
          int num25 = (int) numArray5[index6];
          byte[] numArray6 = buf;
          int index7 = num24;
          int num26 = 1;
          int num27 = index7 + num26;
          int num28 = (int) numArray6[index7] << 8;
          int num29 = num25 | num28;
          byte[] numArray7 = buf;
          int index8 = num27;
          int num30 = 1;
          int num31 = index8 + num30;
          int num32 = (int) numArray7[index8] << 16;
          int num33 = num29 | num32;
          byte[] numArray8 = buf;
          int index9 = num31;
          int num34 = 1;
          int num35 = index9 + num34;
          int num36 = (int) numArray8[index9] << 24;
          uint num37 = (uint) (num33 | num36);
          uint num38 = num4 + num37 * 2246822519U;
          num4 = (num38 << 13 | num38 >> 19) * 2654435761U;
          byte[] numArray9 = buf;
          int index10 = num35;
          int num39 = 1;
          int num40 = index10 + num39;
          int num41 = (int) numArray9[index10];
          byte[] numArray10 = buf;
          int index11 = num40;
          int num42 = 1;
          int num43 = index11 + num42;
          int num44 = (int) numArray10[index11] << 8;
          int num45 = num41 | num44;
          byte[] numArray11 = buf;
          int index12 = num43;
          int num46 = 1;
          int num47 = index12 + num46;
          int num48 = (int) numArray11[index12] << 16;
          int num49 = num45 | num48;
          byte[] numArray12 = buf;
          int index13 = num47;
          int num50 = 1;
          int num51 = index13 + num50;
          int num52 = (int) numArray12[index13] << 24;
          uint num53 = (uint) (num49 | num52);
          uint num54 = num5 + num53 * 2246822519U;
          num5 = (num54 << 13 | num54 >> 19) * 2654435761U;
          byte[] numArray13 = buf;
          int index14 = num51;
          int num55 = 1;
          int num56 = index14 + num55;
          int num57 = (int) numArray13[index14];
          byte[] numArray14 = buf;
          int index15 = num56;
          int num58 = 1;
          int num59 = index15 + num58;
          int num60 = (int) numArray14[index15] << 8;
          int num61 = num57 | num60;
          byte[] numArray15 = buf;
          int index16 = num59;
          int num62 = 1;
          int num63 = index16 + num62;
          int num64 = (int) numArray15[index16] << 16;
          int num65 = num61 | num64;
          byte[] numArray16 = buf;
          int index17 = num63;
          int num66 = 1;
          index1 = index17 + num66;
          int num67 = (int) numArray16[index17] << 24;
          uint num68 = (uint) (num65 | num67);
          uint num69 = num6 + num68 * 2246822519U;
          num6 = (num69 << 13 | num69 >> 19) * 2654435761U;
        }
        while (index1 <= num2);
        num1 = (uint) (((int) num3 << 1 | (int) (num3 >> 31)) + ((int) num4 << 7 | (int) (num4 >> 25)) + ((int) num5 << 12 | (int) (num5 >> 20)) + ((int) num6 << 18 | (int) (num6 >> 14)));
      }
      else
        num1 = seed + 374761393U;
      uint num70 = num1 + (uint) len;
      while (index1 <= len - 4)
      {
        int num2 = (int) num70;
        byte[] numArray1 = buf;
        int index2 = index1;
        int num3 = 1;
        int num4 = index2 + num3;
        int num5 = (int) numArray1[index2];
        byte[] numArray2 = buf;
        int index3 = num4;
        int num6 = 1;
        int num7 = index3 + num6;
        int num8 = (int) numArray2[index3] << 8;
        int num9 = num5 | num8;
        byte[] numArray3 = buf;
        int index4 = num7;
        int num10 = 1;
        int num11 = index4 + num10;
        int num12 = (int) numArray3[index4] << 16;
        int num13 = num9 | num12;
        byte[] numArray4 = buf;
        int index5 = num11;
        int num14 = 1;
        index1 = index5 + num14;
        int num15 = (int) numArray4[index5] << 24;
        int num16 = (num13 | num15) * -1028477379;
        uint num17 = (uint) (num2 + num16);
        num70 = (uint) (((int) num17 << 17 | (int) (num17 >> 15)) * 668265263);
      }
      for (; index1 < len; ++index1)
      {
        uint num2 = num70 + (uint) buf[index1] * 374761393U;
        num70 = (uint) (((int) num2 << 11 | (int) (num2 >> 21)) * -1640531535);
      }
      uint num71 = (num70 ^ num70 >> 15) * 2246822519U;
      uint num72 = (num71 ^ num71 >> 13) * 3266489917U;
      return num72 ^ num72 >> 16;
    }
  }
}
