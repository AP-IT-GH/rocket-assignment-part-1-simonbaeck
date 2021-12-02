using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class myGameManager : MonoBehaviour
{
    [SerializeField]
    public GameObject player;
    public GameObject gameover;
    public GameObject end;

    public GameState state = GameState.Playing;

    public enum GameState    
    {
        Playing, End, GameOver
    }

    // Start is called before the first frame update
    void Start()
    {
        // gameover.SetActive(false);
        // end.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //switch (state)
        //{
        //    case GameState.Playing:
        //        {
        //            gameover.SetActive(false);
        //            end.SetActive(false);
        //        }
        //        break;
        //    case GameState.End:
        //        {
        //            gameover.SetActive(false);
        //            end.SetActive(true);
        //        }
        //        break;
        //}
    }
}
