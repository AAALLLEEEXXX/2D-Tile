using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    [SerializeField]
    private GameObject _target;

    [SerializeField]
    private float _speedCamera;

    private Camera _camera;

    private void Awake()
    {
        _camera = GetComponent<Camera>();
    }

    private void Start()
    {
        _camera.orthographicSize = 2;
    }

    private void Update()
    {
        transform.position = Vector3.Lerp(transform.position, new Vector3(_target.transform.position.x, _target.transform.position.y, -10), _speedCamera * Time.deltaTime);
    }
}
