using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*ALL VARIABLES*/

namespace RTS
{
    
    public static class ResourceManager
    {
        public static float ScrollSpeed { get { return 2*25; } }
        public static float RotateSpeed { get { return 2.5f*100; } }
        public static float RotateAmount { get { return 10; } }
        //границы экрана, при наведении на которые камера будет двигаться
        public static int ScrollWidth { get { return 15; } }
        //ограничение приближения и отдаления камеры
        public static float MinCameraHeight { get { return 10; } }
        public static float MaxCameraHeight { get { return 30; } }
    }
}