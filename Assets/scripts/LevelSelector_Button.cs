using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector_Button : MonoBehaviour
{
    public void LevelSelector()
    {
        SceneManager.LoadScene("Levels");
    }
    public void LevelSelector1()
    {
        SceneManager.LoadScene("Options");
    }
    public void BackButton()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Level1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Level2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
    public void Level3()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }
    public void Level4()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
    }
    public void Level5()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
    }
    public void Level6()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 6);
    }
    public void Level7()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 7);
    }
    public void Level8()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 8);
    }
    public void Levels_Prav�k()
    {
        SceneManager.LoadScene("Levels_Prav�k");
    }
    public void Levels_Starov�k()
    {
        SceneManager.LoadScene("Levels_Starov�k");
    }
    public void Levels_St�edov�k()
    {
        SceneManager.LoadScene("Levels_St�edov�k");
    }
    public void Levels_Novov�k()
    {
        SceneManager.LoadScene("Levels_Novov�k");
    }
    public void Levels_Budoucnost()
    {
        SceneManager.LoadScene("Levels_Budoucnost");
    }

    public void Shop()
    {
        SceneManager.LoadScene("Shop");
    }

    public void pevnosti()
    {
        SceneManager.LoadScene("pevnost_shop");
    }
    public void powerups()
    {
        SceneManager.LoadScene("power_ups");
    }
}
