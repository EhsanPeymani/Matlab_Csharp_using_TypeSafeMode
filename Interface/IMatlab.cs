using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interface
{
    public interface IMatlab
    {
        double add(double num1, double num2);

        double[] add(double[] num1, double[] num2);

        double[,] add(double[,] num1, double[,] num2);

        void PlotMesh(string figureName, string title);

        void DisplayPlot(double[] xData, double[] yData, string plotTitle, string plotXLabel, string plotYLabel,
            string figureName);

        // ReSharper disable once InconsistentNaming
        double[,] makesquare(double dim);

        double[,] makesquare_full(double dim, out double determinant, out double[] eigenvalues);

        double[,] makesquare_in_vector(double[] inputVector);

        MatrixOutputStructure makesquare_structure(double dim);

        MatrixInputOutputstructure makesquare_in_out_structure(MatrixInputStructure input);
    }
}
