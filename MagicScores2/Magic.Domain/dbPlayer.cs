﻿using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic.Domain
{
	[Table(Name = "Players")]
	public class dbPlayer
	{
		[Column(IsPrimaryKey = true)]
		public string Name;
	}
}