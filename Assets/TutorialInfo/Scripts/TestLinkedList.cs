using Unity.VisualScripting;
using UnityEngine;

public class TestLinkedList : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    TestLinkedList list;
    
    void Start()
    {
        list = new();
        list(4);
        list(7);
        list(1);
        list(9);

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
