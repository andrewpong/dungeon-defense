// Decompiled with JetBrains decompiler
// Type: DigitalRuby.ThunderAndLightning.PathGenerator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15F75AAD-48E7-469E-B756-4D8C100CB626
// Assembly location: D:\Dropbox\apps\android\com.GameCoaster.ProtectDungeon\1.92.2\apk\assets\bin\Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
  public static class PathGenerator
  {
    public const int MinPointsForSpline = 4;
    public static bool Is2D;
    private const float curveMultiplier = 3f;
    private const float splineMultiplier1 = -3f;
    private const float splineMultiplier2 = 3f;
    private const float splineMultiplier3 = 2f;
    private const float splineDistanceClamp = 1f;
    private const float splineEpsilon = 0.0001f;

    public static float SquareRoot(float x)
    {
      return (float) Math.Sqrt((double) x);
    }

    private static float Distance2D(ref Vector3 point1, ref Vector3 point2)
    {
      float num1 = point2.x - point1.x;
      float num2 = point2.y - point1.y;
      return PathGenerator.SquareRoot((float) ((double) num1 * (double) num1 + (double) num2 * (double) num2));
    }

    private static float Distance3D(ref Vector3 point1, ref Vector3 point2)
    {
      float num1 = point2.x - point1.x;
      float num2 = point2.y - point1.y;
      float num3 = point2.z - point1.z;
      return PathGenerator.SquareRoot((float) ((double) num1 * (double) num1 + (double) num2 * (double) num2 + (double) num3 * (double) num3));
    }

    private static void GetCurvePoint2D(ref Vector3 start, ref Vector3 end, ref Vector3 ctr1, ref Vector3 ctr2, float t, out Vector3 point)
    {
      float num1 = t * t;
      float num2 = num1 * t;
      float num3 = (float) (3.0 * ((double) ctr1.x - (double) start.x));
      float num4 = (float) (3.0 * ((double) ctr1.y - (double) start.y));
      float num5 = (float) (3.0 * ((double) ctr2.x - (double) ctr1.x)) - num3;
      float num6 = (float) (3.0 * ((double) ctr2.y - (double) ctr1.y)) - num4;
      float num7 = end.x - start.x - num3 - num5;
      float num8 = end.y - start.y - num4 - num6;
      float x = (float) ((double) start.x + (double) num3 * (double) t + (double) num5 * (double) num1 + (double) num7 * (double) num2);
      float y = (float) ((double) start.y + (double) num4 * (double) t + (double) num6 * (double) num1 + (double) num8 * (double) num2);
      point = new Vector3(x, y, 0.0f);
    }

    private static void GetCurvePoint3D(ref Vector3 start, ref Vector3 end, ref Vector3 ctr1, ref Vector3 ctr2, float t, out Vector3 point)
    {
      float num1 = t * t;
      float num2 = num1 * t;
      float num3 = (float) (((double) ctr1.x - (double) start.x) * 3.0);
      float num4 = (float) (((double) ctr1.y - (double) start.y) * 3.0);
      float num5 = (float) (((double) ctr1.z - (double) start.z) * 3.0);
      float num6 = (float) (((double) ctr2.x - (double) ctr1.x) * 3.0) - num3;
      float num7 = (float) (((double) ctr2.y - (double) ctr1.y) * 3.0) - num4;
      float num8 = (float) (((double) ctr2.z - (double) ctr1.z) * 3.0) - num5;
      float num9 = end.x - start.x - num3 - num6;
      float num10 = end.y - start.y - num4 - num7;
      float num11 = end.z - start.z - num5 - num8;
      float x = (float) ((double) start.x + (double) num3 * (double) t + (double) num6 * (double) num1 + (double) num9 * (double) num2);
      float y = (float) ((double) start.y + (double) num4 * (double) t + (double) num7 * (double) num1 + (double) num10 * (double) num2);
      float z = (float) ((double) start.z + (double) num5 * (double) t + (double) num8 * (double) num1 + (double) num11 * (double) num2);
      point = new Vector3(x, y, z);
    }

    private static void CalculateNonuniformCatmullRom(float p1, float p2, float p3, float p4, float distance1, float distance2, float distance3, out Vector4 point)
    {
      float y = (float) (((double) p2 - (double) p1) / (double) distance1 - ((double) p3 - (double) p1) / ((double) distance1 + (double) distance2) + ((double) p3 - (double) p2) / (double) distance2) * distance2;
      float num = (float) (((double) p3 - (double) p2) / (double) distance2 - ((double) p4 - (double) p2) / ((double) distance2 + (double) distance3) + ((double) p4 - (double) p3) / (double) distance3) * distance2;
      point = new Vector4(p2, y, (float) (-3.0 * (double) p2 + 3.0 * (double) p3 - ((double) num + 2.0 * (double) y)), (float) ((double) y + (double) num + (2.0 * (double) p2 - 2.0 * (double) p3)));
    }

    private static float CalculatePolynomial(ref Vector4 point, float t)
    {
      float num1 = t * t;
      float num2 = num1 * t;
      return (float) ((double) point.w * (double) num2 + (double) point.z * (double) num1 + (double) point.y * (double) t) + point.x;
    }

    private static void ClampSplineDistances(ref float distance1, ref float distance2, ref float distance3)
    {
      if ((double) distance2 < 9.99999974737875E-05)
        distance2 = 1f;
      if ((double) distance1 < 9.99999974737875E-05)
        distance1 = distance2;
      if ((double) distance3 >= 9.99999974737875E-05)
        return;
      distance3 = distance2;
    }

    private static void GetSplinePoint2D(ref Vector3 point1, ref Vector3 point2, ref Vector3 point3, ref Vector3 point4, float t, out Vector3 point)
    {
      float distance1 = PathGenerator.Distance2D(ref point1, ref point2);
      float distance2 = PathGenerator.Distance2D(ref point2, ref point3);
      float distance3 = PathGenerator.Distance2D(ref point3, ref point4);
      PathGenerator.ClampSplineDistances(ref distance1, ref distance2, ref distance3);
      Vector4 point5;
      PathGenerator.CalculateNonuniformCatmullRom(point1.x, point2.x, point3.x, point4.x, distance1, distance2, distance3, out point5);
      Vector4 point6;
      PathGenerator.CalculateNonuniformCatmullRom(point1.y, point2.y, point3.y, point4.y, distance1, distance2, distance3, out point6);
      point = new Vector3(PathGenerator.CalculatePolynomial(ref point5, t), PathGenerator.CalculatePolynomial(ref point6, t), 0.0f);
    }

    private static void GetSplinePoint3D(ref Vector3 point1, ref Vector3 point2, ref Vector3 point3, ref Vector3 point4, float t, out Vector3 point)
    {
      float distance1 = PathGenerator.Distance3D(ref point1, ref point2);
      float distance2 = PathGenerator.Distance3D(ref point2, ref point3);
      float distance3 = PathGenerator.Distance3D(ref point3, ref point4);
      PathGenerator.ClampSplineDistances(ref distance1, ref distance2, ref distance3);
      Vector4 point5;
      PathGenerator.CalculateNonuniformCatmullRom(point1.x, point2.x, point3.x, point4.x, distance1, distance2, distance3, out point5);
      Vector4 point6;
      PathGenerator.CalculateNonuniformCatmullRom(point1.y, point2.y, point3.y, point4.y, distance1, distance2, distance3, out point6);
      Vector4 point7;
      PathGenerator.CalculateNonuniformCatmullRom(point1.z, point2.z, point3.z, point4.z, distance1, distance2, distance3, out point7);
      point = new Vector3(PathGenerator.CalculatePolynomial(ref point5, t), PathGenerator.CalculatePolynomial(ref point6, t), PathGenerator.CalculatePolynomial(ref point7, t));
    }

    public static float CreateCurve(ICollection<Vector3> path, Vector3 start, Vector3 end, Vector3 ctr1, Vector3 ctr2, int numberOfSegments, float startT)
    {
      numberOfSegments = Math.Min(1024, Math.Max(numberOfSegments, 4));
      float num = 1f / (float) (numberOfSegments + 1);
      float t;
      if (PathGenerator.Is2D)
      {
        t = startT;
        while ((double) t <= 1.0)
        {
          Vector3 point;
          PathGenerator.GetCurvePoint2D(ref start, ref end, ref ctr1, ref ctr2, t, out point);
          path.Add(point);
          t += num;
        }
      }
      else
      {
        t = startT;
        while ((double) t <= 1.0)
        {
          Vector3 point;
          PathGenerator.GetCurvePoint3D(ref start, ref end, ref ctr1, ref ctr2, t, out point);
          path.Add(point);
          t += num;
        }
      }
      return t - 1f;
    }

    public static bool CreateSpline(ICollection<Vector3> path, IList<Vector3> points, int numberOfSegments, bool closePath)
    {
      if (points.Count < 4)
        return false;
      numberOfSegments = Math.Min(1024, Math.Max(numberOfSegments, 4));
      int num1 = !closePath ? points.Count - 1 : points.Count;
      int num2 = !closePath ? 0 : 1;
      float num3 = 1f / (float) numberOfSegments * (float) num1;
      float num4 = 0.0f;
      for (int index1 = 0; index1 < num1; ++index1)
      {
        int index2 = index1 != 0 ? index1 - 1 : num1 - num2;
        int index3 = index1 + 1;
        int index4 = index1 + 2;
        if (closePath && index3 > num1 - 1)
          index3 -= num1;
        if (index4 > num1 - 1)
          index4 = !closePath ? num1 : index4 - num1;
        Vector3 point1 = points[index2];
        Vector3 point2 = points[index1];
        Vector3 point3 = points[index3];
        Vector3 point4 = points[index4];
        float t;
        Vector3 point5;
        if (PathGenerator.Is2D)
        {
          t = num4;
          while ((double) t <= 1.0)
          {
            PathGenerator.GetSplinePoint2D(ref point1, ref point2, ref point3, ref point4, t, out point5);
            path.Add(point5);
            t += num3;
          }
        }
        else
        {
          t = num4;
          while ((double) t <= 1.0)
          {
            PathGenerator.GetSplinePoint3D(ref point1, ref point2, ref point3, ref point4, t, out point5);
            path.Add(point5);
            t += num3;
          }
        }
        num4 = t - 1f;
      }
      return true;
    }

    public static bool CreateSplineWithSegmentDistance(ICollection<Vector3> path, IList<Vector3> points, float distancePerSegment, bool closePath)
    {
      if (points.Count < 4 || (double) distancePerSegment <= 0.0)
        return false;
      int num1 = !closePath ? points.Count - 1 : points.Count;
      int num2 = !closePath ? 0 : 1;
      float num3 = 0.0f;
      for (int index1 = 0; index1 < num1; ++index1)
      {
        int index2 = index1 != 0 ? index1 - 1 : num1 - num2;
        int index3 = index1 + 1;
        int index4 = index1 + 2;
        if (closePath && index3 > num1 - 1)
          index3 -= num1;
        if (index4 > num1 - 1)
          index4 = !closePath ? num1 : index4 - num1;
        Vector3 point1 = points[index2];
        Vector3 point2 = points[index1];
        Vector3 point3 = points[index3];
        Vector3 point4 = points[index4];
        Vector3 point5;
        if (PathGenerator.Is2D)
        {
          float num4 = Mathf.Clamp((float) (1.0 / ((double) PathGenerator.Distance2D(ref point3, ref point2) / (double) distancePerSegment)), 1f / 256f, 1f);
          float t = num3;
          while ((double) t <= 1.0)
          {
            PathGenerator.GetSplinePoint2D(ref point1, ref point2, ref point3, ref point4, t, out point5);
            path.Add(point5);
            t += num4;
          }
        }
        else
        {
          float num4 = Mathf.Clamp((float) (1.0 / ((double) PathGenerator.Distance3D(ref point3, ref point2) / (double) distancePerSegment)), 1f / 256f, 1f);
          float t = num3;
          while ((double) t <= 1.0)
          {
            PathGenerator.GetSplinePoint3D(ref point1, ref point2, ref point3, ref point4, t, out point5);
            path.Add(point5);
            t += num4;
          }
        }
        num3 = 0.0f;
      }
      return true;
    }
  }
}
