using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineMechanic : MonoBehaviour
{
    public TrailRenderer TrailRenderer;
    public Rigidbody2D Rigidbody;
    void Update()
    {
    if(Rigidbody.velocity.x + Rigidbody.velocity.y >= 9 || Rigidbody.velocity.x + Rigidbody.velocity.y <= 9){
        TrailRenderer.emitting = true;
    }else{
        TrailRenderer.emitting = false;
    }
    }

}
