
namespace ProphetRev4PatchManager
{
    /// <summary>
    /// Stuct for NRPNs 
    /// </summary>
    public struct NonRegisteredParameterNumber
    {
        // format is   NRPN #  MidiCh   Second    Third
        //              0000    nnnn    0kkkkkkk 0vvvvvvv
        private int _number;
        private int _channelNumber;
        private int _status;
        private int _second;
        private int _third;
        private string _description;
        private string _name;
        private int _minValue;
        private int _maxValue;
        private NrpnType _nrpnType;

        /// <summary>
        /// 
        /// </summary>
        public int Number
        {
            get
            {
                return _number;
            }
            set
            {
                _number = value;
            }

        }
        /* midi channel number 0-15 = channel 1-16
         0 	0000 0
         1 	0001 1
         2 	0010 2
         3 	0011 3
         4 	0100 4
         5 	0101 5
         6 	0110 6
         7 	0111 7
         8 	1000 8
         9 	1001 9
         10 1010 A
         11 1011 B
         12 1100 C
         13 1101 D
         14 1110 E
         15 1111 F
        */
        /// <summary>
        /// 
        /// </summary>
        public int ChannelNumber
        {
            get
            {
                return _channelNumber;
            }
            set
            {
                if (value < 0 || value > 16)
                {
                    _channelNumber = 0;
                    return;
                }
            }
        }
        //1000 - Note Off
        //1001 - Note On
        //1010 - Polyphonic Key Pressure
        //1011 - Control Change
        //1100 - Program Change
        //1101 - Channel Pressure
        //1110 - Pitch Bend
        /// <summary>
        /// 
        /// </summary>
        public int Status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
            }

        }
        //Second Value usually the MSB or 0
        /// <summary>
        /// 
        /// </summary>
        public int Second
        {
            get
            {
                return _second;
            }
            //clamp to min max
            set
            {
                if(value < _minValue)
                {
                    _second = _minValue;
                    return;
                }
                if (value > _maxValue)
                {
                    _second = _maxValue;
                    return;
                }
                _second = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        //Third Value- usually the actual control value but could be LSB
        public int Third
        {
            get
            {
                return _third;
            }
            //clamp to min max
            set
            {
                if (value < _minValue)
                {
                    _third = _minValue;
                    return;
                }
                if (value > _maxValue)
                {
                    _third = _maxValue;
                    return;
                }
                _third = value;
            }
        }
        //Nrpn description
        /// <summary>
        /// 
        /// </summary>
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }
        //Nrpn Name
        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        //Used to clamp values
        public int MinimumValue
        {
            get
            {
                return _minValue;
            }
            set
            {
                _minValue = value;
            }
        }
        //Used to clamp values
        /// <summary>
        /// 
        /// </summary>
        public int MaximumValue
        {
            get
            {
                return _maxValue;
            }
            set
            {
                _maxValue = value;
            }
        }
        //NrpnType Type- received message, cc message or sysex mesage
        /// <summary>
        /// 
        /// </summary>
        public NrpnType NrpnType
        {
            get
            {
                return _nrpnType;
            }
            set
            {
                _nrpnType = value;
            }
        }
    }
    /// <summary>
    /// 
    /// </summary>
    public enum NrpnType
    {
        /// <summary>
        /// 
        /// </summary>
        Midi = 0,
        /// <summary>
        /// 
        /// </summary>
        Received = 1,
        /// <summary>
        /// 
        /// </summary>
        Control = 2,
        /// <summary>
        /// 
        /// </summary>
        SysEx = 3
    }
}
