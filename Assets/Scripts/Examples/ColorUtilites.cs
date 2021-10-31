using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class ColorUtilites : MonoBehaviour
{
   public static Color GetRandomColor()
   {
      return new Color(Random.value, Random.value, Random.value);
   }
}
