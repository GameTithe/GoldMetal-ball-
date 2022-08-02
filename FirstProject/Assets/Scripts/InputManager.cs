using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static Action<Define.MouseType> MouseEvent = null;
    public static Action<Define.KeyType> KeyEvent = null;

    bool _pressed = false;
    float _pressedTime = 0.0f;

    void Update()
    {
        if (MouseEvent != null)
        {
            if(Input.GetMouseButtonDown(0))
            {
                MouseEvent.Invoke(Define.MouseType.Click);

                _pressed = true;
                _pressedTime = Time.time;
            }

            if (Input.GetMouseButton(0))
            {
                if(_pressedTime  - Time.time > 0.2f)
                    MouseEvent.Invoke(Define.MouseType.Press);
            }

            if(Input.GetMouseButtonUp(0))
            {
                _pressed = false;
                _pressedTime = 0.0f;
                MouseEvent.Invoke(Define.MouseType.None);
            }
        }
        
        if(KeyEvent != null)
        {
            if(Input.GetKey(KeyCode.Space))
                KeyEvent.Invoke(Define.KeyType.Jump);
        }
    }
}

