using System.Collections.Generic;

namespace ProphetRev4sSysexHelper
{
    public class ProphetRev4Patch
    {

        public Dictionary<int, ContinuousController> Rev4PatchParameters { get; private set; }
        public ProphetRev4Patch()
        {
            Rev4PatchParameters = new Dictionary<int,ContinuousController>();
            CreateDefaultPatch();
        }

        public ProphetRev4Patch(IEnumerable<ContinuousController> parameters)
        {
            //initialize the same way as the default constructor, but set the values
            //usung the CCs passed into the constructor. This will allow
            //creation of a patch using only the parameters you care about and
            //doesnt require every parameter to be part of the collection.
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
        public ContinuousController OscilatorAFrequency { get; set; }
        public ContinuousController MasterVolume { get; set; }
        public ContinuousController OscilatorBFrequency { get; set; }
        public ContinuousController OscilatorBFineTune { get; set; }
        public ContinuousController OscilatorASawOnOff { get; set; }
        public ContinuousController OscilatorASquareOnOff { get; set; }
        public ContinuousController OscilatorAPulseWidth { get; set; }
        public ContinuousController OscilatorBPulseWidth { get; set; }
        public ContinuousController OscilatorSyncOnOff { get; set; }
        public ContinuousController OscilatorBLowFreqOnOff { get; set; }
        public ContinuousController OscilatorBKeyboardOnOff { get; set; }
        public ContinuousController GlideRate { get; set; }
        public ContinuousController OscilatorALevel { get; set; }
        public ContinuousController OscilatorBLevel { get; set; }
        public ContinuousController NoiseLevel { get; set; }
        public ContinuousController OscilatorBSawOnOff { get; set; }
        public ContinuousController Resonance { get; set; }
        public ContinuousController FilterKeyboardTrackOffHalfFull { get; set; }
        public ContinuousController FilterRevSelect { get; set; }
        public ContinuousController LFOFrequency { get; set; }
        public ContinuousController LFOInitialAmount { get; set; }
        public ContinuousController OscilatorBTriOnOff { get; set; }
        public ContinuousController LFOSourceMix { get; set; }
        public ContinuousController LFOFreqAOnOff { get; set; }
        public ContinuousController LFOFreqBOnOff { get; set; }
        public ContinuousController LFOFreqPWAOnOff { get; set; }
        public ContinuousController LFOFreqPWBOnOff { get; set; }
        public ContinuousController LFOFilterOnOff { get; set; }
        public ContinuousController PolyModFiltEnvAmount { get; set; }
        public ContinuousController PolyModOscBAmount { get; set; }
        public ContinuousController PolyModFreqAOnOff { get; set; }
        public ContinuousController PolyModPWOnOff { get; set; }
        public ContinuousController PolyModFilterOnOff { get; set; }
        public ContinuousController PitchWheelRange { get; set; }
        public ContinuousController RetriggerAndUnisonAssign { get; set; }
        public ContinuousController Cutoff { get; set; }
        public ContinuousController Brightness { get; set; }
        public ContinuousController Vintage { get; set; }
        public ContinuousController PressureFilter { get; set; }
        public ContinuousController PressureLFO { get; set; }
        public ContinuousController EnvelopeFilterAmount { get; set; }
        public ContinuousController EnvelopeFilterVelocityOnOff { get; set; }
        public ContinuousController EnvelopeVCAVelocityOnOff { get; set; }
        public ContinuousController AttackFilter { get; set; }
        public ContinuousController AttackVCA { get; set; }
        public ContinuousController DecayFilter { get; set; }
        public ContinuousController DecayVCA { get; set; }
        public ContinuousController SustainFilter { get; set; }
        public ContinuousController SustainVCA { get; set; }
        public ContinuousController ReleaseFilter { get; set; }
        public ContinuousController ReleaseVCA { get; set; }
        public ContinuousController ReleaseOnOff { get; set; }
        public ContinuousController UnisonOnOff { get; set; }
        public ContinuousController UnisonVoiceCount { get; set; }
        public ContinuousController UnisonDetune { get; set; }
        public ContinuousController OscilatorBSquareOnOff { get; set; }
        public ContinuousController LFOSawOnOff { get; set; }
        public ContinuousController LFOTriOnOff { get; set; }
        public ContinuousController LFOSquareOnOff { get; set; }
        #endregion


        //initializes a default patch of CC messages. Used when class is initialized or method is called from Editor
        //Also want this in a Dictionary for quick access by CC#
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
            Cutoff = new ContinuousController { MaximumValue = 120, MinimumValue = 0, Number = 73, ParameterName = "CUTOFF", ParameterValue = 100 };
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
