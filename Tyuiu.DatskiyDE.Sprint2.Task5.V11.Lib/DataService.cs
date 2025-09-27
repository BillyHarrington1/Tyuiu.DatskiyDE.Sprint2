using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.DatskiyDE.Sprint2.Task5.V11.Lib
{
    public class DataService : ISprint2Task5V11
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            int nextDay = n + 1;
            int nextMonth = m;
            int nextYear = g;        
            int daysInMonth;
            switch (m)
            {
                case 1:  // Январь
                    daysInMonth = 31;
                    break;
                case 2:  // Февраль
                    daysInMonth = 28; // не високосный
                    break;
                case 3:  // Март
                    daysInMonth = 31;
                    break;
                case 4:  // Апрель
                    daysInMonth = 30;
                    break;
                case 5:  // Май
                    daysInMonth = 31;
                    break;
                case 6:  // Июнь
                    daysInMonth = 30;
                    break;
                case 7:  // Июль
                    daysInMonth = 31;
                    break;
                case 8:  // Август
                    daysInMonth = 31;
                    break;
                case 9:  // Сентябрь
                    daysInMonth = 30;
                    break;
                case 10: // Октябрь
                    daysInMonth = 31;
                    break;
                case 11: // Ноябрь
                    daysInMonth = 30;
                    break;
                case 12: // Декабрь
                    daysInMonth = 31;
                    break;
                default:
                    return "sosal";
            }

            // >>>>>>>>>>>>>>>>>день>>>>>>>>>>>>>>>месяц>>>>>>>>>>>>>>>>>>>
            if (nextDay > daysInMonth)
            {
                nextDay = 1;
                nextMonth++;

                // >>>>>>>>>>>>>>>>>месяц>>>>>>>>>>>>>>>>>>12>>>>>>>>>>>>>>>>>>>>>
                if (nextMonth > 12)
                {
                    nextMonth = 1;
                    nextYear++;
                }
            }

            // Формат c 0
            string formattedDay = nextDay.ToString("00");
            string formattedMonth = nextMonth.ToString("00");

            return $"{formattedDay}.{formattedMonth}.{nextYear}";
       
        }
    }
}