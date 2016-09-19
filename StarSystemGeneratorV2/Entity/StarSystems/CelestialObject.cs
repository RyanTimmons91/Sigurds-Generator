﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace StarSystemGeneratorV2.Entity.StarSystems
{
	class CelestialObject : SystemEntity
	{
		internal override EntityTypes EntityType
		{
			get { return EntityTypes.CelestialObject; }
		}

		internal NodeObject _Node = null;
		internal override NodeObject Node
		{
			get
			{
				if (_Node == null)
				{
					NodeObject no = new NodeObject(this, "Cel.Obj. " + Type.ToString() + TextString);

					foreach (SystemEntity se in ChildEntities)
					{
						no.Node.Nodes.Add(se.Node.Node);
					}

					_Node = no;
					return no;
				}
				else return _Node;
			}
		}
		
		CelestialBodyTypes Type;
		string TextString = "";

		internal CelestialObject(SystemEntity parent, CelestialBodyTypes type)
		{
			ParentEntity = parent;
			Type = type;

			if(Type == CelestialBodyTypes.WormholeJunction && VersionNumber >= 30) //We generate the number of wormholes after version 30
			{
				int count = Generator.diceHelper.D20();
				TextString = " " + count;
			}
		}

		internal override void Generate()
		{
			throw new NotImplementedException();
		}
	}
}
