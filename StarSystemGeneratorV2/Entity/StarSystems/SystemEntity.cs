using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarSystemGeneratorV2.Generator;
using System.Drawing;

namespace StarSystemGeneratorV2.Entity.StarSystems
{
	abstract class SystemEntity
	{
		internal List<SystemEntity> StarSystems = new List<SystemEntity>();

		internal static HighlightTypes _highlightType = HighlightTypes.None;
		internal static HighlightTypes HighlightType
		{
			get
			{
				return _highlightType;
			}
			set
			{
				_highlightType = value;

				if(_highlightType == HighlightTypes.None)
				{
					C1 = Color.Empty;
					C2 = Color.Empty;
					C3 = Color.Empty;
					C4 = Color.Empty;
					COverride = Color.Empty;
				}
				if(_highlightType == HighlightTypes.LostColony)
				{
					C1 = Color.Green; //Lost Civ Found of HyperSpace or Civ Level
					C2 = Color.Yellow; //Lost Civ Found but its <50% intact
					C3 = Color.Orange; //Not Worth Exploring
					C4 = Color.Salmon; //Life exists on a planet
				}
				if(_highlightType == HighlightTypes.ReadyForColonization)
				{
					C1 = Color.Green; //Oxygen planet with Great stats
					C2 = Color.Yellow; //Oxygen planet with Good stats
					C3 = Color.Orange; //Oxygen planet with OK stats
					C4 = Color.Purple; //Oxygen planet, extreme stats
					COverride = Color.Salmon; //Life Exists in this star system
				}
			}
		}
		internal static Color C1 = Color.Empty;
		internal static Color C2 = Color.Empty;
		internal static Color C3 = Color.Empty;
		internal static Color C4 = Color.Empty;
		internal static Color COverride = Color.Empty;

		internal abstract EntityTypes EntityType
		{
			get;
		}
		internal abstract NodeObject Node
		{
			get;
		}

		internal SystemEntity ParentEntity = null; //This is the Star System that this Entity Resides in

		internal List<SystemEntity> ChildEntities = new List<SystemEntity>();

		internal virtual Randomize Generator
		{
			get
			{
				return ParentEntity.Generator;
			}
		}
		internal virtual int VersionNumber
		{
			get
			{
				return ParentEntity.VersionNumber;
			}
		}
		internal virtual int SystemNumber
		{
			get
			{
				return ParentEntity.SystemNumber;
			}
		}

		//Methods
		internal abstract void Generate();

		internal void Colorize()
		{
			if (HighlightType == HighlightTypes.None)
			{
				RemoveColorization();
			}

			if(HighlightType == HighlightTypes.ReadyForColonization)
			{
				highlightColonization();
			}

			if(HighlightType == HighlightTypes.LostColony)
			{
				highlightLostColony();
			}
		}

		void RemoveColorization()
		{
			//Root Node
			SystemEntity se = this;
			while (se.ParentEntity != null)
				se = se.ParentEntity;

			RemoveColors(se);
		}
		void RemoveColors(SystemEntity se)
		{
			se.Node.Node.BackColor = Color.Empty;

			foreach (SystemEntity se2 in se.ChildEntities)
				RemoveColors(se2);
		}

		void highlightColonization()
		{
			bool OverrideTriggered = false;

			//Root Node
			SystemEntity se = this;
			while (se.ParentEntity != null)
				se = se.ParentEntity;

			//Star nodes
			List<SystemEntity> stars = new List<SystemEntity>();
			foreach(SystemEntity starse in se.ChildEntities)
			{
				if (starse.EntityType == EntityTypes.Star) stars.Add(starse);
			}

			//Loop Though each star looking for life
			foreach(Star s in stars)
			{
				bool CivFound = SearchForLife(s);
				
				if(CivFound)
				{
					OverrideTriggered = true;
					colorizeStarWithLife(s);
				}
				else
				{
					colorizeColonization(s);
				}
			}

			//if (OverrideTriggered) se.Node.Node.BackColor = Color.LightCyan;
		}
		bool SearchForLife(SystemEntity entity)
		{
			if(entity.EntityType == EntityTypes.Civilization)
			{
				Civilization civ = (Civilization)entity;
				if(civ.CivType == CivilizationTypes.Living)
				{
					return true;
				}
			}

			foreach (SystemEntity cEntity in entity.ChildEntities)
			{
				if (SearchForLife(cEntity))
				{
					return true;
				}
			}

			return false;
		}
		void colorizeStarWithLife(SystemEntity entity)
		{
			entity.Node.Node.BackColor = COverride;

			foreach (SystemEntity e in entity.ChildEntities) colorizeStarWithLife(e);
		}
		void colorizeColonization(SystemEntity entity)
		{
			

			foreach (SystemEntity e in entity.ChildEntities) colorizeColonization(e);
		}

		void highlightLostColony()
		{

		}
	}
}
