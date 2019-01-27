using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird_movement : MonoBehaviour
{
    public List<Transform> hopSpots;
    public Transform broodingPos;

    [SerializeField]
    private bool inNest = false;
    private Animator anim_control;

    // Start is called before the first frame update
    void Start()
    {
        inNest = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Animation sets
        if (!inNest)
        {
        }
        else
        {
        }
    }
}
