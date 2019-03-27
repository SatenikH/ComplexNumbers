using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumbers
{
    public class Complex
    {
        double re; //real
        double im; //imaginary

        public Complex(double re, double im)
        {
            this.re = re;
            this.im = im;
        }

        public double Re
        {
            get
            {
                return (re);
            }
            set
            {
                re = value;
            }
        }

        public double Im
        {
            get
            {
                return (im);
            }
            set
            {
                im = value;
            }
        }

        public override string ToString()
        {
            return (String.Format("({0}, {1}i)", re, im));
        }

        public static bool operator ==(Complex complexNum1, Complex complexNum2)
        {
            if ((complexNum1.re == complexNum2.re) && (complexNum1.im == complexNum2.im))
                return (true);
            else
                return (false);
        }
        public static bool operator !=(Complex complexNum1, Complex complexNum2)
        {
            return (!(complexNum1 == complexNum2));
        }
       
        public override bool Equals(Object obj)
        {
            Complex complexNum2 = obj as Complex;
            if (complexNum2 == null)
                return false;
            else
                return (this == complexNum2);
        }

        public override int GetHashCode()
        {
            return (re.GetHashCode() ^ im.GetHashCode());
        }

        public static Complex operator +(Complex complexNum1, Complex complexNum2)
        {
            return (new Complex(complexNum1.re + complexNum2.re, complexNum1.im + complexNum2.im));
        }

        public static Complex operator -(Complex complexNum1, Complex complexNum2)
        {
            return (new Complex(complexNum1.re - complexNum2.re, complexNum1.im - complexNum2.im));
        }

        public static Complex operator *(Complex complexNum1, Complex complexNum2)
        {
            return (new Complex(complexNum1.re * complexNum2.re - complexNum1.im * complexNum2.im, complexNum1.re * complexNum2.im + complexNum2.re * complexNum1.im));
        }

        public static Complex operator /(Complex complexNum1, Complex complexNum2)
        {
            double newRe = (complexNum1.re * complexNum2.re + complexNum1.im * complexNum2.im) / (complexNum2.re * complexNum2.re + complexNum2.im * complexNum2.im);
            double newIm = (complexNum2.re * complexNum1.im - complexNum1.re * complexNum2.im) / (complexNum2.re * complexNum2.re + complexNum2.im * complexNum2.im);

            return (new Complex(newRe, newIm));
        }
    }
}
