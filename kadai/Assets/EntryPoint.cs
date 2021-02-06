using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntryPoint : MonoBehaviour
{
    [SerializeField] private Move Input;
    [SerializeField] private View view;


    // Start is called before the first frame update
    void Start()
    {
        UI model = new UI();
        Input.InjectModel(model);
        Presenter presenter = new Presenter(model,view);
    }
    public void InjecSstModel(Move model)
    {
        model = Input;
    }
}
