using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wmFirstInterpolLagranzh
{
    class Polynom
    {
        private double a;  // левая граница
        private double b;  // правая граница
        private int n;  // степень интерполяционного полинома 

        private double[] arrPointsX;  // узлы интерполяции
        private double[] arrLi; //значение многочлена l в точках x
        private double[] coorX; // координаты x для построения графика

        private IFunction funckt;  // ссылка на функцию

        public Polynom(double _a, double _b, int _n, IFunction funck)
        {
            this.a = _a;
            this.b = _b;
            this.n = _n;
            this.funckt = funck;
            arrPointsX = new double[n + 1];
            arrLi = new double[n + 1];
        }

        //определяем какую функцию используем
        public double function(double x)
        {
            return funckt.getFunction(x);
        }

        // Равномерное разбиение
        public void splitEvan()
        {
            for (int i = 0; i <= n; i++)
                arrPointsX[i] = a + (b - a) * i / n;
        }

        // Разбиение Чебышева
        public void splitChebyshev()
        {
            arrPointsX[0] = a;
            for (int i = 1; i < n; i++)
            {
                double nom = 2 * i + 1;
                double denom = 2 * n + 2;
                double p = nom / denom * Math.PI;
                arrPointsX[i] = (a + b) / 2 + (b - a) / 2 * Math.Cos(p);
            }
            arrPointsX[n] = b;
        }

        // Вычисление интерполяционного многочлена Лагранжа
        public double interpolationPolynomLagranzh(double x)
        {
            double result = 0;

            for (int i = 0; i < n; i++)
            {
                double Li = 1;
                for (int j = 0; j < n; j++)
                {
                    if (j != i)
                    {
                        Li *= (x - arrPointsX[j]) / (arrPointsX[i] - arrPointsX[j]);
                    }
                }
                result += Li * function(arrPointsX[i]);
            }
            return result;
        }

        // Генерация cnt точек для построения графика функции
        public void generate(int cnt)
        {
            coorX = new double[cnt];
            double step = (Math.Abs(a) + Math.Abs(b)) / cnt;
            for (int i = 0; i < cnt; i++)
                coorX[i] = a + step * (i );
        }

        // Сгенерированные точки лля построения графика.
        public double getX(int id)
        {
            return coorX[id];
        }

        // Вычисление значения погрешности в точке x
        public double error(double x)
        {
            return Math.Abs(function(x) - interpolationPolynomLagranzh(x));
        }

        // Свойство - узлы интерполяции
        public double getFunkX(int id)
        {
            return arrPointsX[id];
        }
    }
}
