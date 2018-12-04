using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wmFirstInterpolLagranzh
{
    public partial class InterpolForm : Form
    {
        IFunction function;
        public InterpolForm()
        {
            InitializeComponent();

            chFunk.Series[0].Name = "Funcktion";
            chFunk.Series[0].ChartType = SeriesChartType.Spline;
            chFunk.Series[0].Color = Color.Red;

            chFunk.Series.Add("Interpol\nPolynom");
            chFunk.Series[1].ChartType = SeriesChartType.Spline;
            chFunk.Series[1].Color = Color.Blue;

            chFunk.Series.Add("Points of\ninterpolation");
            chFunk.Series[2].ChartType = SeriesChartType.Point;
            chFunk.Series[2].Color = Color.Black;

            chError.Series[0].Name = "Error";
            chError.Series[0].ChartType = SeriesChartType.Spline;
            chError.Series[0].Color = Color.Black;

            rbUniform.Checked = true;
            rbSqrt.Checked = true;
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            chFunk.Series[0].Points.Clear();
            chFunk.Series[1].Points.Clear();
            chError.Series[0].Points.Clear();

            int n = Convert.ToInt32(nudN.Value);
            if (n < 1)
            {
                MessageBox.Show("Степень должна быть больше 0!", "Message");
                return;
            }

            Polynom polynom = new Polynom(-1, 1, n,function);

            if (rbUniform.Checked)
            {
                polynom.splitEvan();  // равномерное 
            }
            else{
                polynom.splitChebyshev(); // чебышевское
            }
                
            // генерация точек x для построения функции
            polynom.generate(50);

            //построение графика искомой функции
            for (int i = 0; i < 50; i++)
                chFunk.Series[0].Points.AddXY(polynom.getX(i), polynom.function(polynom.getX(i)));

            //построение графика интерполяционного многочлена
            for (int i = 0; i < 50; i++)
                chFunk.Series[1].Points.AddXY(polynom.getX(i), polynom.interpolationPolynomLagranzh(polynom.getX(i)));

            double maxErr = 0;
            double eps = 0.001;
            //построение графика погрешности и поиск наибольшей погрешности
            for (int i = 0; i < 50; i++)
            {
                double curErr = polynom.error(polynom.getX(i));
                if ((curErr - maxErr) > eps)
                    maxErr = curErr;
                chError.Series[0].Points.AddXY(polynom.getX(i), polynom.error(polynom.getX(i)));
            }

            // добавление полученных значений в таблицу
            dgvError.RowCount = n;
            for (int i = 0; i < n; i++)
                dgvError.Rows[i].Cells[0].Value = i + 1;
            if (rbUniform.Checked)
                dgvError.Rows[n-1].Cells[1].Value = String.Format("{0:f5}", maxErr) ;
            else
                dgvError.Rows[n-1].Cells[2].Value = String.Format("{0:f5}", maxErr);

            escapePoints(n, polynom);
        }

        // Выделение точек интерполирования
        private void escapePoints(int n, Polynom p)
        {
            chFunk.Series[2].Points.Clear();
            for (int i = 0; i <= n; i++)
                chFunk.Series[2].Points.AddXY(p.getFunkX(i), p.function(p.getFunkX(i)));
        }

        private void rbSqrt_CheckedChanged(object sender, EventArgs e)
        {
            function = new FunctionSqrt();
        }

        private void rbSin_CheckedChanged(object sender, EventArgs e)
        {
            function = new FunctionSin();
        }

        private void rbWOSqrt_CheckedChanged(object sender, EventArgs e)
        {
            function = new FunctionWithoutSqrt();
        }

        private void chError_Click(object sender, EventArgs e)
        {

        }

        private void nudN_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
