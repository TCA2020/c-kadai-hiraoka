using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class View : MonoBehaviour
{
    [SerializeField] private Rigidbody Capsule;

    public void SetCubePosition(Vector3 vector)
    {
        Capsule.velocity = vector;
    }
}