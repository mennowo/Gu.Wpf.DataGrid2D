﻿namespace Gu.Wpf.DataGrid2D.Demo
{
    using System.Collections.Generic;
    using System.Linq;

    public class StyledVm
    {
        public StyledVm()
        {
            this.ColumnHeaders = new[] { "Col1", "Col2" };
            this.ListOfListsOfItems = new List<List<ItemVm>>();
            var count = 0;
            for (int i = 0; i < 3; i++)
            {
                var itemRow = new List<ItemVm>();
                this.ListOfListsOfItems.Add(itemRow);

                for (int j = 0; j < 2; j++)
                {
                    var itemVm = new ItemVm(count);
                    itemRow.Add(itemVm);
                    count++;
                }
            }

            this.ColumnItemHeaders = Enumerable.Range(0, 2)
                                               .Select(x => new ItemVm(x))
                                               .ToArray();
        }

        public string[] ColumnHeaders { get; }

        public List<List<ItemVm>> ListOfListsOfItems { get; }

        public IReadOnlyList<ItemVm> ColumnItemHeaders { get; private set; }
    }
}