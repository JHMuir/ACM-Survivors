using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExperienceSystem : MonoBehaviour
{
    public int experience = 0;
    public int maxExperience = 5;

    public LevelUpScreen levelUpScreen;
    

    public void GainExperience(int exp)
    {
        experience += exp;
        if (experience >= maxExperience)
        {
            LevelUp();
        }
    }

    void LevelUp()
    {
        experience = 0;
        maxExperience += 5;
        StartCoroutine(ShowLevelUpScreen());
        levelUpScreen.ChooseRandomPowerup();

        

    }

    IEnumerator ShowLevelUpScreen()
    {
        levelUpScreen.gameObject.SetActive(true);
        yield return new WaitForSeconds(2);
        levelUpScreen.gameObject.SetActive(false);
    }
}
