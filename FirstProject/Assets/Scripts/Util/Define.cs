using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Define
{
    public enum MouseType
    {
        None,
        Click,
        Press,
    }
    public enum State
    {
        Idle,
        Moving,
        JUMP,
        Die,
    }
    public enum Layer
    {
        Ground = 8,
    }
}
