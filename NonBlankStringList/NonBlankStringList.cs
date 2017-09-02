using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace NonBlankStringList
{
    class NonBlankStringList : Collection<string>
    {
        //inserts non blank/null strings
        protected override void InsertItem(int index, string item)
        {
            if (string.IsNullOrWhiteSpace(item))
                throw new ArgumentException("Elements of NonBlankStringList" +
                    "must not be null or white space.");
            base.InsertItem(index, item);
        }

        //sets non blank/null strings
        protected override void SetItem(int index, string item)
        {
            if (string.IsNullOrWhiteSpace(item))
                throw new ArgumentException("Elements of NonBlankStringList" +
                    "must not be null or white space.");
            base.SetItem(index, item);
        }
    }
}
