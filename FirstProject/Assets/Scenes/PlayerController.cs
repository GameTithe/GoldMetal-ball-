using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float _speed = 5.0f;

    enum State
    {
        Die,
        Moving,
    }

    void Start()
    {
           
    }

    Vector3 _dest;
    Vector3 _dir;

    int _move = 1 << (int)Define.Layer.Ground;
    void Update()
    {

        _dir = _dest - transform.position;

        float moveDist = Mathf.Clamp(_speed  * Time.deltaTime, 0, _dir.magnitude);
        transform.position += moveDist * _dir.normalized;
        
        if(moveDist != 0)
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(_dir), 10 * Time.deltaTime);
        
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); RaycastHit hit;

            Debug.DrawRay(Camera.main.transform.position, ray.direction * 100.0f, Color.red);
            if (Physics.Raycast(ray, out hit, 100.0f, _move))
            {
                _dest = hit.point;
               
            }
        }

    }
}
