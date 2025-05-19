using UnityEngine;

public class Instantiator : MonoBehaviour
{
    public GameObject cuboPrefab; // Reference to the prefab to instantiate
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }


public void InstanciarCubo(){
    Instantiate(cuboPrefab);
}
}
