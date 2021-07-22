// Decompiled with JetBrains decompiler
// Type: DigitalRuby.ThunderAndLightning.LightningGeneratorPath
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
  public class LightningGeneratorPath : LightningGenerator
  {
    public static readonly LightningGeneratorPath PathGeneratorInstance = new LightningGeneratorPath();

    public void GenerateLightningBoltPath(LightningBolt bolt, Vector3 start, Vector3 end, LightningBoltParameters p)
    {
      if (p.Points.Count < 2)
      {
        Debug.LogError((object) "Lightning path should have at least two points");
      }
      else
      {
        int generations = p.Generations;
        int totalGenerations = generations;
        int num1 = p.SmoothingFactor - 1;
        LightningBoltSegmentGroup boltSegmentGroup1 = bolt.AddGroup();
        boltSegmentGroup1.LineWidth = p.TrunkWidth;
        LightningBoltSegmentGroup boltSegmentGroup2 = boltSegmentGroup1;
        int num2 = generations;
        int num3 = 1;
        int generation = num2 - num3;
        boltSegmentGroup2.Generation = num2;
        boltSegmentGroup1.EndWidthMultiplier = p.EndWidthMultiplier;
        boltSegmentGroup1.Color = (Color32) Color.white;
        p.Start = p.Points[0] + start;
        p.End = p.Points[p.Points.Count - 1] + end;
        end = p.Start;
        for (int index = 1; index < p.Points.Count; ++index)
        {
          start = end;
          end = p.Points[index];
          Vector3 vector3_1 = end - start;
          float num4 = PathGenerator.SquareRoot(vector3_1.sqrMagnitude);
          if ((double) p.ChaosFactor > 0.0)
          {
            if (bolt.CameraMode == CameraMode.Perspective)
              end += num4 * p.ChaosFactor * this.RandomDirection3D(p.Random);
            else if (bolt.CameraMode == CameraMode.OrthographicXY)
              end += num4 * p.ChaosFactor * this.RandomDirection2D(p.Random);
            else
              end += num4 * p.ChaosFactor * this.RandomDirection2DXZ(p.Random);
            vector3_1 = end - start;
          }
          boltSegmentGroup1.Segments.Add(new LightningBoltSegment()
          {
            Start = start,
            End = end
          });
          float offsetAmount = num4 * p.ChaosFactor;
          Vector3 result;
          this.RandomVector(bolt, ref start, ref end, offsetAmount, p.Random, out result);
          if (this.ShouldCreateFork(p, generation, totalGenerations))
          {
            Vector3 vector3_2 = vector3_1 * p.ForkMultiplier() * (float) num1 * 0.5f;
            Vector3 end1 = end + vector3_2 + result;
            this.GenerateLightningBoltStandard(bolt, start, end1, generation, totalGenerations, 0.0f, p);
          }
          if (--num1 == 0)
            num1 = p.SmoothingFactor - 1;
        }
      }
    }

    protected override void OnGenerateLightningBolt(LightningBolt bolt, Vector3 start, Vector3 end, LightningBoltParameters p)
    {
      this.GenerateLightningBoltPath(bolt, start, end, p);
    }
  }
}
