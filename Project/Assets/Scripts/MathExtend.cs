using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MathExtend
{
    public static float pi = 3.14f;
    public static Vector2 GetPoint_Reverse(float angle, float range)
    {
        return new Vector2(Mathf.Sin(angle) * range, Mathf.Cos(angle) * range)*(-1f);
    }
    public static double GetAtan(float x, float y)
    {
        double radian = Math.Atan2(y, x);
        double radianToAngle = radian / Math.PI * 180;
        return radianToAngle;
    }
    public static float GetAngle(float rate)       //将0~1间数转化为一个0~2pi 的弧度制角度
    {
        return 2 * pi * rate;
    }
}
