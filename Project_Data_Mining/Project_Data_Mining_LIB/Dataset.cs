using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Data_Mining_LIB
{
    public class Dataset
    {
        #region Fields
        private int docs;
        private object feat1;
        private object feat2;
        private object feat3;
        private object feat4;
        private object feat5;
        private string classes;
        #endregion

        #region Constructors
        public Dataset(int docs, object feat1, object feat2, object feat3, object feat4, object feat5, string classes)
        {
            this.Docs = docs;
            this.Feat1 = feat1;
            this.Feat2 = feat2;
            this.Feat3 = feat3;
            this.Feat4 = feat4;
            this.Feat5 = feat5;
            this.Classes = classes;
        }
        #endregion

        #region Properties
        public int Docs { get => docs; set => docs = value; }
        public object Feat1 { get => feat1; set => feat1 = value; }
        public object Feat2 { get => feat2; set => feat2 = value; }
        public object Feat3 { get => feat3; set => feat3 = value; }
        public object Feat4 { get => feat4; set => feat4 = value; }
        public object Feat5 { get => feat5; set => feat5 = value; }
        public string Classes { get => classes; set => classes = value; }
        #endregion
    }
}
