using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoiseMapGeneration : MonoBehaviour
{
    public float[,] GenerateNoiseMap (int mapWidth, int mapDepth, float scale)
    {
        float[,] noiseMap = new float[mapWidth+1, mapDepth+1];
        for(int x = 0; x <= mapWidth; x++)
        {
            for( int y = 0;y <= mapDepth; y++)
            {
                float sampleX = x / scale;
                float sampleY = y / scale;

                float noise = Mathf.PerlinNoise(sampleX, sampleY);
                noiseMap[x, y] = noise;
            }
        }
        return noiseMap;
    }

}
