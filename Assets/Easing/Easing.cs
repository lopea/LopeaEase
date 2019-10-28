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
      return (t < 0.5f) ?
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
      if(t > 1)
        return b;
      if(t < 0)
        return a;
      
      return a + (b - a) * Mathf.Pow(t,2);
    }
    public static float quadOut(float a, float b, float t)
    {
      if(t > 1)
        return b;
      if(t < 0)
        return a;
      return a + (b - a) * (1- Mathf.Pow(1-t,2));
    }
    public static float quadInOut(float a, float b, float t)
    {
      if(t > 1)
        return b;
      if(t < 0)
        return a;
      return t < 0.5f ? 
             a + (b - a) * (2 * Mathf.Pow(t, 2)) : 
             a + (b - a) * (1 - Mathf.Pow(-2 * t + 2, 2) / 2 );
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
      return a + (b - a) * (1- Mathf.Pow(1 - t, 5));
    }
    public static float quartInOut(float a, float b, float t)
    {
      if(t > 1)
        return b;
      if(t < 0)
        return a;
      return t < 0.5f ?
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
        return b;
      if(t < 0)
        return a;
      return t < 0.5f ?
             a + (b - a) * (16 * Mathf.Pow(t,5)) :
             a + (b - a) * (1 - Mathf.Pow(-2 * t + 2, 5) / 2);
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
    public static float circInOut(float a, float b, float t)
    {
      if(t > 1)
        return b;
      if(t < 0)
        return a;
      return t < 0.5f ? 
             a + (b - a) * 
             ((1 - Mathf.Sqrt(1 - Mathf.Pow(2 * t, 2)))/ 2):
             a + (b - a) * 
             ((Mathf.Sqrt(1 - Mathf.Pow(-2 * t + 2, 2)) + 1) / 2);
    }
    /**************************************************************/

    /* Exponential Functions **************************************/
    public static float expoIn(float a, float b, float t)
    {
      if(t > 1)
        return b;
      if(t <= 0)
        return a;
      return a + (b - a) * Mathf.Pow(2,10 * t - 10); 
    }
    public static float expoOut(float a, float b, float t)
    {
      if(t >= 1)
        return b;
      if(t < 0)
        return a;
      return a + (b - a) * (1 - Mathf.Pow(2, -10 * t));
    }
    public static float expoInOut(float a, float b, float t)
    {
      if(t >= 1)
        return b;
      if(t <= 0)
        return a;
      return t < 0.5f ?
             a + (b - a) *
             (Mathf.Pow(2, 20 * t - 10) / 2):
             a + (b - a) *
             ((2 - Mathf.Pow(2, -20 * t + 10)) / 2);
    }
    /**************************************************************/
    //constants: c1 = 1.70158, c2 = 1.70158 + 1.525 c3: 2.70158
    /* Back functions *********************************************/
    public static float backIn(float a, float b, float t)
    {
      if(t > 1)
        return b;
      if(t < 0)
        return a;
      return a + (b - a) * (2.70158f * t * t * t - 1.70158f * t * t );
    }
    public static float backOut(float a, float b, float t)
    {
      if(t > 1)
        return b;
      if(t < 0)
        return a;
      return a + (b - a) * (1 + 2.70158f * Mathf.Pow( t -1, 3) 
                          + 1.70158f * Mathf.Pow(t - 1, 2));
    }
    public static float backInOut(float a, float b, float t)
    {
      if(t > 1)
        return b;
      if(t < 0)
        return a;
      return t < 0.5f ? 
             a + (b - a) * ((Mathf.Pow(2 * t, 2) * 
                   ((1.70158f + 1.525f + 1) * 2 * t - 
                    (1.70158f + 1.525f) )) / 2):
             a + (b - a) * ((Mathf.Pow(2 * t - 2, 2) * 
                   ((1.70158f + 1.525f + 1) * (2 * t - 2) + 
                    (1.70158f + 1.525f) ) + 2) / 2);            
    }
    /**************************************************************/

    /* Elastic Functions ******************************************/
    public static float elasticIn(float a, float b, float t)
    {
      if(t >= 1)
        return b;
      if(t <= 0)
        return a;
      return a + (b - a) * (-Mathf.Pow(2, 10 * t - 10) * 
                            Mathf.Sin((t * 10 - 10.75f) * 
                            ((Mathf.PI * 2) / 3)));
    }
    public static float elasticOut(float a, float b, float t)
    {
      if(t >= 1)
        return b;
      if(t <= 0)
        return a;
      return a + (b - a) * (Mathf.Pow(2, -10 * t) * 
                            Mathf.Sin((t * 10 - 0.75f) * 
                            ((Mathf.PI * 2) / 3)) + 1);
    } 
    public static float elasticInOut(float a, float b, float t)
    {
      if(t >= 1)
        return b;
      if(t <= 0)
        return a;
      return t < 0.5f ?
             a + (b - a) * (-(Mathf.Pow(2, 20 * t - 10) * 
                            Mathf.Sin((20 * t - 11.125f) * 
                            ((Mathf.PI * 2) / 4.5f))) / 2):
             a + (b - a) * ((Mathf.Pow(2, -20 * t + 10) * 
                            Mathf.Sin((20 * t - 11.125f) * 
                            ((Mathf.PI * 2) / 4.5f))) / 2 + 1);
    }
    /**************************************************************/
    
    /* Bounce Functions *******************************************/
    public static float bounceOut(float a, float b, float t)
    {
      if(t > 1)
        return b;
      if(t < 0)
        return a;

      float n1 = 7.5625f;
      float d1 = 2.75f;
      float res = (b - a);

      if( t < 1 / d1)
        return a + res * (n1 * t * t);
      else if(t < 2 / d1)
        return a + res * (n1 * (t -= (1.5f / d1)) * t + 0.75f);
      else if(t < 2.5f / d1)
        return a + res * (n1 * (t -= (2.25f / d1)) * t + 0.9375f);
      else
        return a + res * (n1 * (t -= (2.625f / d1)) * t + 0.984375f);
    }
    public static float bounceIn(float a, float b, float t)
    {
      if(t > 1)
        return b;
      if(t < 0)
        return a;
      return a + (b - a) * (1 - bounceOut(0,1, 1 - t));
    }
    public static float bounceInOut(float a, float b, float t)
    {
      if(t > 1)
        return b;
      if(t < 0)
        return a;
      return t < 0.5f ?
             a + (b - a) * ((1 - bounceOut(0, 1, 1 - 2 * t )) / 2) :
             a + (b - a) * ((1 + bounceOut(0, 1, 2 * t - 1)) / 2);
    }
    /**************************************************************/
  }
}
