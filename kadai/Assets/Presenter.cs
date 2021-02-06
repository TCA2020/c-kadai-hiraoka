using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class Presenter
{
    public Presenter(UI model, View view)
    {
        model.Velocity.Subscribe(position => view.SetCubePosition(position));
    }
}