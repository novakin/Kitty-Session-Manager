/* 
 * Copyright (C) 2008 David Riseley 
 *
 * This program is free software; you can redistribute it and/or
 * modify it under the terms of the GNU General Public License
 * as published by the Free Software Foundation; either version 2
 * of the License, or (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
 */

/* 
 * NOTE: This class is largely derived from the example at 
 * http://www.codeproject.com/KB/threads/SingleInstance.aspx
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using System.Reflection;

namespace uk.org.riseley.puttySessionManager
{

    public class SingleInstanceManager : IDisposable
    {
        private bool disposed = false;

        [DllImport("kernel32.dll")]
        static extern uint WaitForSingleObject(IntPtr hHandle, uint dwMilliseconds);
        [DllImport("kernel32.dll")]
        static extern IntPtr CreateEvent(IntPtr lpEventAttributes, bool bManualReset, bool bInitialState, string lpName);
        [DllImport("kernel32.dll")]
        static extern bool SetEvent(IntPtr hEvent);
        [DllImport("kernel32.dll")]
        static extern IntPtr OpenEvent(UInt32 dwDesiredAccess, bool bInheritable, string lpName);
        [DllImport("kernel32.dll")]
        static extern bool CloseHandle(IntPtr hHandle);
        [DllImport("kernel32.dll")]
        static extern bool ResetEvent(IntPtr hEvent);

        private const uint INFINITE = 0xFFFFFFFF;
        private const uint SYNCHRONIZE = 0x00100000;
        private const uint EVENT_MODIFY_STATE = 0x0002;

        private IntPtr m_EventHandle = IntPtr.Zero;		// unmanaged

        private bool eventAlreadyExists = false;

        private Form m_Instance;

        public delegate void ShowApplicationCallback();
        private ShowApplicationCallback m_callback;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="instance"></param>
        /// <param name="callback"></param>
        public SingleInstanceManager()
        {
            // Name the event - keep the scope local to allow for multiple users
            String eventName = "Local\\" + Assembly.GetExecutingAssembly().GetName().Name + "-SHOW_WINDOW"; 

            // Try to open our event
            m_EventHandle = OpenEvent(EVENT_MODIFY_STATE | SYNCHRONIZE, false, eventName);

            // If it doesn't exist
            if (m_EventHandle == IntPtr.Zero) 
            {
                //create our event
                m_EventHandle = CreateEvent(IntPtr.Zero, true, false, eventName);
                if (m_EventHandle != IntPtr.Zero) //if successfull
                {
                    Thread thread = new Thread(new ThreadStart(WaitForSignal));
                    thread.Start();
                }
            }
            else
            {
                eventAlreadyExists = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="instance"></param>
        /// <param name="callback"></param>
        public SingleInstanceManager(Form instance, ShowApplicationCallback callback)
            : this()
        {
            setObject(instance, callback);
        }

        /// <summary>
        /// After creation, call this to determine if we are the first instance
        /// </summary>
        /// <returns></returns>
        public bool EventAlreadyExists()
        {
            return eventAlreadyExists;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="instance"></param>
        /// <param name="callback"></param>
        public void setObject(Form instance, ShowApplicationCallback callback)
        {
            m_Instance = instance;
            m_callback = callback;
        }

        /// <summary>
        /// Destructor
        /// </summary>
        ~SingleInstanceManager()
        {
            Dispose(false);
        }

        /// <summary>
        /// an instance calls this when it detects that it is
        /// the second instance.  Then it exits
        /// </summary>
        public void SignalEvent()
        {
            if (m_EventHandle != IntPtr.Zero)
                SetEvent(m_EventHandle);
        }

        /// <summary>
        /// thread method will wait on the event, which will signal
        /// if another instance tries to start
        /// </summary>
        private void WaitForSignal()
        {
            while (true)
            {
                uint result = WaitForSingleObject(m_EventHandle, INFINITE);

                if (result == 0)
                {
                    ResetEvent(m_EventHandle);
                    if ( m_Instance != null && m_callback != null )
                        m_Instance.Invoke(m_callback, null);
                }
                else
                {
                    return;
                }
            }
        }

        #region IDisposable Members

        /// <summary>
        /// 
        /// </summary>
        /// <param name="disposeManagedResources"></param>
        protected virtual void Dispose(bool disposeManagedResources)
        {
            if (!this.disposed)
            {
                // dispose unmanaged resources
                if (m_EventHandle != IntPtr.Zero)
                    CloseHandle(m_EventHandle);
                m_EventHandle = IntPtr.Zero;

                disposed = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}


