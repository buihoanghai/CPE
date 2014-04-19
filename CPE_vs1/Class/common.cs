using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Collections;
using System.Xml;
using System.IO;
using System.Reflection;
using System.Text;
using DevExpress.XtraEditors;
using System.Globalization;
namespace CPE_vs1
{
    public class common
    {
        public static void openOnScreenKeyboard()
        {
            //if (System.Diagnostics.Process.GetProcessesByName("TabTip").Count() <= 0)
            //{
            //    System.Diagnostics.Process.Start("TabTip.exe");
            //}
            System.Diagnostics.Process.Start("TabTip.exe");

        } 

        public static void killOnScreenKeyboard()
        {
            try
            {
                if (System.Diagnostics.Process.GetProcessesByName("TabTip").Count() > 0)
                {
                    System.Diagnostics.Process asd = System.Diagnostics.Process.GetProcessesByName("TabTip").First();
                    asd.Kill();
                }
            }
            catch { }
        }
        /* convert datetime to yyyy/mm/dd
         * Parameter dt: type of Datetime
         */
        private static string[] arr_so = { "không ", "một ", "hai ", "ba ", "bốn ", "năm ", "sáu ", "bảy ", "tám ", "chín " };
        private static string[] arr_dv = { "đồng ", "nghìn ", "triệu ", "tỷ " };
        private static string result;
        private static string tmp = "";
       
        public static void loadLookUp(DataTable dt, LookUpEdit lk)
        {
            lk.Properties.DataSource = dt;
        }
        public static string toStringReplace(object str)
        {
            return toString(str).Replace(" ", "").Replace("'", "").Replace(".", "").Trim();
        }
        public static string ConvertMoneyToLetter_Main(string money, int index)
        {
            result = "";
            index = 0;
            return ConvertMoneyToLetter(money, ref index);
        }
        public static string ConvertMoneyToLetter(string money, ref int index)
        {
            int length = money.Length;
            if (length == 0)
                return result = "";
            if (length == 1)
            {
                tmp = "";
                Read1Number(money, ref index);

                return result = tmp + result;
            }
            if (length == 2)
            {
                tmp = "";
                Read2Number(money, ref index);

                return result = tmp + result;
            }
            else
            {
                tmp = "";
                Read3Number(money.Substring(length - 3, 3), ref index);
                result = tmp + result;

                ConvertMoneyToLetter(money.Substring(0, length - 3), ref  index);

            }
            return result;
        }
        public static string Read1Number(string money, ref  int index)
        {
            string temp = "";
            temp = arr_so[int.Parse(money)] + arr_dv[index];
            return tmp = temp + tmp;
        }
        public static string Read2Number(string money, ref int index)
        {
            string temp = "";
            if (money[0] == 1)
                temp += "mười ";
            if (money[0] == 0)
                temp += "linh";
            if (money[0] != '0' && money[1] != '1')
                temp += arr_so[money[0]] + "mươi ";
            if (money[1] != '0')
            {
                if (money[1] == '1')
                    temp += "mốt ";
                if (money[1] == '5')
                    temp += "lăm ";
                else
                    temp += arr_so[money[1]];
            }
            temp = arr_dv[index] + tmp;
            return tmp = temp + tmp;
        }
        public static string Read3Number(string money, ref int index)
        {
            string temp = "";
            if (money == "000")
            {
                if (index == 0)
                    temp += "đồng";
                index++;
                return tmp = temp + tmp;
            }
            string strTemp = "";
            int index_01 = common.parseInt(money[0]);
            strTemp = arr_so[index_01] + "trăm ";
            int flag = 0;
            if (money[1] == '0' && money[2] == '0')
            {
                strTemp += arr_dv[index];
                index++;
                temp += strTemp;
            }
            if (money[1] == '1')
                strTemp += "mười ";
            if (money[1] == '0')
                strTemp += "linh ";
            if (money[1] != '0' && money[1] != '1')
            {
                strTemp += arr_so[common.parseInt(money[1])] + "mươi ";
                flag = 1;
            }
            if (flag == 0 || money[2] != '1')
            {
                if (money[2] != '0')
                {
                    if (money[2] != '5')
                        strTemp += arr_so[common.parseInt(money[2])];
                    else
                        strTemp += "lăm ";
                }
            }
            else
                strTemp += "mốt ";
            strTemp += arr_dv[index];
            index++;
            temp = strTemp;
            return tmp = temp + tmp;
        }
        public static string ConvertMoneyToString(string money)
        {
            string temp = "";
            string strmoney = money;
            int j = 0;
            int i = strmoney.Length;
            for (; i >= 0; i = i - 3)
            {
                if (i == 0)
                {
                    return strmoney.Substring(0, (strmoney.Length - j)) + temp; ;
                }
                else
                {
                    if (i == 3)
                        temp = strmoney.Substring(i - 3, 3) + temp;
                    else if (i < 3)
                        temp = strmoney.Substring(0, i) + temp;
                    else
                        temp = "," + strmoney.Substring(i - 3, 3) + temp;
                    j += 3;
                }
            }
            return temp;
        }


