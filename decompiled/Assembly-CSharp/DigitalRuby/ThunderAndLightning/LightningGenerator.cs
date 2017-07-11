// Decompiled with JetBrains decompiler
// Type: DigitalRuby.ThunderAndLightning.LightningGenerator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using System;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
  public class LightningGenerator
  {
    public static readonly LightningGenerator GeneratorInstance = new LightningGenerator();

    private void GetPerpendicularVector(ref Vector3 directionNormalized, out Vector3 side)
    {
      if (directionNormalized == Vector3.zero)
      {
        side = Vector3.right;
      }
      else
      {
        float x1 = directionNormalized.x;
        float y1 = directionNormalized.y;
        float z1 = directionNormalized.z;
        float num1 = Mathf.Abs(x1);
        float num2 = Mathf.Abs(y1);
        float num3 = Mathf.Abs(z1);
        float y2;
        float z2;
        float x2;
        if ((double) num1 >= (double) num2 && (double) num2 >= (double) num3)
        {
          y2 = 1f;
          z2 = 1f;
          x2 = (float) -((double) y1 * (double) y2 + (double) z1 * (double) z2) / x1;
        }
        else if ((double) num2 >= (double) num3)
        {
          x2 = 1f;
          z2 = 1f;
          y2 = (float) -((double) x1 * (double) x2 + (double) z1 * (double) z2) / y1;
        }
        else
        {
          x2 = 1f;
          y2 = 1f;
          z2 = (float) -((double) x1 * (double) x2 + (double) y1 * (double) y2) / z1;
        }
        side = new Vector3(x2, y2, z2).normalized;
      }
    }

    protected virtual void OnGenerateLightningBolt(LightningBolt bolt, Vector3 start, Vector3 end, LightningBoltParameters p)
    {
      this.GenerateLightningBoltStandard(bolt, start, end, p.Generations, p.Generations, 0.0f, p);
    }

    public bool ShouldCreateFork(LightningBoltParameters p, int generation, int totalGenerations)
    {
      if (generation > p.generationWhereForksStop && generation >= totalGenerations - p.forkednessCalculated)
        return p.Random.NextDouble() < (double) p.Forkedness;
      return false;
    }

    public void CreateFork(LightningBolt bolt, LightningBoltParameters p, int generation, int totalGenerations, Vector3 start, Vector3 midPoint)
    {
      if (!this.ShouldCreateFork(p, generation, totalGenerations))
        return;
      Vector3 vector3 = (midPoint - start) * p.ForkMultiplier();
      Vector3 end = midPoint + vector3;
      this.GenerateLightningBoltStandard(bolt, midPoint, end, generation, totalGenerations, 0.0f, p);
    }

    public void GenerateLightningBoltStandard(LightningBolt bolt, Vector3 start, Vector3 end, int generation, int totalGenerations, float offsetAmount, LightningBoltParameters p)
    {
      if (generation < 1)
        return;
      LightningBoltSegmentGroup boltSegmentGroup = bolt.AddGroup();
      boltSegmentGroup.Segments.Add(new LightningBoltSegment()
      {
        Start = start,
        End = end
      });
      float num1 = (float) generation / (float) totalGenerations;
      float num2 = num1 * num1;
      boltSegmentGroup.LineWidth = p.TrunkWidth * num2;
      boltSegmentGroup.Generation = generation;
      boltSegmentGroup.Color = new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, (byte) ((double) byte.MaxValue * (double) num2));
      boltSegmentGroup.EndWidthMultiplier = p.EndWidthMultiplier * p.ForkEndWidthMultiplier;
      if ((double) offsetAmount <= 0.0)
        offsetAmount = (end - start).magnitude * p.ChaosFactor;
      while (generation-- > 0)
      {
        int startIndex = boltSegmentGroup.StartIndex;
        boltSegmentGroup.StartIndex = boltSegmentGroup.Segments.Count;
        for (int index = startIndex; index < boltSegmentGroup.StartIndex; ++index)
        {
          start = boltSegmentGroup.Segments[index].Start;
          end = boltSegmentGroup.Segments[index].End;
          Vector3 vector3 = (start + end) * 0.5f;
          Vector3 result;
          this.RandomVector(bolt, ref start, ref end, offsetAmount, p.Random, out result);
          Vector3 midPoint = vector3 + result;
          boltSegmentGroup.Segments.Add(new LightningBoltSegment()
          {
            Start = start,
            End = midPoint
          });
          boltSegmentGroup.Segments.Add(new LightningBoltSegment()
          {
            Start = midPoint,
            End = end
          });
          this.CreateFork(bolt, p, generation, totalGenerations, start, midPoint);
        }
        offsetAmount *= 0.5f;
      }
    }

    public Vector3 RandomDirection3D(System.Random r)
    {
      float num = (float) (2.0 * r.NextDouble() - 1.0);
      Vector3 vector3 = this.RandomDirection2D(r) * Mathf.Sqrt((float) (1.0 - (double) num * (double) num));
      vector3.z = num;
      return vector3;
    }

    public Vector3 RandomDirection2D(System.Random r)
    {
      float f = (float) (r.NextDouble() * 2.0 * 3.14159274101257);
      return new Vector3(Mathf.Cos(f), Mathf.Sin(f), 0.0f);
    }

    public Vector3 RandomDirection2DXZ(System.Random r)
    {
      float f = (float) (r.NextDouble() * 2.0 * 3.14159274101257);
      return new Vector3(Mathf.Cos(f), 0.0f, Mathf.Sin(f));
    }

    public void RandomVector(LightningBolt bolt, ref Vector3 start, ref Vector3 end, float offsetAmount, System.Random random, out Vector3 result)
    {
      if (bolt.CameraMode == CameraMode.Perspective)
      {
        Vector3 normalized = (end - start).normalized;
        Vector3 side = Vector3.Cross(start, end);
        if (side == Vector3.zero)
          this.GetPerpendicularVector(ref normalized, out side);
        else
          side.Normalize();
        float num1 = ((float) random.NextDouble() + 0.1f) * offsetAmount;
        float num2 = (float) random.NextDouble() * 3.141593f;
        Vector3 vector3 = normalized * (float) Math.Sin((double) num2);
        Quaternion quaternion;
        quaternion.x = vector3.x;
        quaternion.y = vector3.y;
        quaternion.z = vector3.z;
        quaternion.w = (float) Math.Cos((double) num2);
        result = quaternion * side * num1;
      }
      else if (bolt.CameraMode == CameraMode.OrthographicXY)
      {
        end.z = start.z;
        Vector3 normalized = (end - start).normalized;
        Vector3 vector3 = new Vector3(-normalized.y, normalized.x, 0.0f);
        float num = (float) (random.NextDouble() * (double) offsetAmount * 2.0) - offsetAmount;
        result = vector3 * num;
      }
      else
      {
        end.y = start.y;
        Vector3 normalized = (end - start).normalized;
        Vector3 vector3 = new Vector3(-normalized.z, 0.0f, normalized.x);
        float num = (float) (random.NextDouble() * (double) offsetAmount * 2.0) - offsetAmount;
        result = vector3 * num;
      }
    }

    public void GenerateLightningBolt(LightningBolt bolt, LightningBoltParameters p)
    {
      Vector3 start = p.ApplyVariance(p.Start, p.StartVariance);
      Vector3 end = p.ApplyVariance(p.End, p.EndVariance);
      this.OnGenerateLightningBolt(bolt, start, end, p);
    }
  }
}
