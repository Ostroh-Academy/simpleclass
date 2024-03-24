namespace L2
{
/*Варіант6*/
    class SineFunction
        {
            private double a;
            private double b;
            public SineFunction(double a, double b)
            {
                this.a = a;
                this.b = b;
            }
            public double Est(double x)
            {
                return Math.Sin(a * x + b);
            }
            public string MaxX(double x)
            {
                double value = Est(x);
                double epsilon = 0.0001;
                double lValue = Est(x - epsilon);
                double rValue = Est(x + epsilon);

                if (value >= lValue && value >= rValue)
                {
                    return $"функцiя набуває найбiльшого значення у точцi x = {x}";
                }
                else
                {
                    return $"функцiя не набуває найбiльшого значення у точцi x = {x}";
                }
            }
        }
}