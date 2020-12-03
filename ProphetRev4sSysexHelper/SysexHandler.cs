using System;
using CoreMidi;

namespace ProphetRev4PatchManager
{
    /// <summary>
    /// 
    /// </summary>
    public class SysexHandler
    {
        /// <summary>
        /// 
        /// </summary>
        public SysexHandler()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        public void GetSysex()
        {
            var client = new MidiClient("client");
            var port = client.CreateInputPort("PortRev4");
            

        }
    }
}
