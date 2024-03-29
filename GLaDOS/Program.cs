﻿using GLaDOS.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace GLaDOS
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                //处理未捕获的异常
                Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
                //处理UI线程异常
                Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);
                //处理非UI线程异常
                AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FormLogin());
                if (LoginFlag == true)
                {
                    Application.Run(new FormMain());
                }
            }
            catch (Exception ex)
            {
                string str = "";
                string strDateInfo = "出现应用程序未处理的异常：" + DateTime.Now.ToString() + "\r\n";

                if (ex != null)
                {
                    str = string.Format(strDateInfo + "异常类型：{0}\r\n异常消息：{1}\r\n异常信息：{2}\r\n",
                    ex.GetType().Name, ex.Message, ex.StackTrace);
                }
                else
                {
                    str = string.Format("应用程序线程错误:{0}", ex);
                }
            }
        }

        private static bool LoginFlag = false;

        public static bool SetLoginFlag { set => LoginFlag = value; }

        public static bool GetLoginFlag { get => LoginFlag; }

        #region "异常处理"

        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            string str = "";
            string strDateInfo = "出现应用程序未处理的异常：" + DateTime.Now.ToString() + "\r\n";
            Exception ex = e.Exception as Exception;
            if (ex != null)
            {
                str = string.Format(strDateInfo + "异常类型：{0}\r\n异常消息：{1}\r\n异常信息：{2}\r\n",
                ex.GetType().Name, ex.Message, ex.StackTrace);
            }
            else
            {
                str = string.Format("应用程序线程错误:{0}", e);
            }
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            string str = "";
            Exception ex = e.ExceptionObject as Exception;
            string strDateInfo = "出现应用程序未处理的异常：" + DateTime.Now.ToString() + "\r\n";
            if (ex != null)
            {
                str = string.Format(strDateInfo + "Application UnhandledException:{0};\n\r堆栈信息:{1}", ex.Message, ex.StackTrace);
            }
            else
            {
                str = string.Format("Application UnhandledError:{0}", e);
            }
        }

        #endregion
    }
}
