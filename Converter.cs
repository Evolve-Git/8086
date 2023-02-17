using System.Linq;

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

            string temp = new string(line.ToUpper().Where(x => char.IsLetterOrDigit(x)).ToArray());
			temp = temp.Insert(0, colorBlue);
            for (int i=0; i<CodesDB.codes.GetLength(0); i++)
			{
				if (temp.Contains(CodesDB.codes[i, 1]))
				{
                    temp = temp.Replace(CodesDB.codes[i, 1], colorGreen + " " + CodesDB.codes[i, 0] + colorBlack).TrimEnd('H');
					codeFound = true;
					break;
				}
			}

			if (!codeFound) temp = colorRed + line;

            return temp;
		}
    }
}
