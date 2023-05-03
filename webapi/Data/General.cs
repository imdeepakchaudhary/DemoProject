using Data;
using Microsoft.Extensions.Options;
using Microsoft.Identity.Client;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace webapi.Data
{
    public class General
    {
        public static string AppName = "Demo";
        public static int PageSize = 25;

        public static string defaultPassword = "23112c31-749c-48b8-902d-18c5df96b9a3A";

        public static string MSGauthKey = "";
        public static string MSGsenderId = "Demo";
        public static string MSGsendSMSUri = "";
        public static string MSGsendOTPUri = "";

        private static string FCMServerKey = "";
        private static string FCMSenderId = "";

        /// <summary>
        /// Calculate total pages  ( for grids)
        /// </summary>
        /// <param name="pages"></param>
        /// <param name="_PageSize"></param>
        /// <returns></returns>
        public static int TotalPages(int pages, int _PageSize)
        {
            double c = ((double)pages / _PageSize);
            return Convert.ToInt32(Math.Ceiling(c));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="config"></param>
        /// <returns></returns>
        private static string GetVersion(IOptions<AppConfig> config)
        {
            return config.Value.Version;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="config"></param>
        /// <returns></returns>
        //public static string getBaseUrl(IOptions<AppConfig> config)
        //{
        //    return config.Value.ApplicationUrl;
        //}

        //public static string GetImageUrl(string ImageName, IOptions<AppConfig> config)
        //{
        //    return getBaseUrl(config) + ImageName + "?v=" + GetVersion(config);
        //}

        public static string Encode(string encodeMe)
        {

            byte[] encoded = System.Text.Encoding.UTF8.GetBytes(encodeMe);
            return System.Net.WebUtility.UrlEncode(Convert.ToBase64String(encoded));
        }

        public static string Decode(string decodeMe)
        {
            if (decodeMe == null)
                return "";

            decodeMe = System.Net.WebUtility.UrlDecode(decodeMe);
            byte[] encoded = Convert.FromBase64String(decodeMe);
            return System.Text.Encoding.UTF8.GetString(encoded);
        }



        public static int CheckIntegergraterthenZero(int integer)
        {

            if (integer == null && integer <= 0)
            {
                return 1;
            }
            else
            {
                return integer;
            }
        }

        public static int CheckStrtypeInt(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(str);
            }
        }

        //public static string GetRestaurantLogo(string CID, string Imag, IOptions<AppConfig> config)
        //{

        //    return General.getBaseUrl(config) + "/uploads/" + CID + "/logos/" + Imag;
        //}

        //public static string GetRestaurantImages(string CID, string Imag, IOptions<AppConfig> config)
        //{

        //    return General.getBaseUrl(config) + "/uploads/" + CID + "/logos/" + Imag;
        //}

        public static bool IsEmail(string str)
        {
            return Regex.IsMatch(str,
                              @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                              @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                        RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
        }

        public static string GenerateCode()
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 6)
              .Select(s => s[random.Next(s.Length)]).ToArray());

        }
        public static decimal? CalculatetaxAmount(decimal? amount, decimal? Percentage)
        {
            if (amount == null || Percentage == null)
                return 0;
            return (amount * Percentage) / 100;
        }

        //public static dynamic getTax(long RestId, long MenuId)
        //{
        //    decimal gst = 0;
        //    decimal cgst = 0;
        //    decimal servicetax = 0;
        //    decimal vat = 0;

        //    var c = new Tabon.DataAccess.Repository.MenuMasterRepository(new Tabon.DataAccess.Infrastructure.ConnectionFactory());
        //    var menu = Task.Run(async () => await c.Get(MenuId)).Result;
        //    if (menu != null && (menu.GstPer > 0 || menu.VatPer > 0))
        //    {
        //        gst = menu.GstPer != null ? menu.GstPer.Value : 0;
        //        cgst = menu.CstPer != null ? menu.CstPer.Value : 0;
        //        servicetax = menu.ServiceTaxPer != null ? menu.ServiceTaxPer.Value : 0;
        //        vat = menu.VatPer != null ? menu.VatPer.Value : 0;
        //    }
        //    else
        //    {
        //        var mc = new Tabon.DataAccess.Repository.MenuCategoryRepository(new Tabon.DataAccess.Infrastructure.ConnectionFactory());
        //        var category = Task.Run(async () => await mc.Get(menu.CategoryID)).Result;
        //        if (category != null && (category.GstPer > 0 || category.VatPer > 0))
        //        {
        //            gst = category.GstPer != null ? category.GstPer.Value : 0;
        //            cgst = category.CstPer != null ? category.CstPer.Value : 0;
        //            servicetax = category.ServiceTaxPer != null ? category.ServiceTaxPer.Value : 0;
        //            vat = category.VatPer != null ? category.VatPer.Value : 0;
        //        }
        //        else
        //        {

        //            var r = new Tabon.DataAccess.Repository.RestaurantRepository(new Tabon.DataAccess.Infrastructure.ConnectionFactory());
        //            var res = Task.Run(async () => await r.Get(RestId)).Result;
        //            if (res != null && (res.Sgstper > 0 || res.Cgstper > 0))
        //            {
        //                gst = res.Sgstper != null ? res.Sgstper.Value : 0;
        //                cgst = res.Cgstper != null ? res.Cgstper.Value : 0;
        //                servicetax = res.ServiceTaxPer != null ? res.ServiceTaxPer.Value : 0;
        //                vat = res.VATPer != null ? res.VATPer.Value : 0;
        //            }
        //        }
        //    }
        //    return new { GST = gst, CGST = cgst, STax = servicetax, Vat = vat };
        //}


        public static string GenerateVoucherCode(int length)
        {
            string allowedChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            char[] chars = new char[length];
            Random rd = new Random();
            for (int i = 0; i < length; i++)
            {
                chars[i] = allowedChars[rd.Next(0, allowedChars.Length)];
            }
            return new string(chars);
        }

        public static bool SendSMS(string PhoneNumber, string message, string Type)
        {

            string mobileNumber = PhoneNumber.Trim();

            StringBuilder sbPostData = new StringBuilder();
            sbPostData.AppendFormat("authkey={0}", MSGauthKey);
            sbPostData.AppendFormat("&mobiles={0}", mobileNumber);
            sbPostData.AppendFormat("&message={0}", message);
            sbPostData.AppendFormat("&sender={0}", MSGsenderId);
            sbPostData.AppendFormat("&route={0}", Type);

            try
            {
                HttpWebRequest httpWReq = (HttpWebRequest)WebRequest.Create(MSGsendSMSUri);
                UTF8Encoding encoding = new UTF8Encoding();
                byte[] data = encoding.GetBytes(sbPostData.ToString());
                httpWReq.Method = "POST";
                httpWReq.ContentType = "application/x-www-form-urlencoded";
                httpWReq.ContentLength = data.Length;
                //  Task.Delay(5000);
                using (Stream stream = httpWReq.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }
                HttpWebResponse response = (HttpWebResponse)httpWReq.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string responseString = reader.ReadToEnd();


                if (response.StatusCode == HttpStatusCode.OK)
                {

                    reader.Close();
                    response.Close();
                    return true;
                }
                else
                {
                    reader.Close();
                    response.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string MaskedPhoneNo(string input)
        {
            //take first 6 characters
            string firstPart = input.Substring(0, 6);

            //take last 4 characters
            int len = input.Length;
            string lastPart = input.Substring(len - 4, 4);

            //take the middle part (XXXXXXXXX)
            int middlePartLenght = input.Substring(6, len - 4).Count();
            string middlePart = new String('X', 5);

            return firstPart + middlePart + lastPart;
        }

        public enum OfferRulType
        {
            Simple_Caupon_Discount = 1,
            Advance_Discount = 2,
            Buy_X_Get_Y_Free = 3,
            Buy_X_Get_Discount = 4,
            Spend_X_Get_Discount = 5,
            Buy_this_Item_Get_this_Item_Free = 6
        }
        public enum OfferType
        {
            Percentage = 1,
            Flat = 2,


        }
        public enum OfferApplyType
        {
            On_Total_Amount = 1,
            On_Menu_Category = 2,
            On_Menu_Iteams = 3

        }

        public static string GetEncriptedIds(string ids)
        {
            string Encriptedid = "";
            if (!string.IsNullOrEmpty(ids))
            {
                string[] strarr = ids.Split(',');
                if (strarr != null && strarr.Count() > 0)
                {
                    foreach (string str in strarr)
                    {
                        Encriptedid += str.ToEncode() + ",";
                    }


                }
            }
            return Encriptedid.TrimEnd(',');
        }
        public static string GetDecriptedIds(string ids)
        {
            string Decriptedid = "";
            if (!string.IsNullOrEmpty(ids))
            {
                string[] strarr = ids.Split(',');
                if (strarr != null && strarr.Count() > 0)
                {
                    foreach (string str in strarr)
                    {
                        Decriptedid += str.ToDecode() + ",";
                    }


                }
            }
            return Decriptedid.TrimEnd(',');
        }



        public static async Task<bool> NotifyAsync(string to, string title, string body, string device, string id = "")
        {
            try
            {
                // Get the server key from FCM console
                var serverKey = string.Format("key={0}", FCMServerKey);

                // Get the sender id from FCM console
                var senderId = string.Format("id={0}", FCMSenderId);

                //var data = new
                //{
                //    to, // Recipient device token
                //    notification = new { title, body }
                //};

                var jsonBody = "";

                // jsonBody = JsonConvert.SerializeObject(data);

                if (device == "Android")
                {
                    var abc = new
                    {
                        to,
                        notification = new
                        {
                            userid = id,
                            body = body,
                            title = title,
                            icon = ""
                        }
                    };
                    jsonBody = JsonConvert.SerializeObject(abc);
                }

                if (device == "iOS")
                {
                    var abc = new
                    {
                        to,
                        notification = new
                        {
                            userid = id,
                            category = title,
                            body = body,
                            icon = "",
                            badge = 1
                        }
                    };
                    jsonBody = JsonConvert.SerializeObject(abc);
                }

                // Using Newtonsoft.Json


                using (var httpRequest = new HttpRequestMessage(HttpMethod.Post, "https://fcm.googleapis.com/fcm/send"))
                {
                    httpRequest.Headers.TryAddWithoutValidation("Authorization", serverKey);
                    httpRequest.Headers.TryAddWithoutValidation("Sender", senderId);
                    httpRequest.Content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

                    using (var httpClient = new HttpClient())
                    {
                        var result = await httpClient.SendAsync(httpRequest);

                        if (result.IsSuccessStatusCode)
                        {
                            return true;
                        }
                        else
                        {
                            // Use result.StatusCode to handle failure
                            // Your custom error handler here

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return false;
        }

        public static string GetIntOfWeeckday(string day)
        {
            string _day = "0";

            if (!string.IsNullOrEmpty(day))
            {
                if (day.ToLower() == "sunday")
                {
                    _day = "1";
                }
                else if (day.ToLower() == "monday")
                {
                    _day = "2";
                }
                else if (day.ToLower() == "tuesday")
                {
                    _day = "3";
                }
                else if (day.ToLower() == "wednesday")
                {
                    _day = "4";
                }
                else if (day.ToLower() == "thursday")
                {
                    _day = "5";
                }
                else if (day.ToLower() == "friday")
                {
                    _day = "6";
                }
                else if (day.ToLower() == "saturday")
                {
                    _day = "7";
                }


            }
            return _day;
        }

        public static string GetRestaurentCuisines(string ids)
        {
            if (string.IsNullOrWhiteSpace(ids))
            {
                return "";
            }
            string CuisinesNames = "";

            string[] name = ids.Split(',');
            if (name.Length > 0)
            {
                for (int i = 0; i < name.Length; i++)
                {
                    if (name[i] == "1")
                    {
                        CuisinesNames += "North Indian,";
                    }
                    else if (name[i] == "2")
                    {
                        CuisinesNames += "Chinese,";
                    }
                    else if (name[i] == "3")
                    {
                        CuisinesNames += "Fast Food,";
                    }
                    else if (name[i] == "4")
                    {
                        CuisinesNames += "Mughlai,";
                    }
                    else if (name[i] == "5")
                    {
                        CuisinesNames += "Bakery,";
                    }
                    else if (name[i] == "6")
                    {
                        CuisinesNames += "Italian,";
                    }
                    else if (name[i] == "7")
                    {
                        CuisinesNames += "Desserts,";
                    }
                    else if (name[i] == "8")
                    {
                        CuisinesNames += "Continental,";
                    }
                    else if (name[i] == "9")
                    {
                        CuisinesNames += "Pizza,";
                    }
                    else if (name[i] == "10")
                    {
                        CuisinesNames += "South Indian,";
                    }
                }

                CuisinesNames = CuisinesNames.TrimEnd(',');
            }

            return CuisinesNames;
        }


    }

    public enum Status
    {
        Active,
        Inactive
    }
    public enum ImageType
    {
        RestaurantGallery = 1,
        Menu = 2,

    }
    public enum CodeStatus
    {
        New,
        Used,
        Closed,
        Deny
    }


}
