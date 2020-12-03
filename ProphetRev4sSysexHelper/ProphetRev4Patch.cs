using System.Collections.Generic;

namespace ProphetRev4PatchManager
{
    /// <summary>
    /// Abstraction of a patch for the Rev4 prophet. Basically a container
    /// of all CC values for the controls
    /// </summary>
    public class ProphetRev4Patch
    {
        /// <summary>
        /// Lookup dictionary for CCs while each exists as a property, thinking
        /// that in the future will possibly remove the properties and only
        /// use this collection. But since Im still sketching this out, leaving
        /// in for now until I know how it will work.
        /// </summary>
        public Dictionary<int, ContinuousController> Rev4PatchParameters { get; private set; }

        /// <summary>
        /// Default Constructor creates a default patch
        /// </summary>
        public ProphetRev4Patch()
        {
            Rev4PatchParameters = new Dictionary<int,ContinuousController>();
            CreateDefaultPatch();
        }

        /// <summary>
        /// If you want to create a patch by passing in some or all parameters
        ///initialize the same way as the default constructor, but set the values
        ///usung the CCs passed into the constructor. This will allow
        ///creation of a patch using only the parameters you care about and
        ///doesnt require every parameter to be part of the collection.
        /// </summary>
        /// <param name="parameters"></param>
        public ProphetRev4Patch(IEnumerable<ContinuousController> parameters)
        {           
            Rev4PatchParameters = new Dictionary<int, ContinuousController>();
            CreateDefaultPatch();

            foreach (var cc in parameters)
            {

                if(Rev4PatchParameters.TryGetValue(cc.Number,out var currentParameter))
                {
                    currentParameter.ParameterValue = cc.ParameterValue;
                }
            }
        }

