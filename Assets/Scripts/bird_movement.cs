using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird_movement : MonoBehaviour
{
    public List<Transform> hopSpots;
    public Transform broodingPos;
    public int speedMove;
    public int speedRot;

    [SerializeField]
    private bool _inNest = false;
    [SerializeField]
    private int hopCheck;
    private Animator _anim_control;


    void Start()
    {
        _inNest = false;
    }

    //To check which spot the bird is at
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
        //update hopcheck
        if (hopCheck < 0)
        {
            hopCheck = 0;
        }
        if (hopCheck > hopSpots.Count - 1)
        {
            hopCheck = hopSpots.Count - 1;
        }

        float stepMove = speedMove * Time.deltaTime;
        float stepRot = speedRot * Time.deltaTime;

        if (!_inNest)
        {
            if (Input.GetKeyDown("left"))
            {
                hopCheck++;
            }
            if (Input.GetKeyDown("right"))
            {
                hopCheck--;
            }
            transform.position = Vector3.MoveTowards(transform.position, hopSpots[hopCheck].position, stepMove);
        }

        if (Input.GetKeyDown("space"))
        {
            _inNest = true;
        }
        if (_inNest)
        {
            transform.position = Vector3.MoveTowards(transform.position, broodingPos.position, stepMove);
            if (Input.GetKey("left"))
            {
                transform.Rotate(Vector3.up * stepRot, Space.World);
            }
            if (Input.GetKey("right"))
            {
                transform.Rotate(Vector3.down * stepRot, Space.World);
            }
        }
    }
}
