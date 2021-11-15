using System;

namespace GR953500.Models
{
	public class Product
	{
		public int ID { set; get; }
		public string Name { set; get; }
		public decimal Price { set; get; }
		public void ApplyDiscount(decimal d)
		{
			if (Price <= d)
				throw new
				ArgumentOutOfRangeException();
			else Price -= d;
		}
	}


}
