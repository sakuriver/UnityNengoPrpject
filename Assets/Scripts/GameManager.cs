using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public GameObject player;
    public GameObject canvas;
    public AudioSource audioSource;
    public AudioClip heiseiClip;
    public AudioClip reiwaClip;
    public AudioClip heartClip;
    public bool isGameStart;
    public float startCount;

    // Start is called before the first frame update
    void Start()
    {
        isGameStart = true;
        startCount = 180.0f;
    }

    // Update is called once per frame
    void Update()
    {

        if (startCount > 0)
        {
            startCount--;
            Text startMessage = GameObject.Find("StartMessage").GetComponent<Text>();
            if (startMessage != null)
            {
                Color color = GameObject.Find("StartMessage").GetComponent<Text>().color;
                Debug.Log(startCount - 1.0f);
                GameObject.Find("StartMessage").GetComponent<Text>().color = new Color(255.0f, 0.0f, 0.0f, startCount - 1.0f);
            }
            return;
        }


        if (Input.GetKeyDown("x"))
        {
            GameObject reiwa = (GameObject)Resources.Load("ReiwaText");
            ObjectAdd(reiwa, new Vector3(0, 0, 0), true);
            if (audioSource != null)
            {
                audioSource.clip = reiwaClip;
                audioSource.Play();
            }

        }
        if (Input.GetKeyDown("z"))
        {
            GameObject reiwa = (GameObject)Resources.Load("HeiseiText");
            ObjectAdd(reiwa, new Vector3(-100, 0, 0), true);
            if (audioSource != null)
            {
                audioSource.clip = heiseiClip;
                audioSource.Play();
            }

            GameObject nezumi = (GameObject)Resources.Load("Nezumi");
            ObjectAdd(nezumi, new Vector3((Random.value * 20.0f) -10.0f, 0, 0), false);


        }
        if (Input.GetKeyDown("c"))
        {
            GameObject reiwa = (GameObject)Resources.Load("PlayerBullet");
            ObjectAdd(reiwa, new Vector3(100, 0, 0), true);
            if (audioSource != null) {
                audioSource.clip = heartClip;
                audioSource.Play();
            }
        }

        //if (GameloopCount % 100) {

        //}

        CharacterMove();


    }


    /// <summary>
    /// 
    /// </summary>
    void CharacterMove()
    {
        if (player != null) {
            Vector3 pos = player.transform.position;

            if (Input.GetKey(KeyCode.LeftArrow)) { 
                player.transform.position = new Vector3(pos.x - 0.25f, pos.y, pos.z);
            }

            if (Input.GetKey(KeyCode.RightArrow)) {
                player.transform.position = new Vector3(pos.x + 0.25f, pos.y, pos.z);
            }

        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="addObject">追加するオブジェクト</param>
    /// <param name="pos">初期座標</param>
    void ObjectAdd(GameObject addObject, Vector3 pos, bool flg)
    {
        GameObject baseObject = Instantiate<GameObject>(addObject);
        if (flg) {
            baseObject.transform.parent = canvas.transform;
        }
        baseObject.transform.localPosition = pos;
    }
}
