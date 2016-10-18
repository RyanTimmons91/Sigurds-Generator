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
	public partial class LoadingAnimationForm : Form
	{
		Bitmap bmp = new Bitmap(601, 601);

		bool isAnimating;
		
		public LoadingAnimationForm()
		{
			InitializeComponent();

			AnimationPlanet.Init();
		}

		private void _animationTimer_Tick(object sender, EventArgs e)
		{
			if (isAnimating) return;

			isAnimating = true;
			
			Animate();

			isAnimating = false;
		}
		
		void Animate()
		{
			using (Graphics g = Graphics.FromImage(bmp))
			{
				g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
				g.Clear(Color.Black);

				foreach (AnimationPlanet AP in AnimationPlanet.Planets)
				{
					AP.Update();
					AP.Draw(g);
				}
			}
			this.Invalidate();
			//_animationPanel.Invalidate();
		}

		private void _animationPanel_Paint(object sender, PaintEventArgs e)
		{
			e.Graphics.DrawImage(bmp, new Point(0, 0));
		}

		private void LoadingAnimationForm_Paint(object sender, PaintEventArgs e)
		{
			e.Graphics.DrawImage(bmp, new Point(0, 0));
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
	class AnimationPlanet
	{
		internal static double maxRadians = 2 * Math.PI;

		static int randomStartingSteps;
		static bool initialized = false;
		internal static void Init()
		{
			if (initialized) return;

			initialized = true;

			randomStartingSteps = new Random().Next();

			AnimationPlanet ap = new AnimationPlanet(new Point(25, 25), 0, 0, 0);
			ap.isVisible = true; //Always show the sun!

			var a1 = new AnimationPlanet(new Point(5, 5), 1, 19, 88);
			a1.isVisible = true;
			a1 = new AnimationPlanet(new Point(10, 10), 2, 28, 225);
			a1.isVisible = true;
			a1 = new AnimationPlanet(new Point(10, 10), 3, 40, 365);
			a1.isVisible = true;
			a1 = new AnimationPlanet(new Point(7, 7), 4, 55, 687);
			a1.isVisible = true;
			a1 = new AnimationPlanet(new Point(67, 67), 5, 103, 4333);
			a1.isVisible = true;
			a1 = new AnimationPlanet(new Point(57, 57), 6, 172, 10759);
			a1.isVisible = true;
			a1 = new AnimationPlanet(new Point(24, 24), 7, 232, 30689);
			a1.isVisible = true;
			a1 = new AnimationPlanet(new Point(23, 23), 8, 286, 60182);
			a1.isVisible = true;

		}

		internal static List<AnimationPlanet> Planets = new List<AnimationPlanet>();

		internal static List<Brush> PlanetBrushes = new List<Brush>()
		{
			new SolidBrush(Color.FromArgb(253, 184, 19)),
			new SolidBrush(Color.FromArgb(133,143,221)),
			new SolidBrush(Color.FromArgb(227,158,28)),
			new SolidBrush(Color.FromArgb(66,106,214)),
			new SolidBrush(Color.FromArgb(109,45,45)),
			new SolidBrush(Color.FromArgb(201,144,57)),
			new SolidBrush(Color.FromArgb(206,206,206)),
			new SolidBrush(Color.FromArgb(198,211,227)),
			new SolidBrush(Color.FromArgb(39,70,135)),
		};

		internal static Point centerPanel = new Point(301, 301); //This is hte center of the panel, it should not change
		internal Point Size;

		bool isStatic
		{
			get
			{
				if (maxSteps == 0) return true;
				return false;
			}
		}
		bool isVisible = false;

		int distanceFromCenter; //this represents the distance from the star we are
		int maxSteps = 0; //Number of steps in the circle
		double stepPart; //How much of the MaxRadians is moved each step
		double currentStep; //This is the current step this object is on

		Point currentPoint = Point.Empty;

		Brush objectBrush; //this is the color we are painting this object;

		internal AnimationPlanet(Point size, int brushIndex, int fromCenter, int steps)
		{
			if (steps == 1) steps = 0;

			Size = size;
			distanceFromCenter = fromCenter;
			maxSteps = steps;
			objectBrush = PlanetBrushes[brushIndex];

			if(steps > 1)
			{
				stepPart = maxRadians / steps;
				currentStep = (randomStartingSteps % maxSteps) * stepPart;
			}

			Planets.Add(this);
		}

		internal void Update()
		{
			if (maxSteps == 0)
			{
				if (currentPoint == Point.Empty)
				{
					currentPoint.X = centerPanel.X - (int)Math.Ceiling((double)Size.X / 2);
					currentPoint.Y = centerPanel.Y - (int)Math.Ceiling((double)Size.Y / 2);
				}
				return;
			}
			else
			{
				currentStep = currentStep + stepPart;
				if (currentStep > maxRadians) currentStep = 0;

				currentPoint.X = (int)(centerPanel.X + distanceFromCenter * Math.Cos(currentStep));
				currentPoint.Y = (int)(centerPanel.Y + distanceFromCenter * Math.Sin(currentStep));

				currentPoint.X = currentPoint.X - (int)Math.Ceiling((double)Size.X / 2);
				currentPoint.Y = currentPoint.Y - (int)Math.Ceiling((double)Size.Y / 2);
			}
		}

		internal void Draw(Graphics g)
		{
			if (isVisible == false) return; //Dont draw if we are invisible!

			if (currentPoint == Point.Empty) return; //We need to update the point at least once before we draw!
			
			g.FillEllipse(objectBrush, new RectangleF(currentPoint.X, currentPoint.Y, Size.X, Size.Y));
		}
	}
}
