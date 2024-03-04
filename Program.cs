﻿using Lab4;

double x = 2.184881044606, x0 = 2.17, x1 = 2.2, x2 = 2.16, e0 = 1E-3, e1 = 1E-5, e2 = 1E-6, e3 = 1E-8;

NonlinearEquationSolution.DivisionInHalf(x0, x1, e0, x);
NonlinearEquationSolution.SecantAlgorithm(x2, x0, x, e1);