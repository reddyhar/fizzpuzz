using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace WebAppProcess.BusinessLayer
{
	public class Extract
	{
		public DataTable FormatInput(string input)
		{
			DataTable dt = new DataTable();
			dt.Columns.Add("Input");
			dt.Columns.Add("Result");
			string[] values = input.Split(',');
			foreach (string s in values)
			{
				var regexItem = new Regex("^[a-zA-Z ]*$");
				string output = "";
				if (s != "" && !regexItem.IsMatch(s))
				{
					char c = Convert.ToChar(s[0]);

					if (Char.IsNumber(c))
					{
						int val = Convert.ToInt32(s);
						if (val % 3 == 0 && val % 5 == 0)
						{
							output = "FizzBuzz";
						}
						else if (val % 3 == 0)
						{
							output = "Fizz";
						}
						else if (val % 5 == 0)
						{
							output = "Buzz";
						}
						else
						{
							output = string.Format("Divided {0} by 3 ,Divided {0} by 5", val);

						}
					}
					else
					{
						output = "Invalid Item";
					}
				}
				else
				{
					output = "Invalid Item";
				}
				dt.Rows.Add(s, output);
			}

			return dt;
		}
	}
}