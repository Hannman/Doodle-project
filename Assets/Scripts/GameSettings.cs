public static  class GameSettings
{
    public static int screenWidth { get; set; }
    public static int heroWidth { get; set; }

    static GameSettings()
    {
        //Default settings
        screenWidth = 640; //������ ������
        heroWidth = 80; //������ �����
    }


}

