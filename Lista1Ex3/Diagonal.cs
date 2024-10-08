﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex3
{
    internal class Diagonal
    {
        private int d;
        private double area;
        public void setDiagonal(int d)
        {
            this.d = d;
        }
        public int getDiagonal()
        {
            return this.d;
        }

        public double getArea()
        {
            return this.area;
        }
        public void calcularArea()
        {
            this.area = Math.Pow(d, 2) / 2;
        }
    }
}
