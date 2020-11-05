using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Helper
{
    public abstract class AppConstants
    {
        public const string USER_INFO = "USER_INFO";
        public const string SESSION_ID = "SESSION_ID";
    }

    public class SessionHelper
    {
        public static void Set<T>(T model)
        {
            System.Web.HttpContext.Current.Session[AppConstants.USER_INFO] = model;
        }

        public static T Get<T>() where T : class
        {
            try
            {
                return System.Web.HttpContext.Current.Session[AppConstants.USER_INFO] as T;
            }
            catch (Exception ex)
            {
                // do nothing
            }
            return default(T);
        }

        public static bool HasLogin<T>() where T : class
        {
            T model = Get<T>();

            if(model != null)
            {
                return true;
            }

            return false;
        }

        public static void Clear()
        {
            try
            {
                System.Web.HttpContext.Current.Session.Remove(AppConstants.USER_INFO);
            }
            catch (Exception ex)
            {
                // do nothing
            }
        }
    }
}