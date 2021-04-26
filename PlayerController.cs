using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    float whereDig;
    public static int Star;
    public static bool isEnd = false;
    public static float Timer = 0;
    public static int finalTime = 0;
    public static int ShortestTime;
    public static int ShortestTime2;
    public static int ShortestTime3;
    public static int ShortestTime4;
    public static int ShortestTime5;
    public static int ShortestTime6;
    public static int ShortestTime7;
    public static int ShortestTime8;
    public static int ShortestTime9;
    public static int ShortestTime10;
    
    public static int MostCoin;
    public static int MostCoin2;
    public static int MostCoin3;
    public static int MostCoin4;
    public static int MostCoin5;
    public static int MostCoin6;
    public static int MostCoin7;
    public static int MostCoin8;
    public static int MostCoin9;
    public static int MostCoin10;

    public static bool firstTime = true;
    public Text ShowStar;
    public Text ShowTime;
    public Text Shortest;
    public Text Most;
    public static bool isWin = false;
    void Start()
    {
        Physics2D.queriesStartInColliders = false;
        isEnd = false;
        Timer = 0;
        finalTime = 0;
        Star = 0;
        isWin = false;
        if(SceneManager.GetActiveScene().buildIndex == 2)
        {
            if(ShortestTime == 0)
            {
                firstTime = true;
                Debug.Log("1");
            }
        }
        if(SceneManager.GetActiveScene().buildIndex == 3)
        {
            if(ShortestTime2 == 0)
            {
                firstTime = true;
                Debug.Log("2");
            }
        }
        if(SceneManager.GetActiveScene().buildIndex == 4)
        {
            if(ShortestTime3 == 0)
            {
                firstTime = true;
            }
        }
        if(SceneManager.GetActiveScene().buildIndex == 5)
        {
            if(ShortestTime4 == 0)
            {
                firstTime = true;
            }
        }
        if(SceneManager.GetActiveScene().buildIndex == 6)
        {
            if(ShortestTime5 == 0)
            {
                firstTime = true;
            }
        }
        if(SceneManager.GetActiveScene().buildIndex == 7)
        {
            if(ShortestTime6 == 0)
            {
                firstTime = true;
            }
        }
        if(SceneManager.GetActiveScene().buildIndex == 8)
        {
            if(ShortestTime7 == 0)
            {
                firstTime = true;
            }
        }
        if(SceneManager.GetActiveScene().buildIndex == 9)
        {
            if(ShortestTime8 == 0)
            {
                firstTime = true;
            }
        }
        if(SceneManager.GetActiveScene().buildIndex == 10)
        {
            if(ShortestTime9 == 0)
            {
                firstTime = true;
            }
        }
        if(SceneManager.GetActiveScene().buildIndex == 11)
        {
            if(ShortestTime10 == 0)
            {
                firstTime = true;
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(isEnd == false)
        {
            Timer += Time.deltaTime;
            finalTime = Mathf.RoundToInt(Timer);
        }
        if(SceneManager.GetActiveScene().buildIndex == 2)
        {
            if(Star > MostCoin)
            {
                MostCoin = Star;
            }
            if(firstTime == true)
            {
                ShortestTime = finalTime;
            }
        }
        if(SceneManager.GetActiveScene().buildIndex == 3)
        {
            if(Star > MostCoin2)
            {
                MostCoin2 = Star;
            }
            if(firstTime == true)
            {
                ShortestTime2 = finalTime;
            }
        }
        if(SceneManager.GetActiveScene().buildIndex == 4)
        {
            if(Star > MostCoin3)
            {
                MostCoin3 = Star;
            }
            if(firstTime == true)
            {
                ShortestTime3 = finalTime;
            }
        }
        if(SceneManager.GetActiveScene().buildIndex == 5)
        {
            if(Star > MostCoin4)
            {
                MostCoin4 = Star;
            }
            if(firstTime == true)
            {
                ShortestTime4 = finalTime;
            }
        }
        if(SceneManager.GetActiveScene().buildIndex == 6)
        {
            if(Star > MostCoin5)
            {
                MostCoin5 = Star;
            }
            if(firstTime == true)
            {
                ShortestTime5 = finalTime;
            }
        }
        if(SceneManager.GetActiveScene().buildIndex == 7)
        {
            if(Star > MostCoin6)
            {
                MostCoin6 = Star;
            }
            if(firstTime == true)
            {
                ShortestTime6 = finalTime;
            }
        }
        if(SceneManager.GetActiveScene().buildIndex == 8)
        {
            if(Star > MostCoin7)
            {
                MostCoin7 = Star;
            }
            if(firstTime == true)
            {
                ShortestTime7 = finalTime;
            }
        }
        if(SceneManager.GetActiveScene().buildIndex == 9)
        {
            if(Star > MostCoin8)
            {
                MostCoin8 = Star;
            }
            if(firstTime == true)
            {
                ShortestTime8 = finalTime;
            }
        }
        if(SceneManager.GetActiveScene().buildIndex == 10)
        {
            if(Star > MostCoin9)
            {
                MostCoin9 = Star;
            }
            if(firstTime == true)
            {
                ShortestTime9 = finalTime;
            }
        }
        if(SceneManager.GetActiveScene().buildIndex == 11)
        {
            if(Star > MostCoin10)
            {
                MostCoin10 = Star;
            }
            if(firstTime == true)
            {
                ShortestTime10 = finalTime;
            }
        }
        if(isEnd == true && isWin == true)
        {
            if(SceneManager.GetActiveScene().buildIndex == 2)
            {
                if(ShortestTime > finalTime)
                {
                    ShortestTime = finalTime;
                }
            }
            if(SceneManager.GetActiveScene().buildIndex == 3)
            {
                if(ShortestTime2 > finalTime)
                {
                    ShortestTime2 = finalTime;
                }
            }
            if(SceneManager.GetActiveScene().buildIndex == 4)
            {
                if(ShortestTime3 > finalTime)
                {
                    ShortestTime3 = finalTime;
                }
            }
            if(SceneManager.GetActiveScene().buildIndex == 5)
            {
                if(ShortestTime4 > finalTime)
                {
                    ShortestTime4 = finalTime;
                }
            }
            if(SceneManager.GetActiveScene().buildIndex == 6)
            {
                if(ShortestTime5 > finalTime)
                {
                    ShortestTime5 = finalTime;
                }
            }
            if(SceneManager.GetActiveScene().buildIndex == 7)
            {
                if(ShortestTime6 > finalTime)
                {
                    ShortestTime6 = finalTime;
                }
            }
            if(SceneManager.GetActiveScene().buildIndex == 8)
            {
                if(ShortestTime7 > finalTime)
                {
                    ShortestTime7 = finalTime;
                }
            }
            if(SceneManager.GetActiveScene().buildIndex == 9)
            {
                if(ShortestTime8 > finalTime)
                {
                    ShortestTime8 = finalTime;
                }
            }
            if(SceneManager.GetActiveScene().buildIndex == 10)
            {
                if(ShortestTime9 > finalTime)
                {
                    ShortestTime9 = finalTime;
                }
            }
            if(SceneManager.GetActiveScene().buildIndex == 11)
            {
                if(ShortestTime10 > finalTime)
                {
                    ShortestTime10 = finalTime;
                }
            }
        }

        int layerMask = 1 << 2;
        layerMask = ~layerMask;
        RaycastHit2D hitInfoRight = Physics2D.Raycast (transform.position, transform.right*-1,1.2f,layerMask);
        RaycastHit2D hitInfoLeft = Physics2D.Raycast (transform.position, transform.right,1.2f, layerMask);
        float x = transform.position.x;
        if(Input.GetKeyDown(KeyCode.A))
        {
            if(hitInfoRight.collider == null)
            {   
                x -= 1;
            }
            
        }
        if(Input.GetKeyDown(KeyCode.D))
        {
            if(hitInfoLeft.collider == null)
            {
                x += 1;
            }
        }
        transform.position = new Vector2(x, transform.position.y);

        ShowStar.text = "Star : " + Star;
        ShowTime.text = "Time : " + finalTime;
        if(SceneManager.GetActiveScene().buildIndex == 2)
        {
            Shortest.text = "Shortest time : " + ShortestTime;
            Most.text = "Most Coin : " + MostCoin;
        }
        if(SceneManager.GetActiveScene().buildIndex == 3)
        {
            Shortest.text = "Shortest time : " + ShortestTime2;
            Most.text = "Most Coin : " + MostCoin2;
        }
        if(SceneManager.GetActiveScene().buildIndex == 4)
        {
            Shortest.text = "Shortest time : " + ShortestTime3;
            Most.text = "Most Coin : " + MostCoin3;
        }
        if(SceneManager.GetActiveScene().buildIndex == 5)
        {
            Shortest.text = "Shortest time : " + ShortestTime4;
            Most.text = "Most Coin : " + MostCoin4;
        }
        if(SceneManager.GetActiveScene().buildIndex == 6)
        {
            Shortest.text = "Shortest time : " + ShortestTime5;
            Most.text = "Most Coin : " + MostCoin5;
        }
        if(SceneManager.GetActiveScene().buildIndex == 7)
        {
            Shortest.text = "Shortest time : " + ShortestTime6;
            Most.text = "Most Coin : " + MostCoin6;
        }
        if(SceneManager.GetActiveScene().buildIndex == 8)
        {
            Shortest.text = "Shortest time : " + ShortestTime7;
            Most.text = "Most Coin : " + MostCoin7;
        }
        if(SceneManager.GetActiveScene().buildIndex == 9)
        {
            Shortest.text = "Shortest time : " + ShortestTime8;
            Most.text = "Most Coin : " + MostCoin8;
        }
        if(SceneManager.GetActiveScene().buildIndex == 10)
        {
            Shortest.text = "Shortest time : " + ShortestTime9;
            Most.text = "Most Coin : " + MostCoin9;
        }
        if(SceneManager.GetActiveScene().buildIndex == 11)
        {
            Shortest.text = "Shortest time : " + ShortestTime10;
            Most.text = "Most Coin : " + MostCoin10;
        }
        
    }
}
