using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UIManager : MonoBehaviour
{
    private GameObject player;
    private Player player_script;

    

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        player_script = player.GetComponent<Player>();
    }

    // ������ �̵� ��ư ������ ��
    public void RightDown()
    {
       //player_script.input_Right = false;
    }

    public void RightUp()
    {
        player_script.Move();
        player_script.input_Right = true;
       
    }

    
    public void LeftDown()
    {
       // player_script.input_Right = false;
    }

    public void LeftUp()
    {
        player_script.Move();
        player_script.input_Right = true;
       

    }

   

}
