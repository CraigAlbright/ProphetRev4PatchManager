
namespace ProphetRev4PatchManager
{
    /// <summary>
    /// 
    /// </summary>
    public class MidiMessage
    {

        private int _midiMessageNumber;
        private int _channelNumber;
        private int _noteNumber;
        private int _value;

        /// <summary>
        /// 
        /// </summary>
        public int MidiMessageNumber
        {
            get
            {
                return _midiMessageNumber;
            }
            set
            {
                _midiMessageNumber = value;
            }
        }

        /// <summary>
        /// not sure how to represent all just yet, but 0-15 binary for channels 1-16
        /// </summary>
        public int MidiChannelNumber
        {
            get
            {
                return _channelNumber;
            }
            set
            {
                _channelNumber = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public int NoteNumber
        {
            get
            {
                return _noteNumber;
            }
            set
            {
                _noteNumber = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public int NoteValue
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="messageNumber"></param>
        /// <param name="channelNumber"></param>
        /// <param name="noteNumber"></param>
        /// <param name="noteValue"></param>
        public MidiMessage(int messageNumber, int channelNumber, int noteNumber, int noteValue)
        {
            _midiMessageNumber = messageNumber;
            _channelNumber = channelNumber;
            _noteNumber = noteNumber;
            _value = noteValue;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="channelNumber"></param>
        /// <param name="noteNumber"></param>
        /// <returns></returns>
        public static MidiMessage NoteOff(int channelNumber, int noteNumber)
        {
            var midiMessageNumber = 0b1000;
            var value = 0;
            return new MidiMessage(midiMessageNumber, channelNumber, noteNumber, value);
        }
    }
    
}
