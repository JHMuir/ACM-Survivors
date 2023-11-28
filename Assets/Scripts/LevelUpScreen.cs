using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelUpScreen : MonoBehaviour
{
    public GameObject[] listOfPowerups;
    public TextMeshProUGUI powerupText;

    public void ChooseRandomPowerup()
    {
        int randomIndex = Random.Range(0, listOfPowerups.Length);
        GameObject randomPowerup = listOfPowerups[randomIndex];
        Instantiate(randomPowerup);
        powerupText.text = "You Got: " + randomPowerup.name;
        
    }

}
