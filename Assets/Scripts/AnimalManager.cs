using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalManager : MonoBehaviour
{
    [SerializeField] private GameObject[] animals;
    private int currentAnimalIndex = 0;
    private GameObject currentAnimal;


    // Start is called before the first frame update
    void Start()
    {
        currentAnimal = Instantiate(animals[currentAnimalIndex], transform.position, Quaternion.identity);        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Destroy(currentAnimal);
            currentAnimalIndex--;
            if (currentAnimalIndex < 0)
            {
                currentAnimalIndex = animals.Length - 1;
            }
            currentAnimal = Instantiate(animals[currentAnimalIndex], currentAnimal.transform.position, currentAnimal.transform.rotation);
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            Destroy(currentAnimal);
            currentAnimalIndex++;
            if (currentAnimalIndex >= animals.Length)
            {
                currentAnimalIndex = 0;
            }
            currentAnimal = Instantiate(animals[currentAnimalIndex], currentAnimal.transform.position, currentAnimal.transform.rotation);
        }
    }
}
