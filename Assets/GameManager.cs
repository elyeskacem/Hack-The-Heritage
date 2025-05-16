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
        // print all rotation angle of Horloge
        print("Horloge rotation: " + Horloge.transform.rotation.eulerAngles);
        // print all rotation angle of Horloge
        print("Horloge rotation x : " + Horloge.transform.rotation.eulerAngles.x);
        print("Horloge rotation y : " + Horloge.transform.rotation.eulerAngles.y);
        print("Horloge rotation z : " + Horloge.transform.rotation.eulerAngles.z);

        if(Horloge.transform.rotation.eulerAngles.z > 180)
        {
            print("Horloge is full rotated");
        }
        
    }
}
