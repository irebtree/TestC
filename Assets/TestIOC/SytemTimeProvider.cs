using UnityEngine;
using System.Collections;
using System;
public class SytemTimeProvider : ITimeProvider  {

	public DateTime CurrentDate{get{return System.DateTime.Now;}}
}
