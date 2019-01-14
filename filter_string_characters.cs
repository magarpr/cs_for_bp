using System;

string in_string = "1234test_string1234";
string out_string = "";
//Begin BP Code
string[] blacklist = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "#", "-", "_"};
foreach (string to_remove in blacklist)
{
  in_string = in_string.Replace(to_remove, "");
}
out_string = in_string;
//End BP Code
Console.WriteLine(in_string);
