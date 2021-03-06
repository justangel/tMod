﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tMod_v3.Events
{
	public delegate void SetLiquidEventHandler(object sender, SetLiquidEventArgs e);

	public class SetLiquidEventArgs : CancelableEventArgs
	{
		public byte PlayerId { get; private set; }
		public int X { get; private set; }
		public int Y { get; private set; }
		public byte Liquid { get; private set; }
		public bool Lava { get; private set; }

		public SetLiquidEventArgs(byte playerId, int x, int y, byte liquid, bool lava)
		{
			PlayerId = playerId;
			X = x;
			Y = y;
			Liquid = liquid;
			Lava = lava;
		}
	}
}
