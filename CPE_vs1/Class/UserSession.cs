using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace CPE_vs1
{
    class UserSession
    {
        private static bool sessionalive;
        private static Timer usertimer;

        public static bool SessionAlive
        {
            get { return sessionalive; }
            set { sessionalive = value; }
        }


        public static void BeginTimer()
        {
            try
            {
                SessionAlive = true;
                //usertimer.Start();
                usertimer = new Timer(600000);
                usertimer.Enabled = true;
                usertimer.AutoReset = false;
                usertimer.Elapsed += new ElapsedEventHandler(DisposeSession);

            }
            catch (Exception ex)
            {

                return;
            }

        }


        private static void DisposeSession(object source, ElapsedEventArgs e)
        {
            try
            {
                SessionAlive = false;
            }
            catch (System.Exception ex)
            {
                return;
            }

        }

        public static void ResetTimer()
        {
            try
            {
                SessionAlive = true;
                usertimer.Stop();
                usertimer.Start();
            }
            catch (Exception ex)
            {

                return;
            }

        }
    }
}
