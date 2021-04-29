using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    public class Words
    {
        #region Fields
        public string engWord { get; set; }
        public string rusWord { get; set; }
        #endregion

        #region Constructors
        public Words(string engWord, string rusWord)
        {
            this.engWord = engWord;
            this.rusWord = rusWord;
        }
        public Words() { }
        #endregion
    }
}
