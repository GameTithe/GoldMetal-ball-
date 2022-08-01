using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    protected float _speed = 5.0f;

    protected Define.State _state = Define.State.Idle;

    public Define.State State
    {
        get { return _state; }
        set
        {
            _state = value;
            Animator _anim = GetComponent<Animator>();

            switch (_state)
            {
                case Define.State.Moving:
                    _anim.Play("RUN");
                    break;

                case Define.State.Idle:
                    _anim.Play("WAIT");
                    break;

                case Define.State.JUMP:
                    _anim.Play("JUMP");
                    break;

                case Define.State.Die:
                    break;

            }
        }
    }
    void Start()
    {
        Init();
    }

    void Init()
    {
        InputManager.MouseEvent -= OnMouseEvent;
        InputManager.MouseEvent += OnMouseEvent;

    }

    Vector3 _dest;
    Vector3 _dir;

    int _mask = 1 << (int)Define.Layer.Ground;
    void Update()
    {
        switch (_state)
        {
            case Define.State.Idle:
                UpdateIdle();
                break;

            case Define.State.Moving:
                UpdateMoving();
                break;

            case Define.State.Die:
                break;
        }
    }
    void UpdateIdle()
    {
        //이번트를 받으면 Moving으로 바꿔야 된다
        if (InputManager.MouseEvent != null)
        {

        }
    }
    void UpdateMoving()
    {

        _dir = _dest - transform.position;

        float moveDist = Mathf.Clamp(_speed * Time.deltaTime, 0, _dir.magnitude);
        transform.position += moveDist * _dir.normalized;

        if (moveDist != 0)
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(_dir), 10 * Time.deltaTime);
        else
        {
            State = Define.State.Idle;
        }

        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); RaycastHit hit;

            Debug.DrawRay(Camera.main.transform.position, ray.direction * 100.0f, Color.red);
            if (Physics.Raycast(ray, out hit, 100.0f, _mask))
            {
                _dest = hit.point;

            }
        }
    }

    void UpdateJumping()
    {

    }

    void OnMouseEvent(Define.MouseType evt)
    {
        switch (evt)
        {
            case Define.MouseType.Click:
                State = Define.State.Moving;
                MouseEvent_Moving(evt);
                break;

            case Define.MouseType.Press:
                State = Define.State.Moving;
                MouseEvent_Moving(evt);
                break;

            case Define.MouseType.None:
                break;
        }
    }

    void MouseEvent_Moving(Define.MouseType evt)
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        bool raycastHit = Physics.Raycast(ray, out hit, 100.0f, _mask);

        switch (evt)
        {
            case Define.MouseType.Click:
            case Define.MouseType.Press:

                {
                    if (raycastHit)
                    {
                        _dest = hit.point;
                        UpdateMoving();

                    }

                }
                break;
            case Define.MouseType.None:
                break;

        }
    }
}
