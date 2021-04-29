using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task_4
{
    public class Progress
    {
        #region Fields
        private string fileName;
        private List<Words> words;
        #endregion

        #region Properties
        public string FileName 
            { set { fileName = value; } }
         
        public Words this[int index]
            { get { return words[index]; } }

        public int Count 
            { get { return words.Count; } }
        #endregion

        #region Constructor
        public Progress(string fileName)
        {
            this.fileName = fileName;
            words = new List<Words>();
        }
        #endregion

        #region Public Methods

        public void Add(string eng, string rus)
            { words.Add(new Words(eng, rus));}

        public void Remove(int index)
        {
            if (words != null && index < words.Count && index >= 0)
                words.RemoveAt(index);
        }

        public void Load()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Words>));
            using (Stream fStream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                words = (List<Words>)xmlSerializer.Deserialize(fStream);
            }
        }

        public void Save()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Words>));
            using(Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                xmlSerializer.Serialize(fStream, words);
            }
        }
        #endregion

    }
}
