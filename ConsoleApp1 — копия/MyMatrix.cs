using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _2_лаба
{
    partial class MyMatrix
    {
        double[,] matrix { get; set; }

        private double? cachedDeterminant = null; //пишу так щоб було зрозуміло що
                                                  //дет. ще не обчислено  
    
        public MyMatrix()
        {
            matrix = new double[,] { };
        }

    
    }

}
