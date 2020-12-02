using System;
using CoreMidi;

namespace ProphetRev4sSysexHelper
{
    public class SysexHandler
    {
        public SysexHandler()
        {
        }

        void GetSysex()
        {
            var client = new MidiClient("client");
            var port = client.CreateInputPort("PortRev4");
            

        }
    }
}
