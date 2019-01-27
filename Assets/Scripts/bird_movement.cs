using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird_movement : MonoBehaviour
{
    public List<Transform> hopSpots;
    public Transform broodingPos;
    public int speed;

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
        if (hopCheck < 0)
        {
            hopCheck = 0;
        }
        if (hopCheck > hopSpots.Count - 1)
        {
            hopCheck = hopSpots.Count - 1;
        }
        if (Input.GetKeyDown("left"))
        {
            if (!_inNest)
            {
                // calculate distance to move
                float step = speed * Time.deltaTime;
                hopCheck++;
                transform.position = Vector3.MoveTowards(transform.position, hopSpots[hopCheck].position, step);
            }
        }
        if (Input.GetKeyDown("right"))
        {
            // calculate distance to move
            float step = speed * Time.deltaTime;
            hopCheck--;
            transform.position = Vector3.MoveTowards(transform.position, hopSpots[hopCheck].position, step);
        }
        if (Input.GetKeyDown("space"))
        {
            // calculate distance to move
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, broodingPos.position, step);
            _inNest = true;
        }
    }
}
