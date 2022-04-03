using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapDisplay : MonoBehaviour
{
    public Renderer textureRender;

    public void drawNoiseMap(ref int[,] noiseMap) 
    {
        int width = noiseMap.GetLength(0);
        int height = noiseMap.GetLength(1);

        Texture2D texture = new Texture2D(width, height);
        texture.filterMode = FilterMode.Point;
        Color[] colorMap = new Color[height*width];

        for(int x = 0; x < width; x++)
            for(int y = 0; y < height; y++)
            {
                colorMap[width * x + y] = Color.Lerp(Color.black, Color.white, noiseMap[x,y]);
            }

        texture.SetPixels(colorMap);
        texture.Apply();

        textureRender.sharedMaterial.mainTexture = texture;
        textureRender.transform.localScale = new Vector3(width, 1, height);
    }

    public void drawNoiseMap(ref float[,] noiseMap) 
    {
        int width = noiseMap.GetLength(0);
        int height = noiseMap.GetLength(1);

        Texture2D texture = new Texture2D(width, height);
        // texture.filterMode = FilterMode.Point;
        Color[] colorMap = new Color[height*width];

        for(int x = 0; x < width; x++)
            for(int y = 0; y < height; y++)
            {
                colorMap[width * x + y] = Color.Lerp(Color.black, Color.white, noiseMap[x,y]);
            }

        texture.SetPixels(colorMap);
        texture.Apply();

        textureRender.sharedMaterial.mainTexture = texture;
        textureRender.transform.localScale = new Vector3(width, 1, height);
    }
}