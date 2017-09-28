using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamelogic : MonoBehaviour {
    public GameObject player;
    public GameObject startPoint;
    public GameObject StaircasePoint;
    public GameObject PoojagharPoint;
    public GameObject Diningroom1Point, Diningroom2Point, KitchenPoint;
    public GameObject Room1Point, Room2Point;
    public GameObject Room2exitPoint, BackyardPoint, Room1dressPoint, Room1dressPoint2;
    public GameObject RoomEnterPoint;
    public Material redmat, greenmat, defaultmat;
    private bool gazedAt = false;
    public float gazeTime = 3f;
    private float timer;
    private GameObject MovetoGO;
    // Use this for initialization
    void Start () {
        player.transform.position = startPoint.transform.position;
        //StaircasePoint.GetComponent<Renderer>().material = defaultmat;
        //PoojagharPoint.GetComponent<Renderer>().material = defaultmat;
    }

    void Update()
    {
        if (gazedAt)
        {
            if (timer >= gazeTime)
            {
                timer = 0f;
                iTween.MoveTo(player,
                    iTween.Hash(
                        "position", MovetoGO.transform.position,
                        "time", 5,
                        "easetype", "linear"
                    )
                );
                makeactive();
                MovetoGO.SetActive(false);

                //MovetoGO = 
            }
            else
            {
                timer = timer + Time.deltaTime;
            }
        }
        //if (gazedAt)
        //{
        //    timer = timer + Time.deltaTime;
        //}
        //Debug.Log("timer : " + timer);
    }

    public void moveaway()
    {
        Debug.Log("Inside moveaway");
        gazedAt = false;        
        timer = 0f;
    }

    public void reachStaircase()
    {
        //Debug.Log("Inside reachStaircase");
        gazedAt = true;
        MovetoGO = StaircasePoint;
        
    }
 

    public void reachPoojaghar()
    {   gazedAt = true;
        MovetoGO = PoojagharPoint;
    }

    public void reachDiningroom1Point()
    { 
        gazedAt = true;
        MovetoGO = Diningroom1Point;
    }

    public void reachDiningroom2Point()
    { 
        gazedAt = true;
        MovetoGO = Diningroom2Point;
    }

    public void reachKitchenPoint()
    { 
        gazedAt = true;
        MovetoGO = KitchenPoint;
    }

    public void reachRoomEnterPoint()
    {
        gazedAt = true;
        MovetoGO = RoomEnterPoint;
    }

    public void reachRoom1Point()
    {
        gazedAt = true;
        MovetoGO = Room1Point;
    }

    public void reachRoom2Point()
    {
        gazedAt = true;
        MovetoGO = Room2Point;
    }

    public void reachRoom2exitPoint()
    {
        gazedAt = true;
        MovetoGO = Room2exitPoint;
    }

    public void reachBackyardPoint()
    {
        gazedAt = true;
        MovetoGO = BackyardPoint;
    }

    public void reachRoom1dressPoint()
    {
        gazedAt = true;
        MovetoGO = Room1dressPoint;
    }

    public void reachRoom1dressPoint2()
    {
        gazedAt = true;
        MovetoGO = Room1dressPoint2;
    }

    public void reachstartPoint()
    {
        gazedAt = true;
        MovetoGO = startPoint;
    }
    void makeactive()
    {
        StaircasePoint.SetActive(true);
        PoojagharPoint.SetActive(true);
        Diningroom1Point.SetActive(true);
        Diningroom2Point.SetActive(true);
        KitchenPoint.SetActive(true);
        RoomEnterPoint.SetActive(true);
        Room1Point.SetActive(true);
        Room2Point.SetActive(true);
        Room2exitPoint.SetActive(true);
        BackyardPoint.SetActive(true);
        Room1dressPoint.SetActive(true);
        Room1dressPoint2.SetActive(true);
        startPoint.SetActive(true);
    }

}
