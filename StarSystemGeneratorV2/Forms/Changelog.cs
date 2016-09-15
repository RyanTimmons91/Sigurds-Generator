using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarSystemGeneratorV2
{
	public partial class Changelog : Form
	{
		public Changelog()
		{
			InitializeComponent();
		}

		private void Changelog_Load(object sender, EventArgs e)
		{
			//TODO Update Changelog with each publish!
			_changeLog.Text = @"System Generator Changelog

-Program ICON Attributed to Dan Wiersema
-Author URL: http://www.danwiersema.com/
-Icon URL: http://all-free-download.com/free-icon/download/sun_100994.html
-Non-Commercial use only

September 9 2016 - 1.0.3.29
-Real name Change

September 9 2016 - 1.0.3.28
-Name Change X2

September 9 2016 - 1.0.3.27
-Name Change

September 9 2016 - 1.0.3:26
-Ship Generator Progress
-Halved Handgun Weight in Handheld Weapon Generator

August 30 2016 - 1.0.2:25
-Tweaked Vehicle Weapons
-Finished the Basic NPC Generator
-Will be reworking the armor generator to make it less screwy in the back
-Added the Ships Generator, it is not done, it is FAR from done.

August 24 2016 - 1.0.2:24
-Added Missile Launcher Generator
-Started on NPC Encounter Generator
-Fixed Weapon decimal places in Mecha generator

August 23 2016 - 1.0.1:23
-Fixed default values in Handheld weapon generator

August 23 2016 - 1.0.1:22
-More Special generator changs

August 19 2016 - 1.0.1:21
-Finished the handheld weapon generator

August 19 2016 - 1.0.1:20
-Finished the mecha generator

August 17 2016 - 1.0.1:19
-Added most of an attack roll generator
-Added a Mecha Cost and weight generator
-Started on the framework for a handheld weapon cost / weight generator
-No generator Changes!

August 13 2016 - 1.0.1:18
-Added a message to the generator for for what generator version your using
-Added a warning for using old generator versions
-Added new Generator Versions up to level 18 (current level)
-Level 18 now has a 1% chance for life and a 3% chance for lost civ's

August 13 2016 - 1.0.1:17
-Added in a special Weapon Cost generator

August 3 2016 - 1.0.1:16
-Removed Console Box

August 3 2016 - 1.0.1:15
-Added the Custom Dice roll maker, there is currently no way to remove them.
-Holding Control while starting the program clears them all
-Fixed an issue with the random Dice roller not adding sums of dice
-Fixed some other small issues
-Reworked the Dice Roller form, it now does not close, it only hides
-Began working on a system to perform earlier generator versions
-Began making Hyperspace Gates roll per star instead of per system
-Added the system number display to each control object
TODO:
*Some nodes are not showing the sysnumber yet, need to rework the node system

July 24 2016: - 1.0.0.14
-Added in the basic Dice roller to the main form, custom dice rolls to follow.

July 10 2016: - 1.0.0.13
-Tweked the generator to auto-select the newest generated system
-Made the clear button in the main form also clear the selected system data

June 12 2016: - 1.0.0.12
-New Program Icon, info above.
-Added ability to press the enter button to generate new systems
-Added a 0 button to reset the seed to 0 and generate a button
-Began planning out code to generate populated systems (different from life colonies)
-Remoted randomization test code
-Renamed the generate system button from 'test' to a real name
-Restructured buttons at the top of the main form
-Renamed main generation for from Form1 to SystemGeneratorForm

June 2 2016: - 1.0.0.11
-Added Changelog button and information
-Added Version number in main form title
-Added Clear Button
";
		}
	}
}
