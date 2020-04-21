using System;
using System.Collections.Generic;
using System.Text;

namespace Cafedebug.Business.Models
{
    public class DataTableParameters
    {
        public int Draw { get; set; }

        public DtColumn[] Columns { get; set; }

        public DtOrder[] Order { get; set; }

        public int Start { get; set; }

        public int Length { get; set; }

        public DtSearch Search { get; set; }

        public string SortOrder => Columns != null && Order != null && Order.Length > 0
            ? (Columns[Order[0].Column].Data +
               (Order[0].Dir == DtOrderDir.Desc ? " " + Order[0].Dir : string.Empty))
            : null;
    }

    public class DtColumn
    {
        public string Data { get; set; }

        public string Name { get; set; }

        public bool Searchable { get; set; }

        public bool Orderable { get; set; }

        public DtSearch Search { get; set; }
    }

    public class DtOrder
    {
        public int Column { get; set; }

        public DtOrderDir Dir { get; set; }
    }

    public class DtSearch
    {
        public string Value { get; set; }
    }

    public enum DtOrderDir
    {
        Asc,
        Desc
    }
}
