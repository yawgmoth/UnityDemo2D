using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaceBehavior : PhysicsObject
{
    public float direction = -3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        desiredx = direction;
    }

    public override void CollideWithHorizontal(Collider2D other)
    {
        direction = -direction;
    }
}
