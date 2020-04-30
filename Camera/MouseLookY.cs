using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLookY : MonoBehaviour
{   
    void Update()
    {
        YLook();
    }

    public void YLook()
    {
        float mouseY = Input.GetAxis("Mouse Y");
        transform.localEulerAngles = new Vector2(transform.localEulerAngles.x - mouseY, transform.localEulerAngles.y);
    }
}
