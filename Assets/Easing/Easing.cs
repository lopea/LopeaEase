/* 
 * LopeaEasing - implementation of easing functions in C#
 * Made by Javier Sandoval (lopea) https://github.com/lopea
 * Easing functions based on work by Andrey Sitnik and Ivan Soloviev https://easings.net
 */
using UnityEngine; /* Mathf */

namespace Lopea.Utils
{
  public static class Ease
  {
    public static float cubicIn(float a, float b, float t)
    {
      if(t > 1)
        return b;
      return a + (b - a) * t * t * t;
    }
    public static float cubicOut(float a, float b, float t)
    {
      return a + (b - a) * (1 - Mathf.Pow(1-t, 3));
    }
    public static float cubicInOut(float a, float b, float t)
    {
      return (t > 0.5) ?
        a + (b - a) * (4 * Mathf.Pow(t, 3)) :
        a + (b - a) * (1 - Mathf.Pow(-2 * t + 2, 2) / 2);
    }
    public static float sinIn(float a, float b, float t)
    {
      return a + (b - a) * (1-Mathf.Cos(t * Mathf.PI/2));
    }
    public static float sinOut(float a, float b,float t)
    {
      return a + (b-a) * Mathf.Sin(t * Mathf.PI / 2);
    }
    public static float sinInOut(float a, float b, float t)
    {
      return a + (b - a) * -(Mathf.Cos(t * Mathf.PI) - 1) / 2;
    }
  }
}
