
namespace ProphetRev4PatchManager
{
    /// <summary>
    /// Abstraction for CC message
    /// </summary>
    public struct ContinuousController
    {
        private int _number;
        private string _paramName;
        private int _minValue;
        private int _maxValue;
        private int _paramValue;
        /// <summary>
        /// 
        /// </summary>
        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ParameterName
        {
            get { return _paramName; }
            set { _paramName = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int MinimumValue
        {
            get { return _minValue; }
            set { _minValue = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int MaximumValue
        {
            get { return _maxValue; }
            set { _maxValue = value; }
        }
        /// <summary>
        /// 
        /// </summary>
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
