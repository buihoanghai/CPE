using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using System.Collections;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using CPE_vs1.BusinessLayer;

namespace CPE_vs1.Interface
{
    interface IGridAlgorithm
    {
        void addRecently(params object[] arr);
        DataTable CreateTable();
        Layer getRowCur();
        
        void addRecently(GridControl gc, params object[] arr);
        DataTable CreateTable(Dictionary<string, Type> dic);
        DataRow getRowCur(TabControl tb, GridView gridRecently, GridView gridDataBase);
        DataRow getRowCur(GridView gridDataBase);
        Layer getRowCur(GridView gridDataBase, Layer l);
        Layer getRowCur(TabControl tb, GridView gridRecently, GridView gridDataBase, Layer l);
        void loadListData(DataTable dt);
        void loadListData(GridControl gc, DataTable dt);
        void setItems(GridView gridDataBase,
        Layer l,
        GridControl gcDataBase);
        void setItems(TabControl tb,
        GridView gridRecently, GridView gridDataBase,
        Dictionary<string, Type> dic,
        Layer l,
        GridControl gcRencently,
        GridControl gcDataBase);
    }
    class DevGridAlgorithm : IGridAlgorithm
    {
        public TabControl tb;
        GridView gridRecently, gridDataBase;
        Dictionary<string, Type> dic;
        Layer l;
        GridControl gcRecently;
        GridControl gcDataBase;
        public void addRecently(params object[] arr)
        {
            DataTable tbl;
            tbl = gcRecently.DataSource as DataTable;
            for (int i = 0; i <= tbl.Rows.Count; i++)
            {
                if (i == tbl.Rows.Count)
                {
                    arr[0] = i + 1;
                    tbl.Rows.Add(arr);
                    break;
                }
                if ((int)arr[2] == Convert.ToInt16(tbl.Rows[i]["ID"]))
                {
                    arr[0] = i + 1;
                    tbl.Rows[i].ItemArray = arr;
                    break;
                }
            }
            gcRecently.DataSource = tbl;
            gcRecently.RefreshDataSource();
        }
        public void addRecently(GridControl gc, params object[] arr)
        {
            DataTable tbl;
            tbl = gc.DataSource as DataTable;
            for (int i = 0; i <= tbl.Rows.Count; i++)
            {
                if (i == tbl.Rows.Count)
                {
                    arr[0] = i + 1;
                    tbl.Rows.Add(arr);
                    break;
                }
                if ((int)arr[2] == Convert.ToInt16(tbl.Rows[i]["ID"]))
                {
                    arr[0] = i + 1;
                    tbl.Rows[i].ItemArray = arr;
                    break;
                }
            }
            gc.DataSource = tbl;
            gc.RefreshDataSource();
        }
        public DataTable CreateTable()
        {
            DataTable tbl = new DataTable();
            foreach (var item in dic)
            {
                tbl.Columns.Add(item.Key, item.Value);
            }
            return tbl;
        }
        public DataTable CreateTable(Dictionary<string,Type> dic)
        {
            DataTable tbl = new DataTable();
            foreach (var item in dic)
            {
                tbl.Columns.Add(item.Key, item.Value);
            }
            return tbl;
        }
        public Layer getRowCur()
        {
            try
            {
                DataRow dt = null;
                if (gridRecently == null)
                    dt = gridDataBase.GetDataRow(gridDataBase.GetSelectedRows()[0]);
                else
                    if (tb.SelectedIndex == (int)EnumConfig.Tab.Recently)
                    {
                        if (gridRecently.GetSelectedRows().Length != 0)
                            dt = gridRecently.GetDataRow(gridRecently.GetSelectedRows()[0]);
                    }
                    else
                    {
                        if (gridDataBase.GetSelectedRows().Length != 0)
                            dt = gridDataBase.GetDataRow(gridDataBase.GetSelectedRows()[0]);
                    }
                return l.GetInfor(Convert.ToInt16(dt["ID"]));
            }
            catch { return null; }
        }
        public DataRow getRowCur(GridView gridDataBase)
        {
            DataRow dt = null;
            if (gridDataBase.GetSelectedRows().Length == 0)
                    return dt;
            dt = gridDataBase.GetDataRow(gridDataBase.GetSelectedRows()[0]);
            return dt;
        }
        public Layer getRowCur(GridView gridDataBase, Layer l)
        {
            DataRow dt = getRowCur(gridDataBase);
            return l.GetInfor(Convert.ToInt16(dt["ID"]));
        }
        public DataRow getRowCur(TabControl tb, GridView gridRecently, GridView gridDataBase)
        {
            DataRow dt = null;
            if (tb.SelectedIndex == (int)EnumConfig.Tab.Recently)
            {
                if (gridRecently.GetSelectedRows().Length == 0)
                    return dt;
                dt = gridRecently.GetDataRow(gridRecently.GetSelectedRows()[0]);
            }
            else
            {
                if (gridDataBase.GetSelectedRows().Length == 0)
                    return dt;
                dt = gridDataBase.GetDataRow(gridDataBase.GetSelectedRows()[0]);
            }
            return dt;
        }
       public Layer getRowCur(TabControl tb, GridView gridRecently, GridView gridDataBase, Layer l)
        {
            DataRow dt = getRowCur(tb, gridRecently, gridDataBase);
            return l.GetInfor(Convert.ToInt16(dt["ID"]));
        }
       public void loadListData(DataTable dt)
       {
           gcDataBase.DataSource = dt;
       }
        public void loadListData(GridControl gc,DataTable dt)
        {
            gc.DataSource = dt;
        }
        public void setItems(TabControl tb,
        GridView gridRecently, GridView gridDataBase,
        Dictionary<string, Type> dic,
        Layer l,
        GridControl gcRecently,
        GridControl gcDataBase)
        {
            this.tb = tb;
            this.gridRecently = gridRecently;
            this.gridDataBase = gridDataBase;
            this.dic = dic;
            this.l = l;
            this.gcRecently = gcRecently;
            this.gcDataBase = gcDataBase;
        }
        public void setItems(GridView gridDataBase,
        Layer l,
        GridControl gcDataBase)
        {
            this.gridDataBase = gridDataBase;
            this.l = l;
            this.gcDataBase = gcDataBase;
        }
    }
}
