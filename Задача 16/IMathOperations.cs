using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_16
{
    interface IMathOperations
    {

        // Метод, возвращающий число PI
        double GetPI();

        // Метод, возвращающий число типа int
        int GetInteger();

        // Метод, возвращающий x в квадрате
        double Square(double x);

        // Метод, возвращающий корень квадратный из x
        double SquareRoot(double x);

    }
}
