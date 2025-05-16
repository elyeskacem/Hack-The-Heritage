using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Horloge;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Horloge.transform.rotation.eulerAngles.z > 180)
        {
            print("Horloge is full rotated");
            //do something
            Destroy(GetComponent<GameManager>());
        }
        
    }
}
