using UnityEngine;

public static  class GameSettings
{
    public static float screenWidth { get; set; }
    public static float heroWidth { get; set; }
    public static float platformWidth { get; set; }
    public static float platformLimit { get; set; }
    public static float destructionHight { get; }
    public static int currentScore { get; set; }
    public static int level { get; set; }


    static GameSettings()
    {
        //Default settings

        destructionHight = 10f;//расстояние пропадания платформ
        currentScore = 0;
        level = 1;
        Calulate();
    }

    private static void Calulate()
    {
        int heroWidthInPixels = 60;
        int platformWidthInPixels = 128;

        float _density = 20 / (float)Screen.height; //Плотность юнитов на один пиксель
        screenWidth = _density * (float)Screen.width;
        heroWidth = _density * heroWidthInPixels;
        platformWidth = _density * platformWidthInPixels;
        platformLimit = (screenWidth - platformWidth) / 2;
        Debug.Log($"Screen.height - {Screen.height}; Screen.width - {Screen.width}.");
        Debug.Log($"screenWidth - {screenWidth}; heroWidth - {heroWidth}; platformWidth - {platformWidth}; platformLimit - {platformLimit}.");
    }

}

