using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_0819_ProductCalculate
{
    public class ProductCalculate
    {
        public  ProductCalculate()
        {
        }

        public string CalculationsColum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <param name="perSum"></param>
        /// <returns></returns>
        public List<int> SumFromColumPerCount<T>(List<T> data, int perSum)
        {

            var resultData = new List<int>();
            return resultData;
        }
    }
}
