using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Janky : MonoBehaviour
{
    private float red;
    private float blue;
    private float green;
    
    // Update is called once per frame
    void Update()
    {
       // GetComponent<Renderer>().material.color = ChangeItUp();
       MakeItSlow();
       //LogTheShitOutOfIt();
    }

    private void LogTheShitOutOfIt()
    {
        Debug.Log("LOGGING IS SLOW AS HELL");
    }

    private void MakeItSlow()
    {
        for (int i = 0; i < 1000; i++)
        {
            GetComponent<Renderer>().material.color = ChangeItUp();
        }
    }
    
    private Color ChangeItUp()
    {
        red += Time.deltaTime;
        if (red > 1f)
            red -= 1f;

        green += Time.deltaTime * 2f;
        if (green > 1f)
            green -= 1f;

        blue += Time.deltaTime * 3f;
        if (blue > 1f)
            blue -= 1f;

        return new Color(red, green, blue);
    }
}
