using UnityEngine;
using System.Collections;

public class SimpleSProductFactory {

	public static SProduct CreateProduct(string productType)
	{
		SProduct product = null;
		switch(productType)
		{
		case "A":
			product = new SProductA();
			break;
		case "B":
			product = new SProductB();
				break;

		}
		return product;
	}
}
