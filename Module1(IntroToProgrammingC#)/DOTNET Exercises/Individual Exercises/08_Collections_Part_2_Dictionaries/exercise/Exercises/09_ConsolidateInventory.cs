using System.Collections.Generic;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Given two Dictionaries, Dictionary<string, int>, merge the two into a new Dictionary, Dictionary<string, int> where keys in Dictionary2,
         * and their int values, are added to the int values of matching keys in Dictionary1. Return the new Dictionary.
         *
         * Unmatched keys and their int values in Dictionary2 are simply added to Dictionary1.
         *
         * ConsolidateInventory({"SKU1": 100, "SKU2": 53, "SKU3": 44} {"SKU2":11, "SKU4": 5})
         * 	 → {"SKU1": 100, "SKU2": 64, "SKU3": 44, "SKU4": 5}
         *
         */
        public Dictionary<string, int> ConsolidateInventory(Dictionary<string, int> mainWarehouse,
                                                            Dictionary<string, int> remoteWarehouse)
        {
            Dictionary<string, int> merge = new Dictionary<string, int>();


            //foreach (KeyValuePair<string, int> item in mainWarehouse)
            //{
            //    foreach (KeyValuePair<string, int> item2 in remoteWarehouse)
            //    {
            //        if (item.Key == item2.Key)
            //        {
            //            merge[item.Key] = item.Value + item2.Value;
            //            //merge.Add(item.Key, item.Value + item2.Value);
            //        }
            //        else if (!merge.ContainsKey(item.Key) || !merge.ContainsKey(item2.Key))
            //        {
            //            if(!merge.ContainsKey(item.Key))
            //            {
            //                merge.Add(item.Key, item.Value);
            //            }
            //            if(!merge.ContainsKey(item2.Key))
            //            {
            //                merge.Add(item2.Key, item2.Value);
            //            }
            //        }
            //    }
            //}
            if(mainWarehouse.Count==0)
            {
                foreach(KeyValuePair<string, int> item2 in remoteWarehouse)
                {
                    merge.Add(item2.Key, item2.Value);
                }
            }
            else if(remoteWarehouse.Count==0)
            {
                foreach (KeyValuePair<string, int> item in mainWarehouse)
                {
                    merge.Add(item.Key, item.Value);
                }
            }
            else
            {
                foreach (KeyValuePair<string, int> item in mainWarehouse)
                {
                    foreach (KeyValuePair<string, int> item2 in remoteWarehouse)
                    {
                        if ((!merge.ContainsKey(item.Key) || !merge.ContainsKey(item2.Key)) && item.Key != item2.Key)
                        {
                            if (!merge.ContainsKey(item.Key))
                            {
                                merge.Add(item.Key, item.Value);
                            }
                            if (!merge.ContainsKey(item2.Key))
                            {
                                merge.Add(item2.Key, item2.Value);
                            }
                        }
                        else if (item.Key == item2.Key)
                        {
                            merge[item.Key] = item.Value + item2.Value;
                        }
                    }
                }
            }
            return merge;
                    }
                }
            }
    

