using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace leetCode
{
	public class IntegerToRoman
	{
		public string IntToRoman(int input) // = 3749
		{
			Dictionary<char, int> dic = new Dictionary<char, int>() {
				{ 'I',  1    },
				{ 'V',  5    },
				{ 'X',  10   },
				{ 'L',  50   },
				{ 'C',  100  },
				{ 'D',  500  },
				{ 'M',  1000 }
			};

			char[] chars = input.ToString().ToCharArray();
			int inputCount = chars.Count();
			if (inputCount <= 0) return "";
			string result = "";

			foreach (var c in chars)
            {
				foreach (var item1 in dic)
				{
					if (c == item1.Value)
					{
						return c.ToString();
					}
				}

				switch (inputCount)
				{
					case 1:
                        // code block

						for (int i = 0; i <= dic.Count; i++)
						{
							if (c < dic.GetValueOrDefault(i))
							{
								result += i.ToString();
							}
						}
                        
                        break;
					case 2:
						// code block
					
                        break;
					case 3:
						// code block
						break;
					case 4:
						// code block
						break;
				}

			};

			return result
		
		}

	}
}
