using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BuiltInSort
{
    class CatalogueItem : IComparer
    {



        public Int32 Id { get; set; }
        public String ItemName { get; set; }
        public String Category { get; set; }


        // constructor
        public CatalogueItem(Int32 newId, String newName, String newCategory)
        {

            Id = newId;
            ItemName = newName;
            Category = newCategory;
        }
        public CatalogueItem() { } //Need an empty constructor so that the Array.Sort() works

        public int Compare(object x, object y)
        {
            return new CaseInsensitiveComparer().Compare((x as CatalogueItem).Id, (y as CatalogueItem).Id);
        }
    }
}
