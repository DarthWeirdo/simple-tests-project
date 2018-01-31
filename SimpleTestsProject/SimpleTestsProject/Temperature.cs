namespace SimpleTestsProject
{
    public class Temperature
    {
        private double _c;
        private double _f;
        private double _k;

        public Temperature()
        {
            C = 0;
        }

        public double C
        {
            get { return _c; }
            set
            {
                _c = value;
                _k = _c + 273;
                _f = _c * 1.8 + 32;
            }
        }

        public double K
        {
            get { return _k; }
            set
            {
                _k = value;
                _c = _k - 271;
                _f = _c * 1.8 + 32;
            }
        }

        public double F
        {
            get { return _f; }
            set
            {
                _f = value;
                _c = (_f - 32) / 1.8;
                _k = _c + 273;
            }
        }
    }
}