using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HexagonSpawner : MonoBehaviour
{
    public GameObject hexagonPrefab;
    public Button hexagonColourizerButton;
    public HexagonCounter hexagonCounter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnSpawnClick()
    {
        Vector3 spawnPosition = transform.position + (Vector3)Random.insideUnitCircle * 5;

        GameObject spawnedHexagonObject = Instantiate(hexagonPrefab, spawnPosition, Quaternion.identity);
        Hexagon spawnedHexagon = spawnedHexagonObject.GetComponent<Hexagon>();
        hexagonColourizerButton.onClick.AddListener(spawnedHexagon.OnColourizeClick);

        spawnedHexagon.onColourChange.AddListener(hexagonCounter.IncreaseCount);
    }

}
//Instantiate(hexagonPrefab, spawnPosition, Quaternion.identity); //CRUCIAL FOR INSTANTIATING STUFF SO IT DOESNT SPAWN IN A WEIRD AREA