using System;
using System.Drawing;
using библиотекаИсполнителяПутник;

namespace исполнительПутник_v_2
{
    public class закраскаКлетки
    {
        public закраскаКлетки(Graphics графика, гаммаЦветов цвет, Rectangle областьЗакраски)
        {
            Brush цветЗакраски = Brushes.ForestGreen;
            switch (цвет)
            {
                case гаммаЦветов.белый:
                    цветЗакраски = Brushes.White;
                    break;
                case гаммаЦветов.голубой:
                    цветЗакраски = Brushes.Blue;
                    break;
                case гаммаЦветов.желтый:
                    цветЗакраски = Brushes.Yellow;
                    break;
                case гаммаЦветов.зеленый:
                    цветЗакраски = Brushes.LimeGreen;
                    break;
                case гаммаЦветов.красный:
                    цветЗакраски = Brushes.Red;
                    break;
                case гаммаЦветов.оранжевый:
                    цветЗакраски = Brushes.Orange;
                    break;
                case гаммаЦветов.синий:
                    цветЗакраски = Brushes.DarkBlue;
                    break;
                case гаммаЦветов.фиолетовый:
                    цветЗакраски = Brushes.Purple;
                    break;
                case гаммаЦветов.цветФона:
                    цветЗакраски = Brushes.ForestGreen;
                    break;
            }
            графика.FillRectangle(цветЗакраски, областьЗакраски);
        }
    }
}
