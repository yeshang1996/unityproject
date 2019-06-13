using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateGameObject : MonoBehaviour
{
    //初始生成时间5秒钟

    float times = 5f;

    //物体
    public GameObject wolf1;
    GameObject targert = null;


    void Start()
    {

    }


    void Update()
    {


        times -= Time.deltaTime; //减时间
        if (times < 0) //倒计时
        {
            //产生物体
            GameObject obj = (GameObject) Instantiate(wolf1);
            int ni = Random.Range(-9, 18);
            int nt = Random.Range(25, 16);

            //随机位置
            obj.transform.position = new Vector3(ni, 5.8f, nt);


            //重新设置时间为0-10之间的一个随机数   随机时间
            times = Random.Range(0, 10);


        }
    }
}
