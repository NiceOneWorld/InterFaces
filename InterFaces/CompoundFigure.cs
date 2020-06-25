﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InterFaces
{
    public class CompoundFigure
    {
        private Simple[] _simples;
        public CompoundFigure(int count) => _simples = new Simple[count];
        public void AddFigure(Simple figure)
        {
            for (int i = 0; i < _simples.Length; i++)
            {
                if (_simples[i] == null)
                {
                    _simples[i] = figure;
                    break;
                }
            }
        }

        public double FindArea()
        {
            double sum = 0;
            for (int i = 0; i < _simples.Length; i++)
            {
                if (_simples[i] is Square)
                    sum += ((Square)_simples[i]).Area();
                else if (_simples[i] is Rectangle)
                    sum += ((Rectangle)_simples[i]).Area();
                else if (_simples[i] is Rhombus)
                    sum += ((Rhombus)_simples[i]).Area();
                else if (_simples[i] is Parallelogram)
                    sum += ((Parallelogram)_simples[i]).Area();
                else if (_simples[i] is Triangle)
                    sum += ((Triangle)_simples[i]).Area();
            }
            return sum;
        }
    }
}
