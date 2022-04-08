public static  class GameSettings
{
    public static int screenWidth { get; set; }
    public static int heroWidth { get; set; }
    public static float destructionHight { get; }
  

    static GameSettings()
    {
        //Default settings
        screenWidth = 640; //������ ������
        heroWidth = 80; //������ �����
        destructionHight = 5f;//���������� ���������� ��������
    }


}