        #region CC properties
        //Create place for all the CCs to reside
        /// <summary>
        /// 
        /// </summary>
        public ContinuousController OscilatorAFrequency { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public ContinuousController MasterVolume { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public ContinuousController OscilatorBFrequency { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public ContinuousController OscilatorBFineTune { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public ContinuousController OscilatorASawOnOff { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public ContinuousController OscilatorASquareOnOff { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public ContinuousController OscilatorAPulseWidth { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public ContinuousController OscilatorBPulseWidth { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public ContinuousController OscilatorSyncOnOff { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public ContinuousController OscilatorBLowFreqOnOff { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public ContinuousController OscilatorBKeyboardOnOff { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public ContinuousController GlideRate { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public ContinuousController OscilatorALevel { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public ContinuousController OscilatorBLevel { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public ContinuousController NoiseLevel { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public ContinuousController OscilatorBSawOnOff { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public ContinuousController Resonance { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public ContinuousController FilterKeyboardTrackOffHalfFull { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public ContinuousController FilterRevSelect { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public ContinuousController LFOFrequency { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public ContinuousController LFOInitialAmount { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public ContinuousController OscilatorBTriOnOff { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public ContinuousController LFOSourceMix { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public ContinuousController LFOFreqAOnOff { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public ContinuousController LFOFreqBOnOff { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public ContinuousController LFOFreqPWAOnOff { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public ContinuousController LFOFreqPWBOnOff { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public ContinuousController LFOFilterOnOff { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public ContinuousController PolyModFiltEnvAmount { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public ContinuousController PolyModOscBAmount { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public ContinuousController PolyModFreqAOnOff { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public ContinuousController PolyModPWOnOff { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public ContinuousController PolyModFilterOnOff { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public ContinuousController PitchWheelRange { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public ContinuousController RetriggerAndUnisonAssign { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public ContinuousController Cutoff { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public ContinuousController Brightness { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public ContinuousController Vintage { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public ContinuousController PressureFilter { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public ContinuousController PressureLFO { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public ContinuousController EnvelopeFilterAmount { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public ContinuousController EnvelopeFilterVelocityOnOff { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public ContinuousController EnvelopeVCAVelocityOnOff { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public ContinuousController AttackFilter { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public ContinuousController AttackVCA { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public ContinuousController DecayFilter { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public ContinuousController DecayVCA { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public ContinuousController SustainFilter { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public ContinuousController SustainVCA { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public ContinuousController ReleaseFilter { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public ContinuousController ReleaseVCA { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public ContinuousController ReleaseOnOff { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public ContinuousController UnisonOnOff { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public ContinuousController UnisonVoiceCount { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public ContinuousController UnisonDetune { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public ContinuousController OscilatorBSquareOnOff { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public ContinuousController LFOSawOnOff { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public ContinuousController LFOTriOnOff { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public ContinuousController LFOSquareOnOff { get; private set; }
        #endregion

        /// <summary>
        /// initializes a default patch of CC messages. Used when class is initialized or method is called from Editor
        /// Also want this in a Dictionary for quick access by CC#
        /// </summary>
        public void CreateDefaultPatch()
        {
            // Set up a Default patch with Saw wave on OSC A
            OscilatorAFrequency = new ContinuousController { MaximumValue = 120, MinimumValue = 0, Number = 3, ParameterName = "OSC A FREQUENCY", ParameterValue = 60 };
            Rev4PatchParameters.Add(3,OscilatorAFrequency);
            MasterVolume = new ContinuousController { MaximumValue = 120, MinimumValue = 0, Number = 7, ParameterName = "MASTER VOLUME", ParameterValue = 100 };
            Rev4PatchParameters.Add(7,MasterVolume);
            OscilatorBFrequency = new ContinuousController { MaximumValue = 120, MinimumValue = 0, Number = 9, ParameterName = "OSC B FREQUENCY", ParameterValue = 60 };
            Rev4PatchParameters.Add(9,OscilatorBFrequency);
            OscilatorBFineTune = new ContinuousController { MaximumValue = 127, MinimumValue = 0, Number = 14, ParameterName = "OSC B FINE TUNE", ParameterValue = 0 };
            Rev4PatchParameters.Add(14, OscilatorBFineTune);
            OscilatorASawOnOff = new ContinuousController { MaximumValue = 1, MinimumValue = 0, Number = 15, ParameterName = "OSC A SAW ON/FF", ParameterValue = 1 };
            Rev4PatchParameters.Add(15, OscilatorASawOnOff);
            OscilatorASquareOnOff = new ContinuousController { MaximumValue = 1, MinimumValue = 0, Number = 20, ParameterName = "OSC A SQUARE ON/FF", ParameterValue = 0 };
            Rev4PatchParameters.Add(20, OscilatorASquareOnOff);
            OscilatorAPulseWidth = new ContinuousController { MaximumValue = 120, MinimumValue = 0, Number = 21, ParameterName = "OSC A PULSE WIDTH", ParameterValue = 100 };
            Rev4PatchParameters.Add(21, OscilatorAPulseWidth);
            OscilatorBPulseWidth = new ContinuousController { MaximumValue = 120, MinimumValue = 0, Number = 22, ParameterName = "OSC B PULSE WIDTH", ParameterValue = 100 };
            Rev4PatchParameters.Add(22, OscilatorBPulseWidth);
            OscilatorSyncOnOff = new ContinuousController { MaximumValue = 1, MinimumValue = 0, Number = 23, ParameterName = "OSC SYNC ON/OFF", ParameterValue = 0 };
            Rev4PatchParameters.Add(23, OscilatorSyncOnOff);
            OscilatorBLowFreqOnOff = new ContinuousController { MaximumValue = 1, MinimumValue = 0, Number = 24, ParameterName = "OSC B LOW FREQ ON/OFF", ParameterValue = 0 };
            Rev4PatchParameters.Add(24, OscilatorBLowFreqOnOff);
            OscilatorBKeyboardOnOff = new ContinuousController { MaximumValue = 1, MinimumValue = 0, Number = 25, ParameterName = "OSC B KEYBOARD ON/OFF", ParameterValue = 0 };
            Rev4PatchParameters.Add(25, OscilatorBKeyboardOnOff);
            GlideRate = new ContinuousController { MaximumValue = 120, MinimumValue = 0, Number = 26, ParameterName = "GLIDE RATE", ParameterValue = 0 };
            Rev4PatchParameters.Add(26, GlideRate);
            OscilatorALevel = new ContinuousController { MaximumValue = 120, MinimumValue = 0, Number = 27, ParameterName = "OSC A LEVEL", ParameterValue = 0 };
            Rev4PatchParameters.Add(27, OscilatorALevel);
            OscilatorBLevel = new ContinuousController { MaximumValue = 120, MinimumValue = 0, Number = 28, ParameterName = "OSC B LEVEL", ParameterValue = 0 };
            Rev4PatchParameters.Add(28, OscilatorBLevel);
            NoiseLevel = new ContinuousController { MaximumValue = 120, MinimumValue = 0, Number = 29, ParameterName = "NOISE LEVEL", ParameterValue = 0 };
            Rev4PatchParameters.Add(29, NoiseLevel);
            OscilatorBSawOnOff = new ContinuousController { MaximumValue = 1, MinimumValue = 0, Number = 30, ParameterName = "OSC B SAW ON/OFF", ParameterValue = 0 };
            Rev4PatchParameters.Add(30, OscilatorBSawOnOff);
            Resonance = new ContinuousController { MaximumValue = 120, MinimumValue = 0, Number = 31, ParameterName = "RESONANCE", ParameterValue = 0 };
            Rev4PatchParameters.Add(31, Resonance);
            FilterKeyboardTrackOffHalfFull = new ContinuousController { MaximumValue = 2, MinimumValue = 0, Number = 35, ParameterName = "FILTER KEYBOARD TRACK OFF/HALF/FULL", ParameterValue = 0 };
            Rev4PatchParameters.Add(35, FilterKeyboardTrackOffHalfFull);
            FilterRevSelect = new ContinuousController { MaximumValue = 1, MinimumValue = 0, Number = 41, ParameterName = "FILTER REV SELECT", ParameterValue = 1 };
            Rev4PatchParameters.Add(41, FilterRevSelect);
            LFOFrequency = new ContinuousController { MaximumValue = 120, MinimumValue = 0, Number = 46, ParameterName = "LFO FREQUENCY", ParameterValue = 0 };
            Rev4PatchParameters.Add(46, LFOFrequency);
            LFOInitialAmount = new ContinuousController { MaximumValue = 120, MinimumValue = 0, Number = 47, ParameterName = "LFO INITIAL AMOUNT", ParameterValue = 0 };
            Rev4PatchParameters.Add(47, LFOInitialAmount);
            OscilatorBTriOnOff = new ContinuousController { MaximumValue = 1, MinimumValue = 0, Number = 52, ParameterName = "OSC B TRI ON/OFF", ParameterValue = 0 };
            Rev4PatchParameters.Add(52, OscilatorBTriOnOff);
            LFOSourceMix = new ContinuousController { MaximumValue = 120, MinimumValue = 0, Number = 53, ParameterName = "LFO SOURCE MIX", ParameterValue = 0 };
            Rev4PatchParameters.Add(52, LFOSourceMix);
            LFOFreqAOnOff = new ContinuousController { MaximumValue = 1, MinimumValue = 0, Number = 54, ParameterName = "LFO FREQ A ON/OFF", ParameterValue = 0 };
            Rev4PatchParameters.Add(54, LFOFreqAOnOff);
            LFOFreqBOnOff = new ContinuousController { MaximumValue = 1, MinimumValue = 0, Number = 55, ParameterName = "LFO FREQ B ON/OFF", ParameterValue = 0 };
            Rev4PatchParameters.Add(55, LFOFreqBOnOff);
            LFOFreqPWAOnOff = new ContinuousController { MaximumValue = 1, MinimumValue = 0, Number = 56, ParameterName = "LFO FREQ PW A ON/OFF", ParameterValue = 0 };
            Rev4PatchParameters.Add(56, LFOFreqPWAOnOff);
            LFOFreqPWBOnOff = new ContinuousController { MaximumValue = 1, MinimumValue = 0, Number = 57, ParameterName = "LFO FREQ PW B ON/OFF", ParameterValue = 0 };
            Rev4PatchParameters.Add(57, LFOFreqPWBOnOff);
            LFOFilterOnOff = new ContinuousController { MaximumValue = 1, MinimumValue = 0, Number = 58, ParameterName = "LFO FILTER ON/OFF", ParameterValue = 0 };
            Rev4PatchParameters.Add(58, LFOFilterOnOff);
            PolyModFiltEnvAmount = new ContinuousController { MaximumValue = 127, MinimumValue = 0, Number = 59, ParameterName = "POLY MOD FILT ENV AMOUNT", ParameterValue = 0 };
            Rev4PatchParameters.Add(59, PolyModFiltEnvAmount);
            PolyModOscBAmount = new ContinuousController { MaximumValue = 120, MinimumValue = 0, Number = 60, ParameterName = "POLY MOD OSC B AMOUNT", ParameterValue = 0 };
            Rev4PatchParameters.Add(60, PolyModOscBAmount);
            PolyModFreqAOnOff = new ContinuousController { MaximumValue = 1, MinimumValue = 0, Number = 61, ParameterName = "POLYMOD FREQ A ON/OFF", ParameterValue = 0 };
            Rev4PatchParameters.Add(61, PolyModFreqAOnOff);
            PolyModPWOnOff = new ContinuousController { MaximumValue = 1, MinimumValue = 0, Number = 62, ParameterName = "POLY MOD PW ON/OFF", ParameterValue = 0 };
            Rev4PatchParameters.Add(62, PolyModPWOnOff);
            PolyModFilterOnOff = new ContinuousController { MaximumValue = 1, MinimumValue = 0, Number = 63, ParameterName = "POLY MOD FILTER ON/OFF", ParameterValue = 0 };
            Rev4PatchParameters.Add(63, PolyModFilterOnOff);
            PitchWheelRange = new ContinuousController { MaximumValue = 11, MinimumValue = 0, Number = 70, ParameterName = "PITCH WHEEL RANGE", ParameterValue = 2 };
            Rev4PatchParameters.Add(70, PitchWheelRange);
            RetriggerAndUnisonAssign = new ContinuousController { MaximumValue = 3, MinimumValue = 0, Number = 71, ParameterName = "RETRIGGER AND UNISON ASSIGN", ParameterValue = 0 };
            Rev4PatchParameters.Add(71, RetriggerAndUnisonAssign);
            Cutoff = new ContinuousController { MaximumValue = 120, MinimumValue = 0, Number = 73, ParameterName = "CUTOFF", ParameterValue = 120 };
            Rev4PatchParameters.Add(73, Cutoff);
            Brightness = new ContinuousController { MaximumValue = 127, MinimumValue = 0, Number = 74, ParameterName = "BRIGHTNESS", ParameterValue = 127 };
            Rev4PatchParameters.Add(74, Brightness);
            Vintage = new ContinuousController { MaximumValue = 127, MinimumValue = 0, Number = 85, ParameterName = "VINTAGE", ParameterValue = 0 };
            Rev4PatchParameters.Add(85, Vintage);
            PressureFilter = new ContinuousController { MaximumValue = 1, MinimumValue = 0, Number = 86, ParameterName = "PRESSURE FILTER", ParameterValue = 0 };
            Rev4PatchParameters.Add(86, PressureFilter);
            PressureLFO = new ContinuousController { MaximumValue = 1, MinimumValue = 0, Number = 87, ParameterName = "PRESSURE LFO", ParameterValue = 0 };
            Rev4PatchParameters.Add(87, PressureLFO);
            EnvelopeFilterAmount = new ContinuousController { MaximumValue = 120, MinimumValue = 0, Number = 88, ParameterName = "ENVELOPE FILTER AMOUNT", ParameterValue = 0 };
            Rev4PatchParameters.Add(88, EnvelopeFilterAmount);
            EnvelopeFilterVelocityOnOff = new ContinuousController { MaximumValue = 1, MinimumValue = 0, Number = 90, ParameterName = "ENVELOPE FILTER VELOCITY ON/OFF", ParameterValue = 0 };
            Rev4PatchParameters.Add(90, EnvelopeFilterVelocityOnOff);
            EnvelopeVCAVelocityOnOff = new ContinuousController { MaximumValue = 1, MinimumValue = 0, Number = 102, ParameterName = "ENVELOPE VCA VELOCITY ON/OFF", ParameterValue = 0 };
            Rev4PatchParameters.Add(102, EnvelopeVCAVelocityOnOff);
            AttackFilter = new ContinuousController { MaximumValue = 120, MinimumValue = 0, Number = 103, ParameterName = "ATTACK FILTER", ParameterValue = 0 };
            Rev4PatchParameters.Add(103, AttackFilter);
            AttackVCA = new ContinuousController { MaximumValue = 120, MinimumValue = 0, Number = 104, ParameterName = "ATTACK VCA", ParameterValue = 0 };
            Rev4PatchParameters.Add(104, AttackVCA);
            DecayFilter = new ContinuousController { MaximumValue = 120, MinimumValue = 0, Number = 105, ParameterName = "DECAY FILTER", ParameterValue = 0 };
            Rev4PatchParameters.Add(105, DecayFilter);
            DecayVCA = new ContinuousController { MaximumValue = 120, MinimumValue = 0, Number = 106, ParameterName = "DECAY VCA", ParameterValue = 0 };
            Rev4PatchParameters.Add(106, DecayVCA);
            SustainFilter = new ContinuousController { MaximumValue = 120, MinimumValue = 0, Number = 107, ParameterName = "SUSTAIN FILTER", ParameterValue = 0 };
            Rev4PatchParameters.Add(107, SustainFilter);
            SustainVCA = new ContinuousController { MaximumValue = 120, MinimumValue = 0, Number = 108, ParameterName = "SUSTAIN VCA", ParameterValue = 120 };
            Rev4PatchParameters.Add(108, SustainVCA);
            ReleaseFilter = new ContinuousController { MaximumValue = 120, MinimumValue = 0, Number = 109, ParameterName = "RELEASE FILTER", ParameterValue = 0 };
            Rev4PatchParameters.Add(109, ReleaseFilter);
            ReleaseVCA = new ContinuousController { MaximumValue = 120, MinimumValue = 0, Number = 110, ParameterName = "RELEASE VCA", ParameterValue = 0 };
            Rev4PatchParameters.Add(110, ReleaseVCA);
            ReleaseOnOff = new ContinuousController { MaximumValue = 1, MinimumValue = 0, Number = 111, ParameterName = "RELEASE ON/OFF", ParameterValue = 1 };
            Rev4PatchParameters.Add(111, ReleaseOnOff);
            UnisonOnOff = new ContinuousController { MaximumValue = 1, MinimumValue = 0, Number = 112, ParameterName = "UNISON ON/OFF", ParameterValue = 0 };
            Rev4PatchParameters.Add(112, UnisonOnOff);
            UnisonVoiceCount = new ContinuousController { MaximumValue = 10, MinimumValue = 0, Number = 113, ParameterName = "UNISON VOICE COUNT", ParameterValue = 0 };
            Rev4PatchParameters.Add(113, UnisonVoiceCount);
            UnisonDetune = new ContinuousController { MaximumValue = 7, MinimumValue = 0, Number = 114, ParameterName = "UNISON DETUNE", ParameterValue = 0 };
            Rev4PatchParameters.Add(114, UnisonDetune);
            OscilatorBSquareOnOff = new ContinuousController { MaximumValue = 1, MinimumValue = 0, Number = 116, ParameterName = "OSC B SQUARE ON/OFF", ParameterValue = 0 };
            Rev4PatchParameters.Add(116, OscilatorBSquareOnOff);
            LFOSawOnOff = new ContinuousController { MaximumValue = 1, MinimumValue = 0, Number = 117, ParameterName = "LFO SAW ON/OFF", ParameterValue = 0 };
            Rev4PatchParameters.Add(117, LFOSawOnOff);
            LFOTriOnOff = new ContinuousController { MaximumValue = 1, MinimumValue = 0, Number = 118, ParameterName = "LFO TRI ON/OFF", ParameterValue = 0 };
            Rev4PatchParameters.Add(118, LFOTriOnOff);
            LFOSquareOnOff = new ContinuousController { MaximumValue = 1, MinimumValue = 0, Number = 119, ParameterName = "LFO SQUARE ON/OFF", ParameterValue = 0 };
            Rev4PatchParameters.Add(119, LFOSquareOnOff);
        }
    }
}
