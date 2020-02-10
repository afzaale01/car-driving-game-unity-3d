using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoint : MonoBehaviour
{
    public float ThresholdDistance;
    public GameObject parent;
    public GameObject CurrentTarget;
    public int currentIndex;
    
    
    // Start is called before the first frame update
    void Start()
    {
        CurrentTarget.transform.position = parent.transform.GetChild(0).position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "AICAR")
        {
            this.GetComponent<BoxCollider>().enabled = false;
            currentIndex++;
            if (currentIndex >= parent.transform.childCount)
            {
                currentIndex = 0;
            }
            UpdateTarget();
            yield return new WaitForSeconds(1f);
            this.GetComponent<BoxCollider>().enabled = true;
        }
    }

        void UpdateTarget()
        {
        CurrentTarget.transform.position = parent.transform.GetChild(currentIndex).position;
    }

}
