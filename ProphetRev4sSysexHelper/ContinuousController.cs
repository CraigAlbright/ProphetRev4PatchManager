
namespace ProphetRev4sSysexHelper
{
    public struct ContinuousController
    {
        private int _number;
        private string _paramName;
        private int _minValue;
        private int _maxValue;
        private int _paramValue;
        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }
        public string ParameterName
        {
            get { return _paramName; }
            set { _paramName = value; }
        }
        public int MinimumValue
        {
            get { return _minValue; }
            set { _minValue = value; }
        }
        public int MaximumValue
        {
            get { return _maxValue; }
            set { _maxValue = value; }
        }
        //clamp to min max value
        public int ParameterValue
        {
            get { return _paramValue; }
            set
            {
                if (value < _minValue)
                {
                    _paramValue = _minValue;
                    return;
                }
                if (value > _maxValue)
                {
                    _paramValue = _maxValue;
                    return;
                }
                _paramValue = value;
            }
        }
    }
}
