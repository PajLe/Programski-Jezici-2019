using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class PunaMatrica : IKvadratnaMatrica
    {
        private int dim; // dimenzije
        private double[,] mat;

        public PunaMatrica(int dim)
        {
            this.dim = dim;
            mat = new double[dim, dim];
        }

        public void citajBIN()
        {
            throw new NotImplementedException();
            throw new ArgumentOutOfRangeException();
        }

        public void citajSTD()
        {
            throw new NotImplementedException();
        }

        public double DET()
        {
            if (dim == 1) { return mat[0,0]; }
            if (dim == 2) { return (mat[0, 0] * mat[1,1] - mat[0,1] * mat[1,0]); }

            PunaMatrica a = new PunaMatrica(dim - 1);
            for (int i = 1; i < dim; i++)
            {
                double x = mat[i,0] / mat[0,0];
                for (int k = 1; k < dim; k++)
                {
                    a.mat[i - 1, k - 1] = mat[i,k] - mat[0,k]*x;
                }
            }
            return mat[0,0]*a.DET();
        }

        public void stampajBIN()
        {
            throw new NotImplementedException();
        }

        public void stampajSTD()
        {
            throw new NotImplementedException();
        }

        
    }
}
