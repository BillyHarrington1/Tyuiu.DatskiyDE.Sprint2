using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.DatskiyDE.Sprint2.Task2.V10.Lib
{
    public class DataService : ISprint2Task2V10
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

            if

              ((x >= 3 && x <= 5 && y >= 3 && y <= 7) ||     // Левый прямоугольник
              (x >= 9 && x <= 12 && y >= 3 && y <= 7) ||     // Правый прямоугольник  
              (x >= 3 && x <= 12 && y >= 9 && y <= 11) ||    // Центральный горизонтальный
              (x >= 6 && x <= 10 && y >= 12 && y <= 13) ||   // Нижний маленький
              (x >= 13 && x <= 14 && y >= 2 && y <= 7) ||    // Вертикальная линия справа
              (x >= 6 && x <= 14 && y >= 13 && y <= 15))     // Горизонтальная линия внизу
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}