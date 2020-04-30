using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLookX : MonoBehaviour
{
    void Update()
    {
        XLook();
    }

    public void XLook()
    {
        float mouseX = Input.GetAxis("Mouse X");
        transform.localEulerAngles = new Vector2(transform.localEulerAngles.x, transform.localEulerAngles.y + mouseX);
    }
}
