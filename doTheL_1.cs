using System.Text;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace nmsp {
  public class Program {
    static void Main(string[] args) {
      var y = new int[] { 111, 70, 65, 108, 90, 122, 79, 76, 97, 102 }.ToList();
      var x = Encoding.UTF8.GetString(Convert.FromBase64String("YWJjZGVmZ2hpamtsbW5vcHFyc3R1dnd4eXpBQkNERUZHSElKS0xNTk9QUVJTVFVWV1hZWjEyMzQ1Njc4OTA=")).ToArray().ToList();
      char[] isp = new char[] { 'x', 'x', 'x', 'x', 'x', 'x', 'x' };
      var s = new string('*', 6);
      var GClaRTTJpreZXyanmAJWGFV = new char[(((x.Count * 6) - 2 * (1 + 4) - (7 / 3) - 40) / 5) - 12];

      Func<char, char> PX = (c) => {
        if(char.IsLetter(c) && y.Contains(c)) {
          var i = y.IndexOf(c);
          y.RemoveAt(i);

          return c;
        }

        return ' ';
      };

      x.Reverse();

      for(int l = 0; l < x.Count; l++) {
        if(char.IsNumber(x[l]))
          continue;

        GClaRTTJpreZXyanmAJWGFV[l - 10] = x[l];
      }

    R:
      var asc = new Random().Next(GClaRTTJpreZXyanmAJWGFV.Length);
      var t = PX(GClaRTTJpreZXyanmAJWGFV[asc]);
      switch(t) {
        case (char)70:
          isp[0] = t;
          break;
        case (char)122:
          isp[2] = t;
          isp[3] = ' ';
          break;
        case (char)76:
          isp[6] = t;
          break;
        case (char)97:
          isp[1] = t;
          break;
        case (char)111:
          isp[4] = t;
          isp[5] = ' ';
          break;
        default:
          goto PS;
      }

    PS:
      var tmp = string.Empty;
      foreach(char c in isp) {
        if(c != 'x')
          tmp += c;
      }

      if(tmp.Length < 7)
        goto R;

      Console.WriteLine(string.Concat(s, ' ', tmp, ' ', s, '*'));
    }
  }
}