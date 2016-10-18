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
			}
		}

		internal abstract EntityTypes EntityType
		{
			get;
		}
		internal abstract NodeObject Node
		{
			get;
		}

        internal Color seColor
        {
            get
            {
                return Node.Node.BackColor;
            }
            set
            {
                Node.Node.BackColor = value;
            }
        }
        internal AtmosphereTypes PlanetMoonAtmosphere
        {
            get
            {
                if(EntityType == EntityTypes.Planet)
                {
                    Planet se = (Planet)this;
                    return se.entityAtmosphere_Final;
                }
                if(EntityType == EntityTypes.Moon)
                {
                    Moon se = (Moon)this;
                    return se.entityAtmosphere_Final;
                }

                return AtmosphereTypes.None;
            }
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
                RemoveAllSystemColorization();
			}

			if(HighlightType == HighlightTypes.ReadyForColonization)
			{
                HighlightSystemForColonization();
			}

			if(HighlightType == HighlightTypes.LostColony)
			{
                LogF.WriteLine("Start");
                HighlighLostColonies();
			}
		}

		void RemoveAllSystemColorization()
		{
			//Root Node
			SystemEntity se = this;
			while (se.ParentEntity != null)
				se = se.ParentEntity;

            ColorAll(se, Color.Empty);
		}
        void HighlightSystemForColonization()
        {
            //Get root 'System' Node
            SystemEntity se = this;
            while (se.ParentEntity != null)
                se = se.ParentEntity;
            
            foreach (SystemEntity childSE in se.ChildEntities)
            {
                OxygenSearch(childSE);

                if(LifeSearch(childSE))
                {
                    ColorAll(childSE, Color.Red);
                }
            }
        }
        void HighlighLostColonies()
        {
            LogF.WriteLine("Begin");

            //Get root 'System' Node
            SystemEntity se = this;
            while (se.ParentEntity != null)
                se = se.ParentEntity;

            foreach (SystemEntity childSE in se.ChildEntities)
            {
                LostColonySearch(childSE);
            }
        }
        
        //SearchMethods
        static bool LifeSearch(SystemEntity se) //Returns true if life is found at or below this entity
        {
            if (se.EntityType == EntityTypes.Civilization)
            {
                Civilization civ = (Civilization)se;
                if (civ.CivType == CivilizationTypes.Living)
                {
                    return true;
                }
            }

            foreach (SystemEntity cEntity in se.ChildEntities)
            {
                if (LifeSearch(cEntity))
                {
                    return true;
                }
            }

            return false;
        }
        static void OxygenSearch(SystemEntity se)
        {
            if(se.PlanetMoonAtmosphere == AtmosphereTypes.Oxygen)
            {
                ColorUp(se, Color.Cyan);

                if (se.ParentEntity != null && se.ParentEntity.PlanetMoonAtmosphere == AtmosphereTypes.Oxygen)
                {
                    se.ParentEntity.seColor = Color.Salmon;
                }
            }

            foreach (SystemEntity cEntity in se.ChildEntities)
            {
                OxygenSearch(cEntity);
            }
        }
        static void LostColonySearch(SystemEntity se)
        {
            LogF.WriteLine("Start Search");

            TechLevels tl = LostColonyCheck(se);

            if (tl != TechLevels.None) //We have a lost civ!
            {
                if (tl == TechLevels.ColonizationAge || tl == TechLevels.HyperspaceRevolution)
                {
                    LogF.WriteLine("Color Up green");
                    ColorUp(se, Color.Green);

                }
                else
                {
                    LogF.WriteLine("Color up yellow");
                    ColorUp(se, Color.Yellow);
                }

                TechLevels ptl = LostColonyCheck(se.ParentEntity);

                if (ptl != TechLevels.None)
                {
                    if (ptl == TechLevels.ColonizationAge || ptl == TechLevels.HyperspaceRevolution)
                    {
                        se.ParentEntity.seColor = Color.Goldenrod;
                    }
                    else
                    {
                        se.ParentEntity.seColor = Color.Orange;
                    }
                    
                }
            }

            foreach(SystemEntity cEntity in se.ChildEntities)
            {
                LostColonySearch(cEntity);
            }
        }
        static TechLevels LostColonyCheck(SystemEntity se)
        {
            if (se.EntityType == EntityTypes.Civilization)
            {
                Civilization civ = (Civilization)se;

                if (civ.CivType == CivilizationTypes.Lost)
                {
                    return civ.CivilizationTechLevel;
                }
            }
            return TechLevels.None;
        }


        static void ColorAll(SystemEntity se, Color c) //This will color this node and all nodes below this node a certain color
        {
            ColorOne(se, c);

            foreach(SystemEntity cse in se.ChildEntities)
            {
                ColorAll(cse, c);
            }
        }
        static void ColorOne(SystemEntity se, Color c) //This will color only this node a certain color
        {
            se.seColor = c;
        }
        static void ColorUp(SystemEntity se, Color c) //This will color this node and all of it's parent nodes (except the root node) a certain color
        {
            LogF.WriteLine("Color Up");
            if (se.EntityType == EntityTypes.StarSystem) return;

            ColorOne(se, c);

            ColorUp(se.ParentEntity, c);
        }
	}
}
