public static  class GameSettings
{
    public static int screenWidth { get; set; }
    public static int heroWidth { get; set; }
    public static float destructionHight { get; }
    public static int currentScore { get; set; }
    public static int level { get; set; }


    static GameSettings()
    {
        //Default settings
        screenWidth = 640; //ширина экрана
        heroWidth = 80; //ширина героя
        destructionHight = 5f;//расстояние пропадания платформ
        currentScore = 0;
        level = 1;
    }


}

