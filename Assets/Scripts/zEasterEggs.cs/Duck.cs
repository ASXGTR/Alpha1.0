// Duck.cs
// Smurf-approved version

using UnityEngine;

public class Duck : MonoBehaviour
{
    private readonly string duckArt = @"
          __
       <(o )___
        (  ._>  )
         `----'  
    ";

    void Start()
    {
        Debug.Log(duckArt);
    }
}
