using System;
using System.Windows.Forms;

namespace Практика_11_12_Зад2_В9
{
    public class Figure
    {
        public Double[,] arr = new double[3, 2];

        int figur = 0;
        public void rectangle(Double dlina, Double shirina)
        {
            try
            {
                Double ploshad = dlina * shirina;
                Double pirimetr = 2 * (dlina + shirina);
                arr[0, 0] = ploshad;
                arr[0, 1] = pirimetr;
            }
            catch
            {
                arr[0, 0] = 0;
                arr[0, 1] = 0;
                MessageBox.Show("В данных прямоугольника введены неверные значения");
            }
        }

        public void Circle(Double radius)
        {
            try
            {
                Double ploshad = 3.14 * Math.Pow(radius, 2);
                Double pirimetr = 2 * 3.14 * radius;
                arr[1, 0] = ploshad;
                arr[1, 1] = pirimetr; 
            }
            catch
            {
                arr[1, 0] = 0;
                arr[1, 1] = 0;
                MessageBox.Show("В данных круга введены неверные значения");
            }
        }

        public void Triangle(Double osnovanie, Double visota, Double a, Double b, Double c)
        {
            try
            {
                Double ploshad = 0.5 * osnovanie * visota;
                Double pirimetr = a + b + c;
                arr[2, 0] = ploshad;
                arr[2, 1] = pirimetr;
            }
            catch
            {
                arr[2, 0] = 0;
                arr[2, 1] = 0;
                MessageBox.Show("В данных треугольника введены неверные значения");
            } 
        }
        public string [,] Vizov()
        {
           string [,] a = Vivod(arr);
            return a;
        }
        
        public String[,] Vivod(double[,] arr)
        {
            string [,] a = new string[3, 2];
            int i= 0;
            while (i<3)
            {
                for (int j = 0; j < 2; j++)
                {
                    a[i, j] = Convert.ToString(arr[i, j]);
                }
                i++;
            }
            return a;
        }
    }
}
