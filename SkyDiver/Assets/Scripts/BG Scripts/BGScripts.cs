using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScripts : MonoBehaviour
{
    public GameObject[] clouds;
    public GameObject[] spawnPositions;
    public GameObject gifts;
    public GameObject storms;
    public int count;
    public GameObject[] spawnVerticals;
    public GameObject[] birds;
    private int randomIndex;
    private int randomPosition;
    // Start is called before the first frame update
    void Start()
    {
        count = 0; 
    }

    // Update is called once per frame
    void Update()
    {
        int random = Random.Range(0, 10000);
        if (random > 9995)
        {
            randomIndex = (int)Random.Range(0, clouds.Length);
            randomPosition = (int)Random.Range(0, spawnPositions.Length);
            SpawnClouds();
            SpawnGifts();
            SpawnBirds();
           
        }

    }

    private void SpawnClouds()
    {
        // frequency spawing clouds 1000 > 998
        
          

                GameObject cloudsObj = Instantiate(clouds[randomIndex]);
                //Vector3 cloudScale = cloudsObj.transform.localScale;

               
                if (randomPosition == 0)
                {
                    // spawn left
                    cloudsObj.transform.position = spawnPositions[0].transform.position;
                if (randomIndex == 0)
                {
                    if (count < 2)
                    {
                        cloudsObj.transform.position += new Vector3(0, 0, 3);
                        cloudsObj.SetActive(true);
                        count++;
                    }else
                    {
                        count = 0;
                        GameObject storm = Instantiate(storms);
                        storm.transform.position = spawnPositions[0].transform.position;
                        storm.transform.position += new Vector3(0, 0, 2);
                        storm.SetActive(true);
                    }
                }
                else if (randomIndex == 1)
                {
                    cloudsObj.transform.position += new Vector3(0, 0, 10);
                    cloudsObj.SetActive(true);
                }
                else
                {
                    cloudsObj.transform.position += new Vector3(0, 0, -1);
                    cloudsObj.SetActive(true);
                }

                
                    //cloudScale.x = Mathf.Abs(cloudScale.x);
            }
                else if(randomPosition == 1)
                {
                    // spawn center
                   cloudsObj.transform.position = spawnPositions[1].transform.position;
                if (randomIndex == 0)
                {
                    cloudsObj.transform.position += new Vector3(0, 0, 3);
                    cloudsObj.SetActive(true);
                }
                else if (randomIndex == 1)
                {
                  
                    if (count < 2)
                    {
                        cloudsObj.transform.position += new Vector3(0, 0, 10);
                        cloudsObj.SetActive(true);
                        count++;
                    }
                    else
                    {
                        count = 0;
                        GameObject storm = Instantiate(storms);
                        storm.transform.position = spawnPositions[1].transform.position;
                        storm.transform.position += new Vector3(0, 0, 2);
                        storm.SetActive(true);
                    }
                }
                else
                {
                    cloudsObj.transform.position += new Vector3(0, 0, -1);
                    cloudsObj.SetActive(true);
                }
               
                   //cloudScale.x = Mathf.Abs(cloudScale.x);

            } else
                {   // spawn right
                    cloudsObj.transform.position = spawnPositions[2].transform.position;
                if (randomIndex == 0)
                {
                    cloudsObj.transform.position += new Vector3(0, 0, 3);
                    cloudsObj.SetActive(true);
                }
                else if (randomIndex == 1)
                {
                    cloudsObj.transform.position += new Vector3(0, 0, 10);
                    cloudsObj.SetActive(true);
                }
                else
                {
                  
                    if (count < 2)
                    {
                        cloudsObj.transform.position += new Vector3(0, 0, -1);
                        cloudsObj.SetActive(true);
                        count++;
                    }
                    else
                    {
                        count = 0;
                        GameObject storm = Instantiate(storms);
                        storm.transform.position = spawnPositions[2].transform.position;
                        storm.transform.position += new Vector3(0, 0, 2);
                        storm.SetActive(true);
                    }
                }
                
                    //cloudScale.x = Mathf.Abs(cloudScale.x);
                }

                  //cloudsObj.transform.localScale = cloudScale;

            
        }

    private void SpawnGifts()
    {    // poner a 10000 > 9998
        
            GameObject gift = Instantiate(gifts);

            

            if(randomPosition == 0)
            {

                gift.transform.position = spawnPositions[0].transform.position;

            }
            else if(randomPosition == 1)
            {
                gift.transform.position = spawnPositions[1].transform.position;

            }
            else
            {
                gift.transform.position = spawnPositions[2].transform.position;

            }
            gift.transform.position += new Vector3(0, 0, 2);
            gift.SetActive(true);


        
    }

    private void SpawnBirds()
    {
       

        if(randomPosition == 1)
        {
            GameObject bird = Instantiate(birds[0]);
            bird.transform.position = spawnVerticals[0].transform.position;
            bird.SetActive(true);
        }
        else if(randomPosition == 2)
        {
            GameObject bird = Instantiate(birds[1]);
            bird.transform.position = spawnVerticals[1].transform.position;
            bird.SetActive(true);
        }
        else
        {
            GameObject bird = Instantiate(birds[0]);
            bird.transform.position = spawnVerticals[2].transform.position;
            bird.SetActive(true);
        }
        
    }

}
