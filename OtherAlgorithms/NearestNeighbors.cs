using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OtherAlgorithms
{
    public class NearestNeighbors
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataset"> Список типа Point</param>
        /// <param name="clasifyElem">Элемент который классифицируется</param>
        /// <param name="countNeighbors">Количество соседей</param>
        /// <returns></returns>
        public static string Classify(List<Point> dataset, Point clasifyElem, int countNeighbors)
        {
            SortedList<double, Point> dataDist = new SortedList<double, Point>();
            SortedList<string, int> typesNeighbors = new SortedList<string, int>();

            if (countNeighbors <= 0)
                throw new Exception("Количество соседей должно быть больше нуля!");

            //Нахождение растояния от клвссифицируемого объекта до объектов в базе данных.
            foreach (var elem in dataset)
            {
                if (elem.Name == clasifyElem.Name)
                    continue;
                dataDist.Add(PythagoreanFormula(elem, clasifyElem), elem);
            }
            
            //Выбор опрделенного количества ближайших объектов
            int i = 0;
            foreach (var elem in dataDist)
            {
                if (i == countNeighbors)
                    break;

                if (typesNeighbors.ContainsKey(elem.Value.Name))
                    typesNeighbors[elem.Value.Name]++;
                else
                    typesNeighbors.Add(elem.Value.Name, 1);
                i++;
            }
            
            //Нахождение среди ближайших объектов к классифицируемому тех которых больше по количеству.
            return typesNeighbors.Aggregate((x, y) => (x.Value < y.Value) ? y : x).Key;          
        }

        private static double PythagoreanFormula(Point point1, Point point2)
        {
            return Math.Sqrt((Math.Pow((point1.X - point2.X),2) + Math.Pow((point1.Y - point2.Y), 2)));
        }
    }
}
