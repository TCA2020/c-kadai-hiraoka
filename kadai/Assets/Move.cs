using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;
using UniRx;
public class Move : MonoBehaviour
{
    //public Rigidbody rb;
    [SerializeField] public int front;
    [SerializeField] public int back;
    [SerializeField] public int right;
    [SerializeField] public int left;

    private UI Model;

   
    private void Update()
    {
        Vector3 velocity = new Vector3();
        velocity.x = 0f;
        velocity.z = 0f;
        if (Input.GetKey("up"))
        {
            //  Upキーで奥へ
            velocity.z = front;
        }
        if (Input.GetKey("down"))
        {
            // Downキーで手前へ
            velocity.z = back;
        }
        if (Input.GetKey("right"))
        {
            // right キーで右に進む
            velocity.x = right;
        }
        if (Input.GetKey("left"))
        {
            //left キーで左に進む
            velocity.x = left;
        }
        ///rb.velocity = velocity;

        Model.Velocity.Value = velocity;

    }
    public void InjectModel(UI model)
    {
        Model = model;
    }
}


public class UI//Modelの場所
{
    public ReactiveProperty<Vector3> Velocity = new ReactiveProperty<Vector3>(new Vector3(0f, 0f, 0f));
}


