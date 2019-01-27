using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird_movement : MonoBehaviour
{
    public List<Transform> hopSpots;
    public Transform broodingPos;

    [SerializeField]
    private bool _inNest = false;
    private Animator _anim_control;
    private int hopCheck;
    //



    void Start()
    {
        _inNest = false;
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Collider"))
        {
            for (int i = 0; i <= hopSpots.Count; i++)
            {
                if (hopSpots[i] == col.transform)
                {
                    hopCheck = i;
                    break;
                }
            }
        }
    }
    
    
    // Update is called once per frame
    void Update()
    {
        //checking which spot the bird is at now
        if ()

        //Animation sets
        if (Input.GetKey("left"))
        {
            if (!_inNest)
            {

            }
        }
        else
        {
        }
    }
}
