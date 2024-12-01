using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private float _sensivity;

    [SerializeField]
    private float _maxAngle;

    private Vector2 rotate;

    private Camera _camera;

    [SerializeField]
    private Transform _body;
    private void Awake()
    {
       _camera = GetComponent<Camera>();
    }
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }


    public RaycastHit? ThrowRay(float range)
    {
        Ray ray = _camera.ScreenPointToRay(new Vector2(Screen.width/2, Screen.height/2));
        RaycastHit hit;
        bool isHit = Physics.Raycast(ray, out hit, range);

        Color color = Color.red;
        Debug.DrawRay(ray.origin, ray.direction * range, color, 0.001f);

        if (isHit)
        {
            return hit;
        }
        else
        {
            return null;
        }

        
    }
    
    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Mouse X") * _sensivity * Time.deltaTime;
        float y = Input.GetAxis("Mouse Y") * _sensivity * Time.deltaTime;

        rotate.y = transform.localEulerAngles.y;

        rotate += new Vector2(-y, x);

        rotate.x = Mathf.Clamp(rotate.x, -_maxAngle, _maxAngle);

        transform.localRotation = Quaternion.Euler(rotate.x, 0, 0);
        _body.Rotate(Vector3.up * rotate.y);
    }
}
