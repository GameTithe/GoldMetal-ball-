using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Define
{
    public enum KeyType
    {
        Jump,
    }
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
        Die,
    }
    public enum Layer
    {
        Ground = 8,
    }
}
