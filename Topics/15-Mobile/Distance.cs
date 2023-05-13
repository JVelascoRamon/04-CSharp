public static class DistanceClass
    {
        public static double Distance(Euclidean3D A, Euclidean3D B)
        {
            return Math.Sqrt(Math.Pow(A._xCoord - B._xCoord, 2) + Math.Pow(A._yCoord - B._yCoord, 2) + Math.Pow(A._zCoord - B._zCoord, 2));
        }
    }