/* 
 * Copyright (C) 2006,2007 David Riseley 
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
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using uk.org.riseley.puttySessionManager.model;
using uk.org.riseley.puttySessionManager.model.eventargs;
using System.Collections;

namespace uk.org.riseley.puttySessionManager.control
{
    public partial class SessionEditorControl : SessionControl
    {
        public event System.EventHandler CopySessionAttributes;
        public event System.EventHandler CloseSessionEditor;

        public SessionEditorControl()
            : base()
        {
            InitializeComponent();
            resetDialogFont();
        }

        
        protected override void LoadSessions()
        {
            DataGridViewRow dgvr = null;

            dataGridView1.SuspendLayout();
            dataGridView1.Rows.Clear();

            DataGridViewRow[] arr = new DataGridViewRow[getSessionController().getSessionList().Count];
            int i=0;
            foreach (Session s in getSessionController().getSessionList())
            {                
                dgvr = new DataGridViewRow();
                dgvr.CreateCells(dataGridView1, s.getCellValues());
                dgvr.Tag = s;
                arr[i] = dgvr;
                i++;
            }

            dataGridView1.Rows.AddRange(arr);
            dataGridView1.ResumeLayout();
        }



        protected virtual void OnCopySessionAttributes(EventArgs e)
        {
            if (CopySessionAttributes != null)
            {
                CopySessionAttributes(this, e);
            }
        }

        protected virtual void OnCloseSessionEditor(EventArgs e)
        {
            if (CloseSessionEditor != null)
            {
                CloseSessionEditor(this, e);
            }
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            OnExportSessions(new ExportSessionEventArgs());
        }

        public override List<Session> getSelectedSessions()
        {
            List<Session> sl = new List<Session>();
            Session[] sarr = new Session[dataGridView1.SelectedRows.Count];

            IEnumerator ie = dataGridView1.SelectedRows.GetEnumerator();
            while ( ie.MoveNext() )
            {
                DataGridViewRow dgvr = (DataGridViewRow)ie.Current;
                sl.Add((Session)dgvr.Tag);                
            }
            return sl;
        }

        private void newSessionButton_Click(object sender, EventArgs e)
        {
            OnNewSession(e);
        }

        private void deleteSesssionsButton_Click(object sender, EventArgs e)
        {
            OnDeleteSessions(new CancelEventArgs());
        }

        private void copySessionAttribButton_Click(object sender, EventArgs e)
        {
            OnCopySessionAttributes(e);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            OnCloseSessionEditor(e);
        }

        public override void resetDialogFont()
        {
            Font = Properties.Settings.Default.DialogFont;
        }
    }
}

