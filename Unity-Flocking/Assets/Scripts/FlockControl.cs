using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlockControl : MonoBehaviour
{
    public int currentFlock = 0;
    public GPUFlock[] flock;
    private Transform target;

    public float BoidSpeed;

    public float TargetPositionX;
    public float TargetPositionY;
    public float TargetPositionZ;

    // Start is called before the first frame update
    void Start()
    {
        flock[currentFlock].gameObject.SetActive(true);

        target = flock[currentFlock].transform.GetChild(0);
    }

    public void ChangeSpeed(float speed)
    {
        flock[currentFlock].BoidSpeed = speed;
    }

    public void ChangeDistance(float distance)
    {
        flock[currentFlock].NeighbourDistance = distance;
    }

    public void ChangeFlock(float Indexflock)
    {

        if (currentFlock != (int)Indexflock)
        {
            flock[currentFlock].gameObject.SetActive(false);

            int index = (int)Indexflock;
            currentFlock = index;

            flock[currentFlock].gameObject.SetActive(true);

            target = flock[currentFlock].transform.GetChild(0);
            SetPosition();
        }
    }


    void SetPosition()
    {
        target.localPosition = new Vector3(TargetPositionX, TargetPositionY, TargetPositionZ);
    }

    public void setTargetX(float positionX)
    {
        TargetPositionX = positionX;
        SetPosition();
    }

    public void setTargetY(float positionY)
    {
        TargetPositionY = positionY;
        SetPosition();

    }

    public void setTargetZ(float positionZ)
    {
        TargetPositionZ = positionZ;
        SetPosition();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
