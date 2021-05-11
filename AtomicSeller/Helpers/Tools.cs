using AtomicSeller.Controllers;
using AtomicSeller.Helpers;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
//using Microsoft.Extensions.Logging;
//using NLog.Web;
using NLog;
using NLog.Targets;
using AtomicSeller.Models;
using System.Net;
using System.Net.Mail;
using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Http;
//using NLog.Extensions.Logging;


namespace AtomicSeller
{
    public class Tools
    {
        public static string LabelFilesDirectory = "LabelFiles";
        public static string EDIFilesDirectory = "EDIFiles";
        public static string EDISentFilesDirectory = "Sent";
        public static string ExportFilesDirectory = "ExportFiles";
        //public static string AppdataDirectory = "Atomic";
        public static string InvoiceFilesDirectory = "Invoices";

        public static bool TaxManagement = false;


        static string AppData = string.Empty;


        
      
      
        public static Logger logger = NLog.LogManager.GetCurrentClassLogger();

        private readonly TempDataDictionary tempData;


        private readonly IHttpContextAccessor _context;


        public string GetBaseURL()
        {
            //string url = string.Empty;
            string baseUrl = string.Empty;

            /*
            string toto = System.Web.HttpContext.Current.Server.MapPath("~");
            //System.IO.Directory.Exists(HttpContext.Current.Server.MapPath(RefPath));
            string titi = System.Web.Hosting.HostingEnvironment.MapPath("~/");
            string tutu = HttpRuntime.AppDomainAppPath;
            */

            try
            {
                HttpRequest Request = _context.HttpContext.Request;
                //string toto = System.Net.Dns.GetHostName();
                //string titi = System.Net.Http.Headers. 
                baseUrl = Request.PathBase;

                //baseUrl = Request.Url.Scheme + "://" + Request.Url.Authority + Request.ApplicationPath.TrimEnd('/') + "/";
            }
            catch (Exception ex)
            {
                baseUrl = System.Net.Dns.GetHostName();
                //baseUrl = ex.Message + "</br> " + ex.InnerException.Message + "</br> " + ex.StackTrace + "</br> ";
            }

            return baseUrl;
        }

        private static string ProdSetting = string.Empty;
        private static string DevSetting = string.Empty;
        private static string DemoSetting = string.Empty;
        private static string EcommerceSetting = string.Empty;

        public static void ErrorHandler(string Message, Exception ex = null, bool DisplayMessage = false, bool TraceLog = true, bool DisplayTrace = false, BaseController controller = null)
        {


        }




    }
}
