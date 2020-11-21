using System;

namespace ConsoleAppStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
			//int t = 2;
			//Console.WriteLine(t);
			//string s_ = "bacbacacb";
			//string[] n_A_b = {s_.Length.ToString(), "8", "9"};
			string s_ = "aabaacaba";
			string[] n_A_b = { s_.Length.ToString(), "4", "5" };
			int a_ = Convert.ToInt32(n_A_b[1]);
			int b_ = Convert.ToInt32(n_A_b[2]);
			int result = buildString(a_, b_, s_);
		}

		static int buildString(int a, int b, string s)
		{
			string sDoneLoop = string.Empty;
			string sRest = s;
			for (int i = 0; i < s.Length; i++)
			{
				int cost = a;
				if (sDoneLoop == string.Empty)
				{
					sDoneLoop = sDoneLoop + s[i];
				}
				else
				{
					/*if(i >= 3)
					{
						var sTo3 = s[i].ToString() + s[i+1].ToString() + s[i+1].ToString();
						var distint_sDoneLoop = new String(sDoneLoop.Distinct().ToArray());
						for(int il = 0; il < s.Length-i; il++){

						}
					}
					else{
						cost = a;
						sDoneLoop = sDoneLoop + s[i];
					}*/


					bool isforB = false;
					for (int il = 0; il < s.Length - i; il++)
					{
						for (int ill = 0; ill < sDoneLoop.Length; ill++)
						{
							if (s.Substring(i, s.Length - (i + il)) == sDoneLoop.Substring(0, sDoneLoop.Length - ill))
							{
								if (s.Substring(i, s.Length - (i + il)).Length == 1 && sDoneLoop.Length == 1)
								{
									isforB = false;
								}
								else
								{
									cost = b;
									sDoneLoop = sDoneLoop + s.Substring(i, s.Length - (i + il));
									i = i + s.Substring(i, s.Length - (i + il)).Length;
									isforB = true;
								}
							}
						}
					}
					if (!isforB)
					{
						cost = a;
						sDoneLoop = sDoneLoop + s[i];
					}
					else
					{
						i = i - 1;
					}


					/*if((s[i].ToString() + s[i+1].ToString()) == sDoneLoop.Substring(0, sDoneLoop.Length -1))
					{
						cost = b;
						sDoneLoop = sDoneLoop + (s[i].ToString() + s[i+1].ToString());
						i++;
					}
					else
					{
						cost = a;
						sDoneLoop = sDoneLoop + s[i];
					}*/
				}
				Console.Write(sDoneLoop);
				Console.WriteLine(" Cost is :" + cost.ToString());
			}
			return 0;
		}
	}
}
