using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour
{
    public static States State;
    public enum States
    {
        Begin, Play, End
    }
}
