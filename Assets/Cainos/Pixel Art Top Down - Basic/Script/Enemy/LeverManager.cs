using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverManager : MonoBehaviour
{
    public  static LeverManager Main;

    public Transform startPoint;
    public Transform[] Path;

    private void Awake()
    {
        Main = this;
    }
}