        public static string DateTimeNow()
        {
            return DateTime.Now.Year.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Day.ToString() + " "
                              + DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();
        }
        public static string Order_RecordConvert(string table, object ID)
        {//'PET_1'
            return "'" + table + "_" + toString(ID) + "'";
        }
        public static DateTime getFirstDayOfWeek(DateTime aDate)

        { return aDate.AddDays(-(int)aDate.DayOfWeek); }
        public static DateTime getFirstDayOfMonth(DateTime aDate)
        {
            return new DateTime(aDate.Year, aDate.Month, 1);
        }

        public static string ConvertDate(DateTime dt)
        {
            return dt.Year + "/" + dt.Month + "/" + dt.Day + " 23:59:59";
        }
        public static string ConvertDate1(DateTime dt)
        {
            return dt.Year + "/" + dt.Month + "/" + dt.Day + " 0:0:0";
        }
        public static string ConvertDOBToAge(Object dt)
        {
            return toString(DateTime.Now.Year - ((DateTime)dt).Year);
        }
        public static string ConvertDOBToAge(Object dt, string lang)
        {
            if (lang != "vi")
                return toString(DateTime.Now.Year - ((DateTime)dt).Year) + " Age";
            return toString(DateTime.Now.Year - ((DateTime)dt).Year) + " Tuổi";
        }

        /*convert datetime to yyyy/mm/dd H:m:s
         *Parameter dt: type of Datetime
         * */
        public static string ConvertDateToTime(DateTime dt)
        {
            return dt.Year + "/" + dt.Month + "/" + dt.Day + " " + dt.Hour + ":" + dt.Minute + ":" + dt.Second;
        }


        //check for object
        /*
         * Parameter object: object
         */
        public static string toString(object obj)
        {
            if (obj == null)
                return "";
            if (obj.ToString().Trim() == "")
                return "";
            return obj.ToString();
        }
        public static string toString1(object obj)
        {
            if (obj == null)
                return "";
            if (obj.ToString().Trim() == "")
                return "";
            if (obj.ToString().Trim() == "(##)")
                return "";
            return obj.ToString();
        }

        public static string toStringTime(object obj)
        {
            if (obj == null)
                return "";
            try
            {
                DateTime dt = (DateTime)obj;
                return String.Format("{0:s}", dt);
            }
            catch
            {

            }
            if (obj.ToString().Trim() == "")
                return "";
            return obj.ToString();
        }
        public static string toFormatTime(object obj)
        {
            
            if (obj == null)
                return "";
            try
            {
                CultureInfo ci = new CultureInfo("en");
                ci = new CultureInfo("sv-SE");
                DateTime dt = (DateTime)obj;
                return dt.ToString("G", ci);
            }
            catch
            {
                return obj.ToString();
            }
        }
        //to lang for session lang when session null
        /*
         * Parameter lang: session lang
         */
        public static string toLang(object lang)
        {
            if (lang == null)
                return "vi";
            if (lang.ToString().Trim() == "")
                return "vi";
            return lang.ToString();
        }

        // get Node List

        //build datatable
        public static string combineFullName(object Family_Name, object Given_Name, object Middle_Name, string lang)// combine Full name with language
        {
            string FullName = "";
            if (lang == "vi")// Vietnamese
            {
                FullName = common.toString(Family_Name);
                if (common.toString(Middle_Name) != "")// Check Middle_Name is null
                {
                    FullName += " " + common.toString(Middle_Name);
                }
                FullName += " " + common.toString(Given_Name);
            }
            else
            {
                if (common.toString(Middle_Name) != "")// Check Middle_Name is null
                {
                    FullName = common.toString(Middle_Name) + " ";
                }
                FullName += common.toString(Given_Name);
                FullName += " " + common.toString(Family_Name);
            }

            return FullName;
        }

