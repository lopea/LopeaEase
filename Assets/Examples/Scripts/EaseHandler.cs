using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Lopea.Utils;

public class EaseHandler : MonoBehaviour
{
  [SerializeField] GameObject obj;          // object to move based on easing settings
  EaseType eType = EaseType.Sine;           // stores current type of easing done on obj
  MovementType mType = MovementType.In;     // type easing movement done on obj
  [SerializeField] Dropdown ease, movement; // dropdown menus to change easing settings
  bool customTime = false;
  float time = 0;
  void Start()
  {
    ease.ClearOptions();
    List<string> names = new List<string>();
    foreach(EaseType type in (EaseType[]) Enum.GetValues(typeof(EaseType)))
    {
       names.Add(type.ToString());
    }
    ease.AddOptions(names);

    movement.ClearOptions();
    names = new List<string>();
    foreach(MovementType type in (MovementType[]) Enum.GetValues(typeof(MovementType)))
    {
       names.Add(type.ToString());
    }
    movement.AddOptions(names);
  }
  
  void Update(){
    time += Time.deltaTime;
    UpdateEnums();
    UpdateObj();
  }

  /* Update enum values with dropdown UI */
  void UpdateEnums(){
    if(eType != (EaseType)ease.value || mType != (MovementType)movement.value)
    {
      eType = (EaseType)ease.value;
      mType = (MovementType)movement.value;
      time = 0;
      obj.transform.position = Vector3.zero;
    }
  }

  /* Change Obj's x position based on enum values */ 
  void UpdateObj()
  {
    switch(eType)
    {
      case EaseType.Sine:
        switch(mType)
        {
          case MovementType.In:
            
            obj.transform.position = Vector3.right * Ease.sinIn(0,6.5f,time);
            break;
          case MovementType.Out:
            obj.transform.position = Vector3.right * Ease.sinOut(0,6.5f,time);
            break;
          case MovementType.InOut:
            obj.transform.position = Vector3.right * Ease.sinInOut(0,6.5f,time);
            break;
        }
        break;
      case EaseType.Quad:
        switch(mType)
        {
          case MovementType.In:
            obj.transform.position = Vector3.right * Ease.quadIn(0,6.5f,time);
            break;
          case MovementType.Out:
            obj.transform.position = Vector3.right * Ease.quadOut(0,6.5f,time);
            break;
          case MovementType.InOut:
            obj.transform.position = Vector3.right * Ease.quadInOut(0,6.5f,time);
            break;
        }
        break;
        case EaseType.Cubic:
        switch(mType)
        {
          case MovementType.In:
            obj.transform.position = Vector3.right * Ease.cubicIn(0,6.5f,time);
            break;
          case MovementType.Out:
            obj.transform.position = Vector3.right * Ease.cubicOut(0,6.5f,time);
            break;
          case MovementType.InOut:
            obj.transform.position = Vector3.right * Ease.cubicInOut(0,6.5f,time);
            break;
        }
        break;
        case EaseType.Quart:
        switch(mType)
        {
          case MovementType.In:
            obj.transform.position = Vector3.right * Ease.quartIn(0,6.5f,time);
            break;
          case MovementType.Out:
            obj.transform.position = Vector3.right * Ease.quartOut(0,6.5f,time);
            break;
          case MovementType.InOut:
            obj.transform.position = Vector3.right * Ease.quartInOut(0,6.5f,time);
            break;
        }
        break;
        case EaseType.Quint:
        switch(mType)
        {
          case MovementType.In:
            obj.transform.position = Vector3.right * Ease.quintIn(0,6.5f,time);
            break;
          case MovementType.Out:
            obj.transform.position = Vector3.right * Ease.quintOut(0,6.5f,time);
            break;
          case MovementType.InOut:
            obj.transform.position = Vector3.right * Ease.quintInOut(0,6.5f,time);
            break;
        }
        break;
       case EaseType.Expo:
        switch(mType)
        {
          case MovementType.In:
            obj.transform.position = Vector3.right * Ease.expoIn(0,6.5f,time);
            break;
          case MovementType.Out:
            obj.transform.position = Vector3.right * Ease.expoOut(0,6.5f,time);
            break;
          case MovementType.InOut:
            obj.transform.position = Vector3.right * Ease.expoInOut(0,6.5f,time);
            break;
        }
        break;
        case EaseType.Circ:
        switch(mType)
        {
          case MovementType.In:
            obj.transform.position = Vector3.right * Ease.circIn(0,6.5f,time);
            break;
          case MovementType.Out:
            obj.transform.position = Vector3.right * Ease.circOut(0,6.5f,time);
            break;
          case MovementType.InOut:
            obj.transform.position = Vector3.right * Ease.circInOut(0,6.5f,time);
            break;
        }
        break;
        case EaseType.Back:
        switch(mType)
        {
          case MovementType.In:
            obj.transform.position = Vector3.right * Ease.backIn(0,6.5f,time);
            break;
          case MovementType.Out:
            obj.transform.position = Vector3.right * Ease.backOut(0,6.5f,time);
            break;
          case MovementType.InOut:
            obj.transform.position = Vector3.right * Ease.backInOut(0,6.5f,time);
            break;
        }
        break;
        case EaseType.Elastic:
        switch(mType)
        {
          case MovementType.In:
            obj.transform.position = Vector3.right * Ease.elasticIn(0,6.5f,time);
            break;
          case MovementType.Out:
            obj.transform.position = Vector3.right * Ease.elasticOut(0,6.5f,time);
            break;
          case MovementType.InOut:
            obj.transform.position = Vector3.right * Ease.elasticInOut(0,6.5f,time);
            break;
        }
        break;
        case EaseType.Bounce:
        switch(mType)
        {
          case MovementType.In:
            obj.transform.position = Vector3.right * Ease.bounceIn(0,6.5f,time);
            break;
          case MovementType.Out:
            obj.transform.position = Vector3.right * Ease.bounceOut(0,6.5f,time);
            break;
          case MovementType.InOut:
            obj.transform.position = Vector3.right * Ease.bounceInOut(0,6.5f,time);
            break;
        }
        break;
                 
    }
  }
}
public enum EaseType
{
  Sine,
  Quad,
  Cubic,
  Quart,
  Quint,
  Expo,
  Circ,
  Back,
  Elastic,
  Bounce
}
public enum MovementType{
  In,
  Out,
  InOut
}
