using UnityEngine;

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
        //screenWidth = 640; //������ ������
        screenWidth = Screen.currentResolution.width;
        heroWidth = 80; //������ �����
        destructionHight = 5f;//���������� ���������� ��������
        currentScore = 0;
        level = 1;
    }


}

