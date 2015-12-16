﻿namespace Gu.Wpf.DataGrid2D.Tests
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Windows;
    using System.Windows.Controls;
    using NUnit.Framework;

    [RequiresSTA]
    public class Source2DTests
    {
        public int[,] Data2D { get; set; }

        [Test]
        public void BindItemsSource2D()
        {
            this.Data2D = new[,] { { 1, 2 }, { 3, 4 } };
            var dataGrid = new DataGrid();
            dataGrid.Bind(Source2D.ItemsSource2DProperty)
                    .OneWayTo(this, new PropertyPath(nameof(this.Data2D)));
            Assert.AreEqual(2, dataGrid.Columns.Count);
            var rowsSource = (List<RowView>)dataGrid.GetRowsSource();
            CollectionAssert.AreEqual(new[] { 1, 2 }, rowsSource[0]);
            CollectionAssert.AreEqual(new[] { 3, 4 }, rowsSource[1]);
        }
    }
}