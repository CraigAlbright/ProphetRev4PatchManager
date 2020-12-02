
namespace ProphetRev4sSysexHelper
{
    public class MidiMessage
    {

        private int _midiMessageNumber;
        private int _channelNumber;
        private int _noteNumber;
        private int _value;

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
        //not sure how to represent all just yet, but 0-15 binary for channels 1-16
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

        public MidiMessage(int messageNumber, int channelNumber, int noteNumber, int noteValue)
        {
            _midiMessageNumber = messageNumber;
            _channelNumber = channelNumber;
            _noteNumber = noteNumber;
            _value = noteValue;
        }

        public static MidiMessage NoteOff(int channelNumber, int noteNumber)
        {
            var midiMessageNumber = 0b1000;
            var value = 0;
            return new MidiMessage(midiMessageNumber, channelNumber, noteNumber, value);
        }
    }
    
}
