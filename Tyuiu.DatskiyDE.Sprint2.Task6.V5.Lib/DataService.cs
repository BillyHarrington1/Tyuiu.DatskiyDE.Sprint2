using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.DatskiyDE.Sprint2.Task6.V5.Lib
{
    public class DataService : ISprint2Task6V5
    {
        public string FindCardValue(int k)
        {
            string cardName = k switch
            {
                6 => "Шестерка",
                7 => "Семерка",
                8 => "Восьмерка",
                9 => "Девятка",
                10 => "Десятка",
                11 => "Валет",
                12 => "Дама",
                13 => "Король",
                14 => "Туз",
                _ => "Неверный номер карты"
            };

            return cardName;
        }      
    }
}