        public static string convertDateTime(object dateTime1, string lang)
        {
            if (toString(dateTime1) == "")
                return "";
            DateTime dateTime = (DateTime)dateTime1;
            string date = "";
            if (lang == "vi")
            {
                date = dateTime.Day + "/" + dateTime.Month + "/" + dateTime.Year;
            }
            else
            {
                date = dateTime.Month + "/" + dateTime.Day + "/" + dateTime.Year;
            }
            return date;
        }

        public static string convertDateTime1(object dateTime1, string lang)
        {
            if (toString(dateTime1) == "")
                return "";
            DateTime dateTime = (DateTime)dateTime1;
            string date = "";
            date = dateTime.Month + "/" + dateTime.Day + "/" + dateTime.Year;
            return date;
        }

        public static int parseInt(object str)
        {
            int i = 0;
            int.TryParse(toString(str), out i);
            return i;
        }
        public static double parseDouble(object str)
        {
            double d = 0;
            double.TryParse(toString(str), out d);
            return d;
        }
        public static decimal parseDecimal(object str)
        {
            decimal d = 0;
            decimal.TryParse(toString(str), out d);
            return d;
        }

        //cut string
        public static string CutString(string stringToCut, int lengthTocut)
        {
            if (stringToCut.Length > lengthTocut)
            {
                stringToCut = stringToCut.Substring(0, lengthTocut);
            }
            return stringToCut;
        }

        //convert string to letter
        public static string ConvertConditionString(string condition)
        {
            string conditionString = "";
            for (int i = 0; i < condition.Length; i++)
            {
                conditionString += "+ nchar(" + char.ConvertToUtf32(condition, i) + ")";
            }

            return conditionString;
        }

        public static string ConvertConditionString1(string condition)
        {
            //Hospital=" + common.ConvertConditionString1(Hospital) + " ";
            string conditionString = "";
            if (toString(condition) == "")
                return "''";
            for (int i = 0; i < condition.Length; i++)
            {
                if (conditionString == "")
                {
                    conditionString = " nchar(" + char.ConvertToUtf32(condition, i) + ") ";
                }
                else
                {
                    conditionString += " + nchar(" + char.ConvertToUtf32(condition, i) + ") ";
                }
            }
            return conditionString;
        }

        public static string DateToYYYYMMDD(string dateTime)
        {
            string[] split = dateTime.Split('/');
            return common.toString(int.Parse(split[0]) + 1900) + "/" + split[1] + "/" + split[2];
        }

        public static string getNameDatetimeNow()
        {
            DateTime dt = DateTime.Now;
            return dt.Year.ToString() + dt.Month.ToString() + dt.Day.ToString() + dt.Hour.ToString() + dt.Minute.ToString() + dt.Second.ToString() + dt.Millisecond.ToString() + dt.Ticks.ToString();
        }
        //message
        private static readonly string[] VietnameseSigns = new string[]
        {
            "aAeEoOuUiIdDyY",
            "áàạảãâấầậẩẫăắằặẳẵ",
            "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ",
            "éèẹẻẽêếềệểễ",
            "ÉÈẸẺẼÊẾỀỆỂỄ",
            "óòọỏõôốồộổỗơớờợởỡ",
            "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ",
            "úùụủũưứừựửữ",
            "ÚÙỤỦŨƯỨỪỰỬỮ",
            "íìịỉĩ",
            "ÍÌỊỈĨ",
            "đ",
            "Đ",
            "ýỳỵỷỹ",
            "ÝỲỴỶỸ"
        };
        public static string RemoveSign4VietnameseString(string str)
        {

            //Tiến hành thay thế , lọc bỏ dấu cho chuỗi

            for (int i = 1; i < VietnameseSigns.Length; i++)
            {

                for (int j = 0; j < VietnameseSigns[i].Length; j++)

                    str = str.Replace(VietnameseSigns[i][j], VietnameseSigns[0][i - 1]);
            }
            return str;
        }
    }
}