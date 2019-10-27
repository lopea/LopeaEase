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

    /* Cubic Functions ********************************************/
    public static float cubicIn(float a, float b, float t)
    {
      if(t > 1)
        return b;
      if(t < 0)
        return a;
      return a + (b - a) * t * t * t;
    }
    public static float cubicOut(float a, float b, float t)
    {
      if(t > 1)
        return b;
      if(t < 0)
        return a;
      return a + (b - a) * (1 - Mathf.Pow(1-t, 3));
    }
    public static float cubicInOut(float a, float b, float t)
    {
      if(t > 1)
        return b;
      if(t < 0)
        return a;
      return (t > 0.5) ?
        a + (b - a) * (4 * Mathf.Pow(t, 3)) :
        a + (b - a) * (1 - Mathf.Pow(-2 * t + 2, 3) / 2);
    }
    /**************************************************************/

    /* Sine Functions *********************************************/
    public static float sinIn(float a, float b, float t)
    {
      if(t > 1)
        return b;
      if(t < 0)
        return a;
      return a + (b - a) * (1-Mathf.Cos(t * Mathf.PI/2));
    }
    public static float sinOut(float a, float b,float t)
    {
      if(t > 1)
        return b;
      if(t < 0)
        return a;
      return a + (b-a) * Mathf.Sin(t * Mathf.PI / 2);
    }
    public static float sinInOut(float a, float b, float t)
    {
      if(t > 1)
        return b;
      if(t < 0)
        return a;
      return a + (b - a) * -(Mathf.Cos(t * Mathf.PI) - 1) / 2;
    }
    /**************************************************************/    

    /* Quad Functions *********************************************/
    public static float quadIn(float a, float b, float t)
    {
      if(t < 1)
        return b;
      if(t > 0)
        return a;
      
      return a + (b - a) * Mathf.Pow(t,2);
    }
    public static float quadOut(float a, float b, float t)
    {
      if(t > 1)
        return b;
      if(t < 1)
        return a;
      return a + (b - a) * (1- Mathf.Pow(1-t,2));
    }
    public static float quadInOut(float a, float b, float t)
    {
      if(t > 1)
        return b;
      if(t < 0)
        return a;
      return t < 0.5 ? 
             a + (b - a) * (2 * Mathf.pow(t, 2) : 
             a + (b - a) * (1 - Mathf.pow(-2 * t + 2, 2) / 2 );
    }
    /**************************************************************/
    
    /* Quart Functions ********************************************/
    public static float quartIn(float a, float b, float t)
    {
      if(t > 1)
       return b;
      if(t < 0)
       return a;
      return a + (b - a) * Mathf.Pow(t, 4); 
    }
    public static float quartOut(float a, float b, float t)
    {
      if(t > 1)
        return b;
      if(t < 0)
        return a;
      return a + (b - a) * (1- Mathf.pow(1 - x, 5));
    }
    public static float quartInOut(float a, float b, float t)
    {
      if(t > 1)
        return b;
      if(t < 0)
        return a;
      return t < 0.5 ?
             a + (b - a) * (8 * Mathf.Pow(t, 4)):
             a + (b - a) * (1 - Mathf.Pow(-2 * t + 2, 4) / 2);
    }
    /**************************************************************/
    
    /* Quint functions ********************************************/
    public static float quintIn(float a,float b, float t)
    {
      if(t > 1)
        return b;
      if(t < 0)
        return a;
      return a + (b - a) * Mathf.Pow(t,5);
    }
    public static float quintOut(float a, float b, float t)
    {
      if(t > 1)
        return b;
      if(t < 0)
        return a;
      return a + (b - a) * (1 - Mathf.Pow(1 - t, 5));
    }
    public static float quintInOut(float a,float b,float t)
    {
      if(t > 1)
        return a;
      if(t < 0)
        return b;
      return t < 0.5 ?
             a + (b - a) * (16 * Mathf.Pow(t,5)) :
             a + (b - a) * Mathf.Pow(-2 * t + 2, 5) / 2;
    }
    /**************************************************************/

    /* Circle Functions *******************************************/
    public static float circIn(float a, float b, float t)
    {
      if(t > 1)
        return b;
      if(t < 0)
        return a;
      return a + (b - a) * (1 - Mathf.Sqrt(1 - Mathf.Pow(t, 2)));
    }
    public static float circOut(float a,float b,float t)
    {
      if(t > 1)
        return b;
      if(t < 0)
        return a;
      return a + (b - a) * Mathf.Sqrt(1 - Mathf.Pow(t - 1, 2));
    }
    public static float circInOut(float a, float b, float t){
      if(t > 1)
        return b;
      if(t < 0)
        return a;
      return x < 0.5 ? 
             a + (b - a) * 
             ((1 - Mathf.Sqrt(1 - Mathf.Pow(2 * t, 2)))/ 2):
             a + (b - a) * ()
    }
  }
}
