using System;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace _8086
{
	internal class Converter
	{
		public string run(string text)
		{
			string delimStr = "\n";

            string[] lines = text.Split(delimStr.ToCharArray());

			for (int i=0; i<lines.Length; i++)
			{
				lines[i] = lineContainsCode(lines[i]);
			}

			return string.Join(@"\line ", lines);
		}

		string lineContainsCode(string line)
		{
			string boldStart = @"\b ";
			string boldEnd = @" \b0 ";
			string colorBlack = @"\cf1 ";
			string colorRed = @"\cf2 ";
			string colorGreen = @"\cf3 ";
			string colorBlue = @"\cf4 ";
			bool codeFound = false;
			string HEX = "0123456789ABCDEF";

            string temp = new string(line.ToUpper().Where(x => char.IsLetterOrDigit(x)).ToArray());
            for (int i=0; i<CodesDB.codes.GetLength(0); i++)
			{
				if (temp.Contains(CodesDB.codes[i, 1]))
				{
					string tempStart = temp.Substring(0, temp.IndexOf(CodesDB.codes[i, 1]));
                    string tempEnd = temp.Substring(temp.IndexOf(CodesDB.codes[i, 1]) + CodesDB.codes[i, 1].Length).TrimEnd('H');

					if (!string.IsNullOrWhiteSpace(tempStart))
					{
						tempStart = tempStart.Insert(0, colorRed) + ":";
					}

					if ((tempEnd.Length == Convert.ToInt32(CodesDB.codes[i, 2]) * 2) && tempEnd.All(HEX.Contains))
					{
						if (CodesDB.codes[i, 2] == "2")
						{
							tempEnd = tempEnd.Remove(0, 2) + tempEnd[0] + tempEnd[1];
						}
						tempEnd = tempEnd.Insert(0, colorBlue);
					}
					else
					{
						tempEnd = tempEnd.Insert(0, colorRed);
					}

					temp = "   " + tempStart + " " + colorGreen + CodesDB.codes[i, 0] + " " + tempEnd;
                    //temp = temp.Replace(CodesDB.codes[i, 1], colorGreen + " " + CodesDB.codes[i, 0] + colorBlack).TrimEnd('H');
					codeFound = true;
					break;
				}
			}

			if (!codeFound) temp = "   " + colorRed + line;

            return temp;
		}
    }
}
