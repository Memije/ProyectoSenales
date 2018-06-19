using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ProyectoSenales
{
    class FFT
    {
        public static Complex [] DFT(Complex[] data)
        {
            int n = data.Length;
            int m = n;
            double[] real = new double[n];
            double[] imag = new double[n];
            Complex[] result = new Complex[n];            
            for (int w = 0; w < m; w++)
            {                
                for (int t = 0; t < n; t++)
                {
                    double angle = 2.0 * Math.PI * t * w / n;
                    real[w] += data[t].Real * Math.Cos(angle);
                    imag[w] += -data[t].Real * Math.Sin(angle);
                }
                result[w] = new Complex(real[w], imag[w]);
            }
            return result;
        }        

        public static Complex[] RecursiveFFT(Complex[] a)
        {
            int n = a.Length;
            int n2 = n / 2;

            if (n == 1)
                return a;

            Complex z = new Complex(0.0, 2.0 * Math.PI / n);
            Complex omegaN = Complex.Exp(z);
            Complex omega = new Complex(1.0, 0.0);
            Complex[] a0 = new Complex[n2];
            Complex[] a1 = new Complex[n2];
            Complex[] y0 = new Complex[n2];
            Complex[] y1 = new Complex[n2];
            Complex[] y = new Complex[n];

            for (int i = 0; i < n2; i++)
            {
                a0[i] = new Complex(0.0, 0.0);
                a0[i] = a[2 * i];
                a1[i] = new Complex(0.0, 0.0);
                a1[i] = a[2 * i + 1];
            }

            y0 = RecursiveFFT(a0);
            y1 = RecursiveFFT(a1);

            for (int k = 0; k < n2; k++)
            {
                y[k] = new Complex(0.0, 0.0);
                y[k] = y0[k] + (y1[k] * omega);
                y[k + n2] = new Complex(0.0, 0.0);
                y[k + n2] = y0[k] - (y1[k] * omega);
                omega = omega * omegaN;
            }

            return y;
        }

        public static int BitReverse(int n, int bits)
        {
            int reversedN = n;
            int count = bits - 1;

            n >>= 1;
            while (n > 0)
            {
                reversedN = (reversedN << 1) | (n & 1);
                count--;
                n >>= 1;
            }
            return ((reversedN << count) & ((1 << bits) - 1));
        }     

        public static void FFT_Calc(Complex[] buffer)
        {
            int bits = (int)Math.Log(buffer.Length, 2);
            for (int j = 1; j < buffer.Length / 2; j++)
            {

                int swapPos = BitReverse(j, bits);
                var temp = buffer[j];
                buffer[j] = buffer[swapPos];
                buffer[swapPos] = temp;
            }
            for (int N = 2; N <= buffer.Length; N <<= 1)
            {
                for (int i = 0; i < buffer.Length; i += N)
                {
                    for (int k = 0; k < N / 2; k++)
                    {

                        int evenIndex = i + k;
                        int oddIndex = i + k + (N / 2);
                        var even = buffer[evenIndex];
                        var odd = buffer[oddIndex];

                        double term = -2 * Math.PI * k / (double)N;
                        Complex exp = new Complex(Math.Cos(term), Math.Sin(term)) * odd;

                        buffer[evenIndex] = even + exp;
                        buffer[oddIndex] = even - exp;

                    }
                }
            }
        }
    }    
}
